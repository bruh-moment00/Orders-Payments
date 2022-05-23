
namespace Orders_Payments_Client.UI.Forms
{
    partial class OrdersForm
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
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.addNewOrderButton = new System.Windows.Forms.Button();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sumNumeric = new System.Windows.Forms.NumericUpDown();
            this.bindFundButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersGrid
            // 
            this.ordersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Location = new System.Drawing.Point(12, 12);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.RowTemplate.Height = 25;
            this.ordersGrid.Size = new System.Drawing.Size(545, 392);
            this.ordersGrid.TabIndex = 0;
            // 
            // addNewOrderButton
            // 
            this.addNewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewOrderButton.Location = new System.Drawing.Point(12, 468);
            this.addNewOrderButton.Name = "addNewOrderButton";
            this.addNewOrderButton.Size = new System.Drawing.Size(200, 23);
            this.addNewOrderButton.TabIndex = 1;
            this.addNewOrderButton.Text = "Добавить новый заказ";
            this.addNewOrderButton.UseVisualStyleBackColor = true;
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderDatePicker.Location = new System.Drawing.Point(12, 410);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(200, 23);
            this.orderDatePicker.TabIndex = 2;
            // 
            // sumNumeric
            // 
            this.sumNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sumNumeric.Location = new System.Drawing.Point(12, 439);
            this.sumNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sumNumeric.Name = "sumNumeric";
            this.sumNumeric.Size = new System.Drawing.Size(200, 23);
            this.sumNumeric.TabIndex = 3;
            // 
            // bindFundButton
            // 
            this.bindFundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bindFundButton.Location = new System.Drawing.Point(563, 12);
            this.bindFundButton.Name = "bindFundButton";
            this.bindFundButton.Size = new System.Drawing.Size(167, 23);
            this.bindFundButton.TabIndex = 4;
            this.bindFundButton.Text = "Привязать оплату";
            this.bindFundButton.UseVisualStyleBackColor = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 503);
            this.Controls.Add(this.bindFundButton);
            this.Controls.Add(this.sumNumeric);
            this.Controls.Add(this.orderDatePicker);
            this.Controls.Add(this.addNewOrderButton);
            this.Controls.Add(this.ordersGrid);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.Button addNewOrderButton;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.NumericUpDown sumNumeric;
        private System.Windows.Forms.Button bindFundButton;
    }
}