using System;
using System.Windows.Forms;
using System.IO;

namespace WIT_Earnings
{
    public partial class FORM_WIT : Form
    {
        public FORM_WIT()
        {
            InitializeComponent();
        }
        public void formatText()
        {
            string myCat = string.Format("{0,-30 }", "Catergory");
            string myOccup = string.Format("{0,-40}", "Occupation");
            string myWorkersM = string.Format("{0, 9}", " [Men Workers|$");
            string myEarningsM = string.Format("{0, 9}", "] ");
            string myWorkersF = string.Format("{0,9}", " [Women Workers|$");
            string myEarningsF = string.Format("{0,9}", " ] ");
            string myEarningsRatio = string.Format("{0, 10}", " [Men's/Women's] ");
            string myWorkersTotal = string.Format("{0, 10}", " [Total Workers|$");
            string myWorkersEarnings = string.Format("{0, 10}", "] " + "\n");

            txtDisplayAll.Text += myCat + myOccup + myWorkersM + myEarningsM + myWorkersF + myEarningsF + myEarningsRatio + myWorkersTotal + myWorkersEarnings;
            for (int i = 0; i < 180; i++)
            {
                txtDisplayAll.Text += "-";
            }
            txtDisplayAll.Text += "\n";
        }
        private void BtnDisplayAll_Click(object sender, EventArgs e)
        {
            txtDisplayAll.Clear();
            formatText();
            string myTemp = string.Format("{0, -10}", "");

            string[] files = File.ReadAllLines("Earnings_2018_WIT.txt");
            foreach (string file in files)
            {
                string aNew = file.Replace(",", myTemp) + "\n";
                txtDisplayAll.Text += aNew;
            }
        }//end of Display All 

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            const char DELIM = ',';
            const string DELIM2 = "      ";

            Occupation job = new Occupation();
            // using class Filestream  method 
            using (FileStream fs = File.OpenRead("Earnings_2018_WIT.txt"))
            {
                StreamReader reader = new StreamReader(fs);
                string recordIn;
                string[] fields;

                // Set the stream position to the beginning of the file.
                fs.Seek(0, SeekOrigin.Begin);
                recordIn = reader.ReadLine();
                while (recordIn != "")
                {
                    // While loop to read file and break at a match
                    fields = recordIn.Split(DELIM);
                    job.Cat = fields[0];
                    job.Name = fields[1];
                    string temp = job.WNum.ToString();
                    temp = fields[2];
                    string temp2 = job.WEarn.ToString();
                    temp2 = fields[3];
                    string temp3 = job.MNum.ToString();
                    temp3 = fields[4];
                    string temp4 = job.MEarn.ToString();
                    temp4 = fields[5];
                    string temp5 = job.Percent.ToString();
                    temp5 = fields[6];
                    string temp6 = job.TotalNum.ToString();
                    temp6 = fields[7];
                    string temp7 = job.TotalEarn.ToString();
                    temp7 = fields[8];
                    try
                    {
                        txtDisplayAll.Clear();
                        formatText();
                        if (listOccup.SelectedItem.Equals(job.Name))
                        {
                            txtDisplayAll.Text += job.Cat + DELIM2 + job.Name + DELIM2 + temp + DELIM2 + temp2 + DELIM2 + temp3 + DELIM2 + temp4 + DELIM2 + temp5 + DELIM2 + temp6 + DELIM2 + temp7 + "\n";
                            break;
                        }
                        else
                        {
                            recordIn = reader.ReadLine();
                        }//else if
                    }
                    catch (Exception)
                    {
                        txtDisplayAll.Clear();
                        txtDisplayAll.Text +=  "Select an occupation || Display All || Exit";
                        break;
                    }//end TryCatchBlock
                }//end WhileLoop
            }
        }  //end of Select | Search

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplayAll.Clear();
        }//End of Clear

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("GOOD BYE!"); add choice to cancel
            Close();
        }//end of Exit
        private void Form1_Load(object sender, EventArgs e)
        { }//end of Form1 Load
    }//end of partial class
}//end of namespace
