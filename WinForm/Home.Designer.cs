using System.ComponentModel;
using Libraries.Entities;

namespace WinForm
{
    partial class Home
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            customersGridView = new DataGridView();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            ageLabel = new Label();
            ageTextBox = new TextBox();
            amountOwedLabel = new Label();
            amountOwedTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            newCustomerBox = new GroupBox();
            submitButton = new Button();
            cancelButton = new Button();
            customersQueueGroupBox = new GroupBox();
            updateCircularQueueSizeButton = new Button();
            circularQueueSizeTextBox = new TextBox();
            circularQueueSizeLabel = new Label();
            makeCircularQueueCheckBox = new CheckBox();
            enqueueCustomerButton = new Button();
            dequeueCustomerButton = new Button();
            totalAmountOwedTextBox = new TextBox();
            totalAmountOwedLabel = new Label();
            totalCustomerTextBox = new TextBox();
            totalCustomersLabel = new Label();
            dequeuedCustomerGroupBox = new GroupBox();
            dequeuedCustomerNameTextBox = new TextBox();
            dequeuedCustomerNameLabel = new Label();
            dequeuedCustomerAgeLabel = new Label();
            dequeuedCustomerAgeTextBox = new TextBox();
            dequeuedCustomerAmountOwedLabel = new Label();
            dequeuedCustomerAmountOwedTextBox = new TextBox();
            dequeuedCustomerAddressLabel = new Label();
            dequeuedCustomerAddressTextBox = new TextBox();
            closeDequeuedCustomerViewButton = new Button();
            ((ISupportInitialize)customersGridView).BeginInit();
            newCustomerBox.SuspendLayout();
            customersQueueGroupBox.SuspendLayout();
            dequeuedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // customersGridView
            // 
            customersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            customersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            customersGridView.Location = new Point(22, 51);
            customersGridView.Name = "customersGridView";
            customersGridView.ReadOnly = true;
            customersGridView.Size = new Size(487, 226);
            customersGridView.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(112, 50);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(336, 23);
            nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameLabel.Location = new Point(54, 53);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(43, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ageLabel.Location = new Point(54, 142);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(32, 15);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(112, 139);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(119, 23);
            ageTextBox.TabIndex = 4;
            // 
            // amountOwedLabel
            // 
            amountOwedLabel.AutoSize = true;
            amountOwedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            amountOwedLabel.Location = new Point(235, 145);
            amountOwedLabel.Name = "amountOwedLabel";
            amountOwedLabel.Size = new Size(91, 15);
            amountOwedLabel.TabIndex = 7;
            amountOwedLabel.Text = "Amount Owed:";
            // 
            // amountOwedTextBox
            // 
            amountOwedTextBox.Location = new Point(329, 142);
            amountOwedTextBox.Name = "amountOwedTextBox";
            amountOwedTextBox.Size = new Size(119, 23);
            amountOwedTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addressLabel.Location = new Point(54, 95);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(54, 15);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressTextBox.Location = new Point(112, 92);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(336, 23);
            addressTextBox.TabIndex = 8;
            // 
            // newCustomerBox
            // 
            newCustomerBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newCustomerBox.BackColor = SystemColors.GradientActiveCaption;
            newCustomerBox.Controls.Add(submitButton);
            newCustomerBox.Controls.Add(nameTextBox);
            newCustomerBox.Controls.Add(nameLabel);
            newCustomerBox.Controls.Add(ageLabel);
            newCustomerBox.Controls.Add(ageTextBox);
            newCustomerBox.Controls.Add(amountOwedLabel);
            newCustomerBox.Controls.Add(amountOwedTextBox);
            newCustomerBox.Controls.Add(addressLabel);
            newCustomerBox.Controls.Add(addressTextBox);
            newCustomerBox.Controls.Add(cancelButton);
            newCustomerBox.FlatStyle = FlatStyle.Popup;
            newCustomerBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            newCustomerBox.Location = new Point(40, 28);
            newCustomerBox.Name = "newCustomerBox";
            newCustomerBox.Size = new Size(476, 274);
            newCustomerBox.TabIndex = 10;
            newCustomerBox.TabStop = false;
            newCustomerBox.Text = "New Customer";
            // 
            // submitButton
            // 
            submitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submitButton.BackColor = Color.LimeGreen;
            submitButton.FlatStyle = FlatStyle.Popup;
            submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            submitButton.ForeColor = SystemColors.Control;
            submitButton.Location = new Point(270, 194);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(127, 43);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += EnqueueCustomerButtonClick;
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.BackColor = Color.Red;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cancelButton.ForeColor = SystemColors.HighlightText;
            cancelButton.Location = new Point(124, 194);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(127, 43);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Clear Form";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CloseEnqueueCustomerView;
            // 
            // customersQueueGroupBox
            // 
            customersQueueGroupBox.BackColor = Color.LightSkyBlue;
            customersQueueGroupBox.Controls.Add(updateCircularQueueSizeButton);
            customersQueueGroupBox.Controls.Add(circularQueueSizeTextBox);
            customersQueueGroupBox.Controls.Add(circularQueueSizeLabel);
            customersQueueGroupBox.Controls.Add(makeCircularQueueCheckBox);
            customersQueueGroupBox.Controls.Add(enqueueCustomerButton);
            customersQueueGroupBox.Controls.Add(dequeueCustomerButton);
            customersQueueGroupBox.Controls.Add(totalAmountOwedTextBox);
            customersQueueGroupBox.Controls.Add(totalAmountOwedLabel);
            customersQueueGroupBox.Controls.Add(totalCustomerTextBox);
            customersQueueGroupBox.Controls.Add(totalCustomersLabel);
            customersQueueGroupBox.Controls.Add(customersGridView);
            customersQueueGroupBox.Location = new Point(40, 28);
            customersQueueGroupBox.Name = "customersQueueGroupBox";
            customersQueueGroupBox.Size = new Size(534, 393);
            customersQueueGroupBox.TabIndex = 12;
            customersQueueGroupBox.TabStop = false;
            customersQueueGroupBox.Text = "Customers Queue";
            // 
            // updateCircularQueueSizeButton
            // 
            updateCircularQueueSizeButton.BackColor = Color.PowderBlue;
            updateCircularQueueSizeButton.FlatStyle = FlatStyle.Popup;
            updateCircularQueueSizeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateCircularQueueSizeButton.Location = new Point(412, 17);
            updateCircularQueueSizeButton.Name = "updateCircularQueueSizeButton";
            updateCircularQueueSizeButton.Size = new Size(85, 28);
            updateCircularQueueSizeButton.TabIndex = 12;
            updateCircularQueueSizeButton.Text = "Update Size";
            updateCircularQueueSizeButton.UseVisualStyleBackColor = false;
            updateCircularQueueSizeButton.Click += UpdateCircularQueueSizeButtonClick;
            // 
            // circularQueueSizeTextBox
            // 
            circularQueueSizeTextBox.Location = new Point(306, 17);
            circularQueueSizeTextBox.Name = "circularQueueSizeTextBox";
            circularQueueSizeTextBox.Size = new Size(100, 23);
            circularQueueSizeTextBox.TabIndex = 11;
            // 
            // circularQueueSizeLabel
            // 
            circularQueueSizeLabel.AutoSize = true;
            circularQueueSizeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            circularQueueSizeLabel.Location = new Point(162, 20);
            circularQueueSizeLabel.Name = "circularQueueSizeLabel";
            circularQueueSizeLabel.Size = new Size(146, 20);
            circularQueueSizeLabel.TabIndex = 10;
            circularQueueSizeLabel.Text = "Circular Queue Size:";
            // 
            // makeCircularQueueCheckBox
            // 
            makeCircularQueueCheckBox.AutoSize = true;
            makeCircularQueueCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            makeCircularQueueCheckBox.Location = new Point(23, 22);
            makeCircularQueueCheckBox.Name = "makeCircularQueueCheckBox";
            makeCircularQueueCheckBox.Size = new Size(142, 19);
            makeCircularQueueCheckBox.TabIndex = 9;
            makeCircularQueueCheckBox.Text = "Make Queue Circular";
            makeCircularQueueCheckBox.UseVisualStyleBackColor = true;
            makeCircularQueueCheckBox.CheckedChanged += IsCircularQueueCheckedChanged;
            // 
            // enqueueCustomerButton
            // 
            enqueueCustomerButton.BackColor = Color.LimeGreen;
            enqueueCustomerButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enqueueCustomerButton.Location = new Point(334, 321);
            enqueueCustomerButton.Name = "enqueueCustomerButton";
            enqueueCustomerButton.Size = new Size(175, 43);
            enqueueCustomerButton.TabIndex = 8;
            enqueueCustomerButton.Text = "Enqueue Customer";
            enqueueCustomerButton.UseVisualStyleBackColor = false;
            enqueueCustomerButton.Click += ShowEnqueueCustomerView;
            // 
            // dequeueCustomerButton
            // 
            dequeueCustomerButton.BackColor = Color.Red;
            dequeueCustomerButton.FlatStyle = FlatStyle.Popup;
            dequeueCustomerButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dequeueCustomerButton.ForeColor = Color.White;
            dequeueCustomerButton.Location = new Point(23, 321);
            dequeueCustomerButton.Name = "dequeueCustomerButton";
            dequeueCustomerButton.Size = new Size(175, 43);
            dequeueCustomerButton.TabIndex = 7;
            dequeueCustomerButton.Text = "Dequeue Customer";
            dequeueCustomerButton.UseVisualStyleBackColor = false;
            dequeueCustomerButton.Click += DequeueCustomerButtonClick;
            // 
            // totalAmountOwedTextBox
            // 
            totalAmountOwedTextBox.Location = new Point(409, 287);
            totalAmountOwedTextBox.Name = "totalAmountOwedTextBox";
            totalAmountOwedTextBox.ReadOnly = true;
            totalAmountOwedTextBox.Size = new Size(100, 23);
            totalAmountOwedTextBox.TabIndex = 6;
            // 
            // totalAmountOwedLabel
            // 
            totalAmountOwedLabel.AutoSize = true;
            totalAmountOwedLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmountOwedLabel.Location = new Point(256, 290);
            totalAmountOwedLabel.Name = "totalAmountOwedLabel";
            totalAmountOwedLabel.Size = new Size(154, 20);
            totalAmountOwedLabel.TabIndex = 5;
            totalAmountOwedLabel.Text = "Total Amount Owed:";
            // 
            // totalCustomerTextBox
            // 
            totalCustomerTextBox.Location = new Point(71, 287);
            totalCustomerTextBox.Name = "totalCustomerTextBox";
            totalCustomerTextBox.ReadOnly = true;
            totalCustomerTextBox.Size = new Size(100, 23);
            totalCustomerTextBox.TabIndex = 4;
            // 
            // totalCustomersLabel
            // 
            totalCustomersLabel.AutoSize = true;
            totalCustomersLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCustomersLabel.Location = new Point(23, 290);
            totalCustomersLabel.Name = "totalCustomersLabel";
            totalCustomersLabel.Size = new Size(48, 20);
            totalCustomersLabel.TabIndex = 3;
            totalCustomersLabel.Text = "Total:";
            // 
            // dequeuedCustomerGroupBox
            // 
            dequeuedCustomerGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dequeuedCustomerGroupBox.BackColor = Color.Khaki;
            dequeuedCustomerGroupBox.Controls.Add(dequeuedCustomerNameTextBox);
            dequeuedCustomerGroupBox.Controls.Add(dequeuedCustomerNameLabel);
            dequeuedCustomerGroupBox.Controls.Add(dequeuedCustomerAgeLabel);
            dequeuedCustomerGroupBox.Controls.Add(dequeuedCustomerAgeTextBox);
            dequeuedCustomerGroupBox.Controls.Add(dequeuedCustomerAmountOwedLabel);
            dequeuedCustomerGroupBox.Controls.Add(dequeuedCustomerAmountOwedTextBox);
            dequeuedCustomerGroupBox.Controls.Add(dequeuedCustomerAddressLabel);
            dequeuedCustomerGroupBox.Controls.Add(dequeuedCustomerAddressTextBox);
            dequeuedCustomerGroupBox.Controls.Add(closeDequeuedCustomerViewButton);
            dequeuedCustomerGroupBox.FlatStyle = FlatStyle.Popup;
            dequeuedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dequeuedCustomerGroupBox.Location = new Point(40, 28);
            dequeuedCustomerGroupBox.Name = "dequeuedCustomerGroupBox";
            dequeuedCustomerGroupBox.Size = new Size(476, 274);
            dequeuedCustomerGroupBox.TabIndex = 12;
            dequeuedCustomerGroupBox.TabStop = false;
            dequeuedCustomerGroupBox.Text = "Dequeued Customer";
            // 
            // dequeuedCustomerNameTextBox
            // 
            dequeuedCustomerNameTextBox.Location = new Point(112, 50);
            dequeuedCustomerNameTextBox.Name = "dequeuedCustomerNameTextBox";
            dequeuedCustomerNameTextBox.ReadOnly = true;
            dequeuedCustomerNameTextBox.Size = new Size(336, 23);
            dequeuedCustomerNameTextBox.TabIndex = 2;
            dequeuedCustomerNameTextBox.TabStop = false;
            // 
            // dequeuedCustomerNameLabel
            // 
            dequeuedCustomerNameLabel.AutoSize = true;
            dequeuedCustomerNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dequeuedCustomerNameLabel.Location = new Point(54, 53);
            dequeuedCustomerNameLabel.Name = "dequeuedCustomerNameLabel";
            dequeuedCustomerNameLabel.Size = new Size(43, 15);
            dequeuedCustomerNameLabel.TabIndex = 3;
            dequeuedCustomerNameLabel.Text = "Name:";
            // 
            // dequeuedCustomerAgeLabel
            // 
            dequeuedCustomerAgeLabel.AutoSize = true;
            dequeuedCustomerAgeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dequeuedCustomerAgeLabel.Location = new Point(54, 142);
            dequeuedCustomerAgeLabel.Name = "dequeuedCustomerAgeLabel";
            dequeuedCustomerAgeLabel.Size = new Size(32, 15);
            dequeuedCustomerAgeLabel.TabIndex = 5;
            dequeuedCustomerAgeLabel.Text = "Age:";
            // 
            // dequeuedCustomerAgeTextBox
            // 
            dequeuedCustomerAgeTextBox.Location = new Point(112, 139);
            dequeuedCustomerAgeTextBox.Name = "dequeuedCustomerAgeTextBox";
            dequeuedCustomerAgeTextBox.ReadOnly = true;
            dequeuedCustomerAgeTextBox.Size = new Size(119, 23);
            dequeuedCustomerAgeTextBox.TabIndex = 4;
            dequeuedCustomerAgeTextBox.TabStop = false;
            // 
            // dequeuedCustomerAmountOwedLabel
            // 
            dequeuedCustomerAmountOwedLabel.AutoSize = true;
            dequeuedCustomerAmountOwedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dequeuedCustomerAmountOwedLabel.Location = new Point(235, 145);
            dequeuedCustomerAmountOwedLabel.Name = "dequeuedCustomerAmountOwedLabel";
            dequeuedCustomerAmountOwedLabel.Size = new Size(91, 15);
            dequeuedCustomerAmountOwedLabel.TabIndex = 7;
            dequeuedCustomerAmountOwedLabel.Text = "Amount Owed:";
            // 
            // dequeuedCustomerAmountOwedTextBox
            // 
            dequeuedCustomerAmountOwedTextBox.Location = new Point(329, 142);
            dequeuedCustomerAmountOwedTextBox.Name = "dequeuedCustomerAmountOwedTextBox";
            dequeuedCustomerAmountOwedTextBox.ReadOnly = true;
            dequeuedCustomerAmountOwedTextBox.Size = new Size(119, 23);
            dequeuedCustomerAmountOwedTextBox.TabIndex = 6;
            dequeuedCustomerAmountOwedTextBox.TabStop = false;
            // 
            // dequeuedCustomerAddressLabel
            // 
            dequeuedCustomerAddressLabel.AutoSize = true;
            dequeuedCustomerAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dequeuedCustomerAddressLabel.Location = new Point(54, 95);
            dequeuedCustomerAddressLabel.Name = "dequeuedCustomerAddressLabel";
            dequeuedCustomerAddressLabel.Size = new Size(54, 15);
            dequeuedCustomerAddressLabel.TabIndex = 9;
            dequeuedCustomerAddressLabel.Text = "Address:";
            // 
            // dequeuedCustomerAddressTextBox
            // 
            dequeuedCustomerAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dequeuedCustomerAddressTextBox.Location = new Point(112, 92);
            dequeuedCustomerAddressTextBox.Name = "dequeuedCustomerAddressTextBox";
            dequeuedCustomerAddressTextBox.ReadOnly = true;
            dequeuedCustomerAddressTextBox.Size = new Size(336, 23);
            dequeuedCustomerAddressTextBox.TabIndex = 8;
            dequeuedCustomerAddressTextBox.TabStop = false;
            // 
            // closeDequeuedCustomerViewButton
            // 
            closeDequeuedCustomerViewButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeDequeuedCustomerViewButton.BackColor = Color.Red;
            closeDequeuedCustomerViewButton.FlatStyle = FlatStyle.Popup;
            closeDequeuedCustomerViewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            closeDequeuedCustomerViewButton.ForeColor = SystemColors.HighlightText;
            closeDequeuedCustomerViewButton.Location = new Point(199, 194);
            closeDequeuedCustomerViewButton.Name = "closeDequeuedCustomerViewButton";
            closeDequeuedCustomerViewButton.Size = new Size(127, 43);
            closeDequeuedCustomerViewButton.TabIndex = 11;
            closeDequeuedCustomerViewButton.Text = "Close";
            closeDequeuedCustomerViewButton.UseVisualStyleBackColor = false;
            closeDequeuedCustomerViewButton.Click += CloseDequeuedCustomerButtonOnClick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 459);
            Controls.Add(customersQueueGroupBox);
            Controls.Add(newCustomerBox);
            Controls.Add(dequeuedCustomerGroupBox);
            Name = "Home";
            Text = "Customer Manager";
            Load += MainFormLoad;
            ((ISupportInitialize)customersGridView).EndInit();
            newCustomerBox.ResumeLayout(false);
            newCustomerBox.PerformLayout();
            customersQueueGroupBox.ResumeLayout(false);
            customersQueueGroupBox.PerformLayout();
            dequeuedCustomerGroupBox.ResumeLayout(false);
            dequeuedCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView customersGridView;
        private MyQueue<Customer> customers;
        private BindingList<Customer> customersBindingList;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private TextBox amountOwedTextBox;
        private TextBox addressTextBox;
        private Label nameLabel;
        private Label ageLabel;
        private Label amountOwedLabel;
        private Label addressLabel;
        private GroupBox newCustomerBox;
        private Button cancelButton;
        private Button submitButton;
        private GroupBox customersQueueGroupBox;
        private Label totalCustomersLabel;
        private TextBox totalCustomerTextBox;
        private TextBox totalAmountOwedTextBox;
        private Label totalAmountOwedLabel;
        private Button dequeueCustomerButton;
        private GroupBox dequeuedCustomerGroupBox;
        private TextBox dequeuedCustomerNameTextBox;
        private Label dequeuedCustomerNameLabel;
        private Label dequeuedCustomerAgeLabel;
        private TextBox dequeuedCustomerAgeTextBox;
        private Label dequeuedCustomerAmountOwedLabel;
        private TextBox dequeuedCustomerAmountOwedTextBox;
        private Label dequeuedCustomerAddressLabel;
        private TextBox dequeuedCustomerAddressTextBox;
        private Button closeDequeuedCustomerViewButton;
        private Button enqueueCustomerButton;
        private CheckBox makeCircularQueueCheckBox;
        private TextBox circularQueueSizeTextBox;
        private Label circularQueueSizeLabel;
        private Button updateCircularQueueSizeButton;
    }
}
