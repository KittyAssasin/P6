namespace Builder
{
    partial class FormIssueRecord
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
            this.lblIdText = new System.Windows.Forms.Label();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.lblDiscoveryText = new System.Windows.Forms.Label();
            this.lblDiscovererText = new System.Windows.Forms.Label();
            this.lblComponentText = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerDiscoveryDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDiscoverer = new System.Windows.Forms.ComboBox();
            this.txtBoxComponent = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdText
            // 
            this.lblIdText.AutoSize = true;
            this.lblIdText.Location = new System.Drawing.Point(153, 63);
            this.lblIdText.Name = "lblIdText";
            this.lblIdText.Size = new System.Drawing.Size(34, 25);
            this.lblIdText.TabIndex = 0;
            this.lblIdText.Text = "Id:";
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Location = new System.Drawing.Point(132, 102);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(55, 25);
            this.lblTitleText.TabIndex = 1;
            this.lblTitleText.Text = "Title:";
            // 
            // lblDiscoveryText
            // 
            this.lblDiscoveryText.AutoSize = true;
            this.lblDiscoveryText.Location = new System.Drawing.Point(37, 141);
            this.lblDiscoveryText.Name = "lblDiscoveryText";
            this.lblDiscoveryText.Size = new System.Drawing.Size(150, 25);
            this.lblDiscoveryText.TabIndex = 2;
            this.lblDiscoveryText.Text = "Discovery Date:";
            // 
            // lblDiscovererText
            // 
            this.lblDiscovererText.AutoSize = true;
            this.lblDiscovererText.Location = new System.Drawing.Point(76, 182);
            this.lblDiscovererText.Name = "lblDiscovererText";
            this.lblDiscovererText.Size = new System.Drawing.Size(111, 25);
            this.lblDiscovererText.TabIndex = 3;
            this.lblDiscovererText.Text = "Discoverer:";
            // 
            // lblComponentText
            // 
            this.lblComponentText.AutoSize = true;
            this.lblComponentText.Location = new System.Drawing.Point(67, 223);
            this.lblComponentText.Name = "lblComponentText";
            this.lblComponentText.Size = new System.Drawing.Size(120, 25);
            this.lblComponentText.TabIndex = 4;
            this.lblComponentText.Text = "Component:";
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(113, 268);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(74, 25);
            this.lblStatusText.TabIndex = 5;
            this.lblStatusText.Text = "Status:";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(193, 60);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxId.ShortcutsEnabled = false;
            this.txtBoxId.Size = new System.Drawing.Size(76, 29);
            this.txtBoxId.TabIndex = 6;
            this.txtBoxId.Text = "-1";
            this.txtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(193, 99);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(425, 29);
            this.txtBoxTitle.TabIndex = 7;
            // 
            // dateTimePickerDiscoveryDate
            // 
            this.dateTimePickerDiscoveryDate.Location = new System.Drawing.Point(193, 141);
            this.dateTimePickerDiscoveryDate.Name = "dateTimePickerDiscoveryDate";
            this.dateTimePickerDiscoveryDate.Size = new System.Drawing.Size(425, 29);
            this.dateTimePickerDiscoveryDate.TabIndex = 8;
            // 
            // comboBoxDiscoverer
            // 
            this.comboBoxDiscoverer.FormattingEnabled = true;
            this.comboBoxDiscoverer.Location = new System.Drawing.Point(193, 182);
            this.comboBoxDiscoverer.Name = "comboBoxDiscoverer";
            this.comboBoxDiscoverer.Size = new System.Drawing.Size(425, 32);
            this.comboBoxDiscoverer.TabIndex = 9;
            // 
            // txtBoxComponent
            // 
            this.txtBoxComponent.Location = new System.Drawing.Point(193, 223);
            this.txtBoxComponent.Name = "txtBoxComponent";
            this.txtBoxComponent.Size = new System.Drawing.Size(425, 29);
            this.txtBoxComponent.TabIndex = 10;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(193, 268);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(425, 32);
            this.comboBoxStatus.TabIndex = 11;
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.AutoSize = true;
            this.lblDescriptionText.Location = new System.Drawing.Point(37, 364);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(158, 25);
            this.lblDescriptionText.TabIndex = 12;
            this.lblDescriptionText.Text = "Initial Description";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(72, 401);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(546, 326);
            this.txtBoxDescription.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(72, 771);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 61);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreateIssue
            // 
            this.btnCreateIssue.Location = new System.Drawing.Point(413, 771);
            this.btnCreateIssue.Name = "btnCreateIssue";
            this.btnCreateIssue.Size = new System.Drawing.Size(205, 61);
            this.btnCreateIssue.TabIndex = 15;
            this.btnCreateIssue.Text = "Create Issue";
            this.btnCreateIssue.UseVisualStyleBackColor = true;
            // 
            // FormIssueRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 868);
            this.Controls.Add(this.btnCreateIssue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.lblDescriptionText);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.txtBoxComponent);
            this.Controls.Add(this.comboBoxDiscoverer);
            this.Controls.Add(this.dateTimePickerDiscoveryDate);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.lblComponentText);
            this.Controls.Add(this.lblDiscovererText);
            this.Controls.Add(this.lblDiscoveryText);
            this.Controls.Add(this.lblTitleText);
            this.Controls.Add(this.lblIdText);
            this.Name = "FormIssueRecord";
            this.Text = "Record Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdText;
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Label lblDiscoveryText;
        private System.Windows.Forms.Label lblDiscovererText;
        private System.Windows.Forms.Label lblComponentText;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiscoveryDate;
        private System.Windows.Forms.ComboBox comboBoxDiscoverer;
        private System.Windows.Forms.TextBox txtBoxComponent;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblDescriptionText;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateIssue;
    }
}