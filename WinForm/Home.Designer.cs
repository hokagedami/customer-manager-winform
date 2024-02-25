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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            customersListViewGroupBox = new GroupBox();
            totalCustomerTextBox = new TextBox();
            totalCustomersLabel = new Label();
            totalAmountOwedTextBox = new TextBox();
            label1 = new Label();
            dequeueCustomerButton = new Button();
            dequeuedCustomerGroupBox = new GroupBox();
            dequeuedCustomerNameTextBox = new TextBox();
            dequeuedCustomerNameLabel = new Label();
            dequeuedCustomerAgeLabel = new Label();
            dequeuedCustomerAgeTextBox = new TextBox();
            dequeuedCustomerAmountOwedLabel = new Label();
            dequeuedCustomerAmountOwedTextBox = new TextBox();
            dequeuedCustomerAddressLabel = new Label();
            dequeuedCustomerAddressTextBox = new TextBox();
            closeDequeuedCustomerButton = new Button();
            enqueueCustomerButton = new Button();
            makeCircularQueueCheckBox = new CheckBox();
            textBox1 = new TextBox();
            circularQueueSizeLabel = new Label();
            notificationGroupBox = new GroupBox();
            notificationTextBox = new TextBox();
            notificationCloseButton = new Button();
            ((ISupportInitialize)customersGridView).BeginInit();
            newCustomerBox.SuspendLayout();
            customersListViewGroupBox.SuspendLayout();
            dequeuedCustomerGroupBox.SuspendLayout();
            notificationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // customersGridView
            // 
            customersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            customersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            customersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            customersGridView.DefaultCellStyle = dataGridViewCellStyle10;
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
            nameTextBox.TextChanged += NameTextBoxNameTextChanged;
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
            nameLabel.Click += NameLabelClick;
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
            newCustomerBox.Location = new Point(44, 36);
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
            submitButton.Click += button1_Click;
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
            // 
            // customersListViewGroupBox
            // 
            customersListViewGroupBox.BackColor = Color.LightSkyBlue;
            customersListViewGroupBox.Controls.Add(textBox1);
            customersListViewGroupBox.Controls.Add(circularQueueSizeLabel);
            customersListViewGroupBox.Controls.Add(makeCircularQueueCheckBox);
            customersListViewGroupBox.Controls.Add(enqueueCustomerButton);
            customersListViewGroupBox.Controls.Add(dequeueCustomerButton);
            customersListViewGroupBox.Controls.Add(totalAmountOwedTextBox);
            customersListViewGroupBox.Controls.Add(label1);
            customersListViewGroupBox.Controls.Add(totalCustomerTextBox);
            customersListViewGroupBox.Controls.Add(totalCustomersLabel);
            customersListViewGroupBox.Controls.Add(customersGridView);
            customersListViewGroupBox.Location = new Point(553, 36);
            customersListViewGroupBox.Name = "customersListViewGroupBox";
            customersListViewGroupBox.Size = new Size(534, 393);
            customersListViewGroupBox.TabIndex = 12;
            customersListViewGroupBox.TabStop = false;
            customersListViewGroupBox.Text = "Customers Queue";
            // 
            // totalCustomerTextBox
            // 
            totalCustomerTextBox.Location = new Point(71, 287);
            totalCustomerTextBox.Name = "totalCustomerTextBox";
            totalCustomerTextBox.Size = new Size(100, 23);
            totalCustomerTextBox.TabIndex = 4;
            totalCustomerTextBox.TextChanged += textBox1_TextChanged;
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
            // totalAmountOwedTextBox
            // 
            totalAmountOwedTextBox.Location = new Point(409, 287);
            totalAmountOwedTextBox.Name = "totalAmountOwedTextBox";
            totalAmountOwedTextBox.Size = new Size(100, 23);
            totalAmountOwedTextBox.TabIndex = 6;
            totalAmountOwedTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 290);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 5;
            label1.Text = "Total Amount Owed:";
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
            dequeuedCustomerGroupBox.Controls.Add(closeDequeuedCustomerButton);
            dequeuedCustomerGroupBox.FlatStyle = FlatStyle.Popup;
            dequeuedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dequeuedCustomerGroupBox.Location = new Point(44, 356);
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
            dequeuedCustomerNameTextBox.Size = new Size(336, 23);
            dequeuedCustomerNameTextBox.TabIndex = 2;
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
            dequeuedCustomerAgeTextBox.Size = new Size(119, 23);
            dequeuedCustomerAgeTextBox.TabIndex = 4;
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
            dequeuedCustomerAmountOwedTextBox.Size = new Size(119, 23);
            dequeuedCustomerAmountOwedTextBox.TabIndex = 6;
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
            dequeuedCustomerAddressTextBox.Size = new Size(336, 23);
            dequeuedCustomerAddressTextBox.TabIndex = 8;
            // 
            // closeDequeuedCustomerButton
            // 
            closeDequeuedCustomerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeDequeuedCustomerButton.BackColor = Color.Red;
            closeDequeuedCustomerButton.FlatStyle = FlatStyle.Popup;
            closeDequeuedCustomerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            closeDequeuedCustomerButton.ForeColor = SystemColors.HighlightText;
            closeDequeuedCustomerButton.Location = new Point(199, 194);
            closeDequeuedCustomerButton.Name = "closeDequeuedCustomerButton";
            closeDequeuedCustomerButton.Size = new Size(127, 43);
            closeDequeuedCustomerButton.TabIndex = 11;
            closeDequeuedCustomerButton.Text = "Close";
            closeDequeuedCustomerButton.UseVisualStyleBackColor = false;
            closeDequeuedCustomerButton.Click += button2_Click;
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
            enqueueCustomerButton.Click += button1_Click_1;
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(409, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // circularQueueSizeLabel
            // 
            circularQueueSizeLabel.AutoSize = true;
            circularQueueSizeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            circularQueueSizeLabel.Location = new Point(265, 23);
            circularQueueSizeLabel.Name = "circularQueueSizeLabel";
            circularQueueSizeLabel.Size = new Size(146, 20);
            circularQueueSizeLabel.TabIndex = 10;
            circularQueueSizeLabel.Text = "Circular Queue Size:";
            // 
            // notificationGroupBox
            // 
            notificationGroupBox.BackColor = SystemColors.ActiveBorder;
            notificationGroupBox.Controls.Add(notificationCloseButton);
            notificationGroupBox.Controls.Add(notificationTextBox);
            notificationGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            notificationGroupBox.Location = new Point(553, 451);
            notificationGroupBox.Name = "notificationGroupBox";
            notificationGroupBox.Size = new Size(360, 243);
            notificationGroupBox.TabIndex = 13;
            notificationGroupBox.TabStop = false;
            notificationGroupBox.Text = "Notification";
            // 
            // notificationTextBox
            // 
            notificationTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notificationTextBox.Location = new Point(23, 69);
            notificationTextBox.Name = "notificationTextBox";
            notificationTextBox.Size = new Size(301, 25);
            notificationTextBox.TabIndex = 0;
            notificationTextBox.Text = "Notification Sample Text";
            notificationTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // notificationCloseButton
            // 
            notificationCloseButton.BackColor = Color.Red;
            notificationCloseButton.FlatStyle = FlatStyle.Popup;
            notificationCloseButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notificationCloseButton.ForeColor = Color.White;
            notificationCloseButton.Location = new Point(141, 127);
            notificationCloseButton.Name = "notificationCloseButton";
            notificationCloseButton.Size = new Size(75, 33);
            notificationCloseButton.TabIndex = 1;
            notificationCloseButton.Text = "CLOSE";
            notificationCloseButton.UseVisualStyleBackColor = false;
            notificationCloseButton.Click += button1_Click_2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 800);
            Controls.Add(notificationGroupBox);
            Controls.Add(dequeuedCustomerGroupBox);
            Controls.Add(customersListViewGroupBox);
            Controls.Add(newCustomerBox);
            Name = "Home";
            Text = "Customer Manager";
            Load += MainFormLoad;
            ((ISupportInitialize)customersGridView).EndInit();
            newCustomerBox.ResumeLayout(false);
            newCustomerBox.PerformLayout();
            customersListViewGroupBox.ResumeLayout(false);
            customersListViewGroupBox.PerformLayout();
            dequeuedCustomerGroupBox.ResumeLayout(false);
            dequeuedCustomerGroupBox.PerformLayout();
            notificationGroupBox.ResumeLayout(false);
            notificationGroupBox.PerformLayout();
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
        private GroupBox customersListViewGroupBox;
        private Label totalCustomersLabel;
        private TextBox totalCustomerTextBox;
        private TextBox totalAmountOwedTextBox;
        private Label label1;
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
        private Button closeDequeuedCustomerButton;
        private Button enqueueCustomerButton;
        private CheckBox makeCircularQueueCheckBox;
        private TextBox textBox1;
        private Label circularQueueSizeLabel;
        private GroupBox notificationGroupBox;
        private Button notificationCloseButton;
        private TextBox notificationTextBox;
    }
}
