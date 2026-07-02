using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_restaurant
{
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails()
        {
            InitializeComponent();
        }


        float GetSelectedSizePrice()
        {
            if(rbSmall.Checked)
            
                return Convert.ToSingle(rbSmall.Tag);

            else if(rbMedium.Checked)
            
                return Convert.ToSingle(rbMedium.Tag);

             else

                return Convert.ToSingle(rbLarge.Tag);
        }

        float GetSelectedCrustPrice()
        {
            if(rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else
                return Convert.ToSingle(rbThick.Tag);
        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;
            

            if(chkExtraChees.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);

            if(chkOnion.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);

           if(chkMushrooms.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);

            if(chkOlives.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);

            if(chkTomatoes.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);

            if(chkGreenPeppers.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);

            return ToppingsTotalPrice;
        }

        void UpdateTotalPrice()
        {
            txtPrice.Text="$"+ CalculateTotalPrice().ToString();
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
            {
                txtCrustType.Text = "Thin";
                return;
            }

            if (rbThick.Checked)
            {
                txtCrustType.Text = "Thick";
                return;
            }
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                txtSize.Text = "Small";
            }
            else if (rbMedium.Checked)
            {
                txtSize.Text = "Medium";
            }
            else if (rbLarge.Checked)
            {
                txtSize.Text = "Large";
            }
        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            txtTopping.Text = sToppings;


        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                txtPlace.Text = "Eat In";
                return;
            }

            if (rbTakeAway.Checked)
            {
                txtPlace.Text = "Take Away";
                return;
            }
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice();
        }

        void ResetForm()
        {

            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rbThin.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrderPizza.Enabled = true;

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }


        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

     
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Order Confirm", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Confirmed", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ResetForm();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }
    }
}