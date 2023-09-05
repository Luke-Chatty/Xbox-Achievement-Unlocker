
namespace Xbox_Achievement_Unlocker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            BGWorker = new System.ComponentModel.BackgroundWorker();
            LBL_Attached = new System.Windows.Forms.Label();
            LBL_Xauth = new System.Windows.Forms.TextBox();
            BTN_GrabXauth = new System.Windows.Forms.Button();
            Panel_Recents = new System.Windows.Forms.Panel();
            BTN_SpoofGame = new System.Windows.Forms.Button();
            TXT_Xuid = new System.Windows.Forms.TextBox();
            BTN_SaveToFile = new System.Windows.Forms.Button();
            LST_GameFilterType = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            BTN_fixer = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            TXT_GameFilterTitle = new System.Windows.Forms.TextBox();
            TXT_Xauth = new System.Windows.Forms.TextBox();
            BTN_StatsEditor = new System.Windows.Forms.Button();
            LBL_GamertagValue = new System.Windows.Forms.Label();
            LBL_GamerscoreValue = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            LBL_Gamertag = new System.Windows.Forms.Label();
            LBL_Gamerscore = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BGWorker
            // 
            BGWorker.WorkerReportsProgress = true;
            BGWorker.DoWork += BGWorker_DoWork;
            BGWorker.ProgressChanged += BGWorker_ProgressChanged;
            BGWorker.RunWorkerCompleted += BGWorker_RunWorkerCompleted;
            // 
            // LBL_Attached
            // 
            LBL_Attached.AutoSize = true;
            LBL_Attached.ForeColor = System.Drawing.Color.Red;
            LBL_Attached.Location = new System.Drawing.Point(1113, 43);
            LBL_Attached.Name = "LBL_Attached";
            LBL_Attached.Size = new System.Drawing.Size(143, 14);
            LBL_Attached.TabIndex = 0;
            LBL_Attached.Text = "Not attached to Xbox App";
            LBL_Attached.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            LBL_Attached.Click += LBL_Attached_Click;
            // 
            // LBL_Xauth
            // 
            LBL_Xauth.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            LBL_Xauth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LBL_Xauth.ForeColor = System.Drawing.Color.Cornsilk;
            LBL_Xauth.Location = new System.Drawing.Point(6, 9);
            LBL_Xauth.Name = "LBL_Xauth";
            LBL_Xauth.Size = new System.Drawing.Size(50, 15);
            LBL_Xauth.TabIndex = 16;
            LBL_Xauth.Text = "XAUTH";
            LBL_Xauth.TextChanged += LBL_Xauth_TextChanged;
            // 
            // BTN_GrabXauth
            // 
            BTN_GrabXauth.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            BTN_GrabXauth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            BTN_GrabXauth.Enabled = false;
            BTN_GrabXauth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_GrabXauth.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BTN_GrabXauth.Location = new System.Drawing.Point(1119, 72);
            BTN_GrabXauth.Name = "BTN_GrabXauth";
            BTN_GrabXauth.Size = new System.Drawing.Size(174, 49);
            BTN_GrabXauth.TabIndex = 2;
            BTN_GrabXauth.Text = "Grab All";
            BTN_GrabXauth.UseVisualStyleBackColor = false;
            BTN_GrabXauth.Click += BTN_GrabXauth_Click;
            // 
            // Panel_Recents
            // 
            Panel_Recents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Panel_Recents.AutoScroll = true;
            Panel_Recents.BackColor = System.Drawing.Color.FromArgb(26, 27, 30);
            Panel_Recents.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Panel_Recents.ForeColor = System.Drawing.Color.FromArgb(26, 27, 30);
            Panel_Recents.Location = new System.Drawing.Point(191, 127);
            Panel_Recents.Name = "Panel_Recents";
            Panel_Recents.Size = new System.Drawing.Size(1102, 500);
            Panel_Recents.TabIndex = 8;
            // 
            // BTN_SpoofGame
            // 
            BTN_SpoofGame.BackColor = System.Drawing.Color.FromArgb(65, 64, 67);
            BTN_SpoofGame.Enabled = false;
            BTN_SpoofGame.FlatAppearance.BorderSize = 0;
            BTN_SpoofGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_SpoofGame.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BTN_SpoofGame.ForeColor = System.Drawing.Color.White;
            BTN_SpoofGame.Location = new System.Drawing.Point(6, 202);
            BTN_SpoofGame.Name = "BTN_SpoofGame";
            BTN_SpoofGame.Size = new System.Drawing.Size(174, 45);
            BTN_SpoofGame.TabIndex = 5;
            BTN_SpoofGame.Text = "Game Spoofer";
            BTN_SpoofGame.UseVisualStyleBackColor = false;
            BTN_SpoofGame.Click += BTN_SpoofGame_Click;
            // 
            // TXT_Xuid
            // 
            TXT_Xuid.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            TXT_Xuid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TXT_Xuid.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TXT_Xuid.ForeColor = System.Drawing.SystemColors.MenuBar;
            TXT_Xuid.Location = new System.Drawing.Point(-1, 108);
            TXT_Xuid.Name = "TXT_Xuid";
            TXT_Xuid.Size = new System.Drawing.Size(172, 14);
            TXT_Xuid.TabIndex = 10;
            TXT_Xuid.Text = "XUID:";
            TXT_Xuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_SaveToFile
            // 
            BTN_SaveToFile.BackColor = System.Drawing.Color.FromArgb(65, 64, 67);
            BTN_SaveToFile.Enabled = false;
            BTN_SaveToFile.FlatAppearance.BorderSize = 0;
            BTN_SaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_SaveToFile.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BTN_SaveToFile.ForeColor = System.Drawing.Color.White;
            BTN_SaveToFile.Location = new System.Drawing.Point(6, 252);
            BTN_SaveToFile.Name = "BTN_SaveToFile";
            BTN_SaveToFile.Size = new System.Drawing.Size(174, 45);
            BTN_SaveToFile.TabIndex = 4;
            BTN_SaveToFile.Text = "Export Game List";
            BTN_SaveToFile.UseVisualStyleBackColor = false;
            BTN_SaveToFile.Click += BTN_SaveToFile_Click;
            // 
            // LST_GameFilterType
            // 
            LST_GameFilterType.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            LST_GameFilterType.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LST_GameFilterType.ForeColor = System.Drawing.Color.White;
            LST_GameFilterType.FormattingEnabled = true;
            LST_GameFilterType.Items.AddRange(new object[] { "All", "Console Only", "New Gen", "Win32" });
            LST_GameFilterType.Location = new System.Drawing.Point(193, 94);
            LST_GameFilterType.Name = "LST_GameFilterType";
            LST_GameFilterType.Size = new System.Drawing.Size(159, 29);
            LST_GameFilterType.TabIndex = 3;
            LST_GameFilterType.SelectedIndexChanged += LST_GameFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(209, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 21);
            label1.TabIndex = 13;
            label1.Text = "Filter Platform:";
            // 
            // BTN_fixer
            // 
            BTN_fixer.BackColor = System.Drawing.Color.FromArgb(0, 119, 56);
            BTN_fixer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            BTN_fixer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_fixer.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BTN_fixer.ForeColor = System.Drawing.Color.White;
            BTN_fixer.Location = new System.Drawing.Point(1091, 9);
            BTN_fixer.Name = "BTN_fixer";
            BTN_fixer.Size = new System.Drawing.Size(199, 34);
            BTN_fixer.TabIndex = 1;
            BTN_fixer.Text = "CONNECT TO XBOX APP";
            BTN_fixer.UseVisualStyleBackColor = false;
            BTN_fixer.Click += BTN_fixer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(930, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 21);
            label2.TabIndex = 17;
            label2.Text = "Filter Name/TitleID:";
            label2.Click += label2_Click;
            // 
            // TXT_GameFilterTitle
            // 
            TXT_GameFilterTitle.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            TXT_GameFilterTitle.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TXT_GameFilterTitle.ForeColor = System.Drawing.Color.White;
            TXT_GameFilterTitle.Location = new System.Drawing.Point(930, 92);
            TXT_GameFilterTitle.Name = "TXT_GameFilterTitle";
            TXT_GameFilterTitle.Size = new System.Drawing.Size(159, 28);
            TXT_GameFilterTitle.TabIndex = 18;
            TXT_GameFilterTitle.TextChanged += TXT_GameFilterTitle_TextChanged;
            // 
            // TXT_Xauth
            // 
            TXT_Xauth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            TXT_Xauth.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            TXT_Xauth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TXT_Xauth.ForeColor = System.Drawing.Color.Cornsilk;
            TXT_Xauth.Location = new System.Drawing.Point(50, 9);
            TXT_Xauth.Name = "TXT_Xauth";
            TXT_Xauth.Size = new System.Drawing.Size(1231, 15);
            TXT_Xauth.TabIndex = 19;
            TXT_Xauth.TextChanged += TXT_Xauth_TextChanged;
            // 
            // BTN_StatsEditor
            // 
            BTN_StatsEditor.BackColor = System.Drawing.Color.FromArgb(65, 64, 67);
            BTN_StatsEditor.Enabled = false;
            BTN_StatsEditor.FlatAppearance.BorderSize = 0;
            BTN_StatsEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(88, 89, 91);
            BTN_StatsEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_StatsEditor.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BTN_StatsEditor.ForeColor = System.Drawing.Color.Transparent;
            BTN_StatsEditor.Location = new System.Drawing.Point(6, 152);
            BTN_StatsEditor.Name = "BTN_StatsEditor";
            BTN_StatsEditor.Size = new System.Drawing.Size(174, 45);
            BTN_StatsEditor.TabIndex = 20;
            BTN_StatsEditor.Text = "Stats Editor";
            BTN_StatsEditor.UseVisualStyleBackColor = false;
            BTN_StatsEditor.Click += BTN_StatsEditor_Click;
            // 
            // LBL_GamertagValue
            // 
            LBL_GamertagValue.AutoSize = true;
            LBL_GamertagValue.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LBL_GamertagValue.Location = new System.Drawing.Point(60, 56);
            LBL_GamertagValue.Name = "LBL_GamertagValue";
            LBL_GamertagValue.Size = new System.Drawing.Size(81, 19);
            LBL_GamertagValue.TabIndex = 21;
            LBL_GamertagValue.Text = "Gamertag";
            LBL_GamertagValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            LBL_GamertagValue.Click += label3_Click;
            // 
            // LBL_GamerscoreValue
            // 
            LBL_GamerscoreValue.AutoSize = true;
            LBL_GamerscoreValue.BackColor = System.Drawing.Color.Transparent;
            LBL_GamerscoreValue.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LBL_GamerscoreValue.Location = new System.Drawing.Point(60, 79);
            LBL_GamerscoreValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            LBL_GamerscoreValue.Name = "LBL_GamerscoreValue";
            LBL_GamerscoreValue.Size = new System.Drawing.Size(63, 19);
            LBL_GamerscoreValue.TabIndex = 22;
            LBL_GamerscoreValue.Text = "100,000";
            LBL_GamerscoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            LBL_GamerscoreValue.Click += label3_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(BTN_SaveToFile);
            panel1.Controls.Add(BTN_SpoofGame);
            panel1.Controls.Add(BTN_StatsEditor);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(185, 645);
            panel1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(LBL_GamerscoreValue);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(TXT_Xuid);
            panel3.Controls.Add(LBL_GamertagValue);
            panel3.Location = new System.Drawing.Point(1, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(181, 124);
            panel3.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(41, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(20, 19);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(60, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(48, 46);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // LBL_Gamertag
            // 
            LBL_Gamertag.AutoSize = true;
            LBL_Gamertag.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_Gamertag.ForeColor = System.Drawing.Color.FromArgb(26, 27, 30);
            LBL_Gamertag.Location = new System.Drawing.Point(193, 25);
            LBL_Gamertag.Name = "LBL_Gamertag";
            LBL_Gamertag.Size = new System.Drawing.Size(64, 14);
            LBL_Gamertag.TabIndex = 6;
            LBL_Gamertag.Text = "Gamertag: ";
            // 
            // LBL_Gamerscore
            // 
            LBL_Gamerscore.AutoSize = true;
            LBL_Gamerscore.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_Gamerscore.ForeColor = System.Drawing.Color.FromArgb(26, 27, 30);
            LBL_Gamerscore.Location = new System.Drawing.Point(192, 9);
            LBL_Gamerscore.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            LBL_Gamerscore.Name = "LBL_Gamerscore";
            LBL_Gamerscore.Size = new System.Drawing.Size(78, 14);
            LBL_Gamerscore.TabIndex = 7;
            LBL_Gamerscore.Text = "Gamerscore: ";
            LBL_Gamerscore.Click += LBL_Gamerscore_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            panel2.Controls.Add(TXT_Xauth);
            panel2.Controls.Add(LBL_Xauth);
            panel2.Location = new System.Drawing.Point(1, 642);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1308, 37);
            panel2.TabIndex = 24;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(26, 27, 30);
            ClientSize = new System.Drawing.Size(1310, 678);
            Controls.Add(panel2);
            Controls.Add(TXT_GameFilterTitle);
            Controls.Add(BTN_GrabXauth);
            Controls.Add(label2);
            Controls.Add(BTN_fixer);
            Controls.Add(LBL_Gamertag);
            Controls.Add(label1);
            Controls.Add(LBL_Gamerscore);
            Controls.Add(LST_GameFilterType);
            Controls.Add(Panel_Recents);
            Controls.Add(LBL_Attached);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Xbox 360 Achievement Unlocker";
            Load += MainWindow_Load;
            Shown += MainWindow_Shown;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label LBL_Attached;
        private System.Windows.Forms.TextBox LBL_Xauth;
        private System.Windows.Forms.Button BTN_GrabXauth;
        private System.Windows.Forms.Label LBL_GamertagValue;
        private System.Windows.Forms.Label LBL_GamerscoreValue;
        private System.Windows.Forms.Panel Panel_Recents;
        private System.Windows.Forms.Button BTN_SpoofGame;
        private System.Windows.Forms.TextBox TXT_Xuid;
        private System.Windows.Forms.Button BTN_SaveToFile;
        private System.Windows.Forms.ComboBox LST_GameFilterType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_fixer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_GameFilterTitle;
        private System.Windows.Forms.TextBox TXT_Xauth;
        private System.Windows.Forms.Button BTN_StatsEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_Gamertag;
        private System.Windows.Forms.Label LBL_Gamerscore;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

