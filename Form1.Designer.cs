namespace URGE
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkTopTrends = new System.Windows.Forms.CheckedListBox();
            this.txtGeneratedTweet = new System.Windows.Forms.TextBox();
            this.btnSendTweet = new System.Windows.Forms.Button();
            this.btnGenerateTweet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkAntiShock = new System.Windows.Forms.CheckBox();
            this.radioBrainstorm = new System.Windows.Forms.RadioButton();
            this.radioSafeteyNet = new System.Windows.Forms.RadioButton();
            this.radioNewTag = new System.Windows.Forms.RadioButton();
            this.radioHijack = new System.Windows.Forms.RadioButton();
            this.txtOperationTag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFollowTag = new System.Windows.Forms.TextBox();
            this.btnRefreshWatchTag = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCharCount = new System.Windows.Forms.Label();
            this.btnRefreshTrends = new System.Windows.Forms.Button();
            this.webTweetHistory = new System.Windows.Forms.WebBrowser();
            this.txtTagPerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkTopTrends
            // 
            this.checkTopTrends.CheckOnClick = true;
            this.checkTopTrends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTopTrends.FormattingEnabled = true;
            this.checkTopTrends.Location = new System.Drawing.Point(614, 152);
            this.checkTopTrends.Name = "checkTopTrends";
            this.checkTopTrends.Size = new System.Drawing.Size(290, 154);
            this.checkTopTrends.TabIndex = 0;
            // 
            // txtGeneratedTweet
            // 
            this.txtGeneratedTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedTweet.Location = new System.Drawing.Point(615, 367);
            this.txtGeneratedTweet.Multiline = true;
            this.txtGeneratedTweet.Name = "txtGeneratedTweet";
            this.txtGeneratedTweet.Size = new System.Drawing.Size(292, 172);
            this.txtGeneratedTweet.TabIndex = 2;
            this.txtGeneratedTweet.TextChanged += new System.EventHandler(this.txtGeneratedTweet_TextChanged);
            // 
            // btnSendTweet
            // 
            this.btnSendTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendTweet.Location = new System.Drawing.Point(617, 545);
            this.btnSendTweet.Name = "btnSendTweet";
            this.btnSendTweet.Size = new System.Drawing.Size(226, 37);
            this.btnSendTweet.TabIndex = 3;
            this.btnSendTweet.Text = "Send Tweet";
            this.btnSendTweet.UseVisualStyleBackColor = true;
            this.btnSendTweet.Click += new System.EventHandler(this.btnSendTweet_Click);
            // 
            // btnGenerateTweet
            // 
            this.btnGenerateTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTweet.Location = new System.Drawing.Point(614, 312);
            this.btnGenerateTweet.Name = "btnGenerateTweet";
            this.btnGenerateTweet.Size = new System.Drawing.Size(144, 37);
            this.btnGenerateTweet.TabIndex = 4;
            this.btnGenerateTweet.Text = "Generate Tweet";
            this.btnGenerateTweet.UseVisualStyleBackColor = true;
            this.btnGenerateTweet.Click += new System.EventHandler(this.btnGenerateTweet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Top-Trends";
            // 
            // checkAntiShock
            // 
            this.checkAntiShock.AutoSize = true;
            this.checkAntiShock.Checked = true;
            this.checkAntiShock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAntiShock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAntiShock.Location = new System.Drawing.Point(510, 105);
            this.checkAntiShock.Name = "checkAntiShock";
            this.checkAntiShock.Size = new System.Drawing.Size(87, 19);
            this.checkAntiShock.TabIndex = 7;
            this.checkAntiShock.Text = "#AntiShock";
            this.checkAntiShock.UseVisualStyleBackColor = true;
            this.checkAntiShock.CheckStateChanged += new System.EventHandler(this.checkAntiShock_CheckStateChanged);
            // 
            // radioBrainstorm
            // 
            this.radioBrainstorm.AutoSize = true;
            this.radioBrainstorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBrainstorm.Location = new System.Drawing.Point(615, 90);
            this.radioBrainstorm.Name = "radioBrainstorm";
            this.radioBrainstorm.Size = new System.Drawing.Size(151, 19);
            this.radioBrainstorm.TabIndex = 8;
            this.radioBrainstorm.Text = "brainstorm [#OPRadar]";
            this.radioBrainstorm.UseVisualStyleBackColor = true;
            this.radioBrainstorm.CheckedChanged += new System.EventHandler(this.radioBrainstorm_CheckedChanged);
            // 
            // radioSafeteyNet
            // 
            this.radioSafeteyNet.AutoSize = true;
            this.radioSafeteyNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSafeteyNet.Location = new System.Drawing.Point(615, 115);
            this.radioSafeteyNet.Name = "radioSafeteyNet";
            this.radioSafeteyNet.Size = new System.Drawing.Size(143, 19);
            this.radioSafeteyNet.TabIndex = 9;
            this.radioSafeteyNet.Text = "safety net [#OpShield]";
            this.radioSafeteyNet.UseVisualStyleBackColor = true;
            this.radioSafeteyNet.CheckedChanged += new System.EventHandler(this.radioSafeteyNet_CheckedChanged);
            // 
            // radioNewTag
            // 
            this.radioNewTag.AutoSize = true;
            this.radioNewTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNewTag.Location = new System.Drawing.Point(776, 90);
            this.radioNewTag.Name = "radioNewTag";
            this.radioNewTag.Size = new System.Drawing.Size(131, 19);
            this.radioNewTag.TabIndex = 10;
            this.radioNewTag.Text = "new tag [#OpPulse]";
            this.radioNewTag.UseVisualStyleBackColor = true;
            this.radioNewTag.CheckedChanged += new System.EventHandler(this.radioNewTag_CheckedChanged);
            // 
            // radioHijack
            // 
            this.radioHijack.AutoSize = true;
            this.radioHijack.Checked = true;
            this.radioHijack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHijack.Location = new System.Drawing.Point(776, 115);
            this.radioHijack.Name = "radioHijack";
            this.radioHijack.Size = new System.Drawing.Size(134, 19);
            this.radioHijack.TabIndex = 11;
            this.radioHijack.TabStop = true;
            this.radioHijack.Text = "hijack [#OpShadow]";
            this.radioHijack.UseVisualStyleBackColor = true;
            this.radioHijack.CheckedChanged += new System.EventHandler(this.radioHijack_CheckedChanged);
            // 
            // txtOperationTag
            // 
            this.txtOperationTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperationTag.Location = new System.Drawing.Point(615, 25);
            this.txtOperationTag.Name = "txtOperationTag";
            this.txtOperationTag.Size = new System.Drawing.Size(290, 22);
            this.txtOperationTag.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Operation name";
            // 
            // txtFollowTag
            // 
            this.txtFollowTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFollowTag.Location = new System.Drawing.Point(100, 25);
            this.txtFollowTag.Name = "txtFollowTag";
            this.txtFollowTag.Size = new System.Drawing.Size(226, 22);
            this.txtFollowTag.TabIndex = 15;
            // 
            // btnRefreshWatchTag
            // 
            this.btnRefreshWatchTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshWatchTag.Location = new System.Drawing.Point(332, 22);
            this.btnRefreshWatchTag.Name = "btnRefreshWatchTag";
            this.btnRefreshWatchTag.Size = new System.Drawing.Size(113, 26);
            this.btnRefreshWatchTag.TabIndex = 16;
            this.btnRefreshWatchTag.Text = "Refresh";
            this.btnRefreshWatchTag.UseVisualStyleBackColor = true;
            this.btnRefreshWatchTag.Click += new System.EventHandler(this.btnRefreshWatchTag_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Watch tag";
            // 
            // txtCharCount
            // 
            this.txtCharCount.AutoSize = true;
            this.txtCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharCount.Location = new System.Drawing.Point(860, 555);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.Size = new System.Drawing.Size(45, 16);
            this.txtCharCount.TabIndex = 19;
            this.txtCharCount.Text = "0/140";
            // 
            // btnRefreshTrends
            // 
            this.btnRefreshTrends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTrends.Location = new System.Drawing.Point(814, 312);
            this.btnRefreshTrends.Name = "btnRefreshTrends";
            this.btnRefreshTrends.Size = new System.Drawing.Size(90, 35);
            this.btnRefreshTrends.TabIndex = 20;
            this.btnRefreshTrends.Text = "Refresh";
            this.btnRefreshTrends.UseVisualStyleBackColor = true;
            this.btnRefreshTrends.Click += new System.EventHandler(this.btnRefreshTrends_Click);
            // 
            // webTweetHistory
            // 
            this.webTweetHistory.Location = new System.Drawing.Point(16, 56);
            this.webTweetHistory.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTweetHistory.Name = "webTweetHistory";
            this.webTweetHistory.Size = new System.Drawing.Size(429, 526);
            this.webTweetHistory.TabIndex = 21;
            // 
            // txtTagPerson
            // 
            this.txtTagPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagPerson.Location = new System.Drawing.Point(614, 56);
            this.txtTagPerson.Name = "txtTagPerson";
            this.txtTagPerson.Size = new System.Drawing.Size(290, 22);
            this.txtTagPerson.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tag person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Generated-Tweet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 597);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTagPerson);
            this.Controls.Add(this.webTweetHistory);
            this.Controls.Add(this.btnRefreshTrends);
            this.Controls.Add(this.txtCharCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefreshWatchTag);
            this.Controls.Add(this.txtFollowTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOperationTag);
            this.Controls.Add(this.radioHijack);
            this.Controls.Add(this.radioNewTag);
            this.Controls.Add(this.radioSafeteyNet);
            this.Controls.Add(this.radioBrainstorm);
            this.Controls.Add(this.checkAntiShock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateTweet);
            this.Controls.Add(this.btnSendTweet);
            this.Controls.Add(this.txtGeneratedTweet);
            this.Controls.Add(this.checkTopTrends);
            this.Name = "Form1";
            this.Text = "U.R.G.E. Universal Rapid Gamma Emitter (twitter edition)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkTopTrends;
        private System.Windows.Forms.TextBox txtGeneratedTweet;
        private System.Windows.Forms.Button btnSendTweet;
        private System.Windows.Forms.Button btnGenerateTweet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkAntiShock;
        private System.Windows.Forms.RadioButton radioBrainstorm;
        private System.Windows.Forms.RadioButton radioSafeteyNet;
        private System.Windows.Forms.RadioButton radioNewTag;
        private System.Windows.Forms.RadioButton radioHijack;
        private System.Windows.Forms.TextBox txtOperationTag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFollowTag;
        private System.Windows.Forms.Button btnRefreshWatchTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtCharCount;
        private System.Windows.Forms.Button btnRefreshTrends;
        private System.Windows.Forms.WebBrowser webTweetHistory;
        private System.Windows.Forms.TextBox txtTagPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

