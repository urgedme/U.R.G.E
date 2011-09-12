namespace URGE
{
    partial class Enter_PIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_PIN));
            this.button1 = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.webTwitterAuth = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.picLoadScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(57, 12);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(169, 26);
            this.txtPin.TabIndex = 1;
            // 
            // webTwitterAuth
            // 
            this.webTwitterAuth.Location = new System.Drawing.Point(0, 48);
            this.webTwitterAuth.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTwitterAuth.Name = "webTwitterAuth";
            this.webTwitterAuth.ScrollBarsEnabled = false;
            this.webTwitterAuth.Size = new System.Drawing.Size(1125, 577);
            this.webTwitterAuth.TabIndex = 2;
            this.webTwitterAuth.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webTwitterAuth_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PIN:";
            // 
            // picLoadScreen
            // 
            this.picLoadScreen.Image = ((System.Drawing.Image)(resources.GetObject("picLoadScreen.Image")));
            this.picLoadScreen.Location = new System.Drawing.Point(0, 48);
            this.picLoadScreen.Name = "picLoadScreen";
            this.picLoadScreen.Size = new System.Drawing.Size(1134, 577);
            this.picLoadScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoadScreen.TabIndex = 4;
            this.picLoadScreen.TabStop = false;
            // 
            // Enter_PIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 624);
            this.Controls.Add(this.picLoadScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webTwitterAuth);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.button1);
            this.Name = "Enter_PIN";
            this.Text = "Twitter authentication";
            ((System.ComponentModel.ISupportInitialize)(this.picLoadScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.WebBrowser webTwitterAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLoadScreen;
    }
}