﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Reflection.Emit;
using Timer = System.Windows.Forms.Timer;

namespace Xbox_Achievement_Unlocker
{
    public partial class AchievementList : Form
    {
        private Timer typingTimer = new Timer();
        public dynamic aJsonresponse;
        public HttpClient client = new HttpClient();


        public AchievementList()
        {
            InitializeComponent();

            // timer so it doesnt update 9999 times after the search
            typingTimer.Interval = 500;
            typingTimer.Tick += TypingTimer_Tick;
        }
        // New constructor that takes a game name
        public AchievementList(string gameName, string gamertagValue, string gamerscoreValue)
        {
            InitializeComponent();
            LBL_GamertagValue.Text = gamertagValue;
            LBL_GamerscoreValue.Text = gamerscoreValue;
            this.Text = TitleID + " - Achievements";
            MessageBox.Show(gameName, "Game Name Debug");
        }

        string currentSystemLanguage = System.Globalization.CultureInfo.CurrentCulture.Name;
        public List<string> AchievementIDs = new List<string>();
        string SCID;
        string TitleID;
        string responseString;
        List<string> UnlockableAchievements = new List<string>();

        #region bright warning shit for stupid people
        private const int RainbowLength = 360;
        private readonly Color[] Rainbow = new Color[RainbowLength];
        private void InitRainbow()
        {
            for (int i = 0; i < RainbowLength; i++)
            {
                Rainbow[i] = ColorFromHSV(i, 1, 1);
            }
        }

        private async void StartFlashing()
        {
            while (true)
            {
                for (int i = 0; i < RainbowLength; i++)
                {
                    label1.ForeColor = Rainbow[i];
                    await Task.Delay(1);
                }
            }
        }

        private Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0) return Color.FromArgb(255, v, t, p);
            else if (hi == 1) return Color.FromArgb(255, q, v, p);
            else if (hi == 2) return Color.FromArgb(255, p, v, t);
            else if (hi == 3) return Color.FromArgb(255, p, q, v);
            else if (hi == 4) return Color.FromArgb(255, t, p, v);
            else return Color.FromArgb(255, v, p, q);
        }


        #endregion



        public void PopulateAchievementList()
        {
            DGV_AchievementList.Rows.Clear();
            var newline = 0;
            var backcolour = Color.Silver;
            if (aJsonresponse.achievements.Count == 0)
            {
                Close();
                MessageBox.Show("this game has no achivements", "fucky wucky");

            }
            else
            {
                SCID = aJsonresponse.achievements[0].serviceConfigId.ToString();
                TitleID = aJsonresponse.achievements[0].titleAssociations[0].id.ToString();
                for (int i = 0; i < aJsonresponse.achievements.Count; i++)
                {
                    if (aJsonresponse.achievements[0].progression.requirements.ToString().Length > 2)
                    {
                        if (aJsonresponse.achievements[0].progression.requirements[0].id !=
                            "00000000-0000-0000-0000-000000000000")
                        {
                            InitRainbow();
                            MessageBox.Show("THIS GAME USES EVENT BASED ACHIVEMENTS.\nTHIS TOOL WILL CURRENTLY NOT WORK", "Warning");
                            label1.Visible = true;
                            StartFlashing();
                        }

                        break;
                    }
                }

                for (int i = 0; i < aJsonresponse.achievements.Count; i++)
                {
                    if (aJsonresponse.achievements[i].progressState.ToString() == "Achieved" && (Sorting_Box.SelectedIndex is 0 or 2 or -1))
                    {
                        try
                        {
                            if (searchbox.Text.Length > 0)
                                if (!aJsonresponse.achievements[i].name.ToString().ToLowerInvariant().Contains(searchbox.Text.ToLowerInvariant()))
                                    continue;
                            // check if UnlockedTime is null

                            string unlockedTime; // Declare the variable here
                            DateTime dateTimeUnlocked;
                            if (DateTime.TryParse(aJsonresponse.achievements[i].progression.timeUnlocked?.ToString(), out dateTimeUnlocked)
                                && dateTimeUnlocked != DateTime.MinValue)
                            {
                                unlockedTime = dateTimeUnlocked.ToString();
                            }
                            else
                            {
                                unlockedTime = "Locked";
                            }

                            DGV_AchievementList.Rows.Add(2,
                                aJsonresponse.achievements[i].name.ToString(),
                                aJsonresponse.achievements[i].description.ToString(),
                                "Gamerscore: " + aJsonresponse.achievements[i].rewards[0].value.ToString() +
                                "\nRarity: " + aJsonresponse.achievements[i].rarity.currentCategory.ToString() +
                                "\nPlayer Percentage: " +
                                aJsonresponse.achievements[i].rarity.currentPercentage.ToString() + "%" +
                                "\nSecret: " + aJsonresponse.achievements[i].isSecret.ToString() +
                                "\nProgress State: " + aJsonresponse.achievements[i].progressState.ToString() +
                                "\nUnlock Time: " + aJsonresponse.achievements[i].progression.timeUnlocked.ToString(),
                                unlockedTime,
                                Convert.ToInt32(aJsonresponse.achievements[i].id)
                            );
                        }
                        catch
                        {
                            string unlockedTime; // Declare the variable here
                            DateTime dateTimeUnlocked;
                            if (DateTime.TryParse(aJsonresponse.achievements[i].progression.timeUnlocked?.ToString(), out dateTimeUnlocked)
                                && dateTimeUnlocked != DateTime.MinValue)
                            {
                                unlockedTime = dateTimeUnlocked.ToString();
                            }
                            else
                            {
                                unlockedTime = "Locked";
                            }

                            DGV_AchievementList.Rows.Add(0,
                                aJsonresponse.achievements[i].name.ToString(),
                                aJsonresponse.achievements[i].description.ToString(),
                                "There was a problem grabbing stats for this achievement.\n\n\n\n\n",
                                unlockedTime,
                                Convert.ToInt32(aJsonresponse.achievements[i].id)
                            );
                        }
                    }
                    if (aJsonresponse.achievements[i].progressState.ToString() != "Achieved" && (Sorting_Box.SelectedIndex is 0 or 1))
                    {
                        if (searchbox.Text.Length > 0)
                            if (!aJsonresponse.achievements[i].name.ToString().ToLowerInvariant().Contains(searchbox.Text.ToLowerInvariant()))
                                continue;

                        try
                        {
                            string unlockedTime; // Declare the variable here
                            DateTime dateTimeUnlocked;
                            if (DateTime.TryParse(aJsonresponse.achievements[i].progression.timeUnlocked?.ToString(), out dateTimeUnlocked)
                                && dateTimeUnlocked != DateTime.MinValue)
                            {
                                unlockedTime = dateTimeUnlocked.ToString();
                            }
                            else
                            {
                                unlockedTime = "Locked";
                            }

                            DGV_AchievementList.Rows.Add(0,
                                aJsonresponse.achievements[i].name.ToString(),
                                aJsonresponse.achievements[i].description.ToString(),
                                "Gamerscore: " + aJsonresponse.achievements[i].rewards[0].value.ToString() +
                                "\nRarity: " + aJsonresponse.achievements[i].rarity.currentCategory.ToString() +
                                "\nPlayer Percentage: " +
                                aJsonresponse.achievements[i].rarity.currentPercentage.ToString() +
                                "%" +
                                "\nSecret: " + aJsonresponse.achievements[i].isSecret.ToString() +
                                "\nProgress State: " + aJsonresponse.achievements[i].progressState.ToString() + "\n",
                                unlockedTime,
                                Convert.ToInt32(aJsonresponse.achievements[i].id)
                            );
                        }
                        catch
                        {
                            string unlockedTime; // Declare the variable here
                            DateTime dateTimeUnlocked;
                            if (DateTime.TryParse(aJsonresponse.achievements[i].progression.timeUnlocked?.ToString(), out dateTimeUnlocked)
                                && dateTimeUnlocked != DateTime.MinValue)
                            {
                                unlockedTime = dateTimeUnlocked.ToString();
                            }
                            else
                            {
                                unlockedTime = "Locked";
                            }

                            DGV_AchievementList.Rows.Add(0,
                                aJsonresponse.achievements[i].name.ToString(),
                                aJsonresponse.achievements[i].description.ToString(),
                                "There was a problem grabbing stats for this achievement.\n\n\n\n\n",
                                unlockedTime,
                                Convert.ToInt32(aJsonresponse.achievements[i].id)
                            );
                        }

                    }
                }
            }
        }
        void SelectAchievement(object sender, EventArgs e)
        {
            CheckBox SelectedAchievement = (sender as CheckBox);
            if (SelectedAchievement.Checked)
            {
                AchievementIDs.Add(SelectedAchievement.Name);
            }
            else
            {
                AchievementIDs.Remove(SelectedAchievement.Name);
            }
        }
        private void CheckBox_Images_CheckedChanged(object sender, EventArgs e)
        {
            //dont even know if I can put images in a data grid view lmao
        }

        async void BTN_Unlock_Click(object sender, EventArgs e)
        {
            var requestbody = "{\"action\":\"progressUpdate\",\"serviceConfigId\":\"" + SCID + "\",\"titleId\":\"" + TitleID + "\",\"userId\":\"" + MainWindow.xuid + "\",\"achievements\":[";

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "2");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);
            client.DefaultRequestHeaders.Add("Host", "achievements.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            client.DefaultRequestHeaders.Add("User-Agent", "XboxServicesAPI/2021.10.20211005.0 c");
            client.DefaultRequestHeaders.Add("Signature", "RGFtbklHb3R0YU1ha2VUaGlzU3RyaW5nU3VwZXJMb25nSHVoLkRvbnRFdmVuS25vd1doYXRTaG91bGRCZUhlcmVEcmFmZlN0cmluZw==");
            //
            if (AchievementIDs.Count == 0)
            {
                MessageBox.Show("Select Achivements");
            }
            else
            {
                foreach (string id in AchievementIDs)
                {
                    requestbody = requestbody + "{\"id\":\"" + id + "\",\"percentComplete\":\"100\"},";
                }
                requestbody = requestbody.Remove(requestbody.Length - 1) + "]}";
                var bodyconverted = new StringContent(requestbody, Encoding.UTF8, "application/json");
                try
                {
                    await client.PostAsync("https://achievements.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/achievements/" + SCID + "/update", bodyconverted);
                }
                catch (HttpRequestException ex)
                {
                    if ((int)ex.StatusCode == 401)
                        MessageBox.Show("Xauth is not correct. Click the FuckyWucky Fixer button until the error goes away", "401 Unauthorised");
                    else
                        MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky");
                }


            }
            await RefreshList();
        }

        private async void BTN_UnlockAll_Click(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "4");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);
            client.DefaultRequestHeaders.Add("Host", "achievements.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            var Jsonresponse = (dynamic)JObject.Parse(await client.GetStringAsync("https://achievements.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/achievements?titleId=" + TitleID + "&maxItems=1000"));
            //create list for unlock all
            for (int i = 0; i < Jsonresponse.achievements.Count; i++)
            {
                if (Jsonresponse.achievements[i].progressState.ToString() != "Achieved")
                {
                    UnlockableAchievements.Add(Jsonresponse.achievements[i].id.ToString());
                }
            }

            var requestbody = "{\"action\":\"progressUpdate\",\"serviceConfigId\":\"" + SCID + "\",\"titleId\":\"" + TitleID + "\",\"userId\":\"" + MainWindow.xuid + "\",\"achievements\":[";

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "2");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);
            client.DefaultRequestHeaders.Add("Host", "achievements.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            client.DefaultRequestHeaders.Add("User-Agent", "XboxServicesAPI/2021.04.20210610.3 c");
            client.DefaultRequestHeaders.Add("Signature", "RGFtbklHb3R0YU1ha2VUaGlzU3RyaW5nU3VwZXJMb25nSHVoLkRvbnRFdmVuS25vd1doYXRTaG91bGRCZUhlcmVEcmFmZlN0cmluZw==");

            for (int i = 0; i < UnlockableAchievements.Count; i++)
            {
                requestbody = requestbody + "{\"id\":\"" + UnlockableAchievements[i] + "\",\"percentComplete\":\"100\"},";


                if (i % 50 == 0 || i == UnlockableAchievements.Count || i != 0)
                {
                    requestbody = requestbody.Remove(requestbody.Length - 1) + "]}";
                    var bodyconverted = new StringContent(requestbody);
                    try
                    {
                        client.PostAsync("https://achievements.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/achievements/" + SCID + "/update", bodyconverted);
                    }
                    catch (HttpRequestException ex)
                    {
                        if ((int)ex.StatusCode == 401)
                            MessageBox.Show("Xauth is not correct. Click the FuckyWucky Fixer button until the error goes away", "401 Unauthorised");
                        else
                            MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky");
                    }

                    requestbody = "{\"action\":\"progressUpdate\",\"serviceConfigId\":\"" + SCID + "\",\"titleId\":\"" + TitleID + "\",\"userId\":\"" + MainWindow.xuid + "\",\"achievements\":[";
                }
            }
            await RefreshList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0
                || e.ColumnIndex < 0)
                return;

            if ((int)DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value == 0)
            {
                AchievementIDs.Add(DGV_AchievementList.Rows[e.RowIndex].Cells["CL_ID"].Value.ToString());
                DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value = 1;
            }
            else if ((int)DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value == 1)
            {
                DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value = 0;
                AchievementIDs.Remove(DGV_AchievementList.Rows[e.RowIndex].Cells["CL_ID"].Value.ToString());
            }

        }

        private void Check_UnlockAll_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_UnlockAll.Checked)
            {
                BTN_UnlockAll.Enabled = true;
            }
            else
            {
                BTN_UnlockAll.Enabled = false;
            }
        }

        async void BTN_ALRefresh_Click(object sender, EventArgs e)
        {
            await RefreshList();
        }

        async Task RefreshList()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "4");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);
            client.DefaultRequestHeaders.Add("Host", "achievements.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            aJsonresponse = (dynamic)JObject.Parse(await client.GetStringAsync("https://achievements.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/achievements?titleId=" + TitleID + "&maxItems=1000"));
            PopulateAchievementList();
        }

        private async void AchievementList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                await RefreshList();

        }

        private async void Sorting_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAchievementList();
        }


        private async void searchbox_TextChanged(object sender, EventArgs e)
        {
            typingTimer.Stop();
            typingTimer.Start();
        }

        private async void TypingTimer_Tick(object sender, EventArgs e)
        {
            typingTimer.Stop();
            PopulateAchievementList();
        }

        private void AchievementList_Load(object sender, EventArgs e)
        {

        }

        private void DGV_AchievementList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LBL_GamerscoreValue_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
