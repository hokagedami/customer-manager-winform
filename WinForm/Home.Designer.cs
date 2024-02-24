using System.ComponentModel;
using CustomerManager.Libraries.Entities;

namespace CustomerManager
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
            customersGridView = new DataGridView();
            ((ISupportInitialize)customersGridView).BeginInit();
            SuspendLayout();
            // 
            // customersGridView
            // 
            customersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            customersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersGridView.Location = new Point(33, 12);
            customersGridView.Name = "customersGridView";
            customersGridView.ReadOnly = true;
            customersGridView.Size = new Size(734, 409);
            customersGridView.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customersGridView);
            Name = "Home";
            Text = "Customer Manager";
            Load += MainFormLoad;
            ((ISupportInitialize)customersGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView customersGridView;
        private MyQueue<Customer> customers;
        private BindingList<Customer> customersBindingList;
    }
}
