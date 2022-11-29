using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MonthNumeric_ValueChanged(object sender, EventArgs e)
        {
            ResultTextBox.Text = (12 - (int)MonthNumeric.Value).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultTextBox.Text = (12 - (int)MonthNumeric.Value).ToString();
        }
    }
}
