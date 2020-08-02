using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaOrdering
{
    public partial class SelsCafeteria : Form
    {
        public SelsCafeteria()
        {
            InitializeComponent();
        }

        double soup, salad, chicken, lasagna, steak, soda, water, juice;


        double appetizer, main, drink, subtotal, tax, total;

        private void RdoMain3_CheckedChanged(object sender, EventArgs e)
        {
            TxtMain.Text = steak.ToString("c");
            main = steak;
        }

        private void RdoDrink2_CheckedChanged(object sender, EventArgs e)
        {
            TxtDrink.Text = water.ToString("c");
            drink = water;
        }

        private void RdoDrink3_CheckedChanged(object sender, EventArgs e)
        {
            TxtDrink.Text = juice.ToString("c");
            drink = juice;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            subtotal = appetizer + main + drink;
            tax = subtotal * .13;
            total = subtotal + tax;

            TxtSubtotal.Text = subtotal.ToString("c");
            TxtTax.Text = tax.ToString("c");
            TxtTotal.Text = total.ToString("c");
        }

        private void RdoMain2_CheckedChanged(object sender, EventArgs e)
        {
            TxtMain.Text = lasagna.ToString("c");
            main = lasagna;
        }

        private void RdoMain1_CheckedChanged(object sender, EventArgs e)
        {
            TxtMain.Text = chicken.ToString("c");
            main = chicken;
        }

        private void RdoApp2_CheckedChanged(object sender, EventArgs e)
        {
            TxtAppetizer.Text = salad.ToString("c");
            appetizer = salad;
        }

        private void RdoApp1_CheckedChanged(object sender, EventArgs e)
        {
            TxtAppetizer.Text = soup.ToString("c");
            appetizer = soup;
        }

        private void TxtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDrink_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAppetizer_Load(object sender, EventArgs e)
        {
            soup = 2.00;
            salad = 2.50;
            chicken = 10.50;
            lasagna = 11.75;
            steak = 15.00;
            soda = 1.25;
            water = 1.00;
            juice = 1.30;

            appetizer = 0;
            main = 0;
            drink = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            RdoApp1.Checked = false;
            RdoApp2.Checked = false;
            RdoMain1.Checked = false;
            RdoMain2.Checked = false;
            RdoMain3.Checked = false;
            RdoDrink1.Checked = false;
            RdoDrink2.Checked = false;
            RdoDrink3.Checked = false;

            TxtAppetizer.Text = "";
            TxtMain.Text = "";
            TxtDrink.Text = "";
            TxtSubtotal.Text = "";
            TxtTax.Text = "";
            TxtTotal.Text = "";

            appetizer = 0;
            main = 0;
            drink = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
        }
        private void RdoDrink1_CheckedChanged(object sender, EventArgs e)
        {
            TxtDrink.Text = soda.ToString("c");
            drink = soda;
        }

        private void TxtAppetizer_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
