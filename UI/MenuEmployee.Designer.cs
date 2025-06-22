namespace UI
{
    partial class MenuEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmployee));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panelStartOrder = new Panel();
            labelClub = new Label();
            checkBoxClub = new CheckBox();
            buttonStartOrder = new Button();
            pictureBox1 = new PictureBox();
            panelCategory = new Panel();
            buttonFinishOrderMenu = new Button();
            buttonSkincare = new Button();
            buttonFaceMakeup = new Button();
            buttonMakeupToolsAndAccessories = new Button();
            buttonEyeMakeup = new Button();
            buttonLipMakeup = new Button();
            panelShowProduct = new Panel();
            buttonBack = new Button();
            buttonFinishOrder = new Button();
            dataGridViewShowProduct = new DataGridView();
            numericUpDownAmountProduct = new NumericUpDown();
            buttonAddToOrder = new Button();
            panelOrderFinish = new Panel();
            labelShowPrice = new Label();
            labelPrice = new Label();
            label1 = new Label();
            dataGridViewProductInOrder = new DataGridView();
            pictureBox2 = new PictureBox();
            panelStartOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCategory.SuspendLayout();
            panelShowProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountProduct).BeginInit();
            panelOrderFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductInOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelStartOrder
            // 
            panelStartOrder.BackColor = Color.Transparent;
            panelStartOrder.Controls.Add(labelClub);
            panelStartOrder.Controls.Add(checkBoxClub);
            panelStartOrder.Controls.Add(buttonStartOrder);
            panelStartOrder.Controls.Add(pictureBox1);
            panelStartOrder.Location = new Point(161, 2);
            panelStartOrder.Name = "panelStartOrder";
            panelStartOrder.Size = new Size(397, 335);
            panelStartOrder.TabIndex = 6;
            // 
            // labelClub
            // 
            labelClub.AutoSize = true;
            labelClub.BackColor = Color.Transparent;
            labelClub.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelClub.Location = new Point(192, 213);
            labelClub.Name = "labelClub";
            labelClub.Size = new Size(41, 15);
            labelClub.TabIndex = 5;
            labelClub.Text = "מועדון";
            // 
            // checkBoxClub
            // 
            checkBoxClub.AutoSize = true;
            checkBoxClub.BackColor = SystemColors.ActiveCaptionText;
            checkBoxClub.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBoxClub.ForeColor = SystemColors.Control;
            checkBoxClub.Location = new Point(169, 214);
            checkBoxClub.Name = "checkBoxClub";
            checkBoxClub.Size = new Size(15, 14);
            checkBoxClub.TabIndex = 6;
            checkBoxClub.UseVisualStyleBackColor = false;
            // 
            // buttonStartOrder
            // 
            buttonStartOrder.BackgroundImage = (Image)resources.GetObject("buttonStartOrder.BackgroundImage");
            buttonStartOrder.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStartOrder.FlatStyle = FlatStyle.Popup;
            buttonStartOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonStartOrder.Location = new Point(150, 231);
            buttonStartOrder.Name = "buttonStartOrder";
            buttonStartOrder.Size = new Size(104, 27);
            buttonStartOrder.TabIndex = 4;
            buttonStartOrder.Text = "התחל קניה";
            buttonStartOrder.UseVisualStyleBackColor = true;
            buttonStartOrder.Click += buttonStartOrder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 34);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panelCategory
            // 
            panelCategory.BackColor = Color.Transparent;
            panelCategory.BackgroundImageLayout = ImageLayout.Stretch;
            panelCategory.Controls.Add(buttonFinishOrderMenu);
            panelCategory.Controls.Add(buttonSkincare);
            panelCategory.Controls.Add(buttonFaceMakeup);
            panelCategory.Controls.Add(buttonMakeupToolsAndAccessories);
            panelCategory.Controls.Add(buttonEyeMakeup);
            panelCategory.Controls.Add(buttonLipMakeup);
            panelCategory.Location = new Point(22, 6);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(645, 331);
            panelCategory.TabIndex = 7;
            // 
            // buttonFinishOrderMenu
            // 
            buttonFinishOrderMenu.BackgroundImage = (Image)resources.GetObject("buttonFinishOrderMenu.BackgroundImage");
            buttonFinishOrderMenu.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFinishOrderMenu.FlatStyle = FlatStyle.Popup;
            buttonFinishOrderMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonFinishOrderMenu.Location = new Point(265, 302);
            buttonFinishOrderMenu.Name = "buttonFinishOrderMenu";
            buttonFinishOrderMenu.Size = new Size(97, 20);
            buttonFinishOrderMenu.TabIndex = 34;
            buttonFinishOrderMenu.Text = "סיים הזמנה";
            buttonFinishOrderMenu.UseVisualStyleBackColor = true;
            buttonFinishOrderMenu.Click += buttonFinishOrderMenu_Click;
            // 
            // buttonSkincare
            // 
            buttonSkincare.BackgroundImage = (Image)resources.GetObject("buttonSkincare.BackgroundImage");
            buttonSkincare.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSkincare.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonSkincare.Location = new Point(430, 14);
            buttonSkincare.Name = "buttonSkincare";
            buttonSkincare.Size = new Size(186, 130);
            buttonSkincare.TabIndex = 5;
            buttonSkincare.Text = "Skincare";
            buttonSkincare.UseVisualStyleBackColor = true;
            buttonSkincare.Click += buttonSkincare_Click;
            // 
            // buttonFaceMakeup
            // 
            buttonFaceMakeup.BackgroundImage = (Image)resources.GetObject("buttonFaceMakeup.BackgroundImage");
            buttonFaceMakeup.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFaceMakeup.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonFaceMakeup.Location = new Point(120, 156);
            buttonFaceMakeup.Name = "buttonFaceMakeup";
            buttonFaceMakeup.Size = new Size(186, 130);
            buttonFaceMakeup.TabIndex = 4;
            buttonFaceMakeup.Text = "FaceMakeup";
            buttonFaceMakeup.UseVisualStyleBackColor = true;
            buttonFaceMakeup.Click += buttonFaceMakeup_Click;
            // 
            // buttonMakeupToolsAndAccessories
            // 
            buttonMakeupToolsAndAccessories.BackgroundImage = (Image)resources.GetObject("buttonMakeupToolsAndAccessories.BackgroundImage");
            buttonMakeupToolsAndAccessories.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMakeupToolsAndAccessories.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonMakeupToolsAndAccessories.Location = new Point(23, 14);
            buttonMakeupToolsAndAccessories.Name = "buttonMakeupToolsAndAccessories";
            buttonMakeupToolsAndAccessories.Size = new Size(186, 130);
            buttonMakeupToolsAndAccessories.TabIndex = 3;
            buttonMakeupToolsAndAccessories.Text = "MakeupToolsAndAccessories";
            buttonMakeupToolsAndAccessories.UseVisualStyleBackColor = true;
            buttonMakeupToolsAndAccessories.Click += buttonMakeupToolsAndAccessories_Click;
            // 
            // buttonEyeMakeup
            // 
            buttonEyeMakeup.BackgroundImage = (Image)resources.GetObject("buttonEyeMakeup.BackgroundImage");
            buttonEyeMakeup.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEyeMakeup.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonEyeMakeup.Location = new Point(318, 156);
            buttonEyeMakeup.Name = "buttonEyeMakeup";
            buttonEyeMakeup.Size = new Size(186, 130);
            buttonEyeMakeup.TabIndex = 2;
            buttonEyeMakeup.Text = "EyeMakeup";
            buttonEyeMakeup.UseVisualStyleBackColor = true;
            buttonEyeMakeup.Click += buttonEyeMakeup_Click;
            // 
            // buttonLipMakeup
            // 
            buttonLipMakeup.BackgroundImage = (Image)resources.GetObject("buttonLipMakeup.BackgroundImage");
            buttonLipMakeup.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLipMakeup.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonLipMakeup.Location = new Point(228, 14);
            buttonLipMakeup.Name = "buttonLipMakeup";
            buttonLipMakeup.Size = new Size(186, 130);
            buttonLipMakeup.TabIndex = 1;
            buttonLipMakeup.Text = "LipMakeup";
            buttonLipMakeup.UseVisualStyleBackColor = true;
            buttonLipMakeup.Click += buttonLipMakeup_Click;
            // 
            // panelShowProduct
            // 
            panelShowProduct.BackColor = Color.Transparent;
            panelShowProduct.Controls.Add(buttonBack);
            panelShowProduct.Controls.Add(buttonFinishOrder);
            panelShowProduct.Controls.Add(dataGridViewShowProduct);
            panelShowProduct.Controls.Add(numericUpDownAmountProduct);
            panelShowProduct.Controls.Add(buttonAddToOrder);
            panelShowProduct.Location = new Point(19, 25);
            panelShowProduct.Margin = new Padding(3, 2, 3, 2);
            panelShowProduct.Name = "panelShowProduct";
            panelShowProduct.Size = new Size(669, 295);
            panelShowProduct.TabIndex = 8;
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImage = (Image)resources.GetObject("buttonBack.BackgroundImage");
            buttonBack.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBack.Location = new Point(37, 7);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(97, 20);
            buttonBack.TabIndex = 34;
            buttonBack.Text = "חזרה";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonFinishOrder
            // 
            buttonFinishOrder.BackgroundImage = (Image)resources.GetObject("buttonFinishOrder.BackgroundImage");
            buttonFinishOrder.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFinishOrder.FlatStyle = FlatStyle.Popup;
            buttonFinishOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonFinishOrder.Location = new Point(165, 263);
            buttonFinishOrder.Name = "buttonFinishOrder";
            buttonFinishOrder.Size = new Size(97, 20);
            buttonFinishOrder.TabIndex = 33;
            buttonFinishOrder.Text = "סיים הזמנה";
            buttonFinishOrder.UseVisualStyleBackColor = true;
            buttonFinishOrder.Click += buttonFinishOrder_Click;
            // 
            // dataGridViewShowProduct
            // 
            dataGridViewShowProduct.BackgroundColor = Color.FromArgb(247, 242, 228);
            dataGridViewShowProduct.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(247, 242, 228);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewShowProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewShowProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(247, 242, 228);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(217, 184, 115);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewShowProduct.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewShowProduct.GridColor = Color.FromArgb(240, 234, 217);
            dataGridViewShowProduct.Location = new Point(109, 37);
            dataGridViewShowProduct.Margin = new Padding(3, 2, 3, 2);
            dataGridViewShowProduct.Name = "dataGridViewShowProduct";
            dataGridViewShowProduct.ReadOnly = true;
            dataGridViewShowProduct.RowHeadersWidth = 51;
            dataGridViewShowProduct.Size = new Size(470, 209);
            dataGridViewShowProduct.TabIndex = 32;
            // 
            // numericUpDownAmountProduct
            // 
            numericUpDownAmountProduct.BackColor = Color.Black;
            numericUpDownAmountProduct.ForeColor = Color.White;
            numericUpDownAmountProduct.Location = new Point(394, 263);
            numericUpDownAmountProduct.Margin = new Padding(3, 2, 3, 2);
            numericUpDownAmountProduct.Name = "numericUpDownAmountProduct";
            numericUpDownAmountProduct.Size = new Size(57, 23);
            numericUpDownAmountProduct.TabIndex = 9;
            numericUpDownAmountProduct.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAddToOrder
            // 
            buttonAddToOrder.BackgroundImage = (Image)resources.GetObject("buttonAddToOrder.BackgroundImage");
            buttonAddToOrder.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAddToOrder.FlatStyle = FlatStyle.Popup;
            buttonAddToOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddToOrder.Location = new Point(281, 263);
            buttonAddToOrder.Name = "buttonAddToOrder";
            buttonAddToOrder.Size = new Size(97, 20);
            buttonAddToOrder.TabIndex = 8;
            buttonAddToOrder.Text = "הוסף להזמנה";
            buttonAddToOrder.UseVisualStyleBackColor = true;
            buttonAddToOrder.Click += buttonAddToOrder_Click;
            // 
            // panelOrderFinish
            // 
            panelOrderFinish.BackColor = Color.Transparent;
            panelOrderFinish.Controls.Add(labelShowPrice);
            panelOrderFinish.Controls.Add(labelPrice);
            panelOrderFinish.Controls.Add(label1);
            panelOrderFinish.Controls.Add(dataGridViewProductInOrder);
            panelOrderFinish.Controls.Add(pictureBox2);
            panelOrderFinish.Location = new Point(36, 6);
            panelOrderFinish.Margin = new Padding(3, 2, 3, 2);
            panelOrderFinish.Name = "panelOrderFinish";
            panelOrderFinish.Size = new Size(610, 302);
            panelOrderFinish.TabIndex = 9;
            // 
            // labelShowPrice
            // 
            labelShowPrice.AutoSize = true;
            labelShowPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelShowPrice.Location = new Point(318, 267);
            labelShowPrice.Name = "labelShowPrice";
            labelShowPrice.Size = new Size(0, 19);
            labelShowPrice.TabIndex = 37;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPrice.Location = new Point(375, 267);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 19);
            labelPrice.TabIndex = 36;
            labelPrice.Text = "מחיר";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(304, 14);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 34;
            label1.Text = "תודה שקניתם ב";
            // 
            // dataGridViewProductInOrder
            // 
            dataGridViewProductInOrder.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewProductInOrder.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(247, 242, 228);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewProductInOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewProductInOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(247, 242, 228);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(217, 184, 115);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewProductInOrder.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewProductInOrder.GridColor = Color.FromArgb(240, 234, 217);
            dataGridViewProductInOrder.Location = new Point(72, 44);
            dataGridViewProductInOrder.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProductInOrder.Name = "dataGridViewProductInOrder";
            dataGridViewProductInOrder.ReadOnly = true;
            dataGridViewProductInOrder.RowHeadersWidth = 51;
            dataGridViewProductInOrder.Size = new Size(470, 209);
            dataGridViewProductInOrder.TabIndex = 33;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(237, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // MenuEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(panelShowProduct);
            Controls.Add(panelOrderFinish);
            Controls.Add(panelStartOrder);
            Controls.Add(panelCategory);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuEmployee";
            Text = "MenuEmployee";
            panelStartOrder.ResumeLayout(false);
            panelStartOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCategory.ResumeLayout(false);
            panelShowProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountProduct).EndInit();
            panelOrderFinish.ResumeLayout(false);
            panelOrderFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductInOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStartOrder;
        private Label labelClub;
        private CheckBox checkBoxClub;
        private Button buttonStartOrder;
        private PictureBox pictureBox1;
        private Panel panelCategory;
        private Button buttonSkincare;
        private Button buttonFaceMakeup;
        private Button buttonMakeupToolsAndAccessories;
        private Button buttonEyeMakeup;
        private Button buttonLipMakeup;
        private Panel panelShowProduct;
        private Button buttonAddToOrder;
        private NumericUpDown numericUpDownAmountProduct;
        private DataGridView dataGridViewShowProduct;
        private Button buttonFinishOrder;
        private Panel panelOrderFinish;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView dataGridViewProductInOrder;
        private Label labelPrice;
        private Label labelShowPrice;
        private Button buttonBack;
        private Button buttonFinishOrderMenu;
    }
}