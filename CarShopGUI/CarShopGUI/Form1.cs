using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
	public partial class Form1 : Form
	{
		Store myStore = new Store();
		BindingSource carInventoryBindingSource = new BindingSource();
		BindingSource shoppingCartBindingSource = new BindingSource();
		BindingSource checkoutBindingSource = new BindingSource();

		public Form1()
		{
			InitializeComponent();
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void btn_addtocart_Click(object sender, EventArgs e)
		{
			Car selected = (Car)lst_inventory.SelectedItem;

			myStore.ShoppingList.Add(selected);

			shoppingCartBindingSource.ResetBindings(false);
		}

		private void btn_create_car_Click(object sender, EventArgs e)
		{
			Car newCar = new Car(txt_make.Text, txt_model.Text, 0);

			try
			{
				newCar.Price = decimal.Parse(txt_price.Text);
			}
			catch (Exception)
			{

				throw new Exception("NOOOOOOOOOOOOOOOO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!☹☹☹☹☹☹☹☹☹☹☹☹☹");
			}

			// MessageBox.Show(newCar.ToString());
			myStore.CarList.Add(newCar);
			carInventoryBindingSource.ResetBindings(false);

			txt_make.Text = "";
			txt_model.Text = "";
			txt_price.Text = "";
		}

		private void btn_checkout_Click(object sender, EventArgs e)
		{
			decimal totalPrice = myStore.Checkout();

			lbl_total.Text = $"${totalPrice.ToString()}";

			shoppingCartBindingSource.ResetBindings(false);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			carInventoryBindingSource.DataSource = myStore.CarList;
			shoppingCartBindingSource.DataSource = myStore.ShoppingList;

			lst_inventory.DataSource = carInventoryBindingSource;
			lst_inventory.DisplayMember = ToString();


			lst_cart.DataSource = shoppingCartBindingSource;
			lst_cart.DisplayMember = ToString();

		}
	}
}
