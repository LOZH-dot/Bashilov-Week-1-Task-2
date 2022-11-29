using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();

            if (ForRadioButton.Checked)
            {
                for (int i = 60; i >= 10; i -= 2)
                {
                    ResultTextBox.Text += $"{i}\n";
                }
            }

            if (WhileRadioButton.Checked)
            {
                int number = 60;
                while (number >= 10)
                {
                    ResultTextBox.Text += $"{number}\n";
                    number -= 2;
                }
            }

            if (doWhileRadioButton.Checked)
            {
                int number = 60;
                do
                {
                    ResultTextBox.Text += $"{number}\n";
                    number -= 2;
                } while (number >= 10);
            }
        }
    }
}
