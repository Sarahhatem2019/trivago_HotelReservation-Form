namespace HotelTrivago
{
    partial class DealsForm
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
            this.view_deal = new System.Windows.Forms.Button();
            this.no_of_guests = new System.Windows.Forms.NumericUpDown();
            this.deal_rating = new System.Windows.Forms.NumericUpDown();
            this.cmb_property_type = new System.Windows.Forms.ComboBox();
            this.price_per_night = new System.Windows.Forms.NumericUpDown();
            this.dest_name = new System.Windows.Forms.TextBox();
            this.dealListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_guests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deal_rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_per_night)).BeginInit();
            this.SuspendLayout();
            // 
            // view_deal
            // 
            this.view_deal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.view_deal.Location = new System.Drawing.Point(694, 145);
            this.view_deal.Name = "view_deal";
            this.view_deal.Size = new System.Drawing.Size(137, 39);
            this.view_deal.TabIndex = 0;
            this.view_deal.Text = "View Deals";
            this.view_deal.UseVisualStyleBackColor = true;
            this.view_deal.Click += new System.EventHandler(this.checkDealsBtn_Click);
            // 
            // no_of_guests
            // 
            this.no_of_guests.Location = new System.Drawing.Point(12, 157);
            this.no_of_guests.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.no_of_guests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.no_of_guests.Name = "no_of_guests";
            this.no_of_guests.Size = new System.Drawing.Size(200, 22);
            this.no_of_guests.TabIndex = 3;
            this.no_of_guests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deal_rating
            // 
            this.deal_rating.Location = new System.Drawing.Point(233, 154);
            this.deal_rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.deal_rating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deal_rating.Name = "deal_rating";
            this.deal_rating.Size = new System.Drawing.Size(200, 22);
            this.deal_rating.TabIndex = 6;
            this.deal_rating.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cmb_property_type
            // 
            this.cmb_property_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_property_type.FormattingEnabled = true;
            this.cmb_property_type.Items.AddRange(new object[] {
            "Any",
            "Hotel",
            "Villa",
            "Apartment"});
            this.cmb_property_type.Location = new System.Drawing.Point(12, 89);
            this.cmb_property_type.Name = "cmb_property_type";
            this.cmb_property_type.Size = new System.Drawing.Size(421, 24);
            this.cmb_property_type.TabIndex = 7;
            // 
            // price_per_night
            // 
            this.price_per_night.DecimalPlaces = 2;
            this.price_per_night.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.price_per_night.Location = new System.Drawing.Point(472, 154);
            this.price_per_night.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.price_per_night.Name = "price_per_night";
            this.price_per_night.Size = new System.Drawing.Size(200, 22);
            this.price_per_night.TabIndex = 8;
            this.price_per_night.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dest_name
            // 
            this.dest_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dest_name.Location = new System.Drawing.Point(12, 32);
            this.dest_name.Name = "dest_name";
            this.dest_name.Size = new System.Drawing.Size(421, 22);
            this.dest_name.TabIndex = 9;
            // 
            // dealListView
            // 
            this.dealListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dealListView.HideSelection = false;
            this.dealListView.Location = new System.Drawing.Point(12, 190);
            this.dealListView.Name = "dealListView";
            this.dealListView.Size = new System.Drawing.Size(819, 269);
            this.dealListView.TabIndex = 10;
            this.dealListView.UseCompatibleStateImageBehavior = false;
            this.dealListView.SelectedIndexChanged += new System.EventHandler(this.dealListView_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(657, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number of guests";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rating";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Destination";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Property Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(684, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "View Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dealListView);
            this.Controls.Add(this.dest_name);
            this.Controls.Add(this.price_per_night);
            this.Controls.Add(this.cmb_property_type);
            this.Controls.Add(this.deal_rating);
            this.Controls.Add(this.no_of_guests);
            this.Controls.Add(this.view_deal);
            this.Name = "DealsForm";
            this.Text = "Search for deals";
            ((System.ComponentModel.ISupportInitialize)(this.no_of_guests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deal_rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_per_night)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_deal;
        private System.Windows.Forms.NumericUpDown no_of_guests;
        private System.Windows.Forms.NumericUpDown deal_rating;
        private System.Windows.Forms.ComboBox cmb_property_type;
        private System.Windows.Forms.NumericUpDown price_per_night;
        private System.Windows.Forms.TextBox dest_name;
        private System.Windows.Forms.ListView dealListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

