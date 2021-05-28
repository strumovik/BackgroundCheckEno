using BackgroundCheckEno.Properties;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using RobloxApiWrapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundCheckEno
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> BlacklistedFriends = new Dictionary<string, string>();
        Dictionary<string, string> BlacklistedGroups = new Dictionary<string, string>();
        List<string> BlacklistedKeywords = new List<string>();
        string currentuser = null;
        string currentName = null;
        static RobloxApi robloxApi = new RobloxApi();
        string ApplicationName = "EnoBackgroundCheck";

        public Form1()
        {
            InitializeComponent();
            UpdateBlacklists();
        }
        private Task UpdateBlacklists()
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyDlBUpqz5xAAVnmjnxavirmB958r1Bb2z4",
                ApplicationName = ApplicationName
            });

            String spreadsheetId = "131tK6-0kD9IY_11Hig4WImwxVXEk0mQZEk5QKwU0HPk";
            String range = "Users!A:C";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    BlacklistedFriends.Add((string)row[0], (string)row[2]);
                }
            }
            range = "Groups!A:C";
            request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            response = request.Execute();
            values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    BlacklistedGroups.Add((string)row[0], (string)row[2]);
                }
            }
            range = "Keywords!A:A";
            request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            response = request.Execute();
            values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    BlacklistedKeywords.Add((string)row[0]);
                }
            }
            service.Dispose();

            return Task.FromResult(true);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            userProfileLinkLabel.LinkVisited = false;
            userProfileLinkLabel.Links.Clear();
            userProfileLinkLabel.Enabled = false;
            currentuser = null;
            CheckButton.Enabled = false;
            UpdateBlacklistsButton.Enabled = false;
            FoundUserDisplayNameBox.Clear();
            FoundUserRegisteredBox.Clear();
            FoundUserUsernamesBox.Items.Clear();
            FoundUserIdBox.Clear();
            listView1.Clear();
            pictureBox1.Image = null;
            string id;
            IReadOnlyCollection<RobloxSearchResult> results;
            if (IdBox.Text == "")
            {
                results = await robloxApi.SearchForPlayerAsync(UsernameBox.Text);
                try
                {
                    id = results.FirstOrDefault<RobloxSearchResult>().Id;
                }
                catch (Exception)
                {
                    pictureBox1.Image = Resources.UserNotFound;
                    pictureBox1.Refresh();
                    CheckButton.Enabled = true;
                    UpdateBlacklistsButton.Enabled = true;
                    IdBox.Clear();
                    UsernameBox.Clear();
                    return;
                }
            }
            else
            {
                var r = await robloxApi.GetPlayerByIdAsync(IdBox.Text);
                if (r == null)
                {
                    pictureBox1.Image = Resources.UserNotFound;
                    pictureBox1.Refresh();
                    CheckButton.Enabled = true;
                    UpdateBlacklistsButton.Enabled = true;
                    IdBox.Clear();
                    UsernameBox.Clear();
                    return;
                }
                id = r.Id;
            }
            currentuser = id;

            await LoadImage(id);

            await UpdateInfo(id);
            await Checkforredflags(id);
            IdBox.Clear();
            UsernameBox.Clear();
            await LoadImage(id);
            CheckButton.Enabled = true;
            userProfileLinkLabel.Links.Add(0, userProfileLinkLabel.Text.ToString().Length, "https://www.roblox.com/users/"+id+"/profile");
            userProfileLinkLabel.Enabled = true;
            UpdateBlacklistsButton.Enabled = true;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public async Task LoadImage(string id)
        {
            var url = await robloxApi.GetPlayerBustUrlAsync(id);
            try
            {
                pictureBox1.Load(url);
            }
            catch (Exception)
            {
                pictureBox1.Image = Resources.FailedToLoad;
            }
        }

        public async Task UpdateInfo(string id)
        {
            var player = await robloxApi.GetPlayerByIdAsync(id);
            FoundUserIdBox.Text = player.Id;
            FoundUserDisplayNameBox.Text = player.DisplayName;
            var previousnames = new List<string>();
            var results = await robloxApi.SearchForPlayerAsync(player.Name);
            var result = results.FirstOrDefault(x => x.Id == player.Id);
            currentName = player.Name;
            foreach (var name in result.PreviousUsernames)
            {
                FoundUserUsernamesBox.Items.Add(name);
            }
            FoundUserUsernamesBox.Items.Add(player.Name);
            FoundUserUsernamesBox.Text = player.Name;
            FoundUserRegisteredBox.Text = player.Created.ToString();
            if (player.Created > DateTime.Now.AddYears(-1))
            {
                listView1.Items.Add("[🚩] Account is less than a year old");
                listView1.Items[listView1.Items.Count - 1].SubItems.Add("https://www.roblox.com/users/"+id+"/profile");
            }
        }

        public async Task Checkforredflags(string Id)
        {
            await Checkfriends(Id);
            await Checkgroups(Id);
            await Displayredflags();
        }
        public async Task Checkfriends(string Id)
        {
            if (BlacklistedFriends.ContainsKey(Id))
            {
                listView1.Items.Add("[🚩] User is blacklisted");
                listView1.Items[listView1.Items.Count - 1].SubItems.Add("https://www.roblox.com/users/" + Id + "/profile");
            }
            var friends = await robloxApi.GetFriendsAsync(Id);
            int minfriendcount = 20;
            if (friends.Count <= minfriendcount)
            {
                listView1.Items.Add("[🚩] User has less than " + minfriendcount +" friends");
                listView1.Items[listView1.Items.Count - 1].SubItems.Add("https://www.roblox.com/users/" + Id + "/profile");
            }
            foreach (var blacklistedId in BlacklistedFriends.Keys)
            {
                foreach (var friend in friends)
                {
                    if (blacklistedId == friend.Id)
                    {
                        BlacklistedFriends.TryGetValue(blacklistedId, out string reason);
                        listView1.Items.Add("[🚩] Player is friends with blacklisted user: " + friend.Name + ", with display name " + friend.DisplayName + " (" + reason + ")");
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add("https://www.roblox.com/users/" + friend.Id + "/profile");
                    }
                }
            }
        }
        public async Task Checkgroups(string Id)
        {
            var groups = await robloxApi.GetPlayerGroupsAsync(Id);

            foreach (var group in groups)
            {
                foreach (var blacklistedId in BlacklistedGroups.Keys)
                {
                    if (group.Id == blacklistedId)
                    {
                        BlacklistedGroups.TryGetValue(blacklistedId, out string reason);
                        listView1.Items.Add("[🚩] Player is in a blacklisted group: " + group.Name + ", with rank there: " + group.RoleInGroup.Name + " (" + reason + ")");
                        listView1.Items[listView1.Items.Count-1].SubItems.Add("https://www.roblox.com/groups/"+group.Id);
                    }
                }

            }
            await DeepCheckGroups(groups);
        }
        private async Task DeepCheckGroups(IReadOnlyCollection<RobloxPlayerGroup> groups)
        {
            var groupsResult = await robloxApi.GetGroupAsync(groups);
            if (groupsResult == null)
            {
                listView1.Items.Add("[🚩] User is in no groups");
                listView1.Items[listView1.Items.Count - 1].SubItems.Add("https://www.roblox.com/users/"+currentuser+"/profile");
                return;
            }
            foreach (var group in groupsResult)
            {
                foreach (var keyword in BlacklistedKeywords)
                {
                    if (group.Name.ToLower().Contains(keyword) | group.Description.ToLower().Contains(keyword))
                    {
                        listView1.Items.Add("[🚩] Group: " + group.Name + " flagged for keyword: " + keyword);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add("https://www.roblox.com/groups/" + group.Id);
                    }
                }
            }
        }
        public Task Displayredflags()
        {
            if (listView1.Items.Count < 1)
            {
                listView1.Items.Add("No red flags");
            }
            return Task.CompletedTask;
        }
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void PictureBox1_Click(object sender, EventArgs e)
        {
            if (currentuser != null)
            {
                await LoadImage(currentuser);
            }
        }

        private async void Button1_Click_1(object sender, EventArgs e)
        {
            UpdateBlacklistsButton.Enabled = false;
            CheckButton.Enabled = false;
            BlacklistedGroups.Clear();
            BlacklistedFriends.Clear();
            await UpdateBlacklists();
            CheckButton.Enabled = true;
            UpdateBlacklistsButton.Enabled = true;
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void FoundUserUsernamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoundUserUsernamesBox.Text = currentName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            userProfileLinkLabel.LinkVisited = true;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int Index = 0;
            if (listView1.SelectedItems.Count > 0)
            {
                Index = listView1.SelectedItems[0].Index;
                try
                {
                    if (listView1.Items[Index].SubItems[1].Text.Trim() != "")
                    {
                        Process.Start(listView1.Items[Index].SubItems[1].Text.Trim());
                    }
                }
                catch (Exception)
                {

                }
                
            }
        }
    }
}
