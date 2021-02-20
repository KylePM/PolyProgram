using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (InputValidation(textBox1.Text) && InputValidation(textBox2.Text) && InputValidation(textBox3.Text) && InputValidation(textBox4.Text))
            {   double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double x = Convert.ToDouble(textBox4.Text);                
                MessageBox.Show(Convert.ToString(PolynomialCalc(a, b, c, x)));
            }
            
            
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public static bool InputValidation(string str) 
        {
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Invalid Input! Please enter a number.");
                return false;
            }
            else if (IsDigitOnly(str) == false)
            {
                MessageBox.Show("Invalid Input! Only numbers allowed.");
                return false;
            }
            else return true;

        }
        public static double PolynomialCalc(double a, double b, double c, double x) 
        {
            double result;

            result = (a * (x * x) + (b * x) + c);

            return result;      
        
        }
        public static bool IsDigitOnly(string str) 
        {
            foreach (char c in str) 
            {
                if (c < '0' || c > '9')
                    return false;            
            }
            return true;        
        }
    }
}
