namespace Xbox_Achievement_Unlocker
{
    partial class GamerscoreControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamerscoreControl));
            GamerscoreAmount = new System.Windows.Forms.TextBox();
            PictureBoxGamerscore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxGamerscore).BeginInit();
            SuspendLayout();
            // 
            // GamerscoreAmount
            // 
            GamerscoreAmount.BackColor = System.Drawing.Color.FromArgb(16, 17, 20);
            GamerscoreAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            GamerscoreAmount.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            GamerscoreAmount.ForeColor = System.Drawing.Color.White;
            GamerscoreAmount.Location = new System.Drawing.Point(56, 65);
            GamerscoreAmount.Name = "GamerscoreAmount";
            GamerscoreAmount.Size = new System.Drawing.Size(50, 15);
            GamerscoreAmount.TabIndex = 17;
            GamerscoreAmount.Text = "XAUTH";
            // 
            // PictureBoxGamerscore
            // 
            PictureBoxGamerscore.Image = (System.Drawing.Image)resources.GetObject("PictureBoxGamerscore.Image");
            PictureBoxGamerscore.Location = new System.Drawing.Point(35, 64);
            PictureBoxGamerscore.Name = "PictureBoxGamerscore";
            PictureBoxGamerscore.Size = new System.Drawing.Size(20, 19);
            PictureBoxGamerscore.TabIndex = 24;
            PictureBoxGamerscore.TabStop = false;
            // 
            // GamerscoreControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(PictureBoxGamerscore);
            Controls.Add(GamerscoreAmount);
            Name = "GamerscoreControl";
            ((System.ComponentModel.ISupportInitialize)PictureBoxGamerscore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox GamerscoreAmount;
        private System.Windows.Forms.PictureBox PictureBoxGamerscore;
    }
}
