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
            components = new Container();
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
            closeEnqueueCustomerFormButton = new Button();
            submitButton = new Button();
            cancelButton = new Button();
            notificationGroupBox = new GroupBox();
            notificationCloseButton = new Button();
            notoficationTextBox = new TextBox();
            customersQueueGroupBox = new GroupBox();
            populateQueueWithDummyDataButton = new Button();
            displayCustomerWithHighestOwedAmount = new Button();
            queueToggleButton = new Button();
            updateCircularQueueSizeButton = new Button();
            circularQueueSizeTextBox = new TextBox();
            circularQueueSizeLabel = new Label();
            enqueueCustomerButton = new Button();
            dequeueCustomerButton = new Button();
            totalAmountOwedTextBox = new TextBox();
            totalAmountOwedLabel = new Label();
            totalCustomerTextBox = new TextBox();
            totalCustomersLabel = new Label();
            customerGroupBox = new GroupBox();
            customerNameTextBox = new TextBox();
            dequeuedCustomerNameLabel = new Label();
            dequeuedCustomerAgeLabel = new Label();
            customerAgeTextBox = new TextBox();
            dequeuedCustomerAmountOwedLabel = new Label();
            customerAmountOwedTextBox = new TextBox();
            dequeuedCustomerAddressLabel = new Label();
            customerAddressTextBox = new TextBox();
            closeDequeuedCustomerViewButton = new Button();
            exitNewCustomerFormToolTip = new ToolTip(components);
            customerWithHighestAmountOwedToolTip = new ToolTip(components);
            dummyDataToolTip = new ToolTip(components);
            ((ISupportInitialize)customersGridView).BeginInit();
            newCustomerBox.SuspendLayout();
            notificationGroupBox.SuspendLayout();
            customersQueueGroupBox.SuspendLayout();
            customerGroupBox.SuspendLayout();
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
            customersGridView.Location = new Point(22, 66);
            customersGridView.Name = "customersGridView";
            customersGridView.ReadOnly = true;
            customersGridView.Size = new Size(436, 226);
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
            newCustomerBox.Controls.Add(closeEnqueueCustomerFormButton);
            newCustomerBox.Controls.Add(submitButton);
            newCustomerBox.Controls.Add(ageLabel);
            newCustomerBox.Controls.Add(ageTextBox);
            newCustomerBox.Controls.Add(amountOwedLabel);
            newCustomerBox.Controls.Add(amountOwedTextBox);
            newCustomerBox.Controls.Add(addressLabel);
            newCustomerBox.Controls.Add(addressTextBox);
            newCustomerBox.Controls.Add(cancelButton);
            newCustomerBox.Controls.Add(nameLabel);
            newCustomerBox.Controls.Add(nameTextBox);
            newCustomerBox.FlatStyle = FlatStyle.Popup;
            newCustomerBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            newCustomerBox.Location = new Point(31, 30);
            newCustomerBox.Name = "newCustomerBox";
            newCustomerBox.Size = new Size(476, 274);
            newCustomerBox.TabIndex = 10;
            newCustomerBox.TabStop = false;
            newCustomerBox.Text = "New Customer";
            // 
            // closeEnqueueCustomerFormButton
            // 
            closeEnqueueCustomerFormButton.BackColor = Color.Red;
            closeEnqueueCustomerFormButton.FlatStyle = FlatStyle.Popup;
            closeEnqueueCustomerFormButton.ForeColor = Color.White;
            closeEnqueueCustomerFormButton.Location = new Point(418, 10);
            closeEnqueueCustomerFormButton.Name = "closeEnqueueCustomerFormButton";
            closeEnqueueCustomerFormButton.Size = new Size(30, 23);
            closeEnqueueCustomerFormButton.TabIndex = 12;
            closeEnqueueCustomerFormButton.Text = "X";
            exitNewCustomerFormToolTip.SetToolTip(closeEnqueueCustomerFormButton, "Close Enqueue Customer Form");
            closeEnqueueCustomerFormButton.UseVisualStyleBackColor = false;
            closeEnqueueCustomerFormButton.Click += CloseEnqueueCustomerView;
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
            cancelButton.BackColor = Color.Gray;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cancelButton.ForeColor = SystemColors.HighlightText;
            cancelButton.Location = new Point(124, 194);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(127, 43);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Clear Form";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += ClearEnqueueCustomerForm;
            // 
            // notificationGroupBox
            // 
            notificationGroupBox.BackColor = Color.Gainsboro;
            notificationGroupBox.Controls.Add(notificationCloseButton);
            notificationGroupBox.Controls.Add(notoficationTextBox);
            notificationGroupBox.Location = new Point(31, 5);
            notificationGroupBox.Name = "notificationGroupBox";
            notificationGroupBox.Size = new Size(489, 354);
            notificationGroupBox.TabIndex = 13;
            notificationGroupBox.TabStop = false;
            notificationGroupBox.Text = "Notification";
            // 
            // notificationCloseButton
            // 
            notificationCloseButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notificationCloseButton.Location = new Point(195, 194);
            notificationCloseButton.Name = "notificationCloseButton";
            notificationCloseButton.Size = new Size(75, 32);
            notificationCloseButton.TabIndex = 0;
            notificationCloseButton.Text = "OK";
            notificationCloseButton.UseVisualStyleBackColor = true;
            notificationCloseButton.Click += CloseNotificationButtonOnClick;
            // 
            // notoficationTextBox
            // 
            notoficationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notoficationTextBox.Location = new Point(103, 132);
            notoficationTextBox.Name = "notoficationTextBox";
            notoficationTextBox.ReadOnly = true;
            notoficationTextBox.Size = new Size(263, 29);
            notoficationTextBox.TabIndex = 1;
            notoficationTextBox.TabStop = false;
            notoficationTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // customersQueueGroupBox
            // 
            customersQueueGroupBox.BackColor = Color.LightSkyBlue;
            customersQueueGroupBox.Controls.Add(populateQueueWithDummyDataButton);
            customersQueueGroupBox.Controls.Add(displayCustomerWithHighestOwedAmount);
            customersQueueGroupBox.Controls.Add(queueToggleButton);
            customersQueueGroupBox.Controls.Add(updateCircularQueueSizeButton);
            customersQueueGroupBox.Controls.Add(circularQueueSizeTextBox);
            customersQueueGroupBox.Controls.Add(circularQueueSizeLabel);
            customersQueueGroupBox.Controls.Add(enqueueCustomerButton);
            customersQueueGroupBox.Controls.Add(dequeueCustomerButton);
            customersQueueGroupBox.Controls.Add(totalAmountOwedTextBox);
            customersQueueGroupBox.Controls.Add(totalAmountOwedLabel);
            customersQueueGroupBox.Controls.Add(totalCustomerTextBox);
            customersQueueGroupBox.Controls.Add(totalCustomersLabel);
            customersQueueGroupBox.Controls.Add(customersGridView);
            customersQueueGroupBox.Location = new Point(12, 1);
            customersQueueGroupBox.Name = "customersQueueGroupBox";
            customersQueueGroupBox.Size = new Size(561, 358);
            customersQueueGroupBox.TabIndex = 12;
            customersQueueGroupBox.TabStop = false;
            customersQueueGroupBox.Text = "Customers Queue";
            // 
            // populateQueueWithDummyDataButton
            // 
            populateQueueWithDummyDataButton.BackColor = Color.Silver;
            populateQueueWithDummyDataButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            populateQueueWithDummyDataButton.Location = new Point(466, 256);
            populateQueueWithDummyDataButton.Name = "populateQueueWithDummyDataButton";
            populateQueueWithDummyDataButton.Size = new Size(85, 43);
            populateQueueWithDummyDataButton.TabIndex = 15;
            populateQueueWithDummyDataButton.Text = "Dummy Data";
            dummyDataToolTip.SetToolTip(populateQueueWithDummyDataButton, "Populate Queue with Dummy Data");
            populateQueueWithDummyDataButton.UseVisualStyleBackColor = false;
            populateQueueWithDummyDataButton.Click += PopulateQueueWithDummyData;
            // 
            // displayCustomerWithHighestOwedAmount
            // 
            displayCustomerWithHighestOwedAmount.BackColor = Color.DarkSlateBlue;
            displayCustomerWithHighestOwedAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayCustomerWithHighestOwedAmount.ForeColor = Color.White;
            displayCustomerWithHighestOwedAmount.Location = new Point(464, 207);
            displayCustomerWithHighestOwedAmount.Name = "displayCustomerWithHighestOwedAmount";
            displayCustomerWithHighestOwedAmount.Size = new Size(85, 43);
            displayCustomerWithHighestOwedAmount.TabIndex = 14;
            displayCustomerWithHighestOwedAmount.Text = "Display Customer";
            customerWithHighestAmountOwedToolTip.SetToolTip(displayCustomerWithHighestOwedAmount, "Show Customer with Maximum Amount Owed");
            displayCustomerWithHighestOwedAmount.UseVisualStyleBackColor = false;
            displayCustomerWithHighestOwedAmount.Click += DisplayCustomerWithHighestOwedAmount;
            // 
            // queueToggleButton
            // 
            queueToggleButton.BackColor = Color.Navy;
            queueToggleButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            queueToggleButton.ForeColor = Color.White;
            queueToggleButton.Location = new Point(466, 156);
            queueToggleButton.Name = "queueToggleButton";
            queueToggleButton.Size = new Size(85, 43);
            queueToggleButton.TabIndex = 13;
            queueToggleButton.Text = "Circular Queue";
            queueToggleButton.UseVisualStyleBackColor = false;
            queueToggleButton.Click += ToggleQueueTypeButtonClick;
            // 
            // updateCircularQueueSizeButton
            // 
            updateCircularQueueSizeButton.BackColor = Color.LightSeaGreen;
            updateCircularQueueSizeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateCircularQueueSizeButton.ForeColor = Color.White;
            updateCircularQueueSizeButton.Location = new Point(303, 19);
            updateCircularQueueSizeButton.Name = "updateCircularQueueSizeButton";
            updateCircularQueueSizeButton.Size = new Size(84, 39);
            updateCircularQueueSizeButton.TabIndex = 12;
            updateCircularQueueSizeButton.Text = "Update Size";
            updateCircularQueueSizeButton.UseVisualStyleBackColor = false;
            updateCircularQueueSizeButton.Click += UpdateCircularQueueSizeButtonClick;
            // 
            // circularQueueSizeTextBox
            // 
            circularQueueSizeTextBox.Location = new Point(129, 31);
            circularQueueSizeTextBox.Name = "circularQueueSizeTextBox";
            circularQueueSizeTextBox.Size = new Size(100, 23);
            circularQueueSizeTextBox.TabIndex = 11;
            // 
            // circularQueueSizeLabel
            // 
            circularQueueSizeLabel.AutoSize = true;
            circularQueueSizeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            circularQueueSizeLabel.Location = new Point(39, 31);
            circularQueueSizeLabel.Name = "circularQueueSizeLabel";
            circularQueueSizeLabel.Size = new Size(89, 20);
            circularQueueSizeLabel.TabIndex = 10;
            circularQueueSizeLabel.Text = "Queue Size:";
            // 
            // enqueueCustomerButton
            // 
            enqueueCustomerButton.BackColor = Color.LimeGreen;
            enqueueCustomerButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enqueueCustomerButton.Location = new Point(464, 106);
            enqueueCustomerButton.Name = "enqueueCustomerButton";
            enqueueCustomerButton.Size = new Size(85, 43);
            enqueueCustomerButton.TabIndex = 8;
            enqueueCustomerButton.Text = "Enqueue ";
            enqueueCustomerButton.UseVisualStyleBackColor = false;
            enqueueCustomerButton.Click += ShowEnqueueCustomerView;
            // 
            // dequeueCustomerButton
            // 
            dequeueCustomerButton.BackColor = Color.Red;
            dequeueCustomerButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dequeueCustomerButton.ForeColor = Color.White;
            dequeueCustomerButton.Location = new Point(464, 57);
            dequeueCustomerButton.Name = "dequeueCustomerButton";
            dequeueCustomerButton.Size = new Size(85, 43);
            dequeueCustomerButton.TabIndex = 7;
            dequeueCustomerButton.Text = "Dequeue";
            dequeueCustomerButton.UseVisualStyleBackColor = false;
            dequeueCustomerButton.Click += DequeueCustomerButtonClick;
            // 
            // totalAmountOwedTextBox
            // 
            totalAmountOwedTextBox.Location = new Point(336, 304);
            totalAmountOwedTextBox.Name = "totalAmountOwedTextBox";
            totalAmountOwedTextBox.ReadOnly = true;
            totalAmountOwedTextBox.Size = new Size(71, 23);
            totalAmountOwedTextBox.TabIndex = 6;
            // 
            // totalAmountOwedLabel
            // 
            totalAmountOwedLabel.AutoSize = true;
            totalAmountOwedLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmountOwedLabel.Location = new Point(183, 305);
            totalAmountOwedLabel.Name = "totalAmountOwedLabel";
            totalAmountOwedLabel.Size = new Size(154, 20);
            totalAmountOwedLabel.TabIndex = 5;
            totalAmountOwedLabel.Text = "Total Amount Owed:";
            // 
            // totalCustomerTextBox
            // 
            totalCustomerTextBox.Location = new Point(65, 302);
            totalCustomerTextBox.Name = "totalCustomerTextBox";
            totalCustomerTextBox.ReadOnly = true;
            totalCustomerTextBox.Size = new Size(43, 23);
            totalCustomerTextBox.TabIndex = 4;
            // 
            // totalCustomersLabel
            // 
            totalCustomersLabel.AutoSize = true;
            totalCustomersLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCustomersLabel.Location = new Point(17, 303);
            totalCustomersLabel.Name = "totalCustomersLabel";
            totalCustomersLabel.Size = new Size(48, 20);
            totalCustomersLabel.TabIndex = 3;
            totalCustomersLabel.Text = "Total:";
            // 
            // customerGroupBox
            // 
            customerGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customerGroupBox.BackColor = Color.Khaki;
            customerGroupBox.Controls.Add(customerNameTextBox);
            customerGroupBox.Controls.Add(dequeuedCustomerNameLabel);
            customerGroupBox.Controls.Add(dequeuedCustomerAgeLabel);
            customerGroupBox.Controls.Add(customerAgeTextBox);
            customerGroupBox.Controls.Add(dequeuedCustomerAmountOwedLabel);
            customerGroupBox.Controls.Add(customerAmountOwedTextBox);
            customerGroupBox.Controls.Add(dequeuedCustomerAddressLabel);
            customerGroupBox.Controls.Add(customerAddressTextBox);
            customerGroupBox.Controls.Add(closeDequeuedCustomerViewButton);
            customerGroupBox.FlatStyle = FlatStyle.Popup;
            customerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            customerGroupBox.Location = new Point(31, 30);
            customerGroupBox.Name = "customerGroupBox";
            customerGroupBox.Size = new Size(476, 274);
            customerGroupBox.TabIndex = 12;
            customerGroupBox.TabStop = false;
            customerGroupBox.Text = "Dequeued Customer";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(112, 50);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.ReadOnly = true;
            customerNameTextBox.Size = new Size(336, 23);
            customerNameTextBox.TabIndex = 2;
            customerNameTextBox.TabStop = false;
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
            // customerAgeTextBox
            // 
            customerAgeTextBox.Location = new Point(112, 139);
            customerAgeTextBox.Name = "customerAgeTextBox";
            customerAgeTextBox.ReadOnly = true;
            customerAgeTextBox.Size = new Size(119, 23);
            customerAgeTextBox.TabIndex = 4;
            customerAgeTextBox.TabStop = false;
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
            // customerAmountOwedTextBox
            // 
            customerAmountOwedTextBox.Location = new Point(329, 142);
            customerAmountOwedTextBox.Name = "customerAmountOwedTextBox";
            customerAmountOwedTextBox.ReadOnly = true;
            customerAmountOwedTextBox.Size = new Size(119, 23);
            customerAmountOwedTextBox.TabIndex = 6;
            customerAmountOwedTextBox.TabStop = false;
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
            // customerAddressTextBox
            // 
            customerAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerAddressTextBox.Location = new Point(112, 92);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.ReadOnly = true;
            customerAddressTextBox.Size = new Size(336, 23);
            customerAddressTextBox.TabIndex = 8;
            customerAddressTextBox.TabStop = false;
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
            // exitNewCustomerFormToolTip
            // 
            exitNewCustomerFormToolTip.AutoPopDelay = 5000;
            exitNewCustomerFormToolTip.InitialDelay = 1000;
            exitNewCustomerFormToolTip.ReshowDelay = 500;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 359);
            Controls.Add(customersQueueGroupBox);
            Controls.Add(notificationGroupBox);
            Controls.Add(newCustomerBox);
            Controls.Add(customerGroupBox);
            Name = "Home";
            Text = "Customer Manager";
            Load += MainFormLoad;
            ((ISupportInitialize)customersGridView).EndInit();
            newCustomerBox.ResumeLayout(false);
            newCustomerBox.PerformLayout();
            notificationGroupBox.ResumeLayout(false);
            notificationGroupBox.PerformLayout();
            customersQueueGroupBox.ResumeLayout(false);
            customersQueueGroupBox.PerformLayout();
            customerGroupBox.ResumeLayout(false);
            customerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView customersGridView;
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
        private GroupBox customerGroupBox;
        private TextBox customerNameTextBox;
        private Label dequeuedCustomerNameLabel;
        private Label dequeuedCustomerAgeLabel;
        private TextBox customerAgeTextBox;
        private Label dequeuedCustomerAmountOwedLabel;
        private TextBox customerAmountOwedTextBox;
        private Label dequeuedCustomerAddressLabel;
        private TextBox customerAddressTextBox;
        private Button closeDequeuedCustomerViewButton;
        private Button enqueueCustomerButton;
        private TextBox circularQueueSizeTextBox;
        private Label circularQueueSizeLabel;
        private Button updateCircularQueueSizeButton;
        private GroupBox notificationGroupBox;
        private TextBox notoficationTextBox;
        private Button notificationCloseButton;
        private Button closeEnqueueCustomerFormButton;
        private ToolTip exitNewCustomerFormToolTip;
        private int defaultCircularQueueSize = 10;
        private Button queueToggleButton;
        private bool isCircularQueue = false;
        private Button displayCustomerWithHighestOwedAmount;
        private ToolTip customerWithHighestAmountOwedToolTip;
        private Button populateQueueWithDummyDataButton;
        private ToolTip dummyDataToolTip;
    }
}
