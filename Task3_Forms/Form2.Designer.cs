namespace Task3_Forms
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.ComboBox();
            this.addBrand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupCat = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupSale = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupCat.SuspendLayout();
            this.groupSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(15, 34);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(197, 20);
            this.Product.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(217, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Производитель";
            // 
            // Brand
            // 
            this.Brand.FormattingEnabled = true;
            this.Brand.Items.AddRange(new object[] {
            "Sumsung",
            "Toshiba",
            "HP",
            "IPhone",
            "Dell"});
            this.Brand.Location = new System.Drawing.Point(220, 34);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(164, 21);
            this.Brand.TabIndex = 3;
            // 
            // addBrand
            // 
            this.addBrand.Location = new System.Drawing.Point(390, 34);
            this.addBrand.Name = "addBrand";
            this.addBrand.Size = new System.Drawing.Size(26, 23);
            this.addBrand.TabIndex = 4;
            this.addBrand.Text = "+";
            this.addBrand.UseVisualStyleBackColor = true;
            this.addBrand.Click += new System.EventHandler(this.addBrand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(15, 80);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 9;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(120, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Колличество";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(123, 80);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 20);
            this.Count.TabIndex = 11;
            this.Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Count_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(496, 149);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(415, 149);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // groupCat
            // 
            this.groupCat.Controls.Add(this.radioButton3);
            this.groupCat.Controls.Add(this.radioButton2);
            this.groupCat.Controls.Add(this.radioButton1);
            this.groupCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupCat.Location = new System.Drawing.Point(434, 18);
            this.groupCat.Name = "groupCat";
            this.groupCat.Size = new System.Drawing.Size(137, 100);
            this.groupCat.TabIndex = 19;
            this.groupCat.TabStop = false;
            this.groupCat.Text = "Категория";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(10, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Телефоны";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(10, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Компьютеры";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Бытовая техника";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupSale
            // 
            this.groupSale.Controls.Add(this.radioButton6);
            this.groupSale.Controls.Add(this.radioButton5);
            this.groupSale.Controls.Add(this.radioButton4);
            this.groupSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupSale.Location = new System.Drawing.Point(233, 61);
            this.groupSale.Name = "groupSale";
            this.groupSale.Size = new System.Drawing.Size(159, 45);
            this.groupSale.TabIndex = 20;
            this.groupSale.TabStop = false;
            this.groupSale.Text = "Скидка";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton6.Location = new System.Drawing.Point(102, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(45, 17);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "";
            this.radioButton6.Text = "15%";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton5.Location = new System.Drawing.Point(51, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(45, 17);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "10%";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(39, 17);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "5%";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 184);
            this.ControlBox = false;
            this.Controls.Add(this.groupSale);
            this.Controls.Add(this.groupCat);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBrand);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 223);
            this.MinimumSize = new System.Drawing.Size(600, 223);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Дабавление продукта";
            this.groupCat.ResumeLayout(false);
            this.groupCat.PerformLayout();
            this.groupSale.ResumeLayout(false);
            this.groupSale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Brand;
        private System.Windows.Forms.Button addBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox groupCat;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupSale;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}