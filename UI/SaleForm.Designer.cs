namespace UI
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonSaleReadAll = new Button();
            buttonSaleCreate = new Button();
            textBoxIdSD = new TextBox();
            labelIdSD = new Label();
            buttonSD = new Button();
            dateTimePickerDateFinish = new DateTimePicker();
            buttonSaleDelete = new Button();
            dateTimePickerFinishSU = new DateTimePicker();
            labelDateFinish = new Label();
            dateTimePickerStartSU = new DateTimePicker();
            textBoxCountSU = new TextBox();
            dateTimePickerStart = new DateTimePicker();
            checkBoxClubSC = new CheckBox();
            textBoxCountSC = new TextBox();
            labelDateFinishSU = new Label();
            numericUpDownPriceSU = new NumericUpDown();
            labelCountSU = new Label();
            textBoxIdProductSU = new TextBox();
            labelPriceSU = new Label();
            labelDateStartSU = new Label();
            buttonSaleUpdate = new Button();
            panelSaleReadAll = new Panel();
            dataGridViewSRA = new DataGridView();
            buttonFilterSRA = new Button();
            comboBoxFilterSRA = new ComboBox();
            panelSaleCreate = new Panel();
            numericUpDownPriceSC = new NumericUpDown();
            label1 = new Label();
            labelPriceSC = new Label();
            labelDateStart = new Label();
            labelIdSC = new Label();
            buttonSaveSale = new Button();
            textBoxIdSC = new TextBox();
            panelSaleUpdate = new Panel();
            checkBoxClubSU = new CheckBox();
            labelIdS = new Label();
            textBoxIdSU = new TextBox();
            buttonIdSU = new Button();
            buttonSU = new Button();
            labelIdProductSU = new Label();
            panelSaleDelete = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panelSaleRead = new Panel();
            textBoxClubPR = new TextBox();
            label8 = new Label();
            textBoxFinishDatePR = new TextBox();
            textBoxStartDatePR = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxIdPR = new TextBox();
            buttonIdSR = new Button();
            textBoxCountPR = new TextBox();
            numericUpDownPricePR = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            textBoxIdProductPR = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceSU).BeginInit();
            panelSaleReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSRA).BeginInit();
            panelSaleCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceSC).BeginInit();
            panelSaleUpdate.SuspendLayout();
            panelSaleDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSaleRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePR).BeginInit();
            SuspendLayout();
            // 
            // buttonSaleReadAll
            // 
            buttonSaleReadAll.BackColor = Color.Transparent;
            buttonSaleReadAll.BackgroundImage = (Image)resources.GetObject("buttonSaleReadAll.BackgroundImage");
            buttonSaleReadAll.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaleReadAll.Location = new Point(587, 242);
            buttonSaleReadAll.Margin = new Padding(3, 2, 3, 2);
            buttonSaleReadAll.Name = "buttonSaleReadAll";
            buttonSaleReadAll.Size = new Size(73, 32);
            buttonSaleReadAll.TabIndex = 40;
            buttonSaleReadAll.Text = "הצג הכל";
            buttonSaleReadAll.UseVisualStyleBackColor = false;
            buttonSaleReadAll.Click += buttonSaleReadAll_Click;
            // 
            // buttonSaleCreate
            // 
            buttonSaleCreate.BackgroundImage = (Image)resources.GetObject("buttonSaleCreate.BackgroundImage");
            buttonSaleCreate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaleCreate.Location = new Point(587, 98);
            buttonSaleCreate.Margin = new Padding(3, 2, 3, 2);
            buttonSaleCreate.Name = "buttonSaleCreate";
            buttonSaleCreate.Size = new Size(73, 32);
            buttonSaleCreate.TabIndex = 37;
            buttonSaleCreate.Text = "הוספה";
            buttonSaleCreate.UseVisualStyleBackColor = true;
            buttonSaleCreate.Click += buttonSaleCreate_Click;
            // 
            // textBoxIdSD
            // 
            textBoxIdSD.BackColor = Color.Black;
            textBoxIdSD.BorderStyle = BorderStyle.FixedSingle;
            textBoxIdSD.ForeColor = Color.White;
            textBoxIdSD.Location = new Point(24, 43);
            textBoxIdSD.Margin = new Padding(3, 2, 3, 2);
            textBoxIdSD.Name = "textBoxIdSD";
            textBoxIdSD.Size = new Size(152, 23);
            textBoxIdSD.TabIndex = 19;
            // 
            // labelIdSD
            // 
            labelIdSD.AutoSize = true;
            labelIdSD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIdSD.Location = new Point(50, 21);
            labelIdSD.Name = "labelIdSD";
            labelIdSD.Size = new Size(101, 15);
            labelIdSD.TabIndex = 18;
            labelIdSD.Text = "הכנס מזהה מבצע";
            // 
            // buttonSD
            // 
            buttonSD.BackgroundImage = (Image)resources.GetObject("buttonSD.BackgroundImage");
            buttonSD.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSD.FlatAppearance.BorderSize = 0;
            buttonSD.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSD.FlatStyle = FlatStyle.Flat;
            buttonSD.Location = new Point(50, 45);
            buttonSD.Margin = new Padding(3, 2, 3, 2);
            buttonSD.Name = "buttonSD";
            buttonSD.Size = new Size(99, 74);
            buttonSD.TabIndex = 30;
            buttonSD.UseVisualStyleBackColor = true;
            buttonSD.Click += buttonSD_Click;
            // 
            // dateTimePickerDateFinish
            // 
            dateTimePickerDateFinish.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePickerDateFinish.CalendarForeColor = Color.Transparent;
            dateTimePickerDateFinish.CalendarMonthBackground = Color.Transparent;
            dateTimePickerDateFinish.CalendarTitleBackColor = Color.Transparent;
            dateTimePickerDateFinish.CalendarTrailingForeColor = Color.Black;
            dateTimePickerDateFinish.Location = new Point(139, 166);
            dateTimePickerDateFinish.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerDateFinish.Name = "dateTimePickerDateFinish";
            dateTimePickerDateFinish.Size = new Size(152, 23);
            dateTimePickerDateFinish.TabIndex = 38;
            // 
            // buttonSaleDelete
            // 
            buttonSaleDelete.BackgroundImage = (Image)resources.GetObject("buttonSaleDelete.BackgroundImage");
            buttonSaleDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaleDelete.Location = new Point(587, 194);
            buttonSaleDelete.Margin = new Padding(3, 2, 3, 2);
            buttonSaleDelete.Name = "buttonSaleDelete";
            buttonSaleDelete.Size = new Size(73, 32);
            buttonSaleDelete.TabIndex = 38;
            buttonSaleDelete.Text = "מחיקה";
            buttonSaleDelete.UseVisualStyleBackColor = true;
            buttonSaleDelete.Click += buttonSaleDelete_Click;
            // 
            // dateTimePickerFinishSU
            // 
            dateTimePickerFinishSU.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePickerFinishSU.CalendarForeColor = Color.Transparent;
            dateTimePickerFinishSU.CalendarMonthBackground = Color.Transparent;
            dateTimePickerFinishSU.CalendarTitleBackColor = Color.Transparent;
            dateTimePickerFinishSU.CalendarTrailingForeColor = Color.Black;
            dateTimePickerFinishSU.Location = new Point(24, 218);
            dateTimePickerFinishSU.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFinishSU.Name = "dateTimePickerFinishSU";
            dateTimePickerFinishSU.Size = new Size(152, 23);
            dateTimePickerFinishSU.TabIndex = 48;
            // 
            // labelDateFinish
            // 
            labelDateFinish.AutoSize = true;
            labelDateFinish.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDateFinish.Location = new Point(305, 170);
            labelDateFinish.Name = "labelDateFinish";
            labelDateFinish.Size = new Size(72, 15);
            labelDateFinish.TabIndex = 37;
            labelDateFinish.Text = "תאריך סיום";
            // 
            // dateTimePickerStartSU
            // 
            dateTimePickerStartSU.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePickerStartSU.CalendarForeColor = Color.Transparent;
            dateTimePickerStartSU.CalendarMonthBackground = Color.Transparent;
            dateTimePickerStartSU.CalendarTitleBackColor = Color.Transparent;
            dateTimePickerStartSU.CalendarTrailingForeColor = Color.Black;
            dateTimePickerStartSU.Location = new Point(23, 183);
            dateTimePickerStartSU.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStartSU.Name = "dateTimePickerStartSU";
            dateTimePickerStartSU.Size = new Size(152, 23);
            dateTimePickerStartSU.TabIndex = 46;
            // 
            // textBoxCountSU
            // 
            textBoxCountSU.BackColor = SystemColors.InactiveCaptionText;
            textBoxCountSU.ForeColor = Color.White;
            textBoxCountSU.Location = new Point(22, 106);
            textBoxCountSU.Margin = new Padding(3, 2, 3, 2);
            textBoxCountSU.Name = "textBoxCountSU";
            textBoxCountSU.Size = new Size(153, 23);
            textBoxCountSU.TabIndex = 45;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePickerStart.CalendarForeColor = Color.Transparent;
            dateTimePickerStart.CalendarMonthBackground = Color.Transparent;
            dateTimePickerStart.CalendarTitleBackColor = Color.Transparent;
            dateTimePickerStart.CalendarTrailingForeColor = Color.Black;
            dateTimePickerStart.Location = new Point(138, 132);
            dateTimePickerStart.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(152, 23);
            dateTimePickerStart.TabIndex = 36;
            // 
            // checkBoxClubSC
            // 
            checkBoxClubSC.AutoSize = true;
            checkBoxClubSC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBoxClubSC.Location = new Point(263, 217);
            checkBoxClubSC.Margin = new Padding(3, 2, 3, 2);
            checkBoxClubSC.Name = "checkBoxClubSC";
            checkBoxClubSC.Size = new Size(60, 19);
            checkBoxClubSC.TabIndex = 35;
            checkBoxClubSC.Text = "מועדון";
            checkBoxClubSC.UseVisualStyleBackColor = true;
            // 
            // textBoxCountSC
            // 
            textBoxCountSC.BackColor = SystemColors.InactiveCaptionText;
            textBoxCountSC.ForeColor = Color.White;
            textBoxCountSC.Location = new Point(137, 55);
            textBoxCountSC.Margin = new Padding(3, 2, 3, 2);
            textBoxCountSC.Name = "textBoxCountSC";
            textBoxCountSC.Size = new Size(153, 23);
            textBoxCountSC.TabIndex = 34;
            // 
            // labelDateFinishSU
            // 
            labelDateFinishSU.AutoSize = true;
            labelDateFinishSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDateFinishSU.Location = new Point(190, 221);
            labelDateFinishSU.Name = "labelDateFinishSU";
            labelDateFinishSU.Size = new Size(72, 15);
            labelDateFinishSU.TabIndex = 47;
            labelDateFinishSU.Text = "תאריך סיום";
            // 
            // numericUpDownPriceSU
            // 
            numericUpDownPriceSU.BackColor = Color.Black;
            numericUpDownPriceSU.ForeColor = Color.White;
            numericUpDownPriceSU.Hexadecimal = true;
            numericUpDownPriceSU.Location = new Point(22, 146);
            numericUpDownPriceSU.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPriceSU.Name = "numericUpDownPriceSU";
            numericUpDownPriceSU.Size = new Size(153, 23);
            numericUpDownPriceSU.TabIndex = 44;
            // 
            // labelCountSU
            // 
            labelCountSU.AutoSize = true;
            labelCountSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCountSU.Location = new Point(188, 111);
            labelCountSU.Name = "labelCountSU";
            labelCountSU.Size = new Size(75, 15);
            labelCountSU.TabIndex = 43;
            labelCountSU.Text = "כמות נדרשת";
            // 
            // textBoxIdProductSU
            // 
            textBoxIdProductSU.BackColor = SystemColors.InactiveCaptionText;
            textBoxIdProductSU.ForeColor = Color.White;
            textBoxIdProductSU.Location = new Point(22, 69);
            textBoxIdProductSU.Margin = new Padding(3, 2, 3, 2);
            textBoxIdProductSU.Name = "textBoxIdProductSU";
            textBoxIdProductSU.Size = new Size(153, 23);
            textBoxIdProductSU.TabIndex = 40;
            // 
            // labelPriceSU
            // 
            labelPriceSU.AutoSize = true;
            labelPriceSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPriceSU.Location = new Point(186, 151);
            labelPriceSU.Name = "labelPriceSU";
            labelPriceSU.Size = new Size(76, 15);
            labelPriceSU.TabIndex = 42;
            labelPriceSU.Text = " מחיר בהנחה";
            // 
            // labelDateStartSU
            // 
            labelDateStartSU.AutoSize = true;
            labelDateStartSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDateStartSU.Location = new Point(189, 187);
            labelDateStartSU.Name = "labelDateStartSU";
            labelDateStartSU.Size = new Size(86, 15);
            labelDateStartSU.TabIndex = 41;
            labelDateStartSU.Text = "תאריך התחלה";
            // 
            // buttonSaleUpdate
            // 
            buttonSaleUpdate.BackgroundImage = (Image)resources.GetObject("buttonSaleUpdate.BackgroundImage");
            buttonSaleUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaleUpdate.Location = new Point(587, 146);
            buttonSaleUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonSaleUpdate.Name = "buttonSaleUpdate";
            buttonSaleUpdate.Size = new Size(73, 32);
            buttonSaleUpdate.TabIndex = 39;
            buttonSaleUpdate.Text = "עדכון";
            buttonSaleUpdate.UseVisualStyleBackColor = true;
            buttonSaleUpdate.Click += buttonSaleUpdate_Click;
            // 
            // panelSaleReadAll
            // 
            panelSaleReadAll.BackColor = Color.Transparent;
            panelSaleReadAll.Controls.Add(dataGridViewSRA);
            panelSaleReadAll.Controls.Add(buttonFilterSRA);
            panelSaleReadAll.Controls.Add(comboBoxFilterSRA);
            panelSaleReadAll.Location = new Point(83, 44);
            panelSaleReadAll.Margin = new Padding(3, 2, 3, 2);
            panelSaleReadAll.Name = "panelSaleReadAll";
            panelSaleReadAll.Size = new Size(472, 256);
            panelSaleReadAll.TabIndex = 43;
            // 
            // dataGridViewSRA
            // 
            dataGridViewSRA.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewSRA.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 242, 228);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSRA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSRA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 242, 228);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 184, 115);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSRA.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSRA.GridColor = Color.FromArgb(240, 234, 217);
            dataGridViewSRA.Location = new Point(0, 46);
            dataGridViewSRA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSRA.Name = "dataGridViewSRA";
            dataGridViewSRA.ReadOnly = true;
            dataGridViewSRA.RowHeadersWidth = 51;
            dataGridViewSRA.Size = new Size(470, 209);
            dataGridViewSRA.TabIndex = 31;
            // 
            // buttonFilterSRA
            // 
            buttonFilterSRA.BackColor = Color.Transparent;
            buttonFilterSRA.BackgroundImage = (Image)resources.GetObject("buttonFilterSRA.BackgroundImage");
            buttonFilterSRA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFilterSRA.FlatAppearance.BorderSize = 0;
            buttonFilterSRA.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonFilterSRA.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonFilterSRA.FlatStyle = FlatStyle.Flat;
            buttonFilterSRA.ForeColor = Color.Transparent;
            buttonFilterSRA.Location = new Point(314, 8);
            buttonFilterSRA.Margin = new Padding(3, 2, 3, 2);
            buttonFilterSRA.Name = "buttonFilterSRA";
            buttonFilterSRA.Size = new Size(42, 34);
            buttonFilterSRA.TabIndex = 30;
            buttonFilterSRA.TabStop = false;
            buttonFilterSRA.UseVisualStyleBackColor = false;
            buttonFilterSRA.Click += buttonFilterSRA_Click;
            // 
            // comboBoxFilterSRA
            // 
            comboBoxFilterSRA.BackColor = Color.Black;
            comboBoxFilterSRA.ForeColor = Color.Transparent;
            comboBoxFilterSRA.FormattingEnabled = true;
            comboBoxFilterSRA.Items.AddRange(new object[] { "מבצעים ישנים", "מבצעים פעילים", "מבצעים עתידיים", "כל המבצעים" });
            comboBoxFilterSRA.Location = new Point(141, 20);
            comboBoxFilterSRA.Margin = new Padding(3, 2, 3, 2);
            comboBoxFilterSRA.Name = "comboBoxFilterSRA";
            comboBoxFilterSRA.Size = new Size(168, 23);
            comboBoxFilterSRA.TabIndex = 32;
            // 
            // panelSaleCreate
            // 
            panelSaleCreate.BackColor = Color.Transparent;
            panelSaleCreate.Controls.Add(dateTimePickerDateFinish);
            panelSaleCreate.Controls.Add(labelDateFinish);
            panelSaleCreate.Controls.Add(dateTimePickerStart);
            panelSaleCreate.Controls.Add(checkBoxClubSC);
            panelSaleCreate.Controls.Add(textBoxCountSC);
            panelSaleCreate.Controls.Add(numericUpDownPriceSC);
            panelSaleCreate.Controls.Add(label1);
            panelSaleCreate.Controls.Add(labelPriceSC);
            panelSaleCreate.Controls.Add(labelDateStart);
            panelSaleCreate.Controls.Add(labelIdSC);
            panelSaleCreate.Controls.Add(buttonSaveSale);
            panelSaleCreate.Controls.Add(textBoxIdSC);
            panelSaleCreate.Location = new Point(117, 14);
            panelSaleCreate.Margin = new Padding(3, 2, 3, 2);
            panelSaleCreate.Name = "panelSaleCreate";
            panelSaleCreate.Size = new Size(412, 279);
            panelSaleCreate.TabIndex = 36;
            // 
            // numericUpDownPriceSC
            // 
            numericUpDownPriceSC.BackColor = Color.Black;
            numericUpDownPriceSC.ForeColor = Color.White;
            numericUpDownPriceSC.Hexadecimal = true;
            numericUpDownPriceSC.Location = new Point(137, 95);
            numericUpDownPriceSC.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPriceSC.Name = "numericUpDownPriceSC";
            numericUpDownPriceSC.Size = new Size(153, 23);
            numericUpDownPriceSC.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(304, 60);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 31;
            label1.Text = "כמות נדרשת";
            // 
            // labelPriceSC
            // 
            labelPriceSC.AutoSize = true;
            labelPriceSC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPriceSC.Location = new Point(302, 100);
            labelPriceSC.Name = "labelPriceSC";
            labelPriceSC.Size = new Size(76, 15);
            labelPriceSC.TabIndex = 29;
            labelPriceSC.Text = " מחיר בהנחה";
            // 
            // labelDateStart
            // 
            labelDateStart.AutoSize = true;
            labelDateStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDateStart.Location = new Point(304, 136);
            labelDateStart.Name = "labelDateStart";
            labelDateStart.Size = new Size(86, 15);
            labelDateStart.TabIndex = 28;
            labelDateStart.Text = "תאריך התחלה";
            // 
            // labelIdSC
            // 
            labelIdSC.AutoSize = true;
            labelIdSC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIdSC.Location = new Point(304, 20);
            labelIdSC.Name = "labelIdSC";
            labelIdSC.Size = new Size(65, 15);
            labelIdSC.TabIndex = 26;
            labelIdSC.Text = "מזהה מוצר";
            // 
            // buttonSaveSale
            // 
            buttonSaveSale.BackgroundImage = (Image)resources.GetObject("buttonSaveSale.BackgroundImage");
            buttonSaveSale.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveSale.FlatAppearance.BorderSize = 0;
            buttonSaveSale.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSaveSale.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSaveSale.FlatStyle = FlatStyle.Flat;
            buttonSaveSale.Location = new Point(172, 184);
            buttonSaveSale.Margin = new Padding(3, 2, 3, 2);
            buttonSaveSale.Name = "buttonSaveSale";
            buttonSaveSale.Size = new Size(97, 83);
            buttonSaveSale.TabIndex = 21;
            buttonSaveSale.UseVisualStyleBackColor = true;
            buttonSaveSale.Click += buttonSaveSale_Click;
            // 
            // textBoxIdSC
            // 
            textBoxIdSC.BackColor = SystemColors.InactiveCaptionText;
            textBoxIdSC.ForeColor = Color.White;
            textBoxIdSC.Location = new Point(137, 18);
            textBoxIdSC.Margin = new Padding(3, 2, 3, 2);
            textBoxIdSC.Name = "textBoxIdSC";
            textBoxIdSC.Size = new Size(153, 23);
            textBoxIdSC.TabIndex = 27;
            // 
            // panelSaleUpdate
            // 
            panelSaleUpdate.BackColor = Color.Transparent;
            panelSaleUpdate.Controls.Add(checkBoxClubSU);
            panelSaleUpdate.Controls.Add(dateTimePickerFinishSU);
            panelSaleUpdate.Controls.Add(labelIdS);
            panelSaleUpdate.Controls.Add(labelDateFinishSU);
            panelSaleUpdate.Controls.Add(textBoxIdSU);
            panelSaleUpdate.Controls.Add(dateTimePickerStartSU);
            panelSaleUpdate.Controls.Add(buttonIdSU);
            panelSaleUpdate.Controls.Add(textBoxCountSU);
            panelSaleUpdate.Controls.Add(buttonSU);
            panelSaleUpdate.Controls.Add(numericUpDownPriceSU);
            panelSaleUpdate.Controls.Add(labelIdProductSU);
            panelSaleUpdate.Controls.Add(labelCountSU);
            panelSaleUpdate.Controls.Add(textBoxIdProductSU);
            panelSaleUpdate.Controls.Add(labelPriceSU);
            panelSaleUpdate.Controls.Add(labelDateStartSU);
            panelSaleUpdate.Location = new Point(246, 8);
            panelSaleUpdate.Margin = new Padding(3, 2, 3, 2);
            panelSaleUpdate.Name = "panelSaleUpdate";
            panelSaleUpdate.Size = new Size(281, 320);
            panelSaleUpdate.TabIndex = 42;
            // 
            // checkBoxClubSU
            // 
            checkBoxClubSU.AutoSize = true;
            checkBoxClubSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBoxClubSU.Location = new Point(151, 256);
            checkBoxClubSU.Margin = new Padding(3, 2, 3, 2);
            checkBoxClubSU.Name = "checkBoxClubSU";
            checkBoxClubSU.Size = new Size(60, 19);
            checkBoxClubSU.TabIndex = 49;
            checkBoxClubSU.Text = "מועדון";
            checkBoxClubSU.UseVisualStyleBackColor = true;
            // 
            // labelIdS
            // 
            labelIdS.AutoSize = true;
            labelIdS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIdS.Location = new Point(66, 10);
            labelIdS.Name = "labelIdS";
            labelIdS.Size = new Size(101, 15);
            labelIdS.TabIndex = 21;
            labelIdS.Text = "הכנס מזהה מבצע";
            // 
            // textBoxIdSU
            // 
            textBoxIdSU.BackColor = Color.Black;
            textBoxIdSU.ForeColor = Color.White;
            textBoxIdSU.Location = new Point(21, 34);
            textBoxIdSU.Margin = new Padding(3, 2, 3, 2);
            textBoxIdSU.Name = "textBoxIdSU";
            textBoxIdSU.Size = new Size(153, 23);
            textBoxIdSU.TabIndex = 23;
            // 
            // buttonIdSU
            // 
            buttonIdSU.BackgroundImage = (Image)resources.GetObject("buttonIdSU.BackgroundImage");
            buttonIdSU.BackgroundImageLayout = ImageLayout.Stretch;
            buttonIdSU.FlatAppearance.BorderSize = 0;
            buttonIdSU.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonIdSU.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonIdSU.FlatStyle = FlatStyle.Flat;
            buttonIdSU.ImageAlign = ContentAlignment.TopCenter;
            buttonIdSU.Location = new Point(10, -9);
            buttonIdSU.Margin = new Padding(3, 2, 3, 2);
            buttonIdSU.Name = "buttonIdSU";
            buttonIdSU.Size = new Size(66, 54);
            buttonIdSU.TabIndex = 25;
            buttonIdSU.UseVisualStyleBackColor = true;
            buttonIdSU.Click += buttonIdSU_Click;
            // 
            // buttonSU
            // 
            buttonSU.BackgroundImage = (Image)resources.GetObject("buttonSU.BackgroundImage");
            buttonSU.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSU.FlatAppearance.BorderSize = 0;
            buttonSU.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSU.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSU.FlatStyle = FlatStyle.Flat;
            buttonSU.Location = new Point(34, 226);
            buttonSU.Margin = new Padding(3, 2, 3, 2);
            buttonSU.Name = "buttonSU";
            buttonSU.Size = new Size(127, 94);
            buttonSU.TabIndex = 29;
            buttonSU.UseVisualStyleBackColor = true;
            buttonSU.Click += buttonSU_Click;
            // 
            // labelIdProductSU
            // 
            labelIdProductSU.AutoSize = true;
            labelIdProductSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIdProductSU.Location = new Point(188, 71);
            labelIdProductSU.Name = "labelIdProductSU";
            labelIdProductSU.Size = new Size(65, 15);
            labelIdProductSU.TabIndex = 39;
            labelIdProductSU.Text = "מזהה מוצר";
            // 
            // panelSaleDelete
            // 
            panelSaleDelete.BackColor = Color.Transparent;
            panelSaleDelete.Controls.Add(textBoxIdSD);
            panelSaleDelete.Controls.Add(labelIdSD);
            panelSaleDelete.Controls.Add(buttonSD);
            panelSaleDelete.Location = new Point(246, 88);
            panelSaleDelete.Margin = new Padding(3, 2, 3, 2);
            panelSaleDelete.Name = "panelSaleDelete";
            panelSaleDelete.Size = new Size(200, 118);
            panelSaleDelete.TabIndex = 44;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(547, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 8F);
            button1.Location = new Point(587, 289);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(73, 32);
            button1.TabIndex = 45;
            button1.Text = "הצג מבצע";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelSaleRead
            // 
            panelSaleRead.BackColor = Color.Transparent;
            panelSaleRead.Controls.Add(textBoxClubPR);
            panelSaleRead.Controls.Add(label8);
            panelSaleRead.Controls.Add(textBoxFinishDatePR);
            panelSaleRead.Controls.Add(textBoxStartDatePR);
            panelSaleRead.Controls.Add(label2);
            panelSaleRead.Controls.Add(label3);
            panelSaleRead.Controls.Add(textBoxIdPR);
            panelSaleRead.Controls.Add(buttonIdSR);
            panelSaleRead.Controls.Add(textBoxCountPR);
            panelSaleRead.Controls.Add(numericUpDownPricePR);
            panelSaleRead.Controls.Add(label4);
            panelSaleRead.Controls.Add(label5);
            panelSaleRead.Controls.Add(textBoxIdProductPR);
            panelSaleRead.Controls.Add(label6);
            panelSaleRead.Controls.Add(label7);
            panelSaleRead.Location = new Point(159, 10);
            panelSaleRead.Margin = new Padding(3, 2, 3, 2);
            panelSaleRead.Name = "panelSaleRead";
            panelSaleRead.Size = new Size(393, 320);
            panelSaleRead.TabIndex = 50;
            // 
            // textBoxClubPR
            // 
            textBoxClubPR.BackColor = SystemColors.InactiveCaptionText;
            textBoxClubPR.ForeColor = Color.White;
            textBoxClubPR.Location = new Point(100, 260);
            textBoxClubPR.Margin = new Padding(3, 2, 3, 2);
            textBoxClubPR.Name = "textBoxClubPR";
            textBoxClubPR.ReadOnly = true;
            textBoxClubPR.Size = new Size(153, 23);
            textBoxClubPR.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(267, 262);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 52;
            label8.Text = "מועדון";
            // 
            // textBoxFinishDatePR
            // 
            textBoxFinishDatePR.BackColor = SystemColors.InactiveCaptionText;
            textBoxFinishDatePR.ForeColor = Color.White;
            textBoxFinishDatePR.Location = new Point(100, 226);
            textBoxFinishDatePR.Margin = new Padding(3, 2, 3, 2);
            textBoxFinishDatePR.Name = "textBoxFinishDatePR";
            textBoxFinishDatePR.ReadOnly = true;
            textBoxFinishDatePR.Size = new Size(153, 23);
            textBoxFinishDatePR.TabIndex = 51;
            // 
            // textBoxStartDatePR
            // 
            textBoxStartDatePR.BackColor = SystemColors.InactiveCaptionText;
            textBoxStartDatePR.ForeColor = Color.White;
            textBoxStartDatePR.Location = new Point(101, 188);
            textBoxStartDatePR.Margin = new Padding(3, 2, 3, 2);
            textBoxStartDatePR.Name = "textBoxStartDatePR";
            textBoxStartDatePR.ReadOnly = true;
            textBoxStartDatePR.Size = new Size(153, 23);
            textBoxStartDatePR.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(143, 17);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 21;
            label2.Text = "הכנס מזהה מבצע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(267, 228);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 47;
            label3.Text = "תאריך סיום";
            // 
            // textBoxIdPR
            // 
            textBoxIdPR.BackColor = Color.Black;
            textBoxIdPR.ForeColor = Color.White;
            textBoxIdPR.Location = new Point(98, 41);
            textBoxIdPR.Margin = new Padding(3, 2, 3, 2);
            textBoxIdPR.Name = "textBoxIdPR";
            textBoxIdPR.Size = new Size(153, 23);
            textBoxIdPR.TabIndex = 23;
            // 
            // buttonIdSR
            // 
            buttonIdSR.BackgroundImage = (Image)resources.GetObject("buttonIdSR.BackgroundImage");
            buttonIdSR.BackgroundImageLayout = ImageLayout.Stretch;
            buttonIdSR.FlatAppearance.BorderSize = 0;
            buttonIdSR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonIdSR.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonIdSR.FlatStyle = FlatStyle.Flat;
            buttonIdSR.ImageAlign = ContentAlignment.TopCenter;
            buttonIdSR.Location = new Point(87, -2);
            buttonIdSR.Margin = new Padding(3, 2, 3, 2);
            buttonIdSR.Name = "buttonIdSR";
            buttonIdSR.Size = new Size(66, 54);
            buttonIdSR.TabIndex = 25;
            buttonIdSR.UseVisualStyleBackColor = true;
            buttonIdSR.Click += buttonIdSR_Click;
            // 
            // textBoxCountPR
            // 
            textBoxCountPR.BackColor = SystemColors.InactiveCaptionText;
            textBoxCountPR.ForeColor = Color.White;
            textBoxCountPR.Location = new Point(99, 112);
            textBoxCountPR.Margin = new Padding(3, 2, 3, 2);
            textBoxCountPR.Name = "textBoxCountPR";
            textBoxCountPR.ReadOnly = true;
            textBoxCountPR.Size = new Size(153, 23);
            textBoxCountPR.TabIndex = 45;
            // 
            // numericUpDownPricePR
            // 
            numericUpDownPricePR.BackColor = Color.Black;
            numericUpDownPricePR.ForeColor = Color.White;
            numericUpDownPricePR.Hexadecimal = true;
            numericUpDownPricePR.Location = new Point(99, 153);
            numericUpDownPricePR.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPricePR.Name = "numericUpDownPricePR";
            numericUpDownPricePR.ReadOnly = true;
            numericUpDownPricePR.Size = new Size(153, 23);
            numericUpDownPricePR.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(265, 78);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 39;
            label4.Text = "מזהה מוצר";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(265, 118);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 43;
            label5.Text = "כמות נדרשת";
            // 
            // textBoxIdProductPR
            // 
            textBoxIdProductPR.BackColor = SystemColors.InactiveCaptionText;
            textBoxIdProductPR.ForeColor = Color.White;
            textBoxIdProductPR.Location = new Point(99, 76);
            textBoxIdProductPR.Margin = new Padding(3, 2, 3, 2);
            textBoxIdProductPR.Name = "textBoxIdProductPR";
            textBoxIdProductPR.ReadOnly = true;
            textBoxIdProductPR.Size = new Size(153, 23);
            textBoxIdProductPR.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(263, 158);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 42;
            label6.Text = " מחיר בהנחה";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(266, 194);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 41;
            label7.Text = "תאריך התחלה";
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(panelSaleRead);
            Controls.Add(panelSaleUpdate);
            Controls.Add(button1);
            Controls.Add(panelSaleReadAll);
            Controls.Add(buttonSaleReadAll);
            Controls.Add(buttonSaleCreate);
            Controls.Add(buttonSaleDelete);
            Controls.Add(buttonSaleUpdate);
            Controls.Add(panelSaleCreate);
            Controls.Add(panelSaleDelete);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SaleForm";
            Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceSU).EndInit();
            panelSaleReadAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSRA).EndInit();
            panelSaleCreate.ResumeLayout(false);
            panelSaleCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceSC).EndInit();
            panelSaleUpdate.ResumeLayout(false);
            panelSaleUpdate.PerformLayout();
            panelSaleDelete.ResumeLayout(false);
            panelSaleDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSaleRead.ResumeLayout(false);
            panelSaleRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSaleReadAll;
        private Button buttonSaleCreate;
        private TextBox textBoxIdSD;
        private Label labelIdSD;
        private Button buttonSD;
        private DateTimePicker dateTimePickerDateFinish;
        private Button buttonSaleDelete;
        private DateTimePicker dateTimePickerFinishSU;
        private Label labelDateFinish;
        private DateTimePicker dateTimePickerStartSU;
        private TextBox textBoxCountSU;
        private DateTimePicker dateTimePickerStart;
        private CheckBox checkBoxClubSC;
        private TextBox textBoxCountSC;
        private Label labelDateFinishSU;
        private NumericUpDown numericUpDownPriceSU;
        private Label labelCountSU;
        private TextBox textBoxIdProductSU;
        private Label labelPriceSU;
        private Label labelDateStartSU;
        private Button buttonSaleUpdate;
        private Panel panelSaleReadAll;
        private DataGridView dataGridViewSRA;
        private Button buttonFilterSRA;
        private ComboBox comboBoxFilterSRA;
        private Panel panelSaleCreate;
        private NumericUpDown numericUpDownPriceSC;
        private Label label1;
        private Label labelPriceSC;
        private Label labelDateStart;
        private Label labelIdSC;
        private Button buttonSaveSale;
        private TextBox textBoxIdSC;
        private Panel panelSaleUpdate;
        private Label labelIdS;
        private TextBox textBoxIdSU;
        private Button buttonIdSU;
        private Button buttonSU;
        private Label labelIdProductSU;
        private Panel panelSaleDelete;
        private PictureBox pictureBox1;
        private CheckBox checkBoxClubSU;
        private Button button1;
        private Panel panelSaleRead;
        private TextBox textBoxClubPR;
        private Label label8;
        private TextBox textBoxFinishDatePR;
        private TextBox textBoxStartDatePR;
        private Label label2;
        private Label label3;
        private TextBox textBoxIdPR;
        private Button buttonIdSR;
        private TextBox textBoxCountPR;
        private NumericUpDown numericUpDownPricePR;
        private Label label4;
        private Label label5;
        private TextBox textBoxIdProductPR;
        private Label label6;
        private Label label7;
    }
}