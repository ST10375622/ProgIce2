namespace ProgIce2
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
			label1 = new Label();
			namelbl = new Label();
			Pricelbl = new Label();
			quantitylbl = new Label();
			categorylbl = new Label();
			txtName = new TextBox();
			txtPrice = new TextBox();
			txtQuantity = new TextBox();
			cmbCategory = new ComboBox();
			btnAddItem = new Button();
			btnRemoveItem = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Blue;
			label1.Location = new Point(231, 9);
			label1.Name = "label1";
			label1.Size = new Size(321, 40);
			label1.TabIndex = 0;
			label1.Text = "Inventory Application";
			// 
			// namelbl
			// 
			namelbl.AutoSize = true;
			namelbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			namelbl.Location = new Point(12, 109);
			namelbl.Name = "namelbl";
			namelbl.Size = new Size(62, 23);
			namelbl.TabIndex = 1;
			namelbl.Text = "Name:";
			namelbl.Click += label2_Click;
			// 
			// Pricelbl
			// 
			Pricelbl.AutoSize = true;
			Pricelbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Pricelbl.Location = new Point(209, 109);
			Pricelbl.Name = "Pricelbl";
			Pricelbl.Size = new Size(54, 23);
			Pricelbl.TabIndex = 2;
			Pricelbl.Text = "Price:";
			// 
			// quantitylbl
			// 
			quantitylbl.AutoSize = true;
			quantitylbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			quantitylbl.Location = new Point(434, 109);
			quantitylbl.Name = "quantitylbl";
			quantitylbl.Size = new Size(90, 23);
			quantitylbl.TabIndex = 3;
			quantitylbl.Text = "Quantity: ";
			// 
			// categorylbl
			// 
			categorylbl.AutoSize = true;
			categorylbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			categorylbl.Location = new Point(637, 109);
			categorylbl.Name = "categorylbl";
			categorylbl.Size = new Size(89, 23);
			categorylbl.TabIndex = 4;
			categorylbl.Text = "Category:";
			// 
			// txtName
			// 
			txtName.Location = new Point(12, 149);
			txtName.Name = "txtName";
			txtName.Size = new Size(100, 27);
			txtName.TabIndex = 5;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(209, 149);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(125, 27);
			txtPrice.TabIndex = 6;
			// 
			// txtQuantity
			// 
			txtQuantity.Location = new Point(434, 148);
			txtQuantity.Name = "txtQuantity";
			txtQuantity.Size = new Size(125, 27);
			txtQuantity.TabIndex = 7;
			// 
			// cmbCategory
			// 
			cmbCategory.FormattingEnabled = true;
			cmbCategory.Items.AddRange(new object[] { " fruits", "vegetables", "dairy products", " meat products", "bakery products", "Other" });
			cmbCategory.Location = new Point(637, 147);
			cmbCategory.Name = "cmbCategory";
			cmbCategory.Size = new Size(151, 28);
			cmbCategory.TabIndex = 8;
			// 
			// btnAddItem
			// 
			btnAddItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAddItem.ForeColor = Color.Blue;
			btnAddItem.Location = new Point(23, 379);
			btnAddItem.Name = "btnAddItem";
			btnAddItem.Size = new Size(94, 59);
			btnAddItem.TabIndex = 9;
			btnAddItem.Text = "Add Item";
			btnAddItem.UseVisualStyleBackColor = true;
			btnAddItem.Click += btnAddItem_Click;
			// 
			// btnRemoveItem
			// 
			btnRemoveItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnRemoveItem.ForeColor = Color.Blue;
			btnRemoveItem.Location = new Point(694, 379);
			btnRemoveItem.Name = "btnRemoveItem";
			btnRemoveItem.Size = new Size(94, 61);
			btnRemoveItem.TabIndex = 10;
			btnRemoveItem.Text = "Remove Item";
			btnRemoveItem.UseVisualStyleBackColor = true;
			btnRemoveItem.Click += btnRemoveItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 192, 192);
			ClientSize = new Size(800, 450);
			Controls.Add(btnRemoveItem);
			Controls.Add(btnAddItem);
			Controls.Add(cmbCategory);
			Controls.Add(txtQuantity);
			Controls.Add(txtPrice);
			Controls.Add(txtName);
			Controls.Add(categorylbl);
			Controls.Add(quantitylbl);
			Controls.Add(Pricelbl);
			Controls.Add(namelbl);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Inventory App";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label namelbl;
		private Label Pricelbl;
		private Label quantitylbl;
		private Label categorylbl;
		private TextBox txtName;
		private TextBox txtPrice;
		private TextBox txtQuantity;
		private ComboBox cmbCategory;
		private Button btnAddItem;
		private Button btnRemoveItem;
	}
}
