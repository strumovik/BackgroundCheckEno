using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RobloxApiWrapper
{
    class RobloxApi
    {
        static HttpClient client;
        public RobloxApi()
        {
            client = new HttpClient();
        }
        public async Task<IReadOnlyCollection<RobloxFriend>> GetFriendsAsync(string Id)
        {
            var friends = new List<RobloxFriend>();
            var content = await client.GetStringAsync("https://friends.roblox.com/v1/users/" + Id + "/friends?userSort=Alphabetical");
            JObject json = JObject.Parse(content);
            foreach (var e in json.Values())
            {
                foreach (var b in e)
                {
                    var friend = new RobloxFriend(b);
                    friends.Add(friend);
                }
            }
            var readonlylist = friends.AsReadOnly();
            return readonlylist;
        }
        public async Task<IReadOnlyCollection<RobloxPlayerGroup>> GetPlayerGroupsAsync(string Id)
        {
            var groups = new List<RobloxPlayerGroup>();
            var content = await client.GetStringAsync("https://groups.roblox.com/v2/users/" + Id + "/groups/roles");
            JObject jObject = JObject.Parse(content);
            foreach (var e in jObject.Values())
            {
                foreach (var b in e)
                {
                    RobloxPlayerGroup group = new RobloxPlayerGroup(b);
                    groups.Add(group);
                }
            }
            return groups;
        }
        public async Task<IReadOnlyCollection<RobloxGroup>> GetGroupAsync(IReadOnlyCollection<RobloxPlayerGroup> playerGroups)
        {
            List<RobloxGroup> groups = new List<RobloxGroup>();
            string groupids = null;
            foreach (var group in playerGroups)
            {
                groupids = groupids + group.Id + ",";
            }
            if (groupids == null)
            {
                return null;
            }
            groupids = groupids.Remove(groupids.Length - 1, 1);
            var content = await client.GetStringAsync("https://groups.roblox.com/v2/groups?groupIds=" + groupids);
            JObject jObject = JObject.Parse(content);
            foreach (var e in jObject.Values())
            {
                foreach (var b in e)
                {
                    RobloxGroup group = new RobloxGroup(b);
                    groups.Add(group);
                }
            }
            return groups.AsReadOnly();
        }
        public async Task<RobloxGroup> GetGroupAsync(string Id)
        {
            RobloxGroup group = null;
            var content = await client.GetStringAsync("https://groups.roblox.com/v2/groups?groupIds=" + Id);
            JObject jObject = JObject.Parse(content);
            foreach (var e in jObject.Values())
            {
                foreach (var b in e)
                {
                    group = new RobloxGroup(b);
                }
            }
            return group;
        }
        public async Task<IReadOnlyCollection<RobloxSearchResult>> SearchForPlayerAsync(string query)
        {
            List<RobloxSearchResult> results = new List<RobloxSearchResult>();
            string content;
            try
            {
                content = await client.GetStringAsync("https://users.roblox.com/v1/users/search?keyword=" + query + "&limit=10");
            }
            catch (Exception)
            {
                return null;
            }

            JObject jObject = JObject.Parse(content);
            foreach (var e in jObject.Values())
            {
                foreach (var b in e)
                {
                    var result = new RobloxSearchResult(b);
                    results.Add(result);
                }
            }
            return results;
        }
        public async Task<RobloxPlayer> GetPlayerByIdAsync(string id)
        {
            string content;
            try
            {
                content = await client.GetStringAsync("https://users.roblox.com/v1/users/" + id);
            }
            catch (Exception)
            {
                return null;
            }
            JObject jObject = JObject.Parse(content);
            var result = new RobloxPlayer(jObject);
            return result;
        }
        public async Task<string> GetPlayerBustUrlAsync(string id)
        {
            var content = await client.GetStringAsync("https://thumbnails.roblox.com/v1/users/avatar-bust?userIds=" + id + "&size=150x150&format=Png&isCircular=false");
            JObject jObject = JObject.Parse(content);
            var data = jObject["data"];
            var data2 = data[0];
            var url = (string)data2["imageUrl"];
            return url;
        }
    }
}
