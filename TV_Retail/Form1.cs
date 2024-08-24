using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TV_Retail
{
    public partial class Form1 : Form
    {
        // Initializing the List Items
        readonly static string[] TvBrands = { "Sony", "Samsung", "Apple", "JVC", "MI", "Lenovo", "VU", "LG", "HP", "Dell", "Toshiba", "Hitachi", "Philips", "Asus", "Sonic" };
        readonly static string[] DisplaySize = { "24 inches(Small)", "32 inches(Compact)", "43 inches(Medium)", "55 inches(Large)", "65 inches(Extra Large)" };
        readonly static string[] DisplaySizeShortForm = { "S", "C", "M", "L", "EL" };
        readonly static decimal[,] Price = { { 500, 700, 900, 1000, 1500 }, { 400, 500, 700, 1000, 1100 }, { 700, 800, 1000, 1500, 1900 },
            { 500, 700, 900, 1000, 1500 }, { 400, 500, 700, 1000, 1100 }, { 600, 700, 750, 900, 950 }, { 500, 700, 900, 1000, 1500 }, { 400, 500, 700, 1000, 1100 }, { 600, 700, 750, 900, 950 },
        { 500, 700, 900, 1000, 1500 }, { 400, 500, 700, 1000, 1100 }, { 600, 700, 750, 900, 950 },{ 500, 700, 900, 1000, 1500 }, { 400, 500, 700, 1000, 1100 }, { 600, 700, 750, 900, 950 }};

        public static List<string[]> CartList { get; private set; } = new List<string[]>();
        public static List<string[]> DailyCartList { get; private set; } = new List<string[]>();
        DateTime CurrentDate = DateTime.Now;
        DateTime CurrentTime = DateTime.Now;
        int ProductCount = 0;
        string SelectedTvBrand;
        string SelectedDisplaySize;
        decimal SelectedProductPrice, SelectedOrderTotalPrice;
        string TransactionId, TransactionDate, CustomerName, TelephoneNumber, EmailID;
        public static decimal TotalPriceUptoTheDay { get; private set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }
        static void AddRecord(List<string[]> List, string Brand, string Size, decimal Price)
        {
            // Add a new record to the list
            List.Add(new string[] { Brand, Size, Price.ToString("C", CultureInfo.GetCultureInfo("en-EU")) });
        }

        // Function helps to add the items to cart
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (BrandListBox.SelectedIndex != -1)
            {
                SelectedTvBrand = TvBrands[BrandListBox.SelectedIndex];
                if (int.TryParse(CountTextBox.Text, out ProductCount) && ProductCount > 0)
                {
                    ProductCount = int.Parse(CountTextBox.Text);
                    // The conversion was successful, and ProductCount now holds the parsed value.

                    if (DisplaySizeListBox.SelectedIndex != -1)
                    {
                        string FilePath = "TV_Products_Inventory.txt";
                        SelectedDisplaySize = DisplaySize[DisplaySizeListBox.SelectedIndex];
                        SelectedProductPrice = Price[BrandListBox.SelectedIndex, DisplaySizeListBox.SelectedIndex];
                        // Read all lines from the file
                        string[] Lines = File.ReadAllLines(FilePath);
                        // Iterate through the lines and update the stock level when brand and size match
                        for (int i = 0; i < Lines.Length; i += 4)
                        {
                            string Brand = Lines[i];
                            string Size = Lines[i + 1];
                            decimal ProductPrice = decimal.Parse(Lines[i + 2]);

                            // Check if the brand and size match the criteria
                            if (Brand == SelectedTvBrand && Size == SelectedDisplaySize)
                            {
                                int StockLevel = int.Parse(Lines[i + 3]);
                                if (StockLevel > 0 && StockLevel >= ProductCount)
                                {
                                    for (int Counter = 1; Counter <= ProductCount; Counter++)
                                    {
                                        SelectedOrderTotalPrice += ProductPrice;
                                        AddRecord(CartList, SelectedTvBrand, SelectedDisplaySize, SelectedProductPrice);
                                        //  AddRecord(DailyCartList, SelectedTvBrand, SelectedDisplaySize, SelectedProductPrice);
                                        string Record = $"{SelectedTvBrand}  - {SelectedDisplaySize} - {SelectedProductPrice.ToString("C", CultureInfo.GetCultureInfo("en-EU"))}";

                                        // Add the record to the ListBox
                                        CartListBox.Items.Add(Record);
                                        CheckOutButton.Visible = true;
                                    }

                                }
                                else
                                {
                                    // Stock level is zero so not adding to cart
                                    string Title = "Product Out Of Stock!";
                                    string Message = $"Selected Product is Out of Stock!.\nProduct Name: {SelectedTvBrand}\n" +
                                        $"Display Size: {SelectedDisplaySize}.\n" +
                                        $"Remaining Quantity is {StockLevel}!";
                                    MessageBox.Show(Message, Title);
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Select Display Size");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Count Number", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select the Tv Brand");
            }
        }
        // Function helps to exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Function helps to add customer data
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            OrderDetailsLabel.Visible = true;
            OrderDetailsPanel.Visible = true;
            PlaceOrderButton.Visible = true;
            Random RandomNumber = new Random();
            int RandomValue = RandomNumber.Next(100, 1000);
            TransactionId = $"{CurrentDate:dd}{RandomValue:D4}";
            TransactionDate = $"{CurrentDate:dd/MM/yyyy}";
            TransactionIdResultField.Text = TransactionId;
            DateResultField.Text = TransactionDate;
        }
        // Function helps to place the order
        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CustomerNameTextField.Text))
            {
                CustomerName = CustomerNameTextField.Text;
                if (!string.IsNullOrEmpty(PhoneTextField.Text))
                {
                    TelephoneNumber = PhoneTextField.Text;
                    if (EmailIdTextField.Text.Contains("@"))
                    {
                        EmailID = EmailIdTextField.Text;
                        string CartItems = "";
                        string CartItemsInLine = "";
                        string joinedLineItem = "";
                        string MyCartItem = "";
                        foreach (string[] item in CartList)
                        {
                            CartItems += "Product Name: " + item[0] + "," +
                                         " " + "Size: " + item[1] + "," +
                                         " " + "Price: " + item[2] + Environment.NewLine;
                        }
                        foreach (string[] item in CartList)
                        {
                            CartItemsInLine += "Product Name: " + item[0] + "," +
                                         " " + "Size: " + item[1] + "," +
                                         " " + "Price: " + item[2];
                        }
                        if (!string.IsNullOrEmpty(CartItemsInLine))
                        {
                            joinedLineItem = string.Join("-", CartItemsInLine);
                        }
                        MyCartItem += (string.IsNullOrEmpty(MyCartItem) ? "" : "  |  ") + joinedLineItem;
                        //MyCartItem += ("|") + joinedLineItem;


                        DialogResult ConfirmationBox = MessageBox.Show("Do you like to Confirm this Order?" + Environment.NewLine + Environment.NewLine
                                + "Transaction ID:  " + TransactionId + Environment.NewLine
                                + "Email ID:  " + EmailID + Environment.NewLine
                                + "Date:  " + TransactionDate + Environment.NewLine
                                + "Customer Name:  " + CustomerName + Environment.NewLine
                                + "Telephone Number:  " + TelephoneNumber + Environment.NewLine
                                + CartItems + Environment.NewLine
                                + "Total Order Price:  " + SelectedOrderTotalPrice.ToString("C", CultureInfo.GetCultureInfo("en-EU")) + Environment.NewLine
                                , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (ConfirmationBox == DialogResult.Yes)
                        {
                            string FilePath = "TV_Products_Inventory.txt";
                            string[] Lines = File.ReadAllLines(FilePath);

                            // Transaction File Initialization
                            StreamWriter WriteFile = File.AppendText("TransactionDetails.txt");
                            WriteFile.WriteLine(TransactionId);
                            WriteFile.WriteLine(EmailID);
                            WriteFile.WriteLine(TransactionDate);
                            WriteFile.WriteLine(CustomerName);
                            WriteFile.WriteLine(TelephoneNumber);
                            WriteFile.WriteLine(MyCartItem);
                            // Iterate through the brand and size pairs to update
                            foreach (var BrandAndSize in CartList)
                            {
                                string BrandToSearch = BrandAndSize[0];
                                string SizeToSearch = BrandAndSize[1];

                                // Iterate through the lines and update the stock level when brand and size match
                                for (int i = 0; i < Lines.Length; i += 4)
                                {
                                    string Brand = Lines[i];
                                    string Size = Lines[i + 1];

                                    // Check if the brand and size match the criteria
                                    if (Brand == BrandToSearch && Size == SizeToSearch)
                                    {
                                        int StockLevel = int.Parse(Lines[i + 3]);
                                        StockLevel--; // Decrease stock level by 1

                                        Lines[i + 3] = StockLevel.ToString();
                                    }
                                }
                            }

                            WriteFile.WriteLine(SelectedOrderTotalPrice.ToString("C", CultureInfo.GetCultureInfo("en-EU")));
                            MessageBox.Show("Order Placed Successfully!");
                            foreach (string[] cartItem in CartList)
                            {
                                string[] copiedCartItem = new string[cartItem.Length];
                                Array.Copy(cartItem, copiedCartItem, cartItem.Length);
                                DailyCartList.Add(copiedCartItem);
                            }
                            CartList.Clear();
                            CartListBox.Items.Clear();
                            TotalPriceUptoTheDay += SelectedOrderTotalPrice;
                            SelectedOrderTotalPrice = 0m;
                            ProductCount = 0;
                            BrandListBox.ClearSelected();
                            DisplaySizeListBox.ClearSelected();
                            CheckOutButton.Visible = false;
                            OrderDetailsPanel.Visible = false;
                            OrderDetailsLabel.Visible = false;
                            CustomerNameTextField.Clear();
                            CustomerNameTextField.Clear();
                            EmailIdTextField.Clear();
                            PhoneTextField.Clear();
                            DateResultField.Text = string.Empty;
                            TransactionIdResultField.Text = string.Empty;
                            PlaceOrderButton.Visible = false;
                            File.WriteAllLines(FilePath, Lines);
                            WriteFile.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Email ID", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Phone Number", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Customer Name", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Function helps to generate stock level report
        private void InventoryReportButton_Click(object sender, EventArgs e)
        {
            int BrandCount = TvBrands.Length;
            int DisplaySizeCount = DisplaySize.Length;
            decimal[,] StockLevels = new decimal[BrandCount, DisplaySizeCount];
            try
            {
                string FilePath = "TV_Products_Inventory.txt";
                // Read all lines from the file
                string[] Lines = File.ReadAllLines(FilePath);
                // Iterate through the lines and update the stock level when brand and size match
                for (int i = 0; i < Lines.Length; i += 4)
                {
                    string Brand = Lines[i];
                    string Size = Lines[i + 1];
                    decimal StockLevel = decimal.Parse(Lines[i + 3]);

                    int BrandIndex = Array.IndexOf(TvBrands, Brand);
                    int SizeIndex = Array.IndexOf(DisplaySize, Size);

                    if (BrandIndex != -1 && SizeIndex != -1)
                    {
                        StockLevels[BrandIndex, SizeIndex] = StockLevel;
                    }
                }
                // Write file

                string ReportFilePath = "StockReport.txt";
                using (StreamWriter Writer = new StreamWriter(ReportFilePath))
                {
                    // Write header
                    Writer.Write("  \t");
                    for (int sizeIndex = 0; sizeIndex < DisplaySizeCount; sizeIndex++)
                    {
                        Writer.Write($"{DisplaySizeShortForm[sizeIndex]}\t");
                    }
                    Writer.WriteLine();

                    // Write data
                    for (int brandIndex = 0; brandIndex < BrandCount; brandIndex++)
                    {
                        Writer.Write($"{TvBrands[brandIndex]}\t");
                        for (int sizeIndex = 0; sizeIndex < DisplaySizeCount; sizeIndex++)
                        {
                            Writer.Write($"{StockLevels[brandIndex, sizeIndex]}\t");
                        }
                        Writer.WriteLine();
                    }
                    Writer.WriteLine();
                    Writer.WriteLine();
                    Writer.WriteLine($"TV Retail Stock Report\t");
                    Writer.WriteLine($"Generation Time: {CurrentTime}\t");
                    Writer.Close();
                    MessageBox.Show("Report generated Successfully, Please check the StockReport File!");
                }
            }
            catch
            {

                MessageBox.Show("Something went wrong with the Inventory Generation Report", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Function helps to reset the forms
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            CartList.Clear();
            CartListBox.Items.Clear();
            SelectedOrderTotalPrice = 0m;
            BrandListBox.ClearSelected();
            DisplaySizeListBox.ClearSelected();
            CountTextBox.Clear();
            PlaceOrderButton.Visible = false;
            OrderDetailsLabel.Visible = false;
            CheckOutButton.Visible = false;
            ProductCount = 0;
            OrderDetailsPanel.Visible = false;

            CustomerNameTextField.Clear();
            EmailIdTextField.Clear();
            PhoneTextField.Clear();
            DateResultField.Text = string.Empty;
            TransactionIdResultField.Text = string.Empty;

        }
        // Function helps to open search panel
        private void SearchButton_Click(object sender, EventArgs e)
        {
            FormPanel.Visible = false;
            BrandListLabel.Visible = false;
            SizeListLabel.Visible = false;
            CartListLabel.Visible = false;
            CartListBox.Visible = false;
            OrderDetailsLabel.Visible = false;
            OrderDetailsPanel.Visible = false;
            ClearAllButton.Visible = false;
            SearchPanel.Visible = true;

        }
        // Function helps to reset the form and display landing page
        private void HomeButton_Click(object sender, EventArgs e)
        {
            CheckOutButton.Visible = false;
            FormPanel.Visible = true;
            BrandListLabel.Visible = true;
            SizeListLabel.Visible = true;
            CartListLabel.Visible = true;
            CartListBox.Visible = true;
            ClearAllButton.Visible = true;
            SearchPanel.Visible = false;
            PlaceOrderButton.Visible = false;

            CartList.Clear();
            CartListBox.Items.Clear();
            SelectedOrderTotalPrice = 0m;
            BrandListBox.ClearSelected();
            DisplaySizeListBox.ClearSelected();
            CountTextBox.Clear();
            OrderDetailsLabel.Visible = false;
            CheckOutButton.Visible = false;
            ProductCount = 0;
            OrderDetailsPanel.Visible = false;

            CustomerNameTextField.Clear();
            EmailIdTextField.Clear();
            PhoneTextField.Clear();
            DateResultField.Text = string.Empty;
            TransactionIdResultField.Text = string.Empty;
        }
        // Function helps to open new form and show daily report
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            DailySalesReport Item = new DailySalesReport();
            // ReceivedCartList = CartList;
            Item.Show();

        }
        // Function helps to search the transaction
        private void SearchResultButton_Click(object sender, EventArgs e)
        {
            string SearchTarget;
            string TransactionNumber, Date, Email;
            bool ResultMatched = false;
            StreamReader DataStream = null;
            if (SearchBox.Text.Length > 0)
            {
                SearchTarget = SearchBox.Text;
                try
                {
                    DataStream = File.OpenText("TransactionDetails.txt");

                    while (!DataStream.EndOfStream)
                    {
                        TransactionNumber = DataStream.ReadLine();
                        Email = DataStream.ReadLine();
                        Date = DataStream.ReadLine();

                        if (RadioForTransactionID.Checked)
                        {
                            ResultMatched = SearchBox.Text.Equals(TransactionNumber, StringComparison.OrdinalIgnoreCase);
                        }
                        else if (RadioForDate.Checked)
                        {
                            ResultMatched = SearchBox.Text.Equals(Date, StringComparison.OrdinalIgnoreCase);
                        }

                        if (ResultMatched)
                        {
                            // adding all the fetched data to the panel
                            SearchResultBox.Items.Add("Transaction ID:\t" + TransactionNumber);
                            SearchResultBox.Items.Add("Email ID:\t" + Email);
                            SearchResultBox.Items.Add("Date:\t" + Date);
                            SearchResultBox.Items.Add("Customer Name:\t" + DataStream.ReadLine());
                            SearchResultBox.Items.Add("Telephone Number:\t" + DataStream.ReadLine());
                            SearchResultBox.Items.Add("Order List:\t" + DataStream.ReadLine());
                            SearchResultBox.Items.Add("Total Price:\t" + DataStream.ReadLine());
                            SearchResultBox.Items.Add("#### ####### ########### ####### ######## ######");
                        }
                        else
                        {
                            for (int LineNum = 4; LineNum <= 7; LineNum++)
                            {
                                DataStream.ReadLine();
                            }
                        }
                    }
                    DataStream.Close();
                    SearchResultButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Match Found" + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter Valid input in Search field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Function helps to clear search result
        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            SearchResultButton.Enabled = true;
            ClearSearchButton.Focus();
            for (int i = SearchResultBox.Items.Count - 1; i >= 0; i--)
            {
                SearchResultBox.Items.RemoveAt(i);
            }
        }
    }
}
