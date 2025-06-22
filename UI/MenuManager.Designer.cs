namespace UI
{
    partial class MenuManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManager));
            buttonCustomer = new Button();
            buttonSale = new Button();
            buttonProduct = new Button();
            labelCustomer = new Label();
            labelProduct = new Label();
            labelSale = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCustomer
            // 
            buttonCustomer.BackgroundImage = (Image)resources.GetObject("buttonCustomer.BackgroundImage");
            buttonCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCustomer.Location = new Point(1, -1);
            buttonCustomer.Margin = new Padding(3, 2, 3, 2);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(159, 138);
            buttonCustomer.TabIndex = 0;
            buttonCustomer.UseVisualStyleBackColor = true;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonSale
            // 
            buttonSale.BackgroundImage = (Image)resources.GetObject("buttonSale.BackgroundImage");
            buttonSale.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSale.Location = new Point(412, -1);
            buttonSale.Margin = new Padding(3, 2, 3, 2);
            buttonSale.Name = "buttonSale";
            buttonSale.Size = new Size(159, 138);
            buttonSale.TabIndex = 2;
            buttonSale.UseVisualStyleBackColor = true;
            buttonSale.Click += buttonSale_Click;
            // 
            // buttonProduct
            // 
            buttonProduct.BackColor = Color.FromArgb(255, 224, 192);
            buttonProduct.BackgroundImage = (Image)resources.GetObject("buttonProduct.BackgroundImage");
            buttonProduct.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProduct.Location = new Point(200, 0);
            buttonProduct.Margin = new Padding(3, 2, 3, 2);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(159, 138);
            buttonProduct.TabIndex = 3;
            buttonProduct.UseVisualStyleBackColor = false;
            buttonProduct.Click += buttonProduct_Click;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.BackColor = Color.Transparent;
            labelCustomer.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelCustomer.Location = new Point(43, 103);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(69, 25);
            labelCustomer.TabIndex = 4;
            labelCustomer.Text = "לקוחות";
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.BackColor = Color.Transparent;
            labelProduct.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelProduct.Location = new Point(238, 103);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(70, 25);
            labelProduct.TabIndex = 5;
            labelProduct.Text = "מוצרים";
            // 
            // labelSale
            // 
            labelSale.AutoSize = true;
            labelSale.BackColor = Color.Transparent;
            labelSale.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelSale.Location = new Point(454, 103);
            labelSale.Name = "labelSale";
            labelSale.Size = new Size(76, 25);
            labelSale.TabIndex = 6;
            labelSale.Text = "מבצעים";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(labelProduct);
            panel1.Controls.Add(labelCustomer);
            panel1.Controls.Add(buttonProduct);
            panel1.Controls.Add(labelSale);
            panel1.Controls.Add(buttonSale);
            panel1.Controls.Add(buttonCustomer);
            panel1.Location = new Point(71, 104);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 138);
            panel1.TabIndex = 7;
            // 
            // MenuManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuManager";
            Text = "MenuManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCustomer;
        private Button buttonSale;
        private Button buttonProduct;
        private Label labelCustomer;
        private Label labelProduct;
        private Label labelSale;
        private Panel panel1;
    }
}