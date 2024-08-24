namespace TV_Retail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BrandListLabel = new Label();
            SizeListLabel = new Label();
            CartCheckoutPanel = new Panel();
            InventoryReportButton = new Button();
            PlaceOrderButton = new Button();
            TvLogo = new PictureBox();
            CheckOutButton = new Button();
            AddToCartButton = new Button();
            MenuPanel = new Panel();
            SearchButton = new Button();
            ExitButton = new Button();
            SummaryButton = new Button();
            HomeButton = new Button();
            TvLogoSmall = new PictureBox();
            CartListBox = new ListBox();
            CartListLabel = new Label();
            FormPanel = new Panel();
            BrandListBox = new ListBox();
            CountTextBox = new TextBox();
            CountLabel = new Label();
            DisplaySizeListBox = new ListBox();
            BaseForm = new Panel();
            SearchPanel = new Panel();
            SearchResultBox = new ListBox();
            SearchHeaderPanel = new Panel();
            SearchResultButton = new Button();
            ClearSearchButton = new Button();
            SearchBox = new TextBox();
            RadioForDate = new RadioButton();
            RadioForTransactionID = new RadioButton();
            TransactionSearchLabel = new Label();
            ClearAllButton = new Button();
            OrderDetailsLabel = new Label();
            OrderDetailsPanel = new Panel();
            DateResultField = new Label();
            TransactionIdResultField = new Label();
            PhoneTextField = new TextBox();
            EmailIdTextField = new TextBox();
            CustomerNameTextField = new TextBox();
            CustomerPhoneLabel = new Label();
            CustomerEmailLabel = new Label();
            DateLabel = new Label();
            TransactionIdLabel = new Label();
            CustomerNameLabel = new Label();
            CartCheckoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TvLogo).BeginInit();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TvLogoSmall).BeginInit();
            FormPanel.SuspendLayout();
            BaseForm.SuspendLayout();
            SearchPanel.SuspendLayout();
            SearchHeaderPanel.SuspendLayout();
            OrderDetailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BrandListLabel
            // 
            BrandListLabel.AutoSize = true;
            BrandListLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BrandListLabel.ForeColor = Color.FromArgb(64, 64, 64);
            BrandListLabel.Location = new Point(201, 6);
            BrandListLabel.Name = "BrandListLabel";
            BrandListLabel.Size = new Size(144, 25);
            BrandListLabel.TabIndex = 1;
            BrandListLabel.Text = "Select Tv Brand";
            // 
            // SizeListLabel
            // 
            SizeListLabel.AutoSize = true;
            SizeListLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SizeListLabel.ForeColor = Color.FromArgb(64, 64, 64);
            SizeListLabel.Location = new Point(413, 6);
            SizeListLabel.Name = "SizeListLabel";
            SizeListLabel.Size = new Size(113, 25);
            SizeListLabel.TabIndex = 3;
            SizeListLabel.Text = "Display Size";
            // 
            // CartCheckoutPanel
            // 
            CartCheckoutPanel.BackColor = Color.BlanchedAlmond;
            CartCheckoutPanel.Controls.Add(InventoryReportButton);
            CartCheckoutPanel.Controls.Add(PlaceOrderButton);
            CartCheckoutPanel.Controls.Add(TvLogo);
            CartCheckoutPanel.Controls.Add(CheckOutButton);
            CartCheckoutPanel.Location = new Point(748, 378);
            CartCheckoutPanel.Name = "CartCheckoutPanel";
            CartCheckoutPanel.Size = new Size(355, 208);
            CartCheckoutPanel.TabIndex = 8;
            // 
            // InventoryReportButton
            // 
            InventoryReportButton.BackColor = Color.LightSkyBlue;
            InventoryReportButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InventoryReportButton.ForeColor = SystemColors.Desktop;
            InventoryReportButton.Location = new Point(21, 26);
            InventoryReportButton.Name = "InventoryReportButton";
            InventoryReportButton.Size = new Size(120, 65);
            InventoryReportButton.TabIndex = 7;
            InventoryReportButton.Text = "Stoc&k Report";
            InventoryReportButton.UseVisualStyleBackColor = false;
            InventoryReportButton.Click += InventoryReportButton_Click;
            // 
            // PlaceOrderButton
            // 
            PlaceOrderButton.BackColor = Color.Tomato;
            PlaceOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PlaceOrderButton.ForeColor = Color.SeaShell;
            PlaceOrderButton.Location = new Point(175, 142);
            PlaceOrderButton.Name = "PlaceOrderButton";
            PlaceOrderButton.Size = new Size(139, 34);
            PlaceOrderButton.TabIndex = 13;
            PlaceOrderButton.Text = "Place &Order";
            PlaceOrderButton.UseVisualStyleBackColor = false;
            PlaceOrderButton.Visible = false;
            PlaceOrderButton.Click += PlaceOrderButton_Click;
            // 
            // TvLogo
            // 
            TvLogo.Image = (Image)resources.GetObject("TvLogo.Image");
            TvLogo.Location = new Point(175, 26);
            TvLogo.Name = "TvLogo";
            TvLogo.Size = new Size(139, 110);
            TvLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            TvLogo.TabIndex = 0;
            TvLogo.TabStop = false;
            // 
            // CheckOutButton
            // 
            CheckOutButton.BackColor = Color.Orange;
            CheckOutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CheckOutButton.ForeColor = Color.SeaShell;
            CheckOutButton.Location = new Point(21, 144);
            CheckOutButton.Name = "CheckOutButton";
            CheckOutButton.Size = new Size(120, 32);
            CheckOutButton.TabIndex = 7;
            CheckOutButton.Text = "&Check Out";
            CheckOutButton.UseVisualStyleBackColor = false;
            CheckOutButton.Visible = false;
            CheckOutButton.Click += CheckOutButton_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.BackColor = Color.Orange;
            AddToCartButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddToCartButton.ForeColor = Color.SeaShell;
            AddToCartButton.Location = new Point(248, 200);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(146, 34);
            AddToCartButton.TabIndex = 6;
            AddToCartButton.Text = "&Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = false;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.BlanchedAlmond;
            MenuPanel.Controls.Add(SearchButton);
            MenuPanel.Controls.Add(ExitButton);
            MenuPanel.Controls.Add(SummaryButton);
            MenuPanel.Controls.Add(HomeButton);
            MenuPanel.Controls.Add(TvLogoSmall);
            MenuPanel.Location = new Point(-2, -2);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(156, 628);
            MenuPanel.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightSkyBlue;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.ForeColor = SystemColors.Desktop;
            SearchButton.Location = new Point(25, 281);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(103, 34);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "&Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.OrangeRed;
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.SeaShell;
            ExitButton.Location = new Point(25, 520);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(103, 34);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.BackColor = Color.LightSkyBlue;
            SummaryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SummaryButton.ForeColor = SystemColors.Desktop;
            SummaryButton.Location = new Point(25, 337);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(103, 34);
            SummaryButton.TabIndex = 4;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = false;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.LightSkyBlue;
            HomeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HomeButton.ForeColor = Color.Black;
            HomeButton.Location = new Point(25, 220);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(103, 34);
            HomeButton.TabIndex = 3;
            HomeButton.Text = "&Home";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // TvLogoSmall
            // 
            TvLogoSmall.Image = (Image)resources.GetObject("TvLogoSmall.Image");
            TvLogoSmall.Location = new Point(25, 46);
            TvLogoSmall.Name = "TvLogoSmall";
            TvLogoSmall.Size = new Size(103, 87);
            TvLogoSmall.SizeMode = PictureBoxSizeMode.StretchImage;
            TvLogoSmall.TabIndex = 2;
            TvLogoSmall.TabStop = false;
            // 
            // CartListBox
            // 
            CartListBox.BackColor = Color.LightSlateGray;
            CartListBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CartListBox.ForeColor = Color.SeaShell;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 25;
            CartListBox.Location = new Point(658, 34);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(447, 254);
            CartListBox.TabIndex = 0;
            // 
            // CartListLabel
            // 
            CartListLabel.AutoSize = true;
            CartListLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CartListLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CartListLabel.Location = new Point(658, 6);
            CartListLabel.Name = "CartListLabel";
            CartListLabel.Size = new Size(87, 25);
            CartListLabel.TabIndex = 9;
            CartListLabel.Text = "Cart List:";
            // 
            // FormPanel
            // 
            FormPanel.BackColor = Color.SlateGray;
            FormPanel.Controls.Add(BrandListBox);
            FormPanel.Controls.Add(CountTextBox);
            FormPanel.Controls.Add(CountLabel);
            FormPanel.Controls.Add(AddToCartButton);
            FormPanel.Controls.Add(DisplaySizeListBox);
            FormPanel.Location = new Point(173, 34);
            FormPanel.Name = "FormPanel";
            FormPanel.Size = new Size(415, 254);
            FormPanel.TabIndex = 12;
            // 
            // BrandListBox
            // 
            BrandListBox.FormattingEnabled = true;
            BrandListBox.ItemHeight = 25;
            BrandListBox.Items.AddRange(new object[] { "Sony", "Samsung", "Apple", "JVC", "MI", "Lenovo", "VU", "LG", "HP", "Dell", "Toshiba", "Hitachi", "Philips", "Asus", "Panasonic" });
            BrandListBox.Location = new Point(13, 14);
            BrandListBox.Name = "BrandListBox";
            BrandListBox.Size = new Size(180, 129);
            BrandListBox.TabIndex = 2;
            // 
            // CountTextBox
            // 
            CountTextBox.Location = new Point(14, 203);
            CountTextBox.Name = "CountTextBox";
            CountTextBox.PlaceholderText = "0";
            CountTextBox.Size = new Size(179, 31);
            CountTextBox.TabIndex = 10;
            CountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CountLabel.ForeColor = Color.SeaShell;
            CountLabel.Location = new Point(13, 166);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(151, 25);
            CountLabel.TabIndex = 11;
            CountLabel.Text = "Enter the Count:";
            // 
            // DisplaySizeListBox
            // 
            DisplaySizeListBox.FormattingEnabled = true;
            DisplaySizeListBox.ItemHeight = 25;
            DisplaySizeListBox.Items.AddRange(new object[] { "24 inches(Small)", "32 inches(Compact)", "43 inches(Medium)", "55 inches(Large)", "65 inches(Extra Large)" });
            DisplaySizeListBox.Location = new Point(214, 14);
            DisplaySizeListBox.Name = "DisplaySizeListBox";
            DisplaySizeListBox.Size = new Size(180, 129);
            DisplaySizeListBox.TabIndex = 4;
            // 
            // BaseForm
            // 
            BaseForm.BackColor = Color.LightSteelBlue;
            BaseForm.BorderStyle = BorderStyle.Fixed3D;
            BaseForm.Controls.Add(SearchPanel);
            BaseForm.Controls.Add(ClearAllButton);
            BaseForm.Controls.Add(OrderDetailsLabel);
            BaseForm.Controls.Add(OrderDetailsPanel);
            BaseForm.Controls.Add(FormPanel);
            BaseForm.Controls.Add(CartListLabel);
            BaseForm.Controls.Add(CartListBox);
            BaseForm.Controls.Add(MenuPanel);
            BaseForm.Controls.Add(CartCheckoutPanel);
            BaseForm.Controls.Add(SizeListLabel);
            BaseForm.Controls.Add(BrandListLabel);
            BaseForm.Location = new Point(12, 12);
            BaseForm.Name = "BaseForm";
            BaseForm.Size = new Size(1105, 575);
            BaseForm.TabIndex = 1;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.White;
            SearchPanel.BorderStyle = BorderStyle.Fixed3D;
            SearchPanel.Controls.Add(SearchResultBox);
            SearchPanel.Controls.Add(SearchHeaderPanel);
            SearchPanel.Controls.Add(TransactionSearchLabel);
            SearchPanel.Location = new Point(211, 17);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(531, 537);
            SearchPanel.TabIndex = 12;
            SearchPanel.Visible = false;
            // 
            // SearchResultBox
            // 
            SearchResultBox.BackColor = SystemColors.Info;
            SearchResultBox.FormattingEnabled = true;
            SearchResultBox.ItemHeight = 25;
            SearchResultBox.Location = new Point(17, 213);
            SearchResultBox.Name = "SearchResultBox";
            SearchResultBox.Size = new Size(464, 304);
            SearchResultBox.TabIndex = 18;
            // 
            // SearchHeaderPanel
            // 
            SearchHeaderPanel.BackColor = SystemColors.InactiveCaption;
            SearchHeaderPanel.Controls.Add(SearchResultButton);
            SearchHeaderPanel.Controls.Add(ClearSearchButton);
            SearchHeaderPanel.Controls.Add(SearchBox);
            SearchHeaderPanel.Controls.Add(RadioForDate);
            SearchHeaderPanel.Controls.Add(RadioForTransactionID);
            SearchHeaderPanel.Location = new Point(21, 55);
            SearchHeaderPanel.Name = "SearchHeaderPanel";
            SearchHeaderPanel.Size = new Size(460, 143);
            SearchHeaderPanel.TabIndex = 17;
            // 
            // SearchResultButton
            // 
            SearchResultButton.BackColor = Color.Orange;
            SearchResultButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchResultButton.ForeColor = Color.SeaShell;
            SearchResultButton.Location = new Point(189, 92);
            SearchResultButton.Name = "SearchResultButton";
            SearchResultButton.Size = new Size(103, 34);
            SearchResultButton.TabIndex = 19;
            SearchResultButton.Text = "Searc&h";
            SearchResultButton.UseVisualStyleBackColor = false;
            SearchResultButton.Click += SearchResultButton_Click;
            // 
            // ClearSearchButton
            // 
            ClearSearchButton.BackColor = Color.LightSkyBlue;
            ClearSearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClearSearchButton.ForeColor = SystemColors.Desktop;
            ClearSearchButton.Location = new Point(298, 93);
            ClearSearchButton.Name = "ClearSearchButton";
            ClearSearchButton.Size = new Size(103, 34);
            ClearSearchButton.TabIndex = 18;
            ClearSearchButton.Text = "C&lear";
            ClearSearchButton.UseVisualStyleBackColor = false;
            ClearSearchButton.Click += ClearSearchButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(17, 95);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(166, 31);
            SearchBox.TabIndex = 2;
            // 
            // RadioForDate
            // 
            RadioForDate.AutoSize = true;
            RadioForDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RadioForDate.ForeColor = Color.IndianRed;
            RadioForDate.Location = new Point(17, 49);
            RadioForDate.Name = "RadioForDate";
            RadioForDate.Size = new Size(166, 29);
            RadioForDate.TabIndex = 1;
            RadioForDate.TabStop = true;
            RadioForDate.Text = "Search By Date";
            RadioForDate.UseVisualStyleBackColor = true;
            // 
            // RadioForTransactionID
            // 
            RadioForTransactionID.AutoSize = true;
            RadioForTransactionID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RadioForTransactionID.ForeColor = Color.IndianRed;
            RadioForTransactionID.Location = new Point(17, 14);
            RadioForTransactionID.Name = "RadioForTransactionID";
            RadioForTransactionID.Size = new Size(249, 29);
            RadioForTransactionID.TabIndex = 0;
            RadioForTransactionID.TabStop = true;
            RadioForTransactionID.Text = "Search By Transaction ID";
            RadioForTransactionID.UseVisualStyleBackColor = true;
            // 
            // TransactionSearchLabel
            // 
            TransactionSearchLabel.AutoSize = true;
            TransactionSearchLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TransactionSearchLabel.ForeColor = SystemColors.ControlDarkDark;
            TransactionSearchLabel.Location = new Point(17, 15);
            TransactionSearchLabel.Name = "TransactionSearchLabel";
            TransactionSearchLabel.Size = new Size(241, 25);
            TransactionSearchLabel.TabIndex = 16;
            TransactionSearchLabel.Text = "Search Transaction Details:";
            // 
            // ClearAllButton
            // 
            ClearAllButton.BackColor = Color.Tomato;
            ClearAllButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClearAllButton.ForeColor = Color.SeaShell;
            ClearAllButton.Location = new Point(976, 2);
            ClearAllButton.Name = "ClearAllButton";
            ClearAllButton.Size = new Size(120, 32);
            ClearAllButton.TabIndex = 15;
            ClearAllButton.Text = "Clea&r All";
            ClearAllButton.UseVisualStyleBackColor = false;
            ClearAllButton.Click += ClearAllButton_Click;
            // 
            // OrderDetailsLabel
            // 
            OrderDetailsLabel.AutoSize = true;
            OrderDetailsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrderDetailsLabel.ForeColor = Color.FromArgb(64, 64, 64);
            OrderDetailsLabel.Location = new Point(173, 307);
            OrderDetailsLabel.Name = "OrderDetailsLabel";
            OrderDetailsLabel.Size = new Size(129, 25);
            OrderDetailsLabel.TabIndex = 14;
            OrderDetailsLabel.Text = "Order Details:";
            OrderDetailsLabel.Visible = false;
            // 
            // OrderDetailsPanel
            // 
            OrderDetailsPanel.BackColor = Color.SlateGray;
            OrderDetailsPanel.Controls.Add(DateResultField);
            OrderDetailsPanel.Controls.Add(TransactionIdResultField);
            OrderDetailsPanel.Controls.Add(PhoneTextField);
            OrderDetailsPanel.Controls.Add(EmailIdTextField);
            OrderDetailsPanel.Controls.Add(CustomerNameTextField);
            OrderDetailsPanel.Controls.Add(CustomerPhoneLabel);
            OrderDetailsPanel.Controls.Add(CustomerEmailLabel);
            OrderDetailsPanel.Controls.Add(DateLabel);
            OrderDetailsPanel.Controls.Add(TransactionIdLabel);
            OrderDetailsPanel.Controls.Add(CustomerNameLabel);
            OrderDetailsPanel.Location = new Point(170, 335);
            OrderDetailsPanel.Name = "OrderDetailsPanel";
            OrderDetailsPanel.Size = new Size(415, 217);
            OrderDetailsPanel.TabIndex = 13;
            OrderDetailsPanel.Visible = false;
            // 
            // DateResultField
            // 
            DateResultField.AutoSize = true;
            DateResultField.BackColor = Color.LightSkyBlue;
            DateResultField.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DateResultField.ForeColor = Color.SeaShell;
            DateResultField.Location = new Point(214, 43);
            DateResultField.Name = "DateResultField";
            DateResultField.Size = new Size(17, 25);
            DateResultField.TabIndex = 21;
            DateResultField.Text = ".";
            // 
            // TransactionIdResultField
            // 
            TransactionIdResultField.AutoSize = true;
            TransactionIdResultField.BackColor = Color.LightSkyBlue;
            TransactionIdResultField.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TransactionIdResultField.ForeColor = Color.SeaShell;
            TransactionIdResultField.Location = new Point(214, 5);
            TransactionIdResultField.Name = "TransactionIdResultField";
            TransactionIdResultField.Size = new Size(17, 25);
            TransactionIdResultField.TabIndex = 20;
            TransactionIdResultField.Text = ".";
            // 
            // PhoneTextField
            // 
            PhoneTextField.Location = new Point(214, 163);
            PhoneTextField.Name = "PhoneTextField";
            PhoneTextField.Size = new Size(150, 31);
            PhoneTextField.TabIndex = 19;
            // 
            // EmailIdTextField
            // 
            EmailIdTextField.Location = new Point(214, 122);
            EmailIdTextField.Name = "EmailIdTextField";
            EmailIdTextField.Size = new Size(150, 31);
            EmailIdTextField.TabIndex = 18;
            // 
            // CustomerNameTextField
            // 
            CustomerNameTextField.Location = new Point(214, 82);
            CustomerNameTextField.Name = "CustomerNameTextField";
            CustomerNameTextField.Size = new Size(150, 31);
            CustomerNameTextField.TabIndex = 17;
            // 
            // CustomerPhoneLabel
            // 
            CustomerPhoneLabel.AutoSize = true;
            CustomerPhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerPhoneLabel.ForeColor = Color.SeaShell;
            CustomerPhoneLabel.Location = new Point(3, 166);
            CustomerPhoneLabel.Name = "CustomerPhoneLabel";
            CustomerPhoneLabel.Size = new Size(146, 25);
            CustomerPhoneLabel.TabIndex = 16;
            CustomerPhoneLabel.Text = "Phone Number:";
            // 
            // CustomerEmailLabel
            // 
            CustomerEmailLabel.AutoSize = true;
            CustomerEmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerEmailLabel.ForeColor = Color.SeaShell;
            CustomerEmailLabel.Location = new Point(3, 125);
            CustomerEmailLabel.Name = "CustomerEmailLabel";
            CustomerEmailLabel.Size = new Size(87, 25);
            CustomerEmailLabel.TabIndex = 15;
            CustomerEmailLabel.Text = "Email ID:";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DateLabel.ForeColor = Color.SeaShell;
            DateLabel.Location = new Point(3, 52);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(57, 25);
            DateLabel.TabIndex = 14;
            DateLabel.Text = "Date:";
            // 
            // TransactionIdLabel
            // 
            TransactionIdLabel.AutoSize = true;
            TransactionIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TransactionIdLabel.ForeColor = Color.SeaShell;
            TransactionIdLabel.Location = new Point(3, 9);
            TransactionIdLabel.Name = "TransactionIdLabel";
            TransactionIdLabel.Size = new Size(140, 25);
            TransactionIdLabel.TabIndex = 13;
            TransactionIdLabel.Text = "Transaction ID:";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerNameLabel.ForeColor = Color.SeaShell;
            CustomerNameLabel.Location = new Point(3, 88);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(153, 25);
            CustomerNameLabel.TabIndex = 12;
            CustomerNameLabel.Text = "Customer Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 599);
            Controls.Add(BaseForm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "TV Retail";
            CartCheckoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TvLogo).EndInit();
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TvLogoSmall).EndInit();
            FormPanel.ResumeLayout(false);
            FormPanel.PerformLayout();
            BaseForm.ResumeLayout(false);
            BaseForm.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            SearchHeaderPanel.ResumeLayout(false);
            SearchHeaderPanel.PerformLayout();
            OrderDetailsPanel.ResumeLayout(false);
            OrderDetailsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label BrandListLabel;
        private Label SizeListLabel;
        private Panel CartCheckoutPanel;
        private PictureBox TvLogo;
        private Button CheckOutButton;
        private Button AddToCartButton;
        private Panel MenuPanel;
        private Button SearchButton;
        private Button ExitButton;
        private Button SummaryButton;
        private Button HomeButton;
        private PictureBox TvLogoSmall;
        private ListBox CartListBox;
        private Label CartListLabel;
        private Panel FormPanel;
        private ListBox BrandListBox;
        private TextBox CountTextBox;
        private Label CountLabel;
        private ListBox DisplaySizeListBox;
        private Panel BaseForm;
        private Button PlaceOrderButton;
        private Panel OrderDetailsPanel;
        private Label TransactionIdLabel;
        private Label CustomerNameLabel;
        private Label DateLabel;
        private Label CustomerEmailLabel;
        private Label CustomerPhoneLabel;
        private TextBox CustomerNameTextField;
        private TextBox EmailIdTextField;
        private TextBox PhoneTextField;
        private Label DateResultField;
        private Label TransactionIdResultField;
        private Label OrderDetailsLabel;
        private Button InventoryReportButton;
        private Button ClearAllButton;
        private Panel SearchPanel;
        private Label TransactionSearchLabel;
        private Panel SearchHeaderPanel;
        private RadioButton RadioForTransactionID;
        private RadioButton RadioForDate;
        private TextBox SearchBox;
        private Button ClearSearchButton;
        private Button SearchResultButton;
        private ListBox SearchResultBox;
    }
}