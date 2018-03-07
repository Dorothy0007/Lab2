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
            try
            {

                double x = Double.Parse(textBox1.Text);
                double y = Double.Parse(textBox2.Text);
                label1.ForeColor = Color.Black;

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
                        if (y == 0)
                        {
                            label1.Text = "GREŠKA!";
                            label1.ForeColor = Color.Red;
                        }
                        else label1.Text = (x / y).ToString();
                        break;

                }
            }
            catch (Exception exe)
            {
                label1.Text = exe.Message;
            }
            label1.Visible = true;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rez = textBox1.Text + " " + comboBox1.Text + " " + textBox2.Text + " " + "=" + " " + label1.Text;
            Form2 form2 = new Form2(rez);
            form2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
