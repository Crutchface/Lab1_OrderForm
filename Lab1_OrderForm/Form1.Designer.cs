namespace Lab1_OrderForm
{
    partial class frmLunchOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpMainOrder = new GroupBox();
            rdoSalad = new RadioButton();
            rdoPizza = new RadioButton();
            rdoHamburger = new RadioButton();
            grpAddOns = new GroupBox();
            chkTopping3 = new CheckBox();
            chkTopping2 = new CheckBox();
            chkTopping1 = new CheckBox();
            grpTotal = new GroupBox();
            txtOrderTotal = new TextBox();
            txtTax = new TextBox();
            txtSubTotal = new TextBox();
            lblOrderTotal = new Label();
            lblTax = new Label();
            lblSubTotal = new Label();
            btnPlaceOrder = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpMainOrder.SuspendLayout();
            grpAddOns.SuspendLayout();
            grpTotal.SuspendLayout();
            SuspendLayout();
            // 
            // grpMainOrder
            // 
            grpMainOrder.Controls.Add(rdoSalad);
            grpMainOrder.Controls.Add(rdoPizza);
            grpMainOrder.Controls.Add(rdoHamburger);
            grpMainOrder.Location = new Point(52, 40);
            grpMainOrder.Name = "grpMainOrder";
            grpMainOrder.Size = new Size(308, 159);
            grpMainOrder.TabIndex = 0;
            grpMainOrder.TabStop = false;
            grpMainOrder.Text = "Main Course";
            // 
            // rdoSalad
            // 
            rdoSalad.AutoSize = true;
            rdoSalad.Location = new Point(32, 118);
            rdoSalad.Name = "rdoSalad";
            rdoSalad.Size = new Size(67, 24);
            rdoSalad.TabIndex = 2;
            rdoSalad.TabStop = true;
            rdoSalad.Text = "Salad";
            rdoSalad.UseVisualStyleBackColor = true;
            rdoSalad.CheckedChanged += rdoSalad_CheckedChanged;
            // 
            // rdoPizza
            // 
            rdoPizza.AutoSize = true;
            rdoPizza.Location = new Point(32, 77);
            rdoPizza.Name = "rdoPizza";
            rdoPizza.Size = new Size(64, 24);
            rdoPizza.TabIndex = 1;
            rdoPizza.TabStop = true;
            rdoPizza.Text = "Pizza";
            rdoPizza.UseVisualStyleBackColor = true;
            rdoPizza.CheckedChanged += rdoPizza_CheckedChanged;
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Location = new Point(32, 36);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(106, 24);
            rdoHamburger.TabIndex = 0;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "Hamburger";
            rdoHamburger.UseVisualStyleBackColor = true;
            rdoHamburger.CheckedChanged += rdoHamburger_CheckedChanged;
            // 
            // grpAddOns
            // 
            grpAddOns.Controls.Add(chkTopping3);
            grpAddOns.Controls.Add(chkTopping2);
            grpAddOns.Controls.Add(chkTopping1);
            grpAddOns.Location = new Point(431, 40);
            grpAddOns.Name = "grpAddOns";
            grpAddOns.Size = new Size(310, 159);
            grpAddOns.TabIndex = 1;
            grpAddOns.TabStop = false;
            grpAddOns.Text = "Add On Items";
            // 
            // chkTopping3
            // 
            chkTopping3.AutoSize = true;
            chkTopping3.Location = new Point(36, 118);
            chkTopping3.Name = "chkTopping3";
            chkTopping3.Size = new Size(92, 24);
            chkTopping3.TabIndex = 2;
            chkTopping3.Text = "topping3";
            chkTopping3.UseVisualStyleBackColor = true;
            // 
            // chkTopping2
            // 
            chkTopping2.AutoSize = true;
            chkTopping2.Location = new Point(36, 77);
            chkTopping2.Name = "chkTopping2";
            chkTopping2.Size = new Size(92, 24);
            chkTopping2.TabIndex = 1;
            chkTopping2.Text = "topping2";
            chkTopping2.UseVisualStyleBackColor = true;
            // 
            // chkTopping1
            // 
            chkTopping1.AutoSize = true;
            chkTopping1.Location = new Point(36, 36);
            chkTopping1.Name = "chkTopping1";
            chkTopping1.Size = new Size(92, 24);
            chkTopping1.TabIndex = 0;
            chkTopping1.Text = "topping1";
            chkTopping1.UseVisualStyleBackColor = true;
            // 
            // grpTotal
            // 

            grpTotal.Controls.Add(txtOrderTotal);
            grpTotal.Controls.Add(txtTax);
            grpTotal.Controls.Add(txtSubTotal);
            grpTotal.Controls.Add(lblOrderTotal);
            grpTotal.Controls.Add(lblTax);
            grpTotal.Controls.Add(lblSubTotal);
            grpTotal.Location = new Point(52, 242);
            grpTotal.Name = "grpTotal";
            grpTotal.Size = new Size(308, 174);
            grpTotal.TabIndex = 2;
            grpTotal.TabStop = false;
            grpTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(132, 118);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(125, 27);
            txtOrderTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(132, 78);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(125, 27);
            txtTax.TabIndex = 4;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(132, 35);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(125, 27);
            txtSubTotal.TabIndex = 3;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Location = new Point(39, 125);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(80, 20);
            lblOrderTotal.TabIndex = 2;
            lblOrderTotal.Text = "OrderTotal";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(39, 81);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(30, 20);
            lblTax.TabIndex = 1;
            lblTax.Text = "Tax";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(39, 42);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(73, 20);
            lblSubTotal.TabIndex = 0;
            lblSubTotal.Text = "Sub-Total";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(522, 242);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(219, 47);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(522, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(219, 47);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(522, 360);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(219, 47);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLunchOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnPlaceOrder);
            Controls.Add(grpTotal);
            Controls.Add(grpAddOns);
            Controls.Add(grpMainOrder);
            Name = "frmLunchOrder";
            Text = "Lunch Order";
            TopMost = true;
            Load += frmLunchOrder_Load;
            grpMainOrder.ResumeLayout(false);
            grpMainOrder.PerformLayout();
            grpAddOns.ResumeLayout(false);
            grpAddOns.PerformLayout();
            grpTotal.ResumeLayout(false);
            grpTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMainOrder;
        private GroupBox grpAddOns;
        private GroupBox grpTotal;
        private Label lblTax;
        private Label lblSubTotal;
        private TextBox txtOrderTotal;
        private TextBox txtTax;
        private TextBox txtSubTotal;
        private Label lblOrderTotal;
        private RadioButton rdoSalad;
        private RadioButton rdoPizza;
        private RadioButton rdoHamburger;
        private CheckBox chkTopping3;
        private CheckBox chkTopping2;
        private CheckBox chkTopping1;
        private Button btnPlaceOrder;
        private Button btnClear;
        private Button btnExit;
    }
}
