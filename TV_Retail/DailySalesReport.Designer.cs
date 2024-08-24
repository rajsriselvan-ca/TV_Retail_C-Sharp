namespace TV_Retail
{
    partial class DailySalesReport
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
            ExitReportButton = new Button();
            TotalPriceLabel = new Label();
            TotalDailyPriceResult = new Label();
            ReportListBox = new ListBox();
            SuspendLayout();
            // 
            // ExitReportButton
            // 
            ExitReportButton.BackColor = Color.OrangeRed;
            ExitReportButton.Location = new Point(646, 393);
            ExitReportButton.Name = "ExitReportButton";
            ExitReportButton.Size = new Size(112, 34);
            ExitReportButton.TabIndex = 1;
            ExitReportButton.Text = "E&xit";
            ExitReportButton.UseVisualStyleBackColor = false;
            ExitReportButton.Click += ExitReportButton_Click;
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalPriceLabel.Location = new Point(188, 324);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(232, 25);
            TotalPriceLabel.TabIndex = 2;
            TotalPriceLabel.Text = "Total Price Upto this time:";
            // 
            // TotalDailyPriceResult
            // 
            TotalDailyPriceResult.AutoSize = true;
            TotalDailyPriceResult.Location = new Point(455, 324);
            TotalDailyPriceResult.Name = "TotalDailyPriceResult";
            TotalDailyPriceResult.Size = new Size(59, 25);
            TotalDailyPriceResult.TabIndex = 3;
            TotalDailyPriceResult.Text = "label1";
            // 
            // ReportListBox
            // 
            ReportListBox.BackColor = SystemColors.Info;
            ReportListBox.FormattingEnabled = true;
            ReportListBox.ItemHeight = 25;
            ReportListBox.Location = new Point(141, 60);
            ReportListBox.Name = "ReportListBox";
            ReportListBox.Size = new Size(471, 254);
            ReportListBox.TabIndex = 4;
            // 
            // DailySalesReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReportListBox);
            Controls.Add(TotalDailyPriceResult);
            Controls.Add(TotalPriceLabel);
            Controls.Add(ExitReportButton);
            Name = "DailySalesReport";
            Text = "DailySalesReport";
            Load += DailySalesReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExitReportButton;
        private Label TotalPriceLabel;
        private Label TotalDailyPriceResult;
        private ListBox ReportListBox;
    }
}