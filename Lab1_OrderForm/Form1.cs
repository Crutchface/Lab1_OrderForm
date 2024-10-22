using System;

namespace Lab1_OrderForm
{

    public partial class frmLunchOrder : Form
    {
        decimal toppingPrice = 0m;
        decimal mainPrice = 0;
        decimal topMultiplier = 0;
        decimal hamburgerPrice = 6.95m;
        decimal pizzaPrice = 5.95m;
        decimal saladPrice = 4.95m;
        decimal tax = .050m;
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            grpAddOns.Text = "";
            mainPrice = hamburgerPrice;
            chkTopping1.Text = "Lettuce, Tomato, Onions";
            chkTopping2.Text = "Ketchup, Mustard, Mayo";
            chkTopping3.Text = "French Fries";
            toppingPrice = .75m;
            grpAddOns.Text += $"(Add On Items {toppingPrice.ToString("c")}/each)";

        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {   
            
            rdoHamburger.Checked = true;
            rdoHamburger.Text += $"({hamburgerPrice.ToString("c")})";
            rdoPizza.Text += $"({pizzaPrice.ToString("c")})";
            rdoSalad.Text += $"({saladPrice.ToString("c")})";
            lblTax.Text = $"Tax ({tax.ToString("p")})";


        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            grpAddOns.Text = "";
            mainPrice = pizzaPrice;
            chkTopping1.Text = "Pepperoni";
            chkTopping2.Text = "Sausages";
            chkTopping3.Text = "Olives";
            toppingPrice = .50m;
            grpAddOns.Text += $"(Add On Items {toppingPrice.ToString("c")}/each)";

        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            grpAddOns.Text = "";
            mainPrice = saladPrice;
            chkTopping1.Text = "Croutons";
            chkTopping2.Text = "Bacon Bits";
            chkTopping3.Text = "Bread Sticks";
            toppingPrice = .25m;
            grpAddOns.Text += $"(Add On Items {toppingPrice.ToString("c")}/each)";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if(chkTopping1.Checked)
            {
                 topMultiplier++;
            }
            if (chkTopping2.Checked)
            {
                topMultiplier++;
            }
            if (chkTopping3.Checked)
            {
                topMultiplier++;
            }
            decimal subtotal = mainPrice + (topMultiplier * toppingPrice);
            txtSubTotal.Text = subtotal.ToString("c");

            decimal taxes = subtotal * tax; 
            decimal totalTaxes = Math.Round(taxes, 2);

            txtTax.Text = totalTaxes.ToString("c");
            decimal fullPrice = subtotal + taxes;
            txtOrderTotal.Text = fullPrice.ToString("c");




        }

    }
}
