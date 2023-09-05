
namespace Xbox_Achievement_Unlocker
{
    partial class AchievementList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AchievementList));
            BTN_Unlock = new System.Windows.Forms.Button();
            BTN_UnlockAll = new System.Windows.Forms.Button();
            DGV_AchievementList = new System.Windows.Forms.DataGridView();
            dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_Stats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_UnlockedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Check_UnlockAll = new System.Windows.Forms.CheckBox();
            BTN_ALRefresh = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            Sorting_Box = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            searchbox = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            LBL_GamerscoreValue = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            LBL_GamertagValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)DGV_AchievementList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Unlock
            // 
            BTN_Unlock.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            BTN_Unlock.Location = new System.Drawing.Point(9, 473);
            BTN_Unlock.Margin = new System.Windows.Forms.Padding(0);
            BTN_Unlock.Name = "BTN_Unlock";
            BTN_Unlock.Size = new System.Drawing.Size(113, 43);
            BTN_Unlock.TabIndex = 2;
            BTN_Unlock.Text = "Unlock Selected Achievements";
            BTN_Unlock.UseVisualStyleBackColor = true;
            BTN_Unlock.Click += BTN_Unlock_Click;
            // 
            // BTN_UnlockAll
            // 
            BTN_UnlockAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            BTN_UnlockAll.Enabled = false;
            BTN_UnlockAll.Location = new System.Drawing.Point(905, 7);
            BTN_UnlockAll.Margin = new System.Windows.Forms.Padding(0);
            BTN_UnlockAll.Name = "BTN_UnlockAll";
            BTN_UnlockAll.Size = new System.Drawing.Size(97, 43);
            BTN_UnlockAll.TabIndex = 3;
            BTN_UnlockAll.Text = "Unlock All Achievements";
            BTN_UnlockAll.UseVisualStyleBackColor = true;
            BTN_UnlockAll.Click += BTN_UnlockAll_Click;
            // 
            // DGV_AchievementList
            // 
            DGV_AchievementList.AllowUserToAddRows = false;
            DGV_AchievementList.AllowUserToDeleteRows = false;
            DGV_AchievementList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(26, 27, 30);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(88, 89, 91);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            DGV_AchievementList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGV_AchievementList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DGV_AchievementList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            DGV_AchievementList.BackgroundColor = System.Drawing.Color.FromArgb(26, 27, 30);
            DGV_AchievementList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DGV_AchievementList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DGV_AchievementList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_AchievementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_AchievementList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn1, CL_Description, CL_Stats, CL_UnlockedTime, CL_ID });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(88, 90, 91);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DGV_AchievementList.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_AchievementList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            DGV_AchievementList.GridColor = System.Drawing.Color.FromArgb(26, 27, 30);
            DGV_AchievementList.Location = new System.Drawing.Point(-1, 65);
            DGV_AchievementList.Name = "DGV_AchievementList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(88, 89, 91);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(88, 89, 91);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DGV_AchievementList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGV_AchievementList.RowHeadersVisible = false;
            DGV_AchievementList.RowHeadersWidth = 51;
            DGV_AchievementList.RowTemplate.Height = 25;
            DGV_AchievementList.RowTemplate.ReadOnly = true;
            DGV_AchievementList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            DGV_AchievementList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGV_AchievementList.ShowCellErrors = false;
            DGV_AchievementList.ShowCellToolTips = false;
            DGV_AchievementList.ShowEditingIcon = false;
            DGV_AchievementList.ShowRowErrors = false;
            DGV_AchievementList.Size = new System.Drawing.Size(1167, 405);
            DGV_AchievementList.TabIndex = 1;
            DGV_AchievementList.CellClick += dataGridView1_CellClick;
            DGV_AchievementList.CellContentClick += DGV_AchievementList_CellContentClick;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.FalseValue = "0";
            dataGridViewCheckBoxColumn1.FillWeight = 70F;
            dataGridViewCheckBoxColumn1.HeaderText = "Unlock";
            dataGridViewCheckBoxColumn1.IndeterminateValue = "2";
            dataGridViewCheckBoxColumn1.MinimumWidth = 70;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dataGridViewCheckBoxColumn1.TrueValue = "1";
            dataGridViewCheckBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 150F;
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CL_Description
            // 
            CL_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            CL_Description.FillWeight = 300F;
            CL_Description.HeaderText = "Description";
            CL_Description.MinimumWidth = 6;
            CL_Description.Name = "CL_Description";
            CL_Description.ReadOnly = true;
            // 
            // CL_Stats
            // 
            CL_Stats.FillWeight = 300F;
            CL_Stats.HeaderText = "Stats";
            CL_Stats.MinimumWidth = 6;
            CL_Stats.Name = "CL_Stats";
            CL_Stats.ReadOnly = true;
            CL_Stats.Width = 300;
            // 
            // CL_UnlockedTime
            // 
            CL_UnlockedTime.HeaderText = "UnlockedTime";
            CL_UnlockedTime.Name = "CL_UnlockedTime";
            // 
            // CL_ID
            // 
            CL_ID.FillWeight = 40F;
            CL_ID.HeaderText = "ID";
            CL_ID.MinimumWidth = 6;
            CL_ID.Name = "CL_ID";
            CL_ID.ReadOnly = true;
            CL_ID.Width = 40;
            // 
            // Check_UnlockAll
            // 
            Check_UnlockAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Check_UnlockAll.AutoSize = true;
            Check_UnlockAll.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Check_UnlockAll.ForeColor = System.Drawing.Color.White;
            Check_UnlockAll.Location = new System.Drawing.Point(1021, 12);
            Check_UnlockAll.Name = "Check_UnlockAll";
            Check_UnlockAll.Size = new System.Drawing.Size(80, 32);
            Check_UnlockAll.TabIndex = 4;
            Check_UnlockAll.Text = "Allow\r\nUnlock All";
            Check_UnlockAll.UseVisualStyleBackColor = true;
            Check_UnlockAll.CheckedChanged += Check_UnlockAll_CheckedChanged;
            // 
            // BTN_ALRefresh
            // 
            BTN_ALRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BTN_ALRefresh.Location = new System.Drawing.Point(1021, 478);
            BTN_ALRefresh.Margin = new System.Windows.Forms.Padding(0);
            BTN_ALRefresh.Name = "BTN_ALRefresh";
            BTN_ALRefresh.Size = new System.Drawing.Size(134, 37);
            BTN_ALRefresh.TabIndex = 5;
            BTN_ALRefresh.Text = "Refresh (F5)";
            BTN_ALRefresh.UseVisualStyleBackColor = true;
            BTN_ALRefresh.Click += BTN_ALRefresh_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(598, 486);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(404, 28);
            label1.TabIndex = 13;
            label1.Text = "THIS IS EVENT BASED. IT WONT WORK";
            label1.Visible = false;
            // 
            // Sorting_Box
            // 
            Sorting_Box.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Sorting_Box.FormattingEnabled = true;
            Sorting_Box.Items.AddRange(new object[] { "All", "Unlockable", "Unlocked" });
            Sorting_Box.Location = new System.Drawing.Point(135, 490);
            Sorting_Box.Name = "Sorting_Box";
            Sorting_Box.Size = new System.Drawing.Size(121, 22);
            Sorting_Box.TabIndex = 14;
            Sorting_Box.TabStop = false;
            Sorting_Box.Text = "All";
            Sorting_Box.SelectedIndexChanged += Sorting_Box_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(164, 473);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 14);
            label2.TabIndex = 15;
            label2.Text = "Sorting";
            // 
            // searchbox
            // 
            searchbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            searchbox.Location = new System.Drawing.Point(280, 490);
            searchbox.Name = "searchbox";
            searchbox.PlaceholderText = "Search";
            searchbox.Size = new System.Drawing.Size(291, 22);
            searchbox.TabIndex = 16;
            searchbox.TextChanged += searchbox_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(60, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(20, 19);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // LBL_GamerscoreValue
            // 
            LBL_GamerscoreValue.AutoSize = true;
            LBL_GamerscoreValue.BackColor = System.Drawing.Color.Transparent;
            LBL_GamerscoreValue.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_GamerscoreValue.ForeColor = System.Drawing.Color.White;
            LBL_GamerscoreValue.Location = new System.Drawing.Point(77, 39);
            LBL_GamerscoreValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            LBL_GamerscoreValue.Name = "LBL_GamerscoreValue";
            LBL_GamerscoreValue.Size = new System.Drawing.Size(102, 19);
            LBL_GamerscoreValue.TabIndex = 22;
            LBL_GamerscoreValue.Text = "NAMEEEEEE";
            LBL_GamerscoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            LBL_GamerscoreValue.Click += LBL_GamerscoreValue_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(48, 52);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LBL_GamertagValue
            // 
            LBL_GamertagValue.AutoSize = true;
            LBL_GamertagValue.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LBL_GamertagValue.ForeColor = System.Drawing.Color.White;
            LBL_GamertagValue.Location = new System.Drawing.Point(60, 16);
            LBL_GamertagValue.Name = "LBL_GamertagValue";
            LBL_GamertagValue.Size = new System.Drawing.Size(81, 19);
            LBL_GamertagValue.TabIndex = 21;
            LBL_GamertagValue.Text = "Gamertag";
            LBL_GamertagValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AchievementList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(26, 27, 30);
            ClientSize = new System.Drawing.Size(1161, 521);
            Controls.Add(LBL_GamertagValue);
            Controls.Add(LBL_GamerscoreValue);
            Controls.Add(pictureBox2);
            Controls.Add(searchbox);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(Sorting_Box);
            Controls.Add(BTN_ALRefresh);
            Controls.Add(Check_UnlockAll);
            Controls.Add(DGV_AchievementList);
            Controls.Add(BTN_UnlockAll);
            Controls.Add(BTN_Unlock);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            KeyPreview = true;
            Name = "AchievementList";
            Text = "Achievement List";
            Load += AchievementList_Load;
            KeyDown += AchievementList_KeyDown;
            ((System.ComponentModel.ISupportInitialize)DGV_AchievementList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button BTN_Unlock;
        private System.Windows.Forms.Button BTN_UnlockAll;
        private System.Windows.Forms.DataGridView DGV_AchievementList;
        private System.Windows.Forms.CheckBox Check_UnlockAll;
        private System.Windows.Forms.Button BTN_ALRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sorting_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LBL_GamerscoreValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_GamertagValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_UnlockedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_ID;
    }
}