using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(textBox1.Text);
            double y = Double.Parse(textBox2.Text);

            try
            {
                switch (comboBox1.SelectedIndex.ToString())
                {
                    case "0":
                        label1.Text = (x + y).ToString(); ;
                        break;
                    case "1":
                        label1.Text = (x - y).ToString();
                        break;
                    case "2":
                        label1.Text = (x * y).ToString();
                        break;
                    case "3":
                        label1.Text = (x / y).ToString();
                        break;
                }
            }
            catch (DivideByZeroException exe)
            {
                label1.Text = exe.Message;
                label1.ForeColor = Color.Red;
            }
        }
    }
}
