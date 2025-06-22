namespace UI
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            signInEmployee = new Button();
            pictureBox1 = new PictureBox();
            signInManager = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signInEmployee
            // 
            signInEmployee.BackColor = Color.FromArgb(255, 224, 192);
            signInEmployee.Cursor = Cursors.Hand;
            signInEmployee.FlatAppearance.BorderSize = 0;
            signInEmployee.FlatStyle = FlatStyle.Flat;
            signInEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            signInEmployee.ForeColor = Color.White;
            signInEmployee.Location = new Point(656, 352);
            signInEmployee.Margin = new Padding(3, 2, 3, 2);
            signInEmployee.Name = "signInEmployee";
            signInEmployee.Size = new Size(122, 30);
            signInEmployee.TabIndex = 0;
            signInEmployee.Text = "ביצוע קניה";
            signInEmployee.UseVisualStyleBackColor = false;
            signInEmployee.Click += signInEmployee_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // signInManager
            // 
            signInManager.BackColor = Color.FromArgb(255, 224, 192);
            signInManager.Cursor = Cursors.Hand;
            signInManager.FlatAppearance.BorderSize = 0;
            signInManager.FlatStyle = FlatStyle.Flat;
            signInManager.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            signInManager.ForeColor = Color.White;
            signInManager.Location = new Point(656, 400);
            signInManager.Margin = new Padding(3, 2, 3, 2);
            signInManager.Name = "signInManager";
            signInManager.Size = new Size(122, 30);
            signInManager.TabIndex = 0;
            signInManager.Text = "ניהול מלאי";
            signInManager.UseVisualStyleBackColor = false;
            signInManager.Click += signInManager_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(signInManager);
            Controls.Add(signInEmployee);
            Controls.Add(pictureBox1);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyStore";
            TransparencyKey = SystemColors.ButtonShadow;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button signInEmployee;
        private PictureBox pictureBox1;
        private Button signInManager;
    }
}
