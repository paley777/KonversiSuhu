using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonversiSuhu
{
    public partial class Form1 : Form
    {
        Double Cel, Fah, Rea, Kel;

        private void fromfah_Click(object sender, EventArgs e)
        {
            Fah = Convert.ToDouble(textFahrenheit.Text);
            Fah = Fah;
            Cel = ((Fah - 32) * 5) / 9; // To Celcius
            Rea = ((Fah - 32) * 4) / 9; // To Reamur
            Kel = ((Fah - 32) * 5) / 9 + 273; // To Kelvin
            textCelcius.Text = Convert.ToString(Cel);
            textReamur.Text = Convert.ToString(Rea);
            textKelvin.Text = Convert.ToString(Kel);
        }

        private void fromkel_Click(object sender, EventArgs e)
        {
            Kel = Convert.ToDouble(textKelvin.Text);
            Kel = Kel;
            Cel = Kel - 273; // To Celcius
            Rea = ((Kel - 273) * 4) / 5; // To Reamur
            Fah = (((Kel - 273) * 9) / 5) + 32; // To Fahrenheit
            textCelcius.Text = Convert.ToString(Cel);
            textFahrenheit.Text = Convert.ToString(Fah);
            textReamur.Text = Convert.ToString(Rea);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textCelcius.Text = "0";
            textCelcius.Text = Convert.ToString(0);
            textReamur.Text = "0";
            textReamur.Text = Convert.ToString(0);
            textFahrenheit.Text = "0";
            textFahrenheit.Text = Convert.ToString(0);
            textKelvin.Text = "0";
            textKelvin.Text = Convert.ToString(0);
        }

        private void fromream_Click(object sender, EventArgs e)
        {
            Rea = Convert.ToDouble(textReamur.Text);
            Rea = Rea;
            Cel = (Rea * 5) / 4; // To Celcius
            Fah = ((Rea * 9) / 4) + 32; // To Fahrenheit
            Kel = ((Rea * 5) / 4) + 273; // To Kelvin
            textCelcius.Text = Convert.ToString(Cel);
            textFahrenheit.Text = Convert.ToString(Fah);
            textKelvin.Text = Convert.ToString(Kel);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void fromcel_Click(object sender, EventArgs e)
        {
            Cel = Convert.ToDouble(textCelcius.Text);
            Cel = Cel;
            Rea = (Cel * 4) / 5; // to Reamur
            Fah = (Cel * 9 / 5) + 32; // to Fahrenheit
            Kel = Cel + 273; // To Kelvin
            textReamur.Text = Convert.ToString(Rea);
            textFahrenheit.Text = Convert.ToString(Fah);
            textKelvin.Text = Convert.ToString(Kel);
        }

    }
}
