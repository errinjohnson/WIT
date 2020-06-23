namespace WIT_Earnings
{
    partial class FormWit_Lou
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
            this.BtnDisplay2 = new System.Windows.Forms.Button();
            this.txtDisplayAll2 = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblEmployed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDisplay2
            // 
            this.BtnDisplay2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplay2.Location = new System.Drawing.Point(13, 327);
            this.BtnDisplay2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDisplay2.Name = "BtnDisplay2";
            this.BtnDisplay2.Size = new System.Drawing.Size(149, 56);
            this.BtnDisplay2.TabIndex = 0;
            this.BtnDisplay2.Text = "Display";
            this.BtnDisplay2.UseVisualStyleBackColor = true;
            this.BtnDisplay2.Click += new System.EventHandler(this.BtnDisplay2_Click);
            // 
            // txtDisplayAll2
            // 
            this.txtDisplayAll2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayAll2.Location = new System.Drawing.Point(13, 89);
            this.txtDisplayAll2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisplayAll2.Name = "txtDisplayAll2";
            this.txtDisplayAll2.ReadOnly = true;
            this.txtDisplayAll2.Size = new System.Drawing.Size(832, 203);
            this.txtDisplayAll2.TabIndex = 1;
            this.txtDisplayAll2.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Location = new System.Drawing.Point(538, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 76);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Women In Technology\r\nLouisville, KY\r\n";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(696, 324);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(149, 59);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblEmployed
            // 
            this.lblEmployed.AutoSize = true;
            this.lblEmployed.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEmployed.Location = new System.Drawing.Point(12, 33);
            this.lblEmployed.Name = "lblEmployed";
            this.lblEmployed.Size = new System.Drawing.Size(135, 38);
            this.lblEmployed.TabIndex = 4;
            this.lblEmployed.Text = "Employed";
            // 
            // FormWit_Lou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 395);
            this.Controls.Add(this.lblEmployed);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDisplayAll2);
            this.Controls.Add(this.BtnDisplay2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormWit_Lou";
            this.Text = "FormWit_Lou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDisplay2;
        private System.Windows.Forms.RichTextBox txtDisplayAll2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label lblEmployed;
    }
}