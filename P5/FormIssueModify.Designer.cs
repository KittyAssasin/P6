namespace Builder
{
    partial class FormIssueModify
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
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblDiscoveryDateText = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDiscovererText = new System.Windows.Forms.Label();
            this.comboBoxDiscoverer = new System.Windows.Forms.ComboBox();
            this.lblComponentText = new System.Windows.Forms.Label();
            this.txtBoxComponent = new System.Windows.Forms.TextBox();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblInitialDescriptionText = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(193, 60);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(100, 29);
            this.txtBoxId.TabIndex = 1;
            this.txtBoxId.Text = "-1";
            this.txtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Location = new System.Drawing.Point(132, 102);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(55, 25);
            this.lblTitleText.TabIndex = 2;
            this.lblTitleText.Text = "Title:";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(193, 99);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(425, 29);
            this.txtBoxTitle.TabIndex = 3;
            // 
            // lblDiscoveryDateText
            // 
            this.lblDiscoveryDateText.AutoSize = true;
            this.lblDiscoveryDateText.Location = new System.Drawing.Point(37, 141);
            this.lblDiscoveryDateText.Name = "lblDiscoveryDateText";
            this.lblDiscoveryDateText.Size = new System.Drawing.Size(150, 25);
            this.lblDiscoveryDateText.TabIndex = 4;
            this.lblDiscoveryDateText.Text = "Discovery Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(193, 141);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(425, 29);
            this.dateTimePicker.TabIndex = 5;
            // 
            // lblDiscovererText
            // 
            this.lblDiscovererText.AutoSize = true;
            this.lblDiscovererText.Location = new System.Drawing.Point(76, 182);
            this.lblDiscovererText.Name = "lblDiscovererText";
            this.lblDiscovererText.Size = new System.Drawing.Size(111, 25);
            this.lblDiscovererText.TabIndex = 6;
            this.lblDiscovererText.Text = "Discoverer:";
            // 
            // comboBoxDiscoverer
            // 
            this.comboBoxDiscoverer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverer.FormattingEnabled = true;
            this.comboBoxDiscoverer.Location = new System.Drawing.Point(193, 182);
            this.comboBoxDiscoverer.Name = "comboBoxDiscoverer";
            this.comboBoxDiscoverer.Size = new System.Drawing.Size(425, 32);
            this.comboBoxDiscoverer.TabIndex = 7;
            // 
            // lblComponentText
            // 
            this.lblComponentText.AutoSize = true;
            this.lblComponentText.Location = new System.Drawing.Point(67, 223);
            this.lblComponentText.Name = "lblComponentText";
            this.lblComponentText.Size = new System.Drawing.Size(120, 25);
            this.lblComponentText.TabIndex = 8;
            this.lblComponentText.Text = "Component:";
            // 
            // txtBoxComponent
            // 
            this.txtBoxComponent.Location = new System.Drawing.Point(193, 223);
            this.txtBoxComponent.Name = "txtBoxComponent";
            this.txtBoxComponent.Size = new System.Drawing.Size(425, 29);
            this.txtBoxComponent.TabIndex = 9;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(113, 268);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(74, 25);
            this.lblStatusText.TabIndex = 10;
            this.lblStatusText.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(193, 268);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(425, 32);
            this.comboBoxStatus.TabIndex = 11;
            // 
            // lblInitialDescriptionText
            // 
            this.lblInitialDescriptionText.AutoSize = true;
            this.lblInitialDescriptionText.Location = new System.Drawing.Point(37, 364);
            this.lblInitialDescriptionText.Name = "lblInitialDescriptionText";
            this.lblInitialDescriptionText.Size = new System.Drawing.Size(158, 25);
            this.lblInitialDescriptionText.TabIndex = 12;
            this.lblInitialDescriptionText.Text = "Initial Description";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(72, 401);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(546, 326);
            this.txtBoxDescription.TabIndex = 13;
            // 
            // btnModify
            // 
            this.btnModify.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModify.Location = new System.Drawing.Point(413, 771);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(205, 61);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modify Issue";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(72, 771);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 61);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormIssueModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 868);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.lblInitialDescriptionText);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.txtBoxComponent);
            this.Controls.Add(this.lblComponentText);
            this.Controls.Add(this.comboBoxDiscoverer);
            this.Controls.Add(this.lblDiscovererText);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDiscoveryDateText);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lblTitleText);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.lblIdText);
            this.Name = "FormIssueModify";
            this.Text = "Modify Issue";
            this.Load += new System.EventHandler(this.FormIssueModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdText;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblDiscoveryDateText;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDiscovererText;
        private System.Windows.Forms.ComboBox comboBoxDiscoverer;
        private System.Windows.Forms.Label lblComponentText;
        private System.Windows.Forms.TextBox txtBoxComponent;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblInitialDescriptionText;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
    }
}