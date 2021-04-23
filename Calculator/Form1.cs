using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e){}
        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e){}
        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void Label7_Click_1(object sender, EventArgs e) { }
        private void Label8_Click(object sender, EventArgs e) { } 
 

        private void Button1_Click(object sender, EventArgs e)
        {
          
            double result = 0;
            double result1 = 0;
            double totalamount = 0;
            int people_number = 0;
            float tip_percentage = 0;

            //geting total Bill Amount from Textbox
            string total = amount.Text;
            if (total.Equals(""))
            {
                MessageBox.Show("Enter total Bill Amount");
            }
            else if(double.Parse(total) < 0)
            {
                MessageBox.Show("Bill Amount is less than 0");
            }
            else
            {
                /*value we get from textbox is in string format so, inorder to perform
                  arithimatic operations converting string into int/float/double */

                 totalamount = double.Parse(total);
            }  

            //Geting Tip Percentage
            string tip_per = tippercentage.Text;
            if (tip_per.Equals(""))
            {
                tip_percentage = 0;
            }
            else
            {
                tip_percentage = Convert.ToInt32(tip_per);
            }
                
          
            //Geting Number of People 
            string no_people = no_of_people.Text;
            if (Convert.ToInt32(no_people)==0)
            {
                MessageBox.Show("No. of people cannot be 0");
            }
            else
            {
                people_number = Convert.ToInt32(no_people);
            }
            

            if (totalamount >= 1 && people_number >= 1)
            {
                //Exception Handling
                try  
                {
                    //calculating total tip per person
                    double tip_per_person = (totalamount / people_number) * (tip_percentage / 100);
                    result = Math.Round(tip_per_person, 2 , MidpointRounding.ToNegativeInfinity); //Using round function to show only 2 places after decimal
                    
                    //Calculating total amount per person
                    double amt_per_person = (totalamount / people_number) + tip_per_person;
                    result1 = Math.Round(amt_per_person, 2 , MidpointRounding.ToNegativeInfinity); //Using round function to show only 2 places after decimal

                    tipperperson.Text = Convert.ToString("$ " + result);
                    totalperperson.Text = Convert.ToString("$ " + result1);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
            {
                MessageBox.Show("Missing Details");
            }
            


        }
    }
}
