using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Assignment_4
{
    public partial class Form1 : Form
    {
        decimal principal;
        decimal finalBalance;
        const decimal RATE_1 = 0.50000m;
        const decimal RATE_3 = 0.62500m;
        const decimal RATE_6 = 0.71250m;
        const decimal RATE_12 = 1.12500m;
        const decimal RATE2_1 = 0.60000m;
        const decimal RATE2_3 = 0.72500m;
        const decimal RATE2_6 = 0.81250m;
        const decimal RATE2_12 = 1.22500m;
        const decimal BONUS = 5000m;
        const int LINES_PER_RECORD = 7;
        int month1 = 1,month3 = 3, month6 = 6, month12 = 12;
        
        decimal totalinterest;
        decimal int_rate;
        decimal balance;
        int month;      

        string searchstring;
        string formatedstring;

        int listOfTrans;
        decimal totalinvestment;
        decimal totalPrincipal;
        decimal averageOverallMonths;

        string tn;
        string tnlist;

        int countTN =1;
        int countListTN;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //customerInfoGroupBox2.Visible = false;
            summaryGroupBox3.Visible = false;
        }

         private decimal  calFinalBal(int month, decimal int_rate, decimal principal)
         {
          int counter = 1;
          while (counter <= month)
           {

               principal = principal + (principal * ((int_rate/100))/12);
             counter +=1;
           }
          return principal;         
          }

        

        private void displayButton_Click(object sender, EventArgs e)
        {
            
            

            if (!decimal.TryParse(textBox1.Text, out principal))
            {
                MessageBox.Show("Please enter the valid input");
            }
            else if (principal < 100000m)
            {

                monthRadio1.Text = "Month 1: " + " Month Intrest :" + RATE_1 + ", Balance: " + calFinalBal(month1, RATE_1, principal).ToString("C");
                monthRadio3.Text = "Month 3: " + " Month Intrest :" + RATE_3 + ", Balance: " + calFinalBal(month3, RATE_3, principal).ToString("C");
                monthRadio6.Text = "Month 6: " + " Month Intrest :" + RATE_6 + ", Balance: " + calFinalBal(month6, RATE_6, principal).ToString("C");
                monthRadio12.Text = "Month 12: " + " Month Intrest :" + RATE_12 + ", Balance: " + calFinalBal(month12, RATE_12, principal).ToString("C");
                


                /*  monthlyintrest1 = (principal * (RATE_1 / 100)) / 12;
                 totalinterest1 += monthlyintrest1;
                 balance = principal + totalinterest1;
                 monthRadio1.Text = "Month 1 :  " + RATE_1.ToString("P") + "Month Intrest" + monthlyintrest1 + "Total Intrest" + totalinterest1.ToString() + "Balance" + balance;

                */
               
}
            else if (principal > 100000m)
            {
                monthRadio1.Text = "Month 1: " + " Month Intrest: " + RATE2_1 + ", Balance: " + calFinalBal(month1, RATE2_1, principal).ToString("C2");
                monthRadio3.Text = "Month 3 :" + " Month Intrest :" + RATE2_3 + ", Balance: " + calFinalBal(month3, RATE2_3, principal).ToString("C2");
                if (principal > 100000m && (principal < 1000000m))
                {
                    monthRadio6.Text = "Month 6 :" + " Month Intrest :" + RATE2_6 + ", Balance: " + calFinalBal(month6, RATE2_6, principal).ToString("C2");
                    monthRadio12.Text = "Month 12 :" + " Month Intrest :" + RATE2_12 + ", Balance: " + calFinalBal(month12, RATE2_12, principal).ToString("C2");
                }
                else if (principal >= 1000000m)
                {
                    monthRadio6.Text = "Month 6 :" + " Month Intrest :" + RATE2_6 + ", Balance: " + (calFinalBal(month6, RATE2_6, principal) + 5000).ToString("C2");
                    monthRadio12.Text = "Month 12 :" + " Month Intrest :" + RATE2_12 + ", Balance: " + (calFinalBal(month12, RATE2_12, principal) + 5000).ToString("C2");
                    MessageBox.Show("Congratulations! You got bonus of 5000");
                }



              //  totalPrincipal += principal;
            }
        }
      
        public decimal finalAmount()

        {
            //decimal finalBalance;
            if (principal < 100000m)
            {
                if (monthRadio1.Checked) 
                {
                     finalBalance = calFinalBal(1, RATE_1, principal); month = 1 ;int_rate = RATE_1;
                     //month = 1;
                    // int_rate = RATE_1;

                }
                if (monthRadio3.Checked)
                {
                    finalBalance = calFinalBal(3, RATE_3, principal); month = 3; int_rate = RATE_3;
                     
                     
                }
                if (monthRadio6.Checked)
                {
                     finalBalance = calFinalBal(6, RATE_6, principal);
                     month = 6;
                     int_rate = RATE_6;

                }
                if (monthRadio12.Checked)
                {
                     finalBalance = calFinalBal(12, RATE_12, principal);
                     month = 12;
                     int_rate = RATE_12;
                }
            }
            else if (principal > 100000m)
            {
                if (monthRadio1.Checked) 
                {
                     finalBalance = calFinalBal(1, RATE2_1, principal);
                     month = 1;
                     int_rate = RATE2_1;
                }
               if (monthRadio3.Checked)
                {
                     finalBalance = calFinalBal(3, RATE2_3, principal);
                     month = 3;
                     int_rate = RATE2_3;

                }
                if (monthRadio6.Checked)
                {
                     finalBalance = calFinalBal(6, RATE2_6, principal);
                     month = 6;
                     int_rate = RATE2_6;

                }
                if (monthRadio12.Checked)
                {
                     finalBalance = calFinalBal(12, RATE2_12, principal);
                     month = 12;
                     int_rate = RATE2_12;
                }
            }
            return finalBalance;
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            //int tn;

            
            //customerInfoGroupBox2.Visible = true;

            try
            {
                if (monthRadio1.Checked == false && monthRadio3.Checked == false && monthRadio6.Checked == false && monthRadio12.Checked == false)
                {
                    MessageBox.Show("Please select the Plan");
                }

                else if (monthRadio1.Checked == true || monthRadio3.Checked == true || monthRadio6.Checked == true || monthRadio12.Checked == true)
                {
                    decimal totalinvestment = finalAmount();
                    finBalTextBox.Text = totalinvestment.ToString();
                    monthTextBox.Text = month.ToString();
                    intRateTextBox.Text = int_rate.ToString();
                    investedTextBox.Text = principal.ToString();
                    //
                    confirmTabPage2.Visible = true;
                    investTabPage1.Visible = false;
                    tabControl1.Visible = true;

                    totalPrincipal += principal;

                }                
            }
            catch { }
            //tn = transNumberTextBox.Text
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!this.emailTextBox.Text.Contains('@') || !this.emailTextBox.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tn = (transNumberTextBox.Text + cIdTextBox.Text + uIdTextBox.Text).ToString();
                string confirm = ("Transaction Number: " + tn + "\n" +
                    " First Name: " + firstNameTextBox.Text + "\n" +
                    "LastName: " + lastNameTextBox.Text + "\n" +
                    "Telephone Number:" + teleNoTextBox.Text + "\n" +
                    "Email:" + emailTextBox.Text + "\n" +
                    "Final Balance:" + finBalTextBox.Text + "\n" +
                    "Month:" + monthTextBox.Text + "\n" +
                    "Interest rate:" + intRateTextBox.Text + "\n") + "\n" ;

                //MessageBox.Show((confirm), "Confirmation", MessageBoxButtons.YesNo);
                DialogResult result = MessageBox.Show((confirm), "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        StreamWriter outputFile;                        
                        outputFile = File.AppendText("details3.txt");
                        outputFile.WriteLine(tn);
                        outputFile.WriteLine(emailTextBox.Text);
                        outputFile.WriteLine(firstNameTextBox.Text);
                        outputFile.WriteLine(teleNoTextBox.Text);
                        outputFile.WriteLine(finBalTextBox.Text);
                        outputFile.WriteLine(intRateTextBox.Text);
                        outputFile.WriteLine(monthTextBox.Text);
                        //termn
                        //outputFile.NewLine;
                        outputFile.Close();
                        //listOfTrans += 1;
                        //totalinvestment += totalinvestment;
                        //summary();
                        //tnlist += tn;
                        countTN += 1;

                    }
                    catch
                    {
                     
                    }
                    //countTN += 1;
                }
                else if (result == DialogResult.No)
                {
                    transNumberTextBox.Text = "";
                    cIdTextBox.Text = "";
                    uIdTextBox.Text = "";
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    teleNoTextBox.Text = "";
                    emailTextBox.Text = "";
                    monthTextBox.Text = "";
                    intRateTextBox.Text = "";
                    finBalTextBox.Text = "";
                    investTabPage1.Visible = true;

                    textBox1.Text = "";
                    monthRadio1.Text = "1 month";
                    monthRadio3.Text = "3 months";
                    monthRadio6.Text = "6 months";
                    monthRadio12.Text = "12 months";
                    monthRadio1.Checked = false;
                    monthRadio3.Checked = false;
                    monthRadio6.Checked = false;
                    monthRadio12.Checked = false;
                }

               
            }

            //email
            


         }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string tempstring ="";
            searchstring = searchTextBox.Text;
            string formatstring = "";
            bool found = false;
            StreamReader sr = new StreamReader("details3.txt");

            try
            {
                while (!sr.EndOfStream && !found)
                {
                    tempstring = sr.ReadLine();
                    //if (String.IsNullOrEmpty(tempstring)) continue;
                    //if (tempstring.IndexOf(searchstring, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    if (tempstring.Contains(searchstring))
                    {
                        found = true;
                        formatstring += tempstring + "\n";
                        for (int i = 0; i < LINES_PER_RECORD -1; i++)
                        {
                            formatstring += sr.ReadLine() + "\n";
                           
                        }

                    }
                    else {
                        for (int i = 0; i < LINES_PER_RECORD -1; i++)
                        {
                            tempstring += sr.ReadLine();
                        }
                    }
                    
                    /*else
                    {
                        MessageBox.Show("No match found,Please type the correct transactiojn number");
                    }*/
                }
                if (found)
                    MessageBox.Show(formatstring.ToString());
                else
                    MessageBox.Show("Not found..");
            }
            catch
            {

            }                   
             /* try
                 {
                     string currentLine = "";
                     StreamReader sr = new StreamReader("details.txt");
                     while (sr.Peek() >= 0)
                     {
                         string transactionNameMatch = "";
                         int transactionMatchValue = 0;
                         currentLine = sr.ReadLine();
                         //get substring of Transansaction part or line
                         transactionNameMatch = currentLine.Substring(currentLine.IndexOf(":"), currentLine.IndexOf(",")).Trim();
                         transactionMatchValue = int.Parse(transactionNameMatch);
                         //if match return line in display form... Still to do
                         if (int.Parse(searchstring) == transactionMatchValue)
                         {
                             MessageBox.Show(currentLine);
                         }


                     }
                 }*/
            
            
        
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //string searchstring;
            


        }

        private void clearButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            monthRadio1.Text = "1 month";
            monthRadio3.Text = "3 months";
            monthRadio6.Text = "6 months";
            monthRadio12.Text = "12 months";
            monthRadio1.Checked = false;
            monthRadio3.Checked = false;
            monthRadio6.Checked = false;
            monthRadio12.Checked = false;
        }
       /* private void summary()
        {
            listOfTrans += 1;
            totalinvestment += totalinvestment;
        }*/

        private void summaryButton2_Click(object sender, EventArgs e)
        {

            summaryGroupBox3.Visible = true;
            //string tnlist = "";
            //tnlist += tn;
            const int TOTAL = 3, INTEREST = 4,TERMS = 5;
            string tempstring = "";
            searchstring = searchTextBox.Text;
            //string formatstring = "";
            decimal tot, overAllTotal = 0, overallInterest = 0;
            bool found = false;
            decimal months, overallMonths = 0;
            StreamReader sr = new StreamReader("details3.txt");
            listBox1.Items.Clear();
            
            
            try
            {
                while (!sr.EndOfStream )
                {
                    tempstring = sr.ReadLine(); //+ "\n";
                    listBox1.Items.Add(tempstring);
                   // richTextBox1.It .AppendText(tempstring);
                    //if (String.IsNullOrEmpty(tempstring)) continue;
                    //if (tempstring.IndexOf(searchstring, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    //richTextBox1.AppendText(tn.ToString() + "\n");
                    
                        //formatstring += tempstring + "\n";
                        for (int i = 0; i < LINES_PER_RECORD - 1; i++)
                        {
                            tempstring = sr.ReadLine();
                            if ((i == TOTAL) && (decimal.TryParse(tempstring, out tot)))
                            {
                                overAllTotal += tot; 
                            }
                            /*else if ((i == INTEREST) && (decimal.TryParse(tempstring, out tot)))
                            {
                               overallInterest += tot;
                                //overallInterest += (overAllTotal - totalPrincipal);
                            }*/
                            else if ((i == TERMS) && (decimal.TryParse(tempstring, out months)))
                            {

                                overallMonths += months ;
                                
                            }
                           // formatstring += sr.ReadLine() + "\n";
                            
                        }

                    }

                
                
            }
            catch
            {

            }
           // richTextBox1.AppendText(tempstring);
             countListTN = listBox1.Items.Count;

            averageOverallMonths = overallMonths / countListTN;
            decimal totalIntrestSub = overAllTotal - totalPrincipal;

            //overallInterest = 
                
            //totalinvestment += totalinvestment;
            totalAmountInvestedtextBox.Text = overAllTotal.ToString("C");
            totalIntrestTextBox4.Text = totalIntrestSub.ToString();
            averageTermTextBox5.Text = averageOverallMonths.ToString();
        }

        private void transNumberTextBox_TextChanged(object sender, EventArgs e)
        {
           // transNumberTextBox.maxlength = 10;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*System.Guid guid = System.Guid.NewGuid();
            String id = guid.ToString();
            uIdTextBox.Text = id;*/

            //string.Format("{0:0000}");
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void emailSearchButton_Click(object sender, EventArgs e)
        {
             string tempstring1 = "", tempstring2 = "";
            searchstring = emailSearchTextBox.Text;
            string formatstring = "";
            bool found = false;
            StreamReader sr = new StreamReader("details3.txt");

            try
            {
                while (!sr.EndOfStream)
                {
                    tempstring1 = sr.ReadLine();
                    tempstring2 = sr.ReadLine();
                    
                    if (tempstring2.Contains(searchstring))
                    {
                        found = true;
                        formatstring += tempstring1 + "\n" + tempstring2 + "\n";
                        for (int i = 0; i < LINES_PER_RECORD - 2; i++)
                        {
                            formatstring += sr.ReadLine() + "\n";

                        }
                        formatstring += "\n";
                    }
                    else
                    {
                        for (int i = 0; i < LINES_PER_RECORD - 2; i++)
                        {
                            tempstring2 += sr.ReadLine();
                        }
                    }

                }
                if (found)
                    MessageBox.Show(formatstring.ToString());
                else
                    MessageBox.Show("Not found..");
            }
            catch
            {

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            transNumberTextBox.Text = "";
            cIdTextBox.Text = "";
            uIdTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            teleNoTextBox.Text = "";
            emailTextBox.Text = "";
            monthTextBox.Text = "";
            intRateTextBox.Text = "";
            finBalTextBox.Text = "";

            textBox1.Text = "";
            monthRadio1.Text = "1 month";
            monthRadio3.Text = "3 months";
            monthRadio6.Text = "6 months";
            monthRadio12.Text = "12 months";
            monthRadio1.Checked = false;
            monthRadio3.Checked = false;
            monthRadio6.Checked = false;
            monthRadio12.Checked = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            transNumberTextBox.Text = "";
            cIdTextBox.Text = "";
            uIdTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            teleNoTextBox.Text = "";
            emailTextBox.Text = "";
            monthTextBox.Text = "";
            intRateTextBox.Text = "";
            finBalTextBox.Text = "";
            investTabPage1.Visible = true;
            confirmTabPage2.Visible = true;
        }

        private void summaryTabPage3_Click(object sender, EventArgs e)
        {
            //summaryGroupBox3.Visible = false;
        }

        private void summaryClearButton_Click(object sender, EventArgs e)
        {
            totalAmountInvestedtextBox.Text = "";
            totalIntrestTextBox4.Text = "";
            averageTermTextBox5.Text = "";
            listBox1.Items.Clear();
            
        }

        }
    }

