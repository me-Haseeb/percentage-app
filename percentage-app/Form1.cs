using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace percentage_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int obtmarks = int.Parse(textBox1.Text);
            int totalmarks = int.Parse(textBox2.Text);

            double result = (double)obtmarks / totalmarks * 100;

            string grade;
            if (result >= 90)
                grade = "A";
            else if (result >= 80)
                grade = "B";
            else if (result >= 70)
                grade = "C";
            else if (result >= 60)
                grade = "D";
            else if (result >= 50)
                grade = "E";
            else
                grade = "F";
            { MessageBox.Show("The percentage is " + result.ToString("F2") +""+ grade.ToString()+ "%" ,  "Calculate Result", MessageBoxButtons.OK);}

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
