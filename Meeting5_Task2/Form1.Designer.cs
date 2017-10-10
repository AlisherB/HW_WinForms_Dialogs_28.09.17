namespace Meeting5_Task2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(345, 36);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(204, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.СomboBox_SelectedIndexChanged);
            // 
            // buyButton
            // 
            this.buyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyButton.Location = new System.Drawing.Point(345, 83);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(86, 23);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(13, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(291, 158);
            this.listBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(441, 83);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(86, 23);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(344, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список товаров:";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(532, 88);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(20, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "тг.";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.Location = new System.Drawing.Point(342, 154);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(130, 17);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Общая стоимость:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.Red;
            this.totalPriceLabel.Location = new System.Drawing.Point(471, 151);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(20, 24);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "0";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(345, 120);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 186);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.comboBox);
            this.MaximumSize = new System.Drawing.Size(590, 225);
            this.MinimumSize = new System.Drawing.Size(590, 225);
            this.Name = "MainForm";
            this.Text = "Покупка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

