using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txbox = (TextBox)sender;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string total = amount.Text;
            double totalamount = Convert.ToInt32(total);
            string tip_per = tippercentage.Text;
            float tip_percentage = Convert.ToInt32(tip_per);
            string no_people = no_of_people.Text;
            int people_number = Convert.ToInt32(no_people);
            
            double tip_per_person = (totalamount / people_number) * (tip_percentage / 100);
            double result = Math.Round(tip_per_person, 2);

            double amt_per_person = (totalamount / people_number) + tip_per_person;
            double result1 = Math.Round(amt_per_person, 2);
            tipperperson.Text = Convert.ToString(result);
            totalperperson.Text = Convert.ToString(result1);








        }
    }
}
