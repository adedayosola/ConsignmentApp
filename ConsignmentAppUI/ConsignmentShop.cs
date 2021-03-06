using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentAppUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();

        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        private Decimal storeProfit = 0;


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemBinding;
            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            cartListBox.DataSource = cartBinding;
            cartListBox.DisplayMember = "Display";
            cartListBox.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorBinding;
            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
        }
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "David", LastName = "Ayo" });
            store.Vendors.Add(new Vendor { FirstName = "Joseph", LastName = "Tope" });

            store.Items.Add(new Item
            {
                Title = "Dele Momo",
                Description = "A book about ovation",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Cynthia Morgan",
                Description = "A book about German Juice",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Micheal Cena",
                Description = "A book about wresting",
                Price = 5.20M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Wasiu Ayinde",
                Description = "A book about Fuji",
                Price = 1.50M,
                Owner = store.Vendors[0]
            });

            store.Name = "Na name of store be this";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //figure out what is selected from items list
            //copy that item to the shopping cart
            //do we take it from inventory

            Item selectedItem = (Item)itemsListBox.SelectedItem;
            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //mark each item as sold
            //clear the cart
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1-(decimal)item.Owner.Commission) * item.Price;
            }
            shoppingCartData.Clear();

            itemBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("CAD${0: 0.00}", storeProfit);

            cartBinding.ResetBindings(false);
            itemBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
        }
    }
}
