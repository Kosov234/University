namespace OOPSemesterProject
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Button EngineList;
			System.Windows.Forms.Button HeadlightsList;
			System.Windows.Forms.Button SeatList;
			System.Windows.Forms.Button SteeringList;
			System.Windows.Forms.Button TireList;
			System.Windows.Forms.Button WheelList;
			System.Windows.Forms.Button WindowList;
			System.Windows.Forms.Button buttonAddToTheCart;
			System.Windows.Forms.Button button2;
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTest = new System.Windows.Forms.TextBox();
			this.labelCart = new System.Windows.Forms.Label();
			this.PartsList = new System.Windows.Forms.ListView();
			this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxTotalSum = new System.Windows.Forms.TextBox();
			this.listViewCart = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cart_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.submitOrder = new System.Windows.Forms.Button();
			this.buttonShowCars = new System.Windows.Forms.Button();
			EngineList = new System.Windows.Forms.Button();
			HeadlightsList = new System.Windows.Forms.Button();
			SeatList = new System.Windows.Forms.Button();
			SteeringList = new System.Windows.Forms.Button();
			TireList = new System.Windows.Forms.Button();
			WheelList = new System.Windows.Forms.Button();
			WindowList = new System.Windows.Forms.Button();
			buttonAddToTheCart = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EngineList
			// 
			EngineList.Location = new System.Drawing.Point(275, 3);
			EngineList.Name = "EngineList";
			EngineList.Size = new System.Drawing.Size(127, 26);
			EngineList.TabIndex = 2;
			EngineList.Text = "Show Engines";
			EngineList.UseVisualStyleBackColor = true;
			EngineList.Click += new System.EventHandler(this.ShowEngines_Click);
			// 
			// HeadlightsList
			// 
			HeadlightsList.Location = new System.Drawing.Point(141, 3);
			HeadlightsList.Name = "HeadlightsList";
			HeadlightsList.Size = new System.Drawing.Size(127, 26);
			HeadlightsList.TabIndex = 5;
			HeadlightsList.Text = "Show Headlights";
			HeadlightsList.UseVisualStyleBackColor = true;
			HeadlightsList.Click += new System.EventHandler(this.ShowHeadlights_Click);
			// 
			// SeatList
			// 
			SeatList.Location = new System.Drawing.Point(408, 3);
			SeatList.Name = "SeatList";
			SeatList.Size = new System.Drawing.Size(127, 26);
			SeatList.TabIndex = 6;
			SeatList.Text = "Show Seats";
			SeatList.UseVisualStyleBackColor = true;
			SeatList.Click += new System.EventHandler(this.ShowSeats_Click);
			// 
			// SteeringList
			// 
			SteeringList.Location = new System.Drawing.Point(95, 35);
			SteeringList.Name = "SteeringList";
			SteeringList.Size = new System.Drawing.Size(172, 26);
			SteeringList.TabIndex = 7;
			SteeringList.Text = "Show Steering Wheels";
			SteeringList.UseVisualStyleBackColor = true;
			SteeringList.Click += new System.EventHandler(this.ShowSteering_Click);
			// 
			// TireList
			// 
			TireList.Location = new System.Drawing.Point(408, 35);
			TireList.Name = "TireList";
			TireList.Size = new System.Drawing.Size(127, 26);
			TireList.TabIndex = 8;
			TireList.Text = "Show Tires";
			TireList.UseVisualStyleBackColor = true;
			TireList.Click += new System.EventHandler(this.ShowTires_Click);
			// 
			// WheelList
			// 
			WheelList.Location = new System.Drawing.Point(275, 35);
			WheelList.Name = "WheelList";
			WheelList.Size = new System.Drawing.Size(127, 26);
			WheelList.TabIndex = 9;
			WheelList.Text = "Show Wheels";
			WheelList.UseVisualStyleBackColor = true;
			WheelList.Click += new System.EventHandler(this.ShowWheels_Click);
			// 
			// WindowList
			// 
			WindowList.Location = new System.Drawing.Point(9, 3);
			WindowList.Name = "WindowList";
			WindowList.Size = new System.Drawing.Size(127, 26);
			WindowList.TabIndex = 10;
			WindowList.Text = "Show Windows";
			WindowList.UseVisualStyleBackColor = true;
			WindowList.Click += new System.EventHandler(this.ShowWindows_Click);
			// 
			// buttonAddToTheCart
			// 
			buttonAddToTheCart.Location = new System.Drawing.Point(52, 334);
			buttonAddToTheCart.Name = "buttonAddToTheCart";
			buttonAddToTheCart.Size = new System.Drawing.Size(127, 26);
			buttonAddToTheCart.TabIndex = 14;
			buttonAddToTheCart.Text = "Add To The Cart";
			buttonAddToTheCart.UseVisualStyleBackColor = true;
			buttonAddToTheCart.Click += new System.EventHandler(this.buttonAddToTheCart_Click);
			// 
			// button2
			// 
			button2.Location = new System.Drawing.Point(185, 317);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(127, 43);
			button2.TabIndex = 15;
			button2.Text = "Remove From The Cart";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(this.RemoveFromTheCart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Parts List";
			// 
			// textBoxTest
			// 
			this.textBoxTest.AcceptsReturn = true;
			this.textBoxTest.AcceptsTab = true;
			this.textBoxTest.Location = new System.Drawing.Point(646, 64);
			this.textBoxTest.Multiline = true;
			this.textBoxTest.Name = "textBoxTest";
			this.textBoxTest.ReadOnly = true;
			this.textBoxTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxTest.Size = new System.Drawing.Size(164, 241);
			this.textBoxTest.TabIndex = 4;
			// 
			// labelCart
			// 
			this.labelCart.AutoSize = true;
			this.labelCart.Location = new System.Drawing.Point(12, 343);
			this.labelCart.Name = "labelCart";
			this.labelCart.Size = new System.Drawing.Size(34, 17);
			this.labelCart.TabIndex = 13;
			this.labelCart.Text = "Cart";
			// 
			// PartsList
			// 
			this.PartsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ID,
            this.ch_name,
            this.Price,
            this.Description});
			this.PartsList.FullRowSelect = true;
			this.PartsList.GridLines = true;
			this.PartsList.Location = new System.Drawing.Point(12, 64);
			this.PartsList.MultiSelect = false;
			this.PartsList.Name = "PartsList";
			this.PartsList.Size = new System.Drawing.Size(628, 241);
			this.PartsList.TabIndex = 17;
			this.PartsList.UseCompatibleStateImageBehavior = false;
			this.PartsList.View = System.Windows.Forms.View.Details;
			this.PartsList.SelectedIndexChanged += new System.EventHandler(this.PartsList_SelectedIndexChanged);
			// 
			// ch_ID
			// 
			this.ch_ID.Text = "ID";
			// 
			// ch_name
			// 
			this.ch_name.Text = "Name";
			this.ch_name.Width = 250;
			// 
			// Price
			// 
			this.Price.Text = "Price";
			// 
			// Description
			// 
			this.Description.Text = "Description";
			this.Description.Width = 180;
			// 
			// textBoxTotalSum
			// 
			this.textBoxTotalSum.Location = new System.Drawing.Point(666, 585);
			this.textBoxTotalSum.Name = "textBoxTotalSum";
			this.textBoxTotalSum.ReadOnly = true;
			this.textBoxTotalSum.Size = new System.Drawing.Size(144, 22);
			this.textBoxTotalSum.TabIndex = 18;
			// 
			// listViewCart
			// 
			this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.cart_amount});
			this.listViewCart.FullRowSelect = true;
			this.listViewCart.GridLines = true;
			this.listViewCart.Location = new System.Drawing.Point(12, 366);
			this.listViewCart.MultiSelect = false;
			this.listViewCart.Name = "listViewCart";
			this.listViewCart.Size = new System.Drawing.Size(628, 241);
			this.listViewCart.TabIndex = 19;
			this.listViewCart.UseCompatibleStateImageBehavior = false;
			this.listViewCart.View = System.Windows.Forms.View.Details;
			this.listViewCart.SelectedIndexChanged += new System.EventHandler(this.Cart_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 250;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Price";
			// 
			// cart_amount
			// 
			this.cart_amount.Text = "Amount";
			this.cart_amount.Width = 90;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(663, 565);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 17);
			this.label2.TabIndex = 20;
			this.label2.Text = "Total Sum";
			// 
			// submitOrder
			// 
			this.submitOrder.Location = new System.Drawing.Point(666, 460);
			this.submitOrder.Name = "submitOrder";
			this.submitOrder.Size = new System.Drawing.Size(144, 66);
			this.submitOrder.TabIndex = 21;
			this.submitOrder.Text = "Submit Order";
			this.submitOrder.UseVisualStyleBackColor = true;
			this.submitOrder.Click += new System.EventHandler(this.submitOrder_Click);
			// 
			// buttonShowCars
			// 
			this.buttonShowCars.Location = new System.Drawing.Point(541, 35);
			this.buttonShowCars.Name = "buttonShowCars";
			this.buttonShowCars.Size = new System.Drawing.Size(127, 26);
			this.buttonShowCars.TabIndex = 22;
			this.buttonShowCars.Text = "Show Cars";
			this.buttonShowCars.UseVisualStyleBackColor = true;
			this.buttonShowCars.Click += new System.EventHandler(this.buttonShowCars_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(823, 610);
			this.Controls.Add(this.buttonShowCars);
			this.Controls.Add(this.submitOrder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listViewCart);
			this.Controls.Add(this.textBoxTotalSum);
			this.Controls.Add(this.PartsList);
			this.Controls.Add(button2);
			this.Controls.Add(buttonAddToTheCart);
			this.Controls.Add(this.labelCart);
			this.Controls.Add(WindowList);
			this.Controls.Add(WheelList);
			this.Controls.Add(TireList);
			this.Controls.Add(SteeringList);
			this.Controls.Add(SeatList);
			this.Controls.Add(HeadlightsList);
			this.Controls.Add(this.textBoxTest);
			this.Controls.Add(EngineList);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxTest;
		private System.Windows.Forms.Label labelCart;
		private System.Windows.Forms.ColumnHeader ch_ID;
		private System.Windows.Forms.ColumnHeader ch_name;
		private System.Windows.Forms.TextBox textBoxTotalSum;
		public System.Windows.Forms.ListView PartsList;
		public System.Windows.Forms.ListView listViewCart;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader cart_amount;
		private System.Windows.Forms.ColumnHeader Price;
		private System.Windows.Forms.ColumnHeader Description;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button submitOrder;
		private System.Windows.Forms.Button buttonShowCars;
	}
}

