using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    ResultTextBox.Text += j + " ";
                }
                ResultTextBox.Text += "\n";
            }
        }
    }
}
