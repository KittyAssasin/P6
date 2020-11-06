namespace Builder
{
    partial class FormIssueDashboard
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalIssuesText = new System.Windows.Forms.Label();
            this.lblTotalIssuesNumber = new System.Windows.Forms.Label();
            this.lblIssuesMonthText = new System.Windows.Forms.Label();
            this.lstBoxIssuesbyMonth = new System.Windows.Forms.ListBox();
            this.lblIssuesDiscovererText = new System.Windows.Forms.Label();
            this.lstBoxIssuebyDiscoverer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(406, 720);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalIssuesText
            // 
            this.lblTotalIssuesText.AutoSize = true;
            this.lblTotalIssuesText.Location = new System.Drawing.Point(86, 52);
            this.lblTotalIssuesText.Name = "lblTotalIssuesText";
            this.lblTotalIssuesText.Size = new System.Drawing.Size(219, 25);
            this.lblTotalIssuesText.TabIndex = 1;
            this.lblTotalIssuesText.Text = "Total Number of Issues:";
            // 
            // lblTotalIssuesNumber
            // 
            this.lblTotalIssuesNumber.AutoSize = true;
            this.lblTotalIssuesNumber.Location = new System.Drawing.Point(311, 52);
            this.lblTotalIssuesNumber.Name = "lblTotalIssuesNumber";
            this.lblTotalIssuesNumber.Size = new System.Drawing.Size(30, 25);
            this.lblTotalIssuesNumber.TabIndex = 2;
            this.lblTotalIssuesNumber.Text = "-1";
            // 
            // lblIssuesMonthText
            // 
            this.lblIssuesMonthText.AutoSize = true;
            this.lblIssuesMonthText.Location = new System.Drawing.Point(86, 112);
            this.lblIssuesMonthText.Name = "lblIssuesMonthText";
            this.lblIssuesMonthText.Size = new System.Drawing.Size(155, 25);
            this.lblIssuesMonthText.TabIndex = 3;
            this.lblIssuesMonthText.Text = "Issues by Month";
            // 
            // lstBoxIssuesbyMonth
            // 
            this.lstBoxIssuesbyMonth.FormattingEnabled = true;
            this.lstBoxIssuesbyMonth.ItemHeight = 24;
            this.lstBoxIssuesbyMonth.Location = new System.Drawing.Point(91, 140);
            this.lstBoxIssuesbyMonth.Name = "lstBoxIssuesbyMonth";
            this.lstBoxIssuesbyMonth.Size = new System.Drawing.Size(435, 244);
            this.lstBoxIssuesbyMonth.TabIndex = 4;
            // 
            // lblIssuesDiscovererText
            // 
            this.lblIssuesDiscovererText.AutoSize = true;
            this.lblIssuesDiscovererText.Location = new System.Drawing.Point(86, 414);
            this.lblIssuesDiscovererText.Name = "lblIssuesDiscovererText";
            this.lblIssuesDiscovererText.Size = new System.Drawing.Size(193, 25);
            this.lblIssuesDiscovererText.TabIndex = 5;
            this.lblIssuesDiscovererText.Text = "Issues by Discoverer";
            // 
            // lstBoxIssuebyDiscoverer
            // 
            this.lstBoxIssuebyDiscoverer.FormattingEnabled = true;
            this.lstBoxIssuebyDiscoverer.ItemHeight = 24;
            this.lstBoxIssuebyDiscoverer.Location = new System.Drawing.Point(81, 442);
            this.lstBoxIssuebyDiscoverer.Name = "lstBoxIssuebyDiscoverer";
            this.lstBoxIssuebyDiscoverer.Size = new System.Drawing.Size(445, 244);
            this.lstBoxIssuebyDiscoverer.TabIndex = 6;
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 810);
            this.Controls.Add(this.lstBoxIssuebyDiscoverer);
            this.Controls.Add(this.lblIssuesDiscovererText);
            this.Controls.Add(this.lstBoxIssuesbyMonth);
            this.Controls.Add(this.lblIssuesMonthText);
            this.Controls.Add(this.lblTotalIssuesNumber);
            this.Controls.Add(this.lblTotalIssuesText);
            this.Controls.Add(this.btnClose);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormIssueDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalIssuesText;
        private System.Windows.Forms.Label lblTotalIssuesNumber;
        private System.Windows.Forms.Label lblIssuesMonthText;
        private System.Windows.Forms.ListBox lstBoxIssuesbyMonth;
        private System.Windows.Forms.Label lblIssuesDiscovererText;
        private System.Windows.Forms.ListBox lstBoxIssuebyDiscoverer;
    }
}