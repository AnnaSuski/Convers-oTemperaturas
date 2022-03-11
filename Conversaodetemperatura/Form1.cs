using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversaodetemperatura
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if(rbFromC.Checked && rbToK.Checked)
            {
                double c = Double.Parse(txtTemperatura.Text);
                double k = c + 273.15;
                lbResposta.Text = k.ToString("N2") + " Kelvin";
            }   
            if(rbFromK.Checked && rbToC.Checked)
            {
                double k = Double.Parse(txtTemperatura.Text);
                double c = k - 273.15;
                lbResposta.Text = c.ToString("N2") + " Celsius";
            }
            if (rbFromC.Checked && rbToF.Checked)
            {
                double c = Double.Parse(txtTemperatura.Text);
                double f = c * 1.8 + 32;
                lbResposta.Text = f.ToString("N2") + " Fahrenheit";
            }
            if (rbFromF.Checked && rbToC.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double c =  f / 1.8 - 32;
                lbResposta.Text = c.ToString("N2") +  " Celsius";
            }
            if (rbFromF.Checked && rbToK.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double k = f - 32 / 1.8 + 273.15 ;
                lbResposta.Text = k.ToString("N2") + " Kelvin";
            }
            if (rbFromK.Checked && rbToF.Checked)
            {
                double k = Double.Parse(txtTemperatura.Text);
                double f = 1.8 * (k - 273.15) + 32 ;
                lbResposta.Text = f.ToString("N2") + " Fahrenheit";   
            }
            if (rbFromC.Checked && rbToC.Checked || rbFromK.Checked && rbToK.Checked || rbFromF.Checked && rbToF.Checked )
            {
               lbResposta.Text = "Conversão inválida";
            }         
        }
    }
}