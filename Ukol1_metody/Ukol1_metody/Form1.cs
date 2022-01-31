using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol1_metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Obsah(double stranaA)
        {
            if (Obsahctverce.Checked == true) { double vysledek = Math.Pow(stranaA, 2); return vysledek; }
            if(objemkrychle.Checked == true) { double vysledek = Math.Pow(stranaA, 3); return vysledek; }
            return -1;
        }
        public double Obsah(double stranaA, double stranaB)
        {
            double vysledek = stranaA*stranaB;
            return vysledek;
        }
        public double Obsah(double stranaA, double stranaB, double stranaC)
        {
            double vysledek = stranaA * stranaB*stranaC;
            return vysledek;
        }

        private void Výpočet_Click(object sender, EventArgs e)
        {
            double stranaA =Convert.ToInt32(stranaa.Text);
            double stranaB = Convert.ToInt32(stranab.Text);
            double stranaC = Convert.ToInt32(stranac.Text);
            double obsah1 = Obsah(stranaA);
            Vysledeklb.Text = Convert.ToString(obsah1);
            if (obsahobdelnika.Checked == true) { double obsah2=Obsah(stranaA, stranaB); Vysledeklb.Text = Convert.ToString(obsah2); }
            if (objemkrychle.Checked == true) { double obsah3=Obsah(stranaA, stranaB, stranaC); Vysledeklb.Text = Convert.ToString(obsah3); }

        }
    }
}
