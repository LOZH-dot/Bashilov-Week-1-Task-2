using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal x, y;
            x = XNumeric.Value;
            y = YNumeric.Value;

            if (x * x + y * y < 9 * 9 && x > 0)
                MessageBox.Show($"Точка ({x}, {y}) находится внутри окружности", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (x * x + y * y > 9 * 9 || x < 0)
                MessageBox.Show($"Точка ({x}, {y}) находится вне окружности", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Точка ({x}, {y}) находится на границе окружности", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
