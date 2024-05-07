using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgIce2
{
	internal class GroceryStore : Form1
	{
		// InventoryItem class
		public class InventoryItem
		{
			public string Name { get; set; }
			public double Price { get; set; }
			public int Quantity { get; set; }
			public string Category { get; set; }
		}

		// Inventory class
		public class Inventory
		{
			private Dictionary<string, List<InventoryItem>> inventoryDict;

			public Inventory()
			{
				inventoryDict = new Dictionary<string, List<InventoryItem>>();
			}

			public void AddItem(InventoryItem item)
			{
				if (!inventoryDict.ContainsKey(item.Category))
				{
					inventoryDict[item.Category] = new List<InventoryItem>();
				}
				inventoryDict[item.Category].Add(item);
			}

			public void RemoveItem(InventoryItem item)
			{
				if (inventoryDict.ContainsKey(item.Category))
				{
					inventoryDict[item.Category].Remove(item);
				}
			}

			public void DisplayInventory()
			{
				foreach (var category in inventoryDict)
				{
					Console.WriteLine($"Category: {category.Key}");
					foreach (var item in category.Value)
					{
						Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
					}
				}
			}
		}

		// GroceryStore class
		public class GroceryStores
		{
			public Inventory Inventory { get; set; }

			public GroceryStores()
			{
				Inventory = new Inventory();
			}
		}

		// InputValidator class
		public class InputValidator
		{
			public static bool ValidateItem(InventoryItem item)
			{
				// Implement validation logic here
				return true; // For simplicity, always return true in this example
			}
		}

		// ErrorHandler class
		public class ErrorHandler
		{
			public static void HandleError(Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
