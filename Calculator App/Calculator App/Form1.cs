using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void button_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(outputBox1.Text);
                double num2 = Convert.ToDouble(outputBox2.Text);
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                labelResult.Text = $"Result:{(num1 / num2)}";
            }
            catch (FormatException)
            {
                labelResult.Text = "error: Please enter valid number calculation.";
            }
            catch (DivideByZeroException)
            {
                labelResult.Text = "error: Please enter valid number calculation.";
            }
        }
    }
}
