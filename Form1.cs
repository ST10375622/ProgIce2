using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ProgIce2.GroceryStore.InventoryItem;
using static ProgIce2.GroceryStore;

namespace ProgIce2
{
	public partial class Form1 : Form
	{
		private GroceryStores groceryStore;

		public Form1()
		{
			InitializeComponent();
			groceryStore = new GroceryStores();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			try
			{
				var item = new InventoryItem
				{
					Name = txtName.Text,
					Price = Convert.ToDouble(txtPrice.Text),
					Quantity = Convert.ToInt32(txtQuantity.Text),
					Category = cmbCategory.Text
				};

				if (InputValidator.ValidateItem(item))
				{
					groceryStore.Inventory.AddItem(item);
					MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Invalid item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				ErrorHandler.HandleError(ex);
			}
		}

		private void btnRemoveItem_Click(object sender, EventArgs e)
		{
			try
			{
				var item = new InventoryItem
				{
					Name = txtName.Text,
					Price = Convert.ToDouble(txtPrice.Text),
					Quantity = Convert.ToInt32(txtQuantity.Text),
					Category = cmbCategory.Text
				};

				groceryStore.Inventory.RemoveItem(item);
				MessageBox.Show("Item removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				ErrorHandler.HandleError(ex);
			}
		}

		private void btnDisplayInventory_Click(object sender, EventArgs e)
		{
			try
			{
				groceryStore.Inventory.DisplayInventory();
			}
			catch (Exception ex)
			{
				ErrorHandler.HandleError(ex);
			}
		}
	}
}
