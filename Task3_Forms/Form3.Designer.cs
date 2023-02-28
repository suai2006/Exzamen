namespace Task3_Forms
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.PriceSale = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена со скидкой";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Колличество";
            // 
            // NameField
            // 
            this.NameField.AutoSize = true;
            this.NameField.Location = new System.Drawing.Point(182, 21);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(0, 13);
            this.NameField.TabIndex = 5;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(182, 39);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(0, 13);
            this.Brand.TabIndex = 6;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(182, 61);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(0, 13);
            this.Price.TabIndex = 7;
            // 
            // PriceSale
            // 
            this.PriceSale.AutoSize = true;
            this.PriceSale.Location = new System.Drawing.Point(182, 83);
            this.PriceSale.Name = "PriceSale";
            this.PriceSale.Size = new System.Drawing.Size(0, 13);
            this.PriceSale.TabIndex = 8;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(182, 105);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(0, 13);
            this.Count.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.PriceSale);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(410, 300);
            this.MinimumSize = new System.Drawing.Size(410, 300);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о товаре";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NameField;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label PriceSale;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button button1;
    }
}