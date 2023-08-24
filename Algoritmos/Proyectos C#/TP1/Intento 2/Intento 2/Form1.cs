using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intento_2
{
    public partial class CalculadoraSimple : Form
    {
        public CalculadoraSimple()
        {
            InitializeComponent();
        }

        private void Textrta_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumaButtom_Click(object sender, EventArgs e)
        {
            Textrta.Text = (Int32.Parse(Textop1.Text) + Int32.Parse(Textop2.Text)).ToString();
        }

        private void RestaButtom_Click(object sender, EventArgs e)
        {
            Textrta.Text = Convert.ToString(Convert.ToInt32(Textop1.Text) - Convert.ToInt32(Textop2.Text));
        }

        private void ProductoButtom_Click(object sender, EventArgs e)
        {
            Textrta.Text = (Int32.Parse(Textop1.Text) * Int32.Parse(Textop2.Text)).ToString();
        }

        private void CocienteButtom_Click(object sender, EventArgs e)
        {
            Textrta.Text = (Int32.Parse(Textop1.Text) / Int32.Parse(Textop2.Text)).ToString();

            float num = Int32.Parse(Textop1.Text);
            float den = Int32.Parse(Textop2.Text);
            if (den != 0)
            {
                Textrta.Text = (float.Parse(Textop1.Text) / float.Parse(Textop2.Text)).ToString();
            }

        }

        private void CleanAll_Click(object sender, EventArgs e)
        {
            Textop1.Text = "";
            Textop2.Text = "";
            Textrta.Text = "";
            this.Textop1.Focus();

        }

        private void SalirButtom_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
