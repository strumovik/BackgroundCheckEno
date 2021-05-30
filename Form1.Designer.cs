using System;

namespace BackgroundCheckEno
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CheckButton = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FoundUserIdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FoundUserRegisteredBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FoundUserDisplayNameBox = new System.Windows.Forms.TextBox();
            this.UpdateBlacklistsButton = new System.Windows.Forms.Button();
            this.FoundUserUsernamesBox = new System.Windows.Forms.ComboBox();
            this.userProfileLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(248, 46);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(249, 79);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "CHECK";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(43, 57);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(120, 20);
            this.IdBox.TabIndex = 1;
            this.IdBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserId";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.HideSelection = false;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(12, 168);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 270);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(638, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(43, 96);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(120, 20);
            this.UsernameBox.TabIndex = 8;
            this.UsernameBox.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(506, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "UserId:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // FoundUserIdBox
            // 
            this.FoundUserIdBox.Enabled = false;
            this.FoundUserIdBox.Location = new System.Drawing.Point(509, 25);
            this.FoundUserIdBox.Name = "FoundUserIdBox";
            this.FoundUserIdBox.Size = new System.Drawing.Size(120, 20);
            this.FoundUserIdBox.TabIndex = 10;
            this.FoundUserIdBox.TextChanged += new System.EventHandler(this.FoundUserIdBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(506, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usernames:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(506, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Registered:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FoundUserRegisteredBox
            // 
            this.FoundUserRegisteredBox.Enabled = false;
            this.FoundUserRegisteredBox.Location = new System.Drawing.Point(509, 142);
            this.FoundUserRegisteredBox.Name = "FoundUserRegisteredBox";
            this.FoundUserRegisteredBox.Size = new System.Drawing.Size(120, 20);
            this.FoundUserRegisteredBox.TabIndex = 14;
            this.FoundUserRegisteredBox.TextChanged += new System.EventHandler(this.FoundUserRegisteredBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(506, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DisplayName:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FoundUserDisplayNameBox
            // 
            this.FoundUserDisplayNameBox.Enabled = false;
            this.FoundUserDisplayNameBox.Location = new System.Drawing.Point(509, 103);
            this.FoundUserDisplayNameBox.Name = "FoundUserDisplayNameBox";
            this.FoundUserDisplayNameBox.Size = new System.Drawing.Size(120, 20);
            this.FoundUserDisplayNameBox.TabIndex = 16;
            this.FoundUserDisplayNameBox.TextChanged += new System.EventHandler(this.FoundUserDisplayNameBox_TextChanged);
            // 
            // UpdateBlacklistsButton
            // 
            this.UpdateBlacklistsButton.Location = new System.Drawing.Point(248, 137);
            this.UpdateBlacklistsButton.Name = "UpdateBlacklistsButton";
            this.UpdateBlacklistsButton.Size = new System.Drawing.Size(249, 25);
            this.UpdateBlacklistsButton.TabIndex = 17;
            this.UpdateBlacklistsButton.Text = "Update Blacklists";
            this.UpdateBlacklistsButton.UseVisualStyleBackColor = true;
            this.UpdateBlacklistsButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // FoundUserUsernamesBox
            // 
            this.FoundUserUsernamesBox.AllowDrop = true;
            this.FoundUserUsernamesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoundUserUsernamesBox.FormattingEnabled = true;
            this.FoundUserUsernamesBox.Location = new System.Drawing.Point(509, 64);
            this.FoundUserUsernamesBox.Name = "FoundUserUsernamesBox";
            this.FoundUserUsernamesBox.Size = new System.Drawing.Size(120, 21);
            this.FoundUserUsernamesBox.TabIndex = 18;
            this.FoundUserUsernamesBox.SelectedIndexChanged += new System.EventHandler(this.FoundUserUsernamesBox_SelectedIndexChanged);
            // 
            // userProfileLinkLabel
            // 
            this.userProfileLinkLabel.AutoSize = true;
            this.userProfileLinkLabel.Enabled = false;
            this.userProfileLinkLabel.Location = new System.Drawing.Point(570, 9);
            this.userProfileLinkLabel.Name = "userProfileLinkLabel";
            this.userProfileLinkLabel.Size = new System.Drawing.Size(59, 13);
            this.userProfileLinkLabel.TabIndex = 19;
            this.userProfileLinkLabel.TabStop = true;
            this.userProfileLinkLabel.Text = "Profile Link";
            this.userProfileLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.CheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userProfileLinkLabel);
            this.Controls.Add(this.FoundUserUsernamesBox);
            this.Controls.Add(this.UpdateBlacklistsButton);
            this.Controls.Add(this.FoundUserDisplayNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FoundUserRegisteredBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FoundUserIdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.CheckButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Enomoto BackgroundCheck";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FoundUserDisplayNameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void FoundUserRegisteredBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void FoundUserUsernameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FoundUserIdBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FoundUserIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FoundUserRegisteredBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FoundUserDisplayNameBox;
        private System.Windows.Forms.Button UpdateBlacklistsButton;
        private System.Windows.Forms.ComboBox FoundUserUsernamesBox;
        private System.Windows.Forms.LinkLabel userProfileLinkLabel;
    }
}

