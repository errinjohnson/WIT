using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.SqlServer.Server;

namespace WIT_Earnings
{
    public partial class FormWit_Lou : Form
    {
        public FormWit_Lou()
        {
            InitializeComponent();
        }
        private void BtnDisplay2_Click(object sender, EventArgs e)
        {
            //24 spaces occup, 20 and 5 spaces total,
            string myOccup = string.Format("{0,-65}", "Occupation");
            string myTotal = string.Format("{0,-15}","Total");
            string myNMale = string.Format("{0,10}", "[Males | ");
            string myPMale = string.Format("{0,-20}", "Percentage]");
            string myFemale = string.Format("{0,10}", "[Females | ");
            string myPFemale = string.Format("{0,10}", "Percentage]");
            txtDisplayAll2.Clear();
            txtDisplayAll2.Text += myOccup + myTotal + myNMale + myPMale + myFemale + myPFemale + "\n";
            for (int i = 0; i < 150; i++)
            {
                txtDisplayAll2.Text += "-";
            }
            string myTemp = string.Format("{0,10}", "");
            txtDisplayAll2.Text += "\n";
            string[] files = File.ReadAllLines("Lou2018WIT.txt");
            foreach (string file in files)
            {
                string aNew = file.Replace(",", myTemp) + "\n";
                txtDisplayAll2.Text += aNew;
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("GOOD BYE!"); add choice to cancel
            Close();
        }
    }
}
