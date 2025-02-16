namespace mani_hardware_shop
{
    partial class customer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            label9 = new Label();
            txt_Phone = new TextBox();
            label8 = new Label();
            txt_Name = new TextBox();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            btn_Customer = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label11 = new Label();
            pictureBox6 = new PictureBox();
            panel1 = new Panel();
            lbl_User = new Label();
            pictureBox8 = new PictureBox();
            btn_Logout = new Button();
            button2 = new Button();
            btn_Billing = new Button();
            btn_Category = new Button();
            pictureBox1 = new PictureBox();
            btn_Item = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            cmb_Gender = new ComboBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            lbl_Id = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(887, 100);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 25;
            label9.Text = "Gender";
            label9.Click += label9_Click;
            // 
            // txt_Phone
            // 
            txt_Phone.BorderStyle = BorderStyle.FixedSingle;
            txt_Phone.Location = new Point(1241, 138);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(159, 27);
            txt_Phone.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1291, 100);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 23;
            label8.Text = "Phone";
            // 
            // txt_Name
            // 
            txt_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Name.Location = new Point(414, 138);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(168, 27);
            txt_Name.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 100);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 19;
            label6.Text = "Name";
            label6.Click += label6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1288, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(915, 431);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 43;
            label12.Text = "Customer List";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(565, 454);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(811, 360);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(1241, 369);
            button3.Name = "button3";
            button3.Size = new Size(115, 40);
            button3.TabIndex = 41;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn_Customer
            // 
            btn_Customer.BackColor = Color.Green;
            btn_Customer.Location = new Point(861, 369);
            btn_Customer.Name = "btn_Customer";
            btn_Customer.Size = new Size(150, 40);
            btn_Customer.TabIndex = 40;
            btn_Customer.Text = "Add customer";
            btn_Customer.UseVisualStyleBackColor = false;
            btn_Customer.Click += btn_Customer_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(437, 369);
            button1.Name = "button1";
            button1.Size = new Size(148, 40);
            button1.TabIndex = 39;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(281, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1336, 57);
            panel2.TabIndex = 28;
            panel2.Paint += panel2_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(587, 11);
            label11.Name = "label11";
            label11.Size = new Size(254, 32);
            label11.TabIndex = 19;
            label11.Text = "Mani Hardware Shop";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(496, 2);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(63, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(lbl_User);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(btn_Logout);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btn_Billing);
            panel1.Controls.Add(btn_Category);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_Item);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 826);
            panel1.TabIndex = 27;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            lbl_User.Location = new Point(88, 40);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(0, 25);
            lbl_User.TabIndex = 47;
            lbl_User.TextAlign = ContentAlignment.MiddleCenter;
            lbl_User.Click += lbl_User_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 27);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(55, 47);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 48;
            pictureBox8.TabStop = false;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.Green;
            btn_Logout.FlatAppearance.BorderSize = 0;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            btn_Logout.ForeColor = SystemColors.ActiveCaptionText;
            btn_Logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Logout.Location = new Point(60, 740);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(216, 42);
            btn_Logout.TabIndex = 46;
            btn_Logout.Text = "Logout";
            btn_Logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(60, 499);
            button2.Name = "button2";
            button2.Size = new Size(216, 42);
            button2.TabIndex = 45;
            button2.Text = "Customer";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_Billing
            // 
            btn_Billing.BackColor = Color.Green;
            btn_Billing.FlatAppearance.BorderSize = 0;
            btn_Billing.FlatStyle = FlatStyle.Flat;
            btn_Billing.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            btn_Billing.ForeColor = SystemColors.ActiveCaptionText;
            btn_Billing.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Billing.Location = new Point(60, 424);
            btn_Billing.Name = "btn_Billing";
            btn_Billing.Size = new Size(216, 42);
            btn_Billing.TabIndex = 44;
            btn_Billing.Text = "Billing";
            btn_Billing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Billing.UseVisualStyleBackColor = false;
            btn_Billing.Click += btn_Billing_Click_1;
            // 
            // btn_Category
            // 
            btn_Category.BackColor = Color.Green;
            btn_Category.FlatAppearance.BorderSize = 0;
            btn_Category.FlatStyle = FlatStyle.Flat;
            btn_Category.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            btn_Category.ForeColor = SystemColors.ActiveCaptionText;
            btn_Category.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Category.Location = new Point(60, 344);
            btn_Category.Name = "btn_Category";
            btn_Category.Size = new Size(216, 42);
            btn_Category.TabIndex = 43;
            btn_Category.Text = "Category";
            btn_Category.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Category.UseVisualStyleBackColor = false;
            btn_Category.Click += btn_Category_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 266);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // btn_Item
            // 
            btn_Item.BackColor = Color.Green;
            btn_Item.FlatAppearance.BorderSize = 0;
            btn_Item.FlatStyle = FlatStyle.Flat;
            btn_Item.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            btn_Item.ForeColor = SystemColors.ActiveCaptionText;
            btn_Item.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Item.Location = new Point(60, 266);
            btn_Item.Name = "btn_Item";
            btn_Item.Size = new Size(216, 42);
            btn_Item.TabIndex = 40;
            btn_Item.Text = "Item List";
            btn_Item.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Item.UseVisualStyleBackColor = false;
            btn_Item.Click += btn_Item_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 499);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(4, 740);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 35;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 344);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 424);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // cmb_Gender
            // 
            cmb_Gender.FormattingEnabled = true;
            cmb_Gender.Items.AddRange(new object[] { "Male", "Female" });
            cmb_Gender.Location = new Point(860, 138);
            cmb_Gender.Name = "cmb_Gender";
            cmb_Gender.Size = new Size(151, 28);
            cmb_Gender.TabIndex = 44;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 50;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Location = new Point(281, 100);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(0, 20);
            lbl_Id.TabIndex = 46;
            // 
            // customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 826);
            Controls.Add(lbl_Id);
            Controls.Add(cmb_Gender);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(btn_Customer);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(txt_Phone);
            Controls.Add(label8);
            Controls.Add(txt_Name);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customer";
            Load += customer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
        private Label label9;
        private TextBox txt_Phone;
        private Label label8;
        private TextBox txt_Name;
        private Label label6;
        private PictureBox pictureBox7;
        private Label label12;
        private DataGridView dataGridView1;
        private Button button3;
        private Button btn_Customer;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cmb_Gender;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Button btn_Logout;
        private Button button2;
        private Button btn_Billing;
        private Button btn_Category;
        private PictureBox pictureBox1;
        private Button btn_Item;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label11;
        private PictureBox pictureBox6;
        private Label lbl_User;
        private PictureBox pictureBox8;
        private Label lbl_Id;
    }
}