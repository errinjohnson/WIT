namespace WIT_Earnings
{
    partial class WIT_MAIN
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
            this.BtnWIT_US = new System.Windows.Forms.Button();
            this.lblWitUS = new System.Windows.Forms.Label();
            this.lblWitLou = new System.Windows.Forms.Label();
            this.BtnWIT_Lou = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnWIT_US
            // 
            this.BtnWIT_US.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWIT_US.Location = new System.Drawing.Point(74, 138);
            this.BtnWIT_US.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnWIT_US.Name = "BtnWIT_US";
            this.BtnWIT_US.Size = new System.Drawing.Size(204, 49);
            this.BtnWIT_US.TabIndex = 0;
            this.BtnWIT_US.Text = "View Results";
            this.BtnWIT_US.UseVisualStyleBackColor = true;
            this.BtnWIT_US.Click += new System.EventHandler(this.BtnWIT_US_Click);
            // 
            // lblWitUS
            // 
            this.lblWitUS.AutoSize = true;
            this.lblWitUS.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWitUS.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblWitUS.Location = new System.Drawing.Point(60, 53);
            this.lblWitUS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWitUS.Name = "lblWitUS";
            this.lblWitUS.Size = new System.Drawing.Size(256, 76);
            this.lblWitUS.TabIndex = 1;
            this.lblWitUS.Text = "Women In Tech\r\nU.S. by Occupation";
            // 
            // lblWitLou
            // 
            this.lblWitLou.AutoSize = true;
            this.lblWitLou.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWitLou.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblWitLou.Location = new System.Drawing.Point(537, 51);
            this.lblWitLou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWitLou.Name = "lblWitLou";
            this.lblWitLou.Size = new System.Drawing.Size(373, 76);
            this.lblWitLou.TabIndex = 2;
            this.lblWitLou.Text = "Women In Tech\r\n Louisville, KY by Occupation";
            // 
            // BtnWIT_Lou
            // 
            this.BtnWIT_Lou.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWIT_Lou.Location = new System.Drawing.Point(603, 137);
            this.BtnWIT_Lou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnWIT_Lou.Name = "BtnWIT_Lou";
            this.BtnWIT_Lou.Size = new System.Drawing.Size(228, 59);
            this.BtnWIT_Lou.TabIndex = 3;
            this.BtnWIT_Lou.Text = "View Results";
            this.BtnWIT_Lou.UseVisualStyleBackColor = true;
            this.BtnWIT_Lou.Click += new System.EventHandler(this.BtnWIT_Lou_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(361, 135);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(166, 62);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.AutoSize = true;
            this.lblTitleMain.Location = new System.Drawing.Point(42, 13);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(453, 38);
            this.lblTitleMain.TabIndex = 5;
            this.lblTitleMain.Text = "U.S. Census Labor Statistics  2018";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 6;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(531, 9);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(389, 38);
            this.lblTitle2.TabIndex = 7;
            this.lblTitle2.Text = "U.S. Census 5-Year ACS 2018";
            // 
            // WIT_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 211);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitleMain);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnWIT_Lou);
            this.Controls.Add(this.lblWitLou);
            this.Controls.Add(this.lblWitUS);
            this.Controls.Add(this.BtnWIT_US);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WIT_MAIN";
            this.Text = "WIT_MAIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWIT_US;
        private System.Windows.Forms.Label lblWitUS;
        private System.Windows.Forms.Label lblWitLou;
        private System.Windows.Forms.Button BtnWIT_Lou;
        private System.Windows.Forms.Button BtnExit;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle2;
    }
}