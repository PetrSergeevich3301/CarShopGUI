namespace CarShopGUI
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btn_create_car = new Button();
            txt_price = new TextBox();
            txt_year = new TextBox();
            txt_color = new TextBox();
            txt_model = new TextBox();
            txt_make = new TextBox();
            lbl_price = new Label();
            lbl_year = new Label();
            lbl_color = new Label();
            lbl_model = new Label();
            lbl_make = new Label();
            groupBox2 = new GroupBox();
            lst_inventory = new ListBox();
            btn_addtocart = new Button();
            groupBox3 = new GroupBox();
            lst_cart = new ListBox();
            btn_checkout = new Button();
            label1 = new Label();
            lbl_total = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_create_car);
            groupBox1.Controls.Add(txt_price);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(txt_color);
            groupBox1.Controls.Add(txt_model);
            groupBox1.Controls.Add(txt_make);
            groupBox1.Controls.Add(lbl_price);
            groupBox1.Controls.Add(lbl_year);
            groupBox1.Controls.Add(lbl_color);
            groupBox1.Controls.Add(lbl_model);
            groupBox1.Controls.Add(lbl_make);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 349);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Car:";
            // 
            // btn_create_car
            // 
            btn_create_car.Location = new Point(33, 252);
            btn_create_car.Name = "btn_create_car";
            btn_create_car.Size = new Size(146, 29);
            btn_create_car.TabIndex = 10;
            btn_create_car.Text = "Create a car";
            btn_create_car.UseVisualStyleBackColor = true;
            btn_create_car.Click += btn_create_car_Click;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(86, 175);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(125, 27);
            txt_price.TabIndex = 9;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(86, 142);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(125, 27);
            txt_year.TabIndex = 8;
            // 
            // txt_color
            // 
            txt_color.Location = new Point(86, 109);
            txt_color.Name = "txt_color";
            txt_color.Size = new Size(125, 27);
            txt_color.TabIndex = 7;
            // 
            // txt_model
            // 
            txt_model.Location = new Point(86, 76);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(125, 27);
            txt_model.TabIndex = 6;
            // 
            // txt_make
            // 
            txt_make.Location = new Point(86, 43);
            txt_make.Name = "txt_make";
            txt_make.Size = new Size(125, 27);
            txt_make.TabIndex = 5;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Location = new Point(6, 178);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(44, 20);
            lbl_price.TabIndex = 4;
            lbl_price.Text = "Price:";
            // 
            // lbl_year
            // 
            lbl_year.AutoSize = true;
            lbl_year.Location = new Point(6, 145);
            lbl_year.Name = "lbl_year";
            lbl_year.Size = new Size(40, 20);
            lbl_year.TabIndex = 3;
            lbl_year.Text = "Year:";
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Location = new Point(6, 112);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(48, 20);
            lbl_color.TabIndex = 2;
            lbl_color.Text = "Color:";
            // 
            // lbl_model
            // 
            lbl_model.AutoSize = true;
            lbl_model.Location = new Point(6, 79);
            lbl_model.Name = "lbl_model";
            lbl_model.Size = new Size(55, 20);
            lbl_model.TabIndex = 1;
            lbl_model.Text = "Model:";
            // 
            // lbl_make
            // 
            lbl_make.AutoSize = true;
            lbl_make.Location = new Point(6, 45);
            lbl_make.Name = "lbl_make";
            lbl_make.Size = new Size(48, 20);
            lbl_make.TabIndex = 0;
            lbl_make.Text = "Make:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lst_inventory);
            groupBox2.Location = new Point(237, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(218, 349);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Car Inventory:";
            // 
            // lst_inventory
            // 
            lst_inventory.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lst_inventory.FormattingEnabled = true;
            lst_inventory.HorizontalScrollbar = true;
            lst_inventory.ItemHeight = 17;
            lst_inventory.Location = new Point(0, 42);
            lst_inventory.Name = "lst_inventory";
            lst_inventory.Size = new Size(212, 293);
            lst_inventory.TabIndex = 0;
            // 
            // btn_addtocart
            // 
            btn_addtocart.Location = new Point(461, 154);
            btn_addtocart.Name = "btn_addtocart";
            btn_addtocart.Size = new Size(96, 60);
            btn_addtocart.TabIndex = 2;
            btn_addtocart.Text = "Add to cart";
            btn_addtocart.UseVisualStyleBackColor = true;
            btn_addtocart.Click += btn_addtocart_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lst_cart);
            groupBox3.Location = new Point(576, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(212, 281);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Shopping Cart:";
            // 
            // lst_cart
            // 
            lst_cart.FormattingEnabled = true;
            lst_cart.ItemHeight = 20;
            lst_cart.Location = new Point(0, 42);
            lst_cart.Name = "lst_cart";
            lst_cart.Size = new Size(150, 184);
            lst_cart.TabIndex = 0;
            // 
            // btn_checkout
            // 
            btn_checkout.Location = new Point(632, 299);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(94, 29);
            btn_checkout.TabIndex = 4;
            btn_checkout.Text = "Checkout";
            btn_checkout.UseVisualStyleBackColor = true;
            btn_checkout.Click += btn_checkout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(576, 341);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "Total Cost: ";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(676, 341);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(52, 20);
            lbl_total.TabIndex = 6;
            lbl_total.Text = "$  0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_total);
            Controls.Add(label1);
            Controls.Add(btn_checkout);
            Controls.Add(groupBox3);
            Controls.Add(btn_addtocart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_create_car;
        private TextBox txt_price;
        private TextBox txt_year;
        private TextBox txt_color;
        private TextBox txt_model;
        private TextBox txt_make;
        private Label lbl_price;
        private Label lbl_year;
        private Label lbl_color;
        private Label lbl_model;
        private Label lbl_make;
        private GroupBox groupBox2;
        private ListBox lst_inventory;
        private Button btn_addtocart;
        private GroupBox groupBox3;
        private ListBox lst_cart;
        private Button btn_checkout;
        private Label label1;
        private Label lbl_total;
    }
}