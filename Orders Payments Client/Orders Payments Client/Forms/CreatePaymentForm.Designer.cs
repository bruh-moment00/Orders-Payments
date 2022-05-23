
namespace Orders_Payments_Client.UI.Forms
{
    partial class CreatePaymentForm
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
            this.createPaymentButton = new System.Windows.Forms.Button();
            this.sumNumeric = new System.Windows.Forms.NumericUpDown();
            this.fundDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addNewFundButton = new System.Windows.Forms.Button();
            this.fundsGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentSumNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentSumNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // createPaymentButton
            // 
            this.createPaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createPaymentButton.Location = new System.Drawing.Point(582, 77);
            this.createPaymentButton.Name = "createPaymentButton";
            this.createPaymentButton.Size = new System.Drawing.Size(167, 23);
            this.createPaymentButton.TabIndex = 11;
            this.createPaymentButton.Text = "Готово";
            this.createPaymentButton.UseVisualStyleBackColor = true;
            // 
            // sumNumeric
            // 
            this.sumNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sumNumeric.Location = new System.Drawing.Point(128, 420);
            this.sumNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sumNumeric.Name = "sumNumeric";
            this.sumNumeric.Size = new System.Drawing.Size(200, 23);
            this.sumNumeric.TabIndex = 10;
            // 
            // fundDatePicker
            // 
            this.fundDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fundDatePicker.Location = new System.Drawing.Point(128, 391);
            this.fundDatePicker.Name = "fundDatePicker";
            this.fundDatePicker.Size = new System.Drawing.Size(200, 23);
            this.fundDatePicker.TabIndex = 9;
            // 
            // addNewFundButton
            // 
            this.addNewFundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewFundButton.Location = new System.Drawing.Point(12, 449);
            this.addNewFundButton.Name = "addNewFundButton";
            this.addNewFundButton.Size = new System.Drawing.Size(316, 23);
            this.addNewFundButton.TabIndex = 8;
            this.addNewFundButton.Text = "Добавить новый приход денег";
            this.addNewFundButton.UseVisualStyleBackColor = true;
            // 
            // fundsGrid
            // 
            this.fundsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fundsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fundsGrid.Location = new System.Drawing.Point(12, 30);
            this.fundsGrid.Name = "fundsGrid";
            this.fundsGrid.RowTemplate.Height = 25;
            this.fundsGrid.Size = new System.Drawing.Size(564, 355);
            this.fundsGrid.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сумма:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Дата прихода:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выберите приход денег или добавьте новый:";
            // 
            // paymentSumNumeric
            // 
            this.paymentSumNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentSumNumeric.Location = new System.Drawing.Point(582, 48);
            this.paymentSumNumeric.Name = "paymentSumNumeric";
            this.paymentSumNumeric.Size = new System.Drawing.Size(167, 23);
            this.paymentSumNumeric.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Сколько списать:";
            // 
            // CreatePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 484);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paymentSumNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createPaymentButton);
            this.Controls.Add(this.sumNumeric);
            this.Controls.Add(this.fundDatePicker);
            this.Controls.Add(this.addNewFundButton);
            this.Controls.Add(this.fundsGrid);
            this.Name = "CreatePaymentForm";
            this.Text = "Выбрать приход денег";
            ((System.ComponentModel.ISupportInitialize)(this.sumNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentSumNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createPaymentButton;
        private System.Windows.Forms.NumericUpDown sumNumeric;
        private System.Windows.Forms.DateTimePicker fundDatePicker;
        private System.Windows.Forms.Button addNewFundButton;
        private System.Windows.Forms.DataGridView fundsGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown paymentSumNumeric;
        private System.Windows.Forms.Label label4;
    }
}