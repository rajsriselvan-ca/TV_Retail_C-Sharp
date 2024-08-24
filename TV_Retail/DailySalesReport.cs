using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Retail
{

    public partial class DailySalesReport : Form
    {
        public DailySalesReport()
        {
            InitializeComponent();
        }

        private void DailySalesReport_Load(object sender, EventArgs e)
        {
            List<string[]> ListReceived = Form1.DailyCartList;

            ReportListBox.Items.Clear();

            // Iterate through ListReceived and add each item to the ListBox
            foreach (string[] item in ListReceived)
            {
                string formattedItem = string.Join(", ", item);

                // Add the formatted item to the ListBox
                ReportListBox.Items.Add(formattedItem);
            }

            TotalDailyPriceResult.Text = Form1.TotalPriceUptoTheDay.ToString();
        }

        private void ExitReportButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
