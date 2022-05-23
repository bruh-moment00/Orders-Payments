
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
            this.createPaymentFormBtn = new System.Windows.Forms.Button();
            this.openPaymentsFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.ordersGrid.Size = new System.Drawing.Size(545, 394);
            this.ordersGrid.TabIndex = 0;
            // 
            // addNewOrderButton
            // 
            this.addNewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewOrderButton.Location = new System.Drawing.Point(12, 470);
            this.addNewOrderButton.Name = "addNewOrderButton";
            this.addNewOrderButton.Size = new System.Drawing.Size(324, 23);
            this.addNewOrderButton.TabIndex = 1;
            this.addNewOrderButton.Text = "Добавить новый заказ";
            this.addNewOrderButton.UseVisualStyleBackColor = true;
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderDatePicker.Location = new System.Drawing.Point(136, 412);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(200, 23);
            this.orderDatePicker.TabIndex = 2;
            // 
            // sumNumeric
            // 
            this.sumNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sumNumeric.Location = new System.Drawing.Point(136, 441);
            this.sumNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sumNumeric.Name = "sumNumeric";
            this.sumNumeric.Size = new System.Drawing.Size(200, 23);
            this.sumNumeric.TabIndex = 3;
            // 
            // createPaymentFormBtn
            // 
            this.createPaymentFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createPaymentFormBtn.Location = new System.Drawing.Point(563, 12);
            this.createPaymentFormBtn.Name = "createPaymentFormBtn";
            this.createPaymentFormBtn.Size = new System.Drawing.Size(167, 23);
            this.createPaymentFormBtn.TabIndex = 4;
            this.createPaymentFormBtn.Text = "Привязать оплату";
            this.createPaymentFormBtn.UseVisualStyleBackColor = true;
            // 
            // openPaymentsFormBtn
            // 
            this.openPaymentsFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openPaymentsFormBtn.Location = new System.Drawing.Point(563, 470);
            this.openPaymentsFormBtn.Name = "openPaymentsFormBtn";
            this.openPaymentsFormBtn.Size = new System.Drawing.Size(167, 23);
            this.openPaymentsFormBtn.TabIndex = 5;
            this.openPaymentsFormBtn.Text = "Просмотр операций";
            this.openPaymentsFormBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата заказа:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сумма:";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openPaymentsFormBtn);
            this.Controls.Add(this.createPaymentFormBtn);
            this.Controls.Add(this.sumNumeric);
            this.Controls.Add(this.orderDatePicker);
            this.Controls.Add(this.addNewOrderButton);
            this.Controls.Add(this.ordersGrid);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.Button addNewOrderButton;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.NumericUpDown sumNumeric;
        private System.Windows.Forms.Button createPaymentFormBtn;
        private System.Windows.Forms.Button openPaymentsFormBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}