using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace URGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.twitterAPI = new TwitterAPI();
        }

        public void init()
        {
     
        }

        public TwitterAPI twitterAPI { get; set; }

        private void btnSendTweet_Click(object sender, EventArgs e)
        {
            this.picTweetStatus.Image = URGE.Properties.Resources.light_red;
            if (this.checkTweetLength())
            {
                if (this.twitterAPI.sendTweet(txtGeneratedTweet.Text))
                {
                    if (this.txtOperationTag.Text != "") {
                        this.refreshWatchTag(this.txtOperationTag.Text);
                    }

                    this.picTweetStatus.Image = URGE.Properties.Resources.light_green;
                }
                else
                {
                    MessageBox.Show("Update did not go through.");
                    this.picTweetStatus.Image = URGE.Properties.Resources.light_red;
                }
            }
        }

        protected string currentRadioValue = "#OpShadow";

        private void btnGenerateTweet_Click(object sender, EventArgs e)
        {
            txtGeneratedTweet.Text = "";

            if (txtTagPerson.Text != "") 
            {
                txtGeneratedTweet.Text += " @" + txtTagPerson.Text;
            }

            if (txtOperationTag.Text != "")
            {
                txtGeneratedTweet.Text += " #" + txtOperationTag.Text;
            }

            if (checkAntiShock.Checked) {
                txtGeneratedTweet.Text += " "+this.currentRadioValue;
            }

            foreach ( string trend in checkTopTrends.CheckedItems) {
                txtGeneratedTweet.Text += " "+trend;
            }
        }

        private void checkAntiShock_CheckStateChanged(object sender, EventArgs e)
        {
            if (!checkAntiShock.Checked)
            {
                this.radioBrainstorm.Enabled = false;
                this.radioHijack.Enabled = false;
                this.radioNewTag.Enabled = false;
                this.radioSafeteyNet.Enabled = false;
            }
            else {
                this.radioBrainstorm.Enabled = true;
                this.radioHijack.Enabled = true;
                this.radioNewTag.Enabled = true;
                this.radioSafeteyNet.Enabled = true;
            }
        }

        private void radioBrainstorm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBrainstorm.Checked) {
                this.currentRadioValue = "#OpRadar";
            }
        }

        private void radioSafeteyNet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBrainstorm.Checked)
            {
                this.currentRadioValue = "#OpShield";
            }
        }

        private void radioNewTag_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBrainstorm.Checked)
            {
                this.currentRadioValue = "#OpPulse";
            }
        }

        private void radioHijack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBrainstorm.Checked)
            {
                this.currentRadioValue = "#OpShadow";
            }
        }

        private void btnRefreshTrends_Click(object sender, EventArgs e)
        {
            this.checkTopTrends.Items.Clear();
            foreach (string trend in this.twitterAPI.getGetCurrentTrends())
            {
                this.checkTopTrends.Items.Add(trend);
            }
        }

        private void txtGeneratedTweet_TextChanged(object sender, EventArgs e)
        {
            int len = txtGeneratedTweet.Text.Length;
            txtCharCount.Text =  len.ToString()+ "/140";
        }

        private bool checkTweetLength()
        { 
            int len = txtGeneratedTweet.Text.Length;
            if (len > 140) {
                MessageBox.Show("This Tweet is to long!");
                return false;
            }
            return true;
        }

        private void btnRefreshWatchTag_Click(object sender, EventArgs e)
        {
            if (txtFollowTag.Text != "")
            {
                this.refreshWatchTag(txtFollowTag.Text);
            }
        }

        private void refreshWatchTag(string tag) 
        {
            txtFollowTag.Text = tag;
            string html = @"<html><head></head><body style=""background-color: #333;"">";
            foreach (string tweet in this.twitterAPI.getCurrentTweetsForHash(tag))
            {
                html += tweet;
            }
            html += "</body></html>";
            this.writeInBrowserWindow(html);
        }

        private void writeInBrowserWindow(string html) 
        {
            if (null == this.webTweetHistory.Document)
            {
                this.webTweetHistory.Navigate("about:blank");
            }
            webTweetHistory.Document.OpenNew(true);
            webTweetHistory.Document.Write(html);         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.twitterAPI.auth();
            }
            catch (TwitterizerException ex)
            {
                this.Close();
                Application.Exit();
            }   
        }
    }
}
