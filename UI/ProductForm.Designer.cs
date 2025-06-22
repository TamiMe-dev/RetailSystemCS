namespace UI
{
    partial class ProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            panelProductReadAll = new Panel();
            dataGridViewPRA = new DataGridView();
            buttonFilterPRA = new Button();
            comboBoxFilterPRA = new ComboBox();
            panelProductCreate = new Panel();
            numericUpDownCountPC = new NumericUpDown();
            numericUpDownPricePC = new NumericUpDown();
            label1 = new Label();
            comboBoxCateroryPC = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonSaveProduct = new Button();
            textBoxNamePC = new TextBox();
            panelProductUpdate = new Panel();
            labelIdP = new Label();
            labelNameP = new Label();
            numericUpDownCountPU = new NumericUpDown();
            numericUpDownPricePU = new NumericUpDown();
            label2 = new Label();
            comboBoxPU = new ComboBox();
            label10 = new Label();
            label = new Label();
            textBoxNamePU = new TextBox();
            textBoxIdPU = new TextBox();
            buttonIdPU = new Button();
            buttonPU = new Button();
            panelProductRead = new Panel();
            textBoxCategoryPR = new TextBox();
            label6 = new Label();
            label7 = new Label();
            numericUpDownCountPR = new NumericUpDown();
            numericUpDownPricePR = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            textBoxNamePR = new TextBox();
            textBoxIdPR = new TextBox();
            buttonIdPR = new Button();
            buttonProductReadAll = new Button();
            buttonProductDelete = new Button();
            buttonProductCreate = new Button();
            buttonProductUpdate = new Button();
            pictureBox1 = new PictureBox();
            panelProductDelete = new Panel();
            textBoxIdPD = new TextBox();
            labelIdPD = new Label();
            buttonPD = new Button();
            buttonProductRead = new Button();
            panelProductReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPRA).BeginInit();
            panelProductCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountPC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePC).BeginInit();
            panelProductUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePU).BeginInit();
            panelProductRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountPR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProductDelete.SuspendLayout();
            SuspendLayout();
            // 
            // panelProductReadAll
            // 
            panelProductReadAll.BackColor = Color.Transparent;
            panelProductReadAll.Controls.Add(dataGridViewPRA);
            panelProductReadAll.Controls.Add(buttonFilterPRA);
            panelProductReadAll.Controls.Add(comboBoxFilterPRA);
            panelProductReadAll.Location = new Point(85, 45);
            panelProductReadAll.Margin = new Padding(3, 2, 3, 2);
            panelProductReadAll.Name = "panelProductReadAll";
            panelProductReadAll.Size = new Size(472, 256);
            panelProductReadAll.TabIndex = 34;
            // 
            // dataGridViewPRA
            // 
            dataGridViewPRA.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewPRA.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(247, 242, 228);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPRA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPRA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(247, 242, 228);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(217, 184, 115);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewPRA.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewPRA.GridColor = Color.FromArgb(240, 234, 217);
            dataGridViewPRA.Location = new Point(0, 46);
            dataGridViewPRA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPRA.Name = "dataGridViewPRA";
            dataGridViewPRA.ReadOnly = true;
            dataGridViewPRA.RowHeadersWidth = 51;
            dataGridViewPRA.Size = new Size(470, 209);
            dataGridViewPRA.TabIndex = 31;
            // 
            // buttonFilterPRA
            // 
            buttonFilterPRA.BackColor = Color.Transparent;
            buttonFilterPRA.BackgroundImage = (Image)resources.GetObject("buttonFilterPRA.BackgroundImage");
            buttonFilterPRA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFilterPRA.FlatAppearance.BorderSize = 0;
            buttonFilterPRA.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonFilterPRA.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonFilterPRA.FlatStyle = FlatStyle.Flat;
            buttonFilterPRA.ForeColor = Color.Transparent;
            buttonFilterPRA.Location = new Point(314, 9);
            buttonFilterPRA.Margin = new Padding(3, 2, 3, 2);
            buttonFilterPRA.Name = "buttonFilterPRA";
            buttonFilterPRA.Size = new Size(42, 34);
            buttonFilterPRA.TabIndex = 30;
            buttonFilterPRA.TabStop = false;
            buttonFilterPRA.UseVisualStyleBackColor = false;
            buttonFilterPRA.Click += buttonFilterPRA_Click;
            // 
            // comboBoxFilterPRA
            // 
            comboBoxFilterPRA.BackColor = Color.Black;
            comboBoxFilterPRA.ForeColor = Color.Transparent;
            comboBoxFilterPRA.FormattingEnabled = true;
            comboBoxFilterPRA.Items.AddRange(new object[] { "עד 500 ש\"ח", "עד 1,000 ש\"ח", "עד 5,000 ש\"ח", "עד 10,000 ש\"ח", "מעל 10,000 ש\"ח", "כל המבצעים" });
            comboBoxFilterPRA.Location = new Point(104, 21);
            comboBoxFilterPRA.Margin = new Padding(3, 2, 3, 2);
            comboBoxFilterPRA.Name = "comboBoxFilterPRA";
            comboBoxFilterPRA.Size = new Size(205, 23);
            comboBoxFilterPRA.TabIndex = 32;
            // 
            // panelProductCreate
            // 
            panelProductCreate.BackColor = Color.Transparent;
            panelProductCreate.Controls.Add(numericUpDownCountPC);
            panelProductCreate.Controls.Add(numericUpDownPricePC);
            panelProductCreate.Controls.Add(label1);
            panelProductCreate.Controls.Add(comboBoxCateroryPC);
            panelProductCreate.Controls.Add(label3);
            panelProductCreate.Controls.Add(label4);
            panelProductCreate.Controls.Add(label5);
            panelProductCreate.Controls.Add(buttonSaveProduct);
            panelProductCreate.Controls.Add(textBoxNamePC);
            panelProductCreate.Location = new Point(119, 15);
            panelProductCreate.Margin = new Padding(3, 2, 3, 2);
            panelProductCreate.Name = "panelProductCreate";
            panelProductCreate.Size = new Size(374, 266);
            panelProductCreate.TabIndex = 27;
            // 
            // numericUpDownCountPC
            // 
            numericUpDownCountPC.BackColor = Color.Black;
            numericUpDownCountPC.ForeColor = Color.White;
            numericUpDownCountPC.Location = new Point(129, 150);
            numericUpDownCountPC.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownCountPC.Name = "numericUpDownCountPC";
            numericUpDownCountPC.Size = new Size(153, 23);
            numericUpDownCountPC.TabIndex = 33;
            // 
            // numericUpDownPricePC
            // 
            numericUpDownPricePC.BackColor = Color.Black;
            numericUpDownPricePC.ForeColor = Color.White;
            numericUpDownPricePC.Hexadecimal = true;
            numericUpDownPricePC.Location = new Point(129, 110);
            numericUpDownPricePC.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPricePC.Name = "numericUpDownPricePC";
            numericUpDownPricePC.Size = new Size(153, 23);
            numericUpDownPricePC.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(295, 74);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 31;
            label1.Text = "קטגוריה";
            // 
            // comboBoxCateroryPC
            // 
            comboBoxCateroryPC.BackColor = SystemColors.InfoText;
            comboBoxCateroryPC.ForeColor = Color.White;
            comboBoxCateroryPC.FormattingEnabled = true;
            comboBoxCateroryPC.Items.AddRange(new object[] { "FaceMakeup", "EyeMak", "LipMakeup", "Skincare", "MakeupTools&Accessories" });
            comboBoxCateroryPC.Location = new Point(129, 71);
            comboBoxCateroryPC.Name = "comboBoxCateroryPC";
            comboBoxCateroryPC.Size = new Size(153, 23);
            comboBoxCateroryPC.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(296, 113);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 29;
            label3.Text = "מחיר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(299, 152);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 28;
            label4.Text = "כמות";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(295, 34);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 26;
            label5.Text = "שם";
            // 
            // buttonSaveProduct
            // 
            buttonSaveProduct.BackgroundImage = (Image)resources.GetObject("buttonSaveProduct.BackgroundImage");
            buttonSaveProduct.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveProduct.FlatAppearance.BorderSize = 0;
            buttonSaveProduct.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSaveProduct.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSaveProduct.FlatStyle = FlatStyle.Flat;
            buttonSaveProduct.Location = new Point(164, 154);
            buttonSaveProduct.Margin = new Padding(3, 2, 3, 2);
            buttonSaveProduct.Name = "buttonSaveProduct";
            buttonSaveProduct.Size = new Size(97, 83);
            buttonSaveProduct.TabIndex = 21;
            buttonSaveProduct.UseVisualStyleBackColor = true;
            buttonSaveProduct.Click += buttonSaveProduct_Click;
            // 
            // textBoxNamePC
            // 
            textBoxNamePC.BackColor = SystemColors.InactiveCaptionText;
            textBoxNamePC.ForeColor = Color.White;
            textBoxNamePC.Location = new Point(129, 32);
            textBoxNamePC.Margin = new Padding(3, 2, 3, 2);
            textBoxNamePC.Name = "textBoxNamePC";
            textBoxNamePC.Size = new Size(153, 23);
            textBoxNamePC.TabIndex = 27;
            // 
            // panelProductUpdate
            // 
            panelProductUpdate.BackColor = Color.Transparent;
            panelProductUpdate.Controls.Add(labelIdP);
            panelProductUpdate.Controls.Add(labelNameP);
            panelProductUpdate.Controls.Add(numericUpDownCountPU);
            panelProductUpdate.Controls.Add(numericUpDownPricePU);
            panelProductUpdate.Controls.Add(label2);
            panelProductUpdate.Controls.Add(comboBoxPU);
            panelProductUpdate.Controls.Add(label10);
            panelProductUpdate.Controls.Add(label);
            panelProductUpdate.Controls.Add(textBoxNamePU);
            panelProductUpdate.Controls.Add(textBoxIdPU);
            panelProductUpdate.Controls.Add(buttonIdPU);
            panelProductUpdate.Controls.Add(buttonPU);
            panelProductUpdate.Location = new Point(248, 25);
            panelProductUpdate.Margin = new Padding(3, 2, 3, 2);
            panelProductUpdate.Name = "panelProductUpdate";
            panelProductUpdate.Size = new Size(263, 274);
            panelProductUpdate.TabIndex = 33;
            // 
            // labelIdP
            // 
            labelIdP.AutoSize = true;
            labelIdP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIdP.Location = new Point(66, 10);
            labelIdP.Name = "labelIdP";
            labelIdP.Size = new Size(97, 15);
            labelIdP.TabIndex = 21;
            labelIdP.Text = "הכנס מזהה מוצר";
            // 
            // labelNameP
            // 
            labelNameP.AutoSize = true;
            labelNameP.BackColor = Color.Transparent;
            labelNameP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNameP.Location = new Point(187, 70);
            labelNameP.Name = "labelNameP";
            labelNameP.Size = new Size(26, 15);
            labelNameP.TabIndex = 44;
            labelNameP.Text = "שם";
            // 
            // numericUpDownCountPU
            // 
            numericUpDownCountPU.BackColor = Color.Black;
            numericUpDownCountPU.ForeColor = Color.White;
            numericUpDownCountPU.Location = new Point(21, 186);
            numericUpDownCountPU.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownCountPU.Name = "numericUpDownCountPU";
            numericUpDownCountPU.Size = new Size(153, 23);
            numericUpDownCountPU.TabIndex = 51;
            // 
            // numericUpDownPricePU
            // 
            numericUpDownPricePU.BackColor = Color.Black;
            numericUpDownPricePU.ForeColor = Color.White;
            numericUpDownPricePU.Location = new Point(21, 146);
            numericUpDownPricePU.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPricePU.Name = "numericUpDownPricePU";
            numericUpDownPricePU.Size = new Size(153, 23);
            numericUpDownPricePU.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(187, 110);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 49;
            label2.Text = "קטגוריה";
            // 
            // comboBoxPU
            // 
            comboBoxPU.BackColor = Color.Black;
            comboBoxPU.ForeColor = Color.White;
            comboBoxPU.FormattingEnabled = true;
            comboBoxPU.Items.AddRange(new object[] { "FaceMakeup", "EyeMak", "LipMakeup", "Skincare", "MakeupTools&Accessories" });
            comboBoxPU.Location = new Point(21, 107);
            comboBoxPU.Name = "comboBoxPU";
            comboBoxPU.Size = new Size(153, 23);
            comboBoxPU.TabIndex = 48;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(188, 149);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 47;
            label10.Text = "מחיר";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label.Location = new Point(192, 188);
            label.Name = "label";
            label.Size = new Size(35, 15);
            label.TabIndex = 46;
            label.Text = "כמות";
            // 
            // textBoxNamePU
            // 
            textBoxNamePU.BackColor = Color.Black;
            textBoxNamePU.ForeColor = Color.White;
            textBoxNamePU.Location = new Point(21, 68);
            textBoxNamePU.Margin = new Padding(3, 2, 3, 2);
            textBoxNamePU.Name = "textBoxNamePU";
            textBoxNamePU.Size = new Size(153, 23);
            textBoxNamePU.TabIndex = 45;
            // 
            // textBoxIdPU
            // 
            textBoxIdPU.BackColor = Color.Black;
            textBoxIdPU.ForeColor = Color.White;
            textBoxIdPU.Location = new Point(21, 34);
            textBoxIdPU.Margin = new Padding(3, 2, 3, 2);
            textBoxIdPU.Name = "textBoxIdPU";
            textBoxIdPU.Size = new Size(153, 23);
            textBoxIdPU.TabIndex = 23;
            // 
            // buttonIdPU
            // 
            buttonIdPU.BackgroundImage = (Image)resources.GetObject("buttonIdPU.BackgroundImage");
            buttonIdPU.BackgroundImageLayout = ImageLayout.Stretch;
            buttonIdPU.FlatAppearance.BorderSize = 0;
            buttonIdPU.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonIdPU.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonIdPU.FlatStyle = FlatStyle.Flat;
            buttonIdPU.ImageAlign = ContentAlignment.TopCenter;
            buttonIdPU.Location = new Point(10, -9);
            buttonIdPU.Margin = new Padding(3, 2, 3, 2);
            buttonIdPU.Name = "buttonIdPU";
            buttonIdPU.Size = new Size(66, 54);
            buttonIdPU.TabIndex = 25;
            buttonIdPU.UseVisualStyleBackColor = true;
            buttonIdPU.Click += buttonIdPU_Click;
            // 
            // buttonPU
            // 
            buttonPU.BackgroundImage = (Image)resources.GetObject("buttonPU.BackgroundImage");
            buttonPU.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPU.FlatAppearance.BorderSize = 0;
            buttonPU.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPU.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonPU.FlatStyle = FlatStyle.Flat;
            buttonPU.Location = new Point(30, 191);
            buttonPU.Margin = new Padding(3, 2, 3, 2);
            buttonPU.Name = "buttonPU";
            buttonPU.Size = new Size(127, 94);
            buttonPU.TabIndex = 29;
            buttonPU.UseVisualStyleBackColor = true;
            buttonPU.Click += buttonPU_Click;
            // 
            // panelProductRead
            // 
            panelProductRead.BackColor = Color.Transparent;
            panelProductRead.Controls.Add(textBoxCategoryPR);
            panelProductRead.Controls.Add(label6);
            panelProductRead.Controls.Add(label7);
            panelProductRead.Controls.Add(numericUpDownCountPR);
            panelProductRead.Controls.Add(numericUpDownPricePR);
            panelProductRead.Controls.Add(label8);
            panelProductRead.Controls.Add(label9);
            panelProductRead.Controls.Add(label11);
            panelProductRead.Controls.Add(textBoxNamePR);
            panelProductRead.Controls.Add(textBoxIdPR);
            panelProductRead.Controls.Add(buttonIdPR);
            panelProductRead.Location = new Point(239, 37);
            panelProductRead.Margin = new Padding(3, 2, 3, 2);
            panelProductRead.Name = "panelProductRead";
            panelProductRead.Size = new Size(345, 297);
            panelProductRead.TabIndex = 52;
            // 
            // textBoxCategoryPR
            // 
            textBoxCategoryPR.BackColor = Color.Black;
            textBoxCategoryPR.ForeColor = Color.White;
            textBoxCategoryPR.Location = new Point(22, 106);
            textBoxCategoryPR.Margin = new Padding(3, 2, 3, 2);
            textBoxCategoryPR.Name = "textBoxCategoryPR";
            textBoxCategoryPR.ReadOnly = true;
            textBoxCategoryPR.Size = new Size(153, 23);
            textBoxCategoryPR.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(66, 10);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 21;
            label6.Text = "הכנס מזהה מוצר";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(187, 70);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 44;
            label7.Text = "שם";
            // 
            // numericUpDownCountPR
            // 
            numericUpDownCountPR.BackColor = Color.Black;
            numericUpDownCountPR.ForeColor = Color.White;
            numericUpDownCountPR.Location = new Point(21, 186);
            numericUpDownCountPR.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownCountPR.Name = "numericUpDownCountPR";
            numericUpDownCountPR.ReadOnly = true;
            numericUpDownCountPR.Size = new Size(153, 23);
            numericUpDownCountPR.TabIndex = 51;
            // 
            // numericUpDownPricePR
            // 
            numericUpDownPricePR.BackColor = Color.Black;
            numericUpDownPricePR.ForeColor = Color.White;
            numericUpDownPricePR.Location = new Point(21, 146);
            numericUpDownPricePR.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPricePR.Name = "numericUpDownPricePR";
            numericUpDownPricePR.ReadOnly = true;
            numericUpDownPricePR.Size = new Size(153, 23);
            numericUpDownPricePR.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(187, 110);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 49;
            label8.Text = "קטגוריה";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(188, 149);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 47;
            label9.Text = "מחיר";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(192, 188);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 46;
            label11.Text = "כמות";
            // 
            // textBoxNamePR
            // 
            textBoxNamePR.BackColor = Color.Black;
            textBoxNamePR.ForeColor = Color.White;
            textBoxNamePR.Location = new Point(21, 68);
            textBoxNamePR.Margin = new Padding(3, 2, 3, 2);
            textBoxNamePR.Name = "textBoxNamePR";
            textBoxNamePR.ReadOnly = true;
            textBoxNamePR.Size = new Size(153, 23);
            textBoxNamePR.TabIndex = 45;
            // 
            // textBoxIdPR
            // 
            textBoxIdPR.BackColor = Color.Black;
            textBoxIdPR.ForeColor = Color.White;
            textBoxIdPR.Location = new Point(21, 34);
            textBoxIdPR.Margin = new Padding(3, 2, 3, 2);
            textBoxIdPR.Name = "textBoxIdPR";
            textBoxIdPR.Size = new Size(153, 23);
            textBoxIdPR.TabIndex = 23;
            // 
            // buttonIdPR
            // 
            buttonIdPR.BackgroundImage = (Image)resources.GetObject("buttonIdPR.BackgroundImage");
            buttonIdPR.BackgroundImageLayout = ImageLayout.Stretch;
            buttonIdPR.FlatAppearance.BorderSize = 0;
            buttonIdPR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonIdPR.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonIdPR.FlatStyle = FlatStyle.Flat;
            buttonIdPR.ImageAlign = ContentAlignment.TopCenter;
            buttonIdPR.Location = new Point(10, -9);
            buttonIdPR.Margin = new Padding(3, 2, 3, 2);
            buttonIdPR.Name = "buttonIdPR";
            buttonIdPR.Size = new Size(66, 54);
            buttonIdPR.TabIndex = 25;
            buttonIdPR.UseVisualStyleBackColor = true;
            buttonIdPR.Click += buttonIdPR_Click;
            // 
            // buttonProductReadAll
            // 
            buttonProductReadAll.BackColor = Color.Transparent;
            buttonProductReadAll.BackgroundImage = (Image)resources.GetObject("buttonProductReadAll.BackgroundImage");
            buttonProductReadAll.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProductReadAll.Location = new Point(589, 242);
            buttonProductReadAll.Margin = new Padding(3, 2, 3, 2);
            buttonProductReadAll.Name = "buttonProductReadAll";
            buttonProductReadAll.Size = new Size(73, 32);
            buttonProductReadAll.TabIndex = 31;
            buttonProductReadAll.Text = "הצג הכל";
            buttonProductReadAll.UseVisualStyleBackColor = false;
            buttonProductReadAll.Click += buttonProductReadAll_Click;
            // 
            // buttonProductDelete
            // 
            buttonProductDelete.BackgroundImage = (Image)resources.GetObject("buttonProductDelete.BackgroundImage");
            buttonProductDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProductDelete.Location = new Point(589, 194);
            buttonProductDelete.Margin = new Padding(3, 2, 3, 2);
            buttonProductDelete.Name = "buttonProductDelete";
            buttonProductDelete.Size = new Size(73, 32);
            buttonProductDelete.TabIndex = 29;
            buttonProductDelete.Text = "מחיקה";
            buttonProductDelete.UseVisualStyleBackColor = true;
            buttonProductDelete.Click += buttonProductDelete_Click;
            // 
            // buttonProductCreate
            // 
            buttonProductCreate.BackgroundImage = (Image)resources.GetObject("buttonProductCreate.BackgroundImage");
            buttonProductCreate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProductCreate.Location = new Point(589, 98);
            buttonProductCreate.Margin = new Padding(3, 2, 3, 2);
            buttonProductCreate.Name = "buttonProductCreate";
            buttonProductCreate.Size = new Size(73, 32);
            buttonProductCreate.TabIndex = 28;
            buttonProductCreate.Text = "הוספה";
            buttonProductCreate.UseVisualStyleBackColor = true;
            buttonProductCreate.Click += buttonProductCreate_Click;
            // 
            // buttonProductUpdate
            // 
            buttonProductUpdate.BackgroundImage = (Image)resources.GetObject("buttonProductUpdate.BackgroundImage");
            buttonProductUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProductUpdate.Location = new Point(589, 147);
            buttonProductUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonProductUpdate.Name = "buttonProductUpdate";
            buttonProductUpdate.Size = new Size(73, 32);
            buttonProductUpdate.TabIndex = 30;
            buttonProductUpdate.Text = "עדכון";
            buttonProductUpdate.UseVisualStyleBackColor = true;
            buttonProductUpdate.Click += buttonProductUpdate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(549, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panelProductDelete
            // 
            panelProductDelete.BackColor = Color.Transparent;
            panelProductDelete.Controls.Add(textBoxIdPD);
            panelProductDelete.Controls.Add(labelIdPD);
            panelProductDelete.Controls.Add(buttonPD);
            panelProductDelete.Location = new Point(10, 89);
            panelProductDelete.Margin = new Padding(3, 2, 3, 2);
            panelProductDelete.Name = "panelProductDelete";
            panelProductDelete.Size = new Size(438, 239);
            panelProductDelete.TabIndex = 35;
            // 
            // textBoxIdPD
            // 
            textBoxIdPD.BackColor = Color.Black;
            textBoxIdPD.BorderStyle = BorderStyle.FixedSingle;
            textBoxIdPD.ForeColor = Color.White;
            textBoxIdPD.Location = new Point(265, 58);
            textBoxIdPD.Margin = new Padding(3, 2, 3, 2);
            textBoxIdPD.Name = "textBoxIdPD";
            textBoxIdPD.Size = new Size(152, 23);
            textBoxIdPD.TabIndex = 19;
            // 
            // labelIdPD
            // 
            labelIdPD.AutoSize = true;
            labelIdPD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIdPD.Location = new Point(291, 37);
            labelIdPD.Name = "labelIdPD";
            labelIdPD.Size = new Size(97, 15);
            labelIdPD.TabIndex = 18;
            labelIdPD.Text = "הכנס מזהה מוצר";
            // 
            // buttonPD
            // 
            buttonPD.BackgroundImage = (Image)resources.GetObject("buttonPD.BackgroundImage");
            buttonPD.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPD.FlatAppearance.BorderSize = 0;
            buttonPD.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonPD.FlatStyle = FlatStyle.Flat;
            buttonPD.Location = new Point(291, 61);
            buttonPD.Margin = new Padding(3, 2, 3, 2);
            buttonPD.Name = "buttonPD";
            buttonPD.Size = new Size(99, 74);
            buttonPD.TabIndex = 30;
            buttonPD.UseVisualStyleBackColor = true;
            buttonPD.Click += buttonPD_Click;
            // 
            // buttonProductRead
            // 
            buttonProductRead.BackColor = Color.Transparent;
            buttonProductRead.BackgroundImage = (Image)resources.GetObject("buttonProductRead.BackgroundImage");
            buttonProductRead.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProductRead.Location = new Point(589, 290);
            buttonProductRead.Margin = new Padding(3, 2, 3, 2);
            buttonProductRead.Name = "buttonProductRead";
            buttonProductRead.Size = new Size(73, 32);
            buttonProductRead.TabIndex = 36;
            buttonProductRead.Text = "הצג מוצר";
            buttonProductRead.UseVisualStyleBackColor = false;
            buttonProductRead.Click += buttonProductRead_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(panelProductCreate);
            Controls.Add(buttonProductCreate);
            Controls.Add(pictureBox1);
            Controls.Add(buttonProductRead);
            Controls.Add(buttonProductReadAll);
            Controls.Add(buttonProductDelete);
            Controls.Add(buttonProductUpdate);
            Controls.Add(panelProductDelete);
            Controls.Add(panelProductReadAll);
            Controls.Add(panelProductRead);
            Controls.Add(panelProductUpdate);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductForm";
            Text = "Product";
            panelProductReadAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPRA).EndInit();
            panelProductCreate.ResumeLayout(false);
            panelProductCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountPC).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePC).EndInit();
            panelProductUpdate.ResumeLayout(false);
            panelProductUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePU).EndInit();
            panelProductRead.ResumeLayout(false);
            panelProductRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountPR).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelProductDelete.ResumeLayout(false);
            panelProductDelete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProductReadAll;
        private DataGridView dataGridViewPRA;
        private ComboBox comboBoxFilterPRA;
        private Button buttonFilterPRA;
        private Panel panelProductUpdate;
        private Panel panelProductCreate;
        private Button buttonSaveProduct;
        private Button buttonProductReadAll;
        private Button buttonProductDelete;
        private Button buttonProductCreate;
        private Button buttonProductUpdate;
        private PictureBox pictureBox1;
        private Panel panelProductDelete;
        private TextBox textBoxIdPD;
        private Label labelIdPD;
        private Button buttonPD;
        private TextBox textBoxIdPU;
        private Label labelIdP;
        private Button buttonIdPU;
        private Button buttonPU;
        private NumericUpDown numericUpDownPricePC;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBoxNamePC;
        private Label label5;
        private Label labelNameP;
        private NumericUpDown numericUpDownCountPU;
        private NumericUpDown numericUpDownPricePU;
        private Label label2;
        private ComboBox comboBoxPU;
        private Label label10;
        private Label label;
        private TextBox textBoxNamePU;
        private NumericUpDown numericUpDownCountPC;
        private ComboBox comboBoxCateroryPC;
        private Button buttonProductRead;
        private Panel panelProductRead;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownCountPR;
        private NumericUpDown numericUpDownPricePR;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox textBoxNamePR;
        private TextBox textBoxIdPR;
        private Button buttonIdPR;
        private TextBox textBoxCategoryPR;
    }
}