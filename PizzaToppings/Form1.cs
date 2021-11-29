using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaToppings
{
    public partial class Form1 : Form
    {
        float pizzaPrice;
        float totalPrice;
        public Form1()
        {
            InitializeComponent();
            pizzaPrice = 0f;
            totalPrice = 0f;
        }

        private void PizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked)
            {
                pizzaPrice = 10;
            }
            else if (rdoMediumSize.Checked)
            {
                pizzaPrice = 15;
            }
            else
            {
                pizzaPrice = 20;
            }

            
            totalPrice = pizzaPrice;
            if (cbMushroom.Checked)
            {
                totalPrice += 2;
            }
            if (cbBlackOlive.Checked)
            {
                totalPrice += 3;
            }
            if (cbPepperoni.Checked)
            {
                totalPrice += 5;
            }
            CalulatePizzaCost(totalPrice);
        }

        private void CalulatePizzaCost(float total)
        {
            if (rdoSmallSize.Checked || rdoMediumSize.Checked || rdoLargeSize.Checked)
            {
                txtTotal.Text = String.Format("{0:C}", total);
            }
        }
    }
}