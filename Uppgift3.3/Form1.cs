using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int talA = int.Parse(tbxA.Text);
            int talB = int.Parse(tbxB.Text);
            int talC = int.Parse(tbxC.Text);

            int sum = talA + talB + talC;
            double medel = (double)sum / (double)3;

            lblSumma.Text = $"Summa: {sum}";
            lblMedel.Text = $"Medel: {Math.Round(medel, 2)}";
            
        }
    }
}
