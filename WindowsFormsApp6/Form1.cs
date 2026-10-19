using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(textBox1.Text);
                int B = Convert.ToInt32(textBox2.Text);

                int sum = 0;

                for (int i = A; i <= B; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }

                textBox3.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Помилка введення даних!");
            }
        }
    }
}
