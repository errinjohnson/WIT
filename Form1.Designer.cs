namespace WIT_Earnings
{
    partial class FORM_WIT
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
            this.txtDisplayAll = new System.Windows.Forms.RichTextBox();
            this.BtnDisplayAll = new System.Windows.Forms.Button();
            this.listOccup = new System.Windows.Forms.ListBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.lblSouce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplayAll
            // 
            this.txtDisplayAll.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayAll.Location = new System.Drawing.Point(26, 92);
            this.txtDisplayAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisplayAll.Name = "txtDisplayAll";
            this.txtDisplayAll.Size = new System.Drawing.Size(992, 328);
            this.txtDisplayAll.TabIndex = 6;
            this.txtDisplayAll.Text = "";
            // 
            // BtnDisplayAll
            // 
            this.BtnDisplayAll.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplayAll.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnDisplayAll.Location = new System.Drawing.Point(1026, 194);
            this.BtnDisplayAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDisplayAll.Name = "BtnDisplayAll";
            this.BtnDisplayAll.Size = new System.Drawing.Size(192, 88);
            this.BtnDisplayAll.TabIndex = 7;
            this.BtnDisplayAll.Text = "Display All Records";
            this.BtnDisplayAll.UseVisualStyleBackColor = true;
            this.BtnDisplayAll.Click += new System.EventHandler(this.BtnDisplayAll_Click);
            // 
            // listOccup
            // 
            this.listOccup.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOccup.FormattingEnabled = true;
            this.listOccup.ItemHeight = 38;
            this.listOccup.Items.AddRange(new object[] {
            "aaTotals Computer_math",
            "Actuaries",
            "Computer and info. research scientist",
            "Computer network architects",
            "Computer occup. all other",
            "Computer programmers",
            "Computer support specialists",
            "Computer systems analysts",
            "Database administrators",
            "Information security analysts",
            "Mathematicians",
            "Misc. mathematical science",
            "Network and computer systems admin",
            "Operations research analyst",
            "Software dev apps and systems",
            "Statisticians",
            "Web developers"});
            this.listOccup.Location = new System.Drawing.Point(127, 427);
            this.listOccup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listOccup.Name = "listOccup";
            this.listOccup.Size = new System.Drawing.Size(539, 118);
            this.listOccup.Sorted = true;
            this.listOccup.TabIndex = 8;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.Location = new System.Drawing.Point(205, 552);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(347, 59);
            this.BtnSelect.TabIndex = 9;
            this.BtnSelect.Text = "View Selected Results";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.BtnExit.AutoEllipsis = true;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnExit.Location = new System.Drawing.Point(1026, 291);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(192, 60);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnClear.Location = new System.Drawing.Point(1026, 105);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(192, 80);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clear Display";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblSouce
            // 
            this.lblSouce.AutoSize = true;
            this.lblSouce.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSouce.Location = new System.Drawing.Point(35, 10);
            this.lblSouce.Name = "lblSouce";
            this.lblSouce.Size = new System.Drawing.Size(536, 76);
            this.lblSouce.TabIndex = 12;
            this.lblSouce.Text = "Women\'s Earnings by detailed occupation\r\nReport 1083 | 11/2019";
            // 
            // FORM_WIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 740);
            this.Controls.Add(this.lblSouce);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.listOccup);
            this.Controls.Add(this.BtnDisplayAll);
            this.Controls.Add(this.txtDisplayAll);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FORM_WIT";
            this.Text = "WIT Earnings Ratio Men to Women";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtDisplayAll;
        private System.Windows.Forms.Button BtnDisplayAll;
        private System.Windows.Forms.ListBox listOccup;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label lblSouce;
    }
}

