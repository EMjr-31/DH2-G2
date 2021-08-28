using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH2_G2
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
            ///Condisiones iniciales
            lbDescripcion.Visible = false;
            lbDato1.Visible = false;
            lbDato2.Visible = false;
        }

        private void Calculos_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnTemperatura_CheckedChanged(object sender, EventArgs e)
        {
            lbDescripcion.Text = "Conversion de celcius a farenheit";
            lbDescripcion.Visible = true;
            lbDato1.Text = "°C";
            lbDato1.Visible = true;
            lbDato2.Text = "°F";
            lbDato2.Visible = true;
        }

        private void rbtnLongitud_CheckedChanged(object sender, EventArgs e)
        {
            lbDescripcion.Text = "Conversion de metros a pies";
            lbDescripcion.Visible = true;
            lbDato1.Text = "m";
            lbDato1.Visible = true;
            lbDato2.Text = "pies";
            lbDato2.Visible = true;
        }

        private void rbtnMasa_CheckedChanged(object sender, EventArgs e)
        {
            lbDescripcion.Text = "Conversion de kilogramos a libras";
            lbDescripcion.Visible = true;
            lbDato1.Text = "kg";
            lbDato1.Visible = true;
            lbDato2.Text = "lb";
            lbDato2.Visible = true;

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (rbtnTemperatura.Checked == true)
            {
                //Varibales
                double celsius = Convert.ToDouble(txtDato1.Text);
                double faren;
                //Calculo
                faren = (celsius * (9 / 5)) + 32;
                txtDato2.Text = faren.ToString();
            }
            if (rbtnLongitud.Checked == true)
            {
                //Varibales
                double metros = Convert.ToDouble(txtDato1.Text);
                double pies;
                //Calculo
                pies = metros * 3.281;
                txtDato2.Text = pies.ToString();
            }
            if (rbtnMasa.Checked == true)
            {
                //Varibales
                double kilo = Convert.ToDouble(txtDato1.Text);
                double libras;
                //Calculo
                libras = kilo * 2.205;
                txtDato2.Text = libras.ToString();
            }
        }
    }
}
