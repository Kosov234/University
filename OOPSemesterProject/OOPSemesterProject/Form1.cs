using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOPSemesterProject
{

	public partial class Form1 : Form
	{
		List<Classes.ShopElement> DisplayedParts = new List<Classes.ShopElement>();
		List<CartElement> Cart = new List<CartElement>();
		Classes.PartsList listOfParts;
		public Form1()
		{
			ReadFromJSONHandler handler = new ReadFromJSONHandler();
			listOfParts = handler.readJSON();
			InitializeComponent();
		}
		private void PartsList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (PartsList.SelectedItems.Count > 0)
				textBoxTest.Text = DisplayedParts[PartsList.FocusedItem.Index].GetDescription();
			//When we select smthng on PartsListView,show it's description
		}

		private void Cart_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (listViewCart.SelectedItems.Count > 0)
				textBoxTest.Text = Cart[listViewCart.FocusedItem.Index].GetDescription();
			//Same as the above,but for the cart
		}

		private void ShowEngines_Click(object sender, System.EventArgs e)
		{
			RefreshCarParts(listOfParts.EngineArray);
		}

		private void ShowHeadlights_Click(object sender, System.EventArgs e)
		{
			RefreshCarParts(listOfParts.HeadlightsArray);
		}

		private void ShowSeats_Click(object sender, System.EventArgs e)
		{
			RefreshCarParts(listOfParts.SeatsArray);
		}

		private void ShowSteering_Click(object sender, System.EventArgs e)
		{
			RefreshCarParts(listOfParts.SteeringArray);
		}

		private void ShowTires_Click(object sender, System.EventArgs e)
		{
			RefreshCarParts(listOfParts.TireArray);
		}

		private void ShowWheels_Click(object sender, System.EventArgs e)
		{
			RefreshCarParts(listOfParts.WheelArray);
		}

		private void ShowWindows_Click(object sender, System.EventArgs e)
		{
			RefreshCarParts(listOfParts.WindowArray);
		}

		private void buttonShowCars_Click(object sender, EventArgs e)
		{
			RefreshCarParts(listOfParts.CarArray);
		}

		internal void RefreshCarParts(Classes.ShopElement[] carParts)
		{
			DisplayedParts.Clear();
			PartsList.Items.Clear();
			for (int i = 0; i < carParts.Length; i++)
			{
				DisplayedParts.Add(carParts[i]);
				ListViewItem test = new ListViewItem(carParts[i].ID.ToString());
				test.SubItems.Add(carParts[i].Name);
				test.SubItems.Add(carParts[i].Price.ToString());
				test.SubItems.Add(carParts[i].Description);
				PartsList.Items.Add(test);
			}
		}

		private void buttonAddToTheCart_Click(object sender, EventArgs e)
		{
			if (PartsList.FocusedItem != null && PartsList.SelectedItems.Count > 0)
			{
				for (int i = 0; i < Cart.Count; i++)
				{
					if (Cart[i].Element == DisplayedParts[PartsList.FocusedItem.Index])
					{
						Cart[i].Amount++;
						var columnAmountIndex = 3;
						listViewCart
							.Items[i]
							.SubItems
							.Insert(
								columnAmountIndex,
								new ListViewItem.ListViewSubItem(
									listViewCart.Items[i],
									Cart[i].Amount.ToString()));

						CalculateTotalSum();
						listViewCart.Refresh();

						return;
					}

				}

				Cart.Add(new CartElement(DisplayedParts[PartsList.FocusedItem.Index], 1));
				Classes.ShopElement lastElement = (Classes.ShopElement)Cart[Cart.Count - 1].Element;
				CalculateTotalSum();

				//Adding Item to the ListView
				//Is it a right way to do it?
				ListViewItem test = new ListViewItem(lastElement.ID.ToString());
				test.SubItems.Add(lastElement.Name);
				test.SubItems.Add(lastElement.Price.ToString());
				test.SubItems.Add(Cart[Cart.Count - 1].Amount.ToString());
				listViewCart.Items.Add(test);
			}
		}

		private void RemoveFromTheCart_Click(object sender, EventArgs e)
		{
			if (listViewCart.SelectedItems.Count > 0)
			{
				if (Cart[listViewCart.FocusedItem.Index].Amount == 1)
				{
					Cart.RemoveAt(listViewCart.FocusedItem.Index);
					listViewCart.Items[listViewCart.FocusedItem.Index].Remove();
					CalculateTotalSum();
				}
				else
				{
					Cart[listViewCart.FocusedItem.Index].Amount--;
					CalculateTotalSum();

					var columnIndex = 3;

					listViewCart
						.Items[listViewCart.FocusedItem.Index]
						.SubItems
						.Insert(
							columnIndex,
							new ListViewItem.ListViewSubItem(
								listViewCart.Items[listViewCart.FocusedItem.Index],
								Cart[listViewCart.FocusedItem.Index].Amount.ToString()));
				}
			}
		}

		private void CalculateTotalSum()
		{
			double sum = 0;

			foreach (var item in Cart)
			{
				sum += item.Element.Price * item.Amount;
			}

			textBoxTotalSum.Text = sum.ToString();
		}

		private void submitOrder_Click(object sender, EventArgs e)
		{
			string text= "Part,Amount,Total Price";
			foreach (var item in Cart)
			{
				string orderLine = $"\n{item.Element.Name},{item.Amount},{item.Element.Price * item.Amount}";
				text += orderLine;
				
			}
			text += $"\n,,Totalsum\n,,{textBoxTotalSum.Text}";
			File.WriteAllText("Order.csv", text);
		}

		
	}
}
