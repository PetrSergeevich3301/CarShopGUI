using CarClassLibrary;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBingingSourse = new BindingSource();
        BindingSource cartBingingSourse = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            Car newCar = new Car(txt_make.Text, txt_model.Text, txt_color.Text, int.Parse(txt_year.Text), int.Parse(txt_price.Text));
            //MessageBox.Show(newCar.ToString());
            myStore.CarList.Add(newCar);
            ClearFields();
            carInventoryBingingSourse.ResetBindings(false);
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            Car selected = (Car)lst_inventory.SelectedItem;
            myStore.ShoppingList.Add(selected);
            cartBingingSourse.ResetBindings(false );
            
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$" + total.ToString();

            cartBingingSourse.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBingingSourse.DataSource = myStore.CarList;
            lst_inventory.DataSource = carInventoryBingingSourse;
            lst_inventory.DisplayMember = ToString();

            cartBingingSourse.DataSource = myStore.ShoppingList;
            lst_cart.DataSource = cartBingingSourse;
            lst_cart.DisplayMember = ToString();
        }

        private void ClearFields()
        {
            txt_make.Clear();
            txt_model.Clear();
            txt_color.Clear();
            txt_year.Clear();
            txt_price.Clear();
        }
    }
}