using System;
using System.Windows.Forms;

namespace WIT_Earnings
{
    public partial class WIT_MAIN : Form
    {
        public WIT_MAIN()
        {
            InitializeComponent();
        }
        private void BtnWIT_US_Click(object sender, EventArgs e)
        {
            FORM_WIT wit_All = new FORM_WIT();
            wit_All.ShowDialog();
        }
        private void BtnWIT_Lou_Click(object sender, EventArgs e)
        {
            FormWit_Lou wLou = new FormWit_Lou();
            wLou.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("GOOD BYE!"); add choice to cancel
            Close();
        }
    }
}
