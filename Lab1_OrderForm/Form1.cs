using System;

namespace Lab1_OrderForm
{

    public partial class frmLunchOrder : Form
    {   // Chris Ferguson - Oct 23 - RAD Assignment 1 
        // Declaring our values  
        // This instantiates our topping price until defines later 
        decimal toppingPrice = 0m;
        // Same for mains price. 
        decimal mainPrice = 0;
        // Resets our topping multiplier 
        decimal topMultiplier = 0;
        // Our  main hamburger price 
        decimal hamburgerPrice = 6.95m;
        // our main pizza price
        decimal pizzaPrice = 5.95m;
        // Our Salad price
        decimal saladPrice = 4.95m;
        // Our tax rate
        decimal tax = .050m;
        public frmLunchOrder()
        {
            InitializeComponent();
        }
        // Changes values based on hamburger radio value
        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {   
            // Sets default text to nothing
            grpAddOns.Text = "";
            // Unchecks any boxes 
            chkTopping1.Checked = false;
            chkTopping2.Checked = false;
            chkTopping3.Checked = false;
            // Changes the main course price to that of a hamburger 
            mainPrice = hamburgerPrice;
            // Labels the 3 toppings 
            chkTopping1.Text = "Lettuce, Tomato, Onions";
            chkTopping2.Text = "Ketchup, Mustard, Mayo";
            chkTopping3.Text = "French Fries";
            // Changes the prices for each topping
            toppingPrice = .75m;
            // Changes the text for the price of the toppings and sends the price to the group box
            grpAddOns.Text += $"(Add On Items {toppingPrice.ToString("c")}/each)";

        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            //Sets the default texts for the program loading and default checkbox
            rdoHamburger.Checked = true;
            rdoHamburger.Text += $"({hamburgerPrice.ToString("c")})";
            rdoPizza.Text += $"({pizzaPrice.ToString("c")})";
            rdoSalad.Text += $"({saladPrice.ToString("c")})";
            lblTax.Text = $"Tax ({tax.ToString("p")})";


        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {   // CHanges values based on changing choice to pizza 
            grpAddOns.Text = "";
            // Unchecks any boxes 
            chkTopping1.Checked = false;
            chkTopping2.Checked = false;
            chkTopping3.Checked = false;
            // Sets the main course price to that of pizza
            mainPrice = pizzaPrice;
            // Changes the names of the toppings
            chkTopping1.Text = "Pepperoni";
            chkTopping2.Text = "Sausages";
            chkTopping3.Text = "Olives";
            // Changes the price of all toppings 
            toppingPrice = .50m;
            // Changes text for topping price and changes price for topping group box price
            grpAddOns.Text += $"(Add On Items {toppingPrice.ToString("c")}/each)";

        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {   // Changes based on salad selection 
            grpAddOns.Text = "";
            // Unchecks any boxes 
            chkTopping1.Checked = false;
            chkTopping2.Checked = false;
            chkTopping3.Checked = false;
            // sets main price to that of a salad 
            mainPrice = saladPrice;
            // Changes text of toppings 
            chkTopping1.Text = "Croutons";
            chkTopping2.Text = "Bacon Bits";
            chkTopping3.Text = "Bread Sticks";
            // Changes values of toppings 
            toppingPrice = .25m;
            // Changes text of addons and sends the price to the group box 
            grpAddOns.Text += $"(Add On Items {toppingPrice.ToString("c")}/each)";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the window on the button click
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // checks how many toppings are checked and increments a multiplier 
            if (chkTopping1.Checked)
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
            // Does the math of the subtotal based on main price , topping price and how many are checked 
            decimal subtotal = mainPrice + (topMultiplier * toppingPrice);
            // Changes textbox for subtotal and makes it in currency format 
            txtSubTotal.Text = subtotal.ToString("c");
            // Calculates the taxes and rounds to 2 decimals 
            decimal taxes = subtotal * tax;
            decimal totalTaxes = Math.Round(taxes, 2);
            // changes textbox for tax to tax value
            txtTax.Text = totalTaxes.ToString("c");
            // Does the math for the total price and places the value in the text box. 
            decimal fullPrice = subtotal + taxes;
            txtOrderTotal.Text = fullPrice.ToString("c");




        }

        private void btnClear_Click(object sender, EventArgs e)
        {   
            // Resets all forms and multiplier for toppings 
            rdoHamburger.Checked = true;
            chkTopping1.Checked = false;
            chkTopping2.Checked = false;
            chkTopping3.Checked = false;
            txtOrderTotal.Clear();
            txtTax.Clear();
            txtSubTotal.Clear();
            // Resets multiplier for toppings 
            topMultiplier = 0;

        }
    }
}
