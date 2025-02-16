namespace mani_hardware_shop
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox7 = new PictureBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            btn_Reset = new Button();
            btn_Addbill = new Button();
            txt_Billedby = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txt_Price = new TextBox();
            label8 = new Label();
            txt_Item = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            pictureBox6 = new PictureBox();
            panel1 = new Panel();
            btn_Logout = new Button();
            btn_Customer = new Button();
            btn_Billing = new Button();
            btn_Category = new Button();
            pictureBox1 = new PictureBox();
            btn_Item = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label13 = new Label();
            dataGridView2 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Totalprice = new DataGridViewTextBoxColumn();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            rdo_UPI = new RadioButton();
            rdo_Card = new RadioButton();
            rdo_Cash = new RadioButton();
            cmb_Quantity = new ComboBox();
            button1 = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            txt_Customerid = new TextBox();
            label2 = new Label();
            txt_FinalCost = new TextBox();
            label14 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            txt_Productid = new TextBox();
            label1 = new Label();
            lbl_User = new Label();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
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
            label12.Location = new Point(532, 440);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 33;
            label12.Text = "Item List";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.Row;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(287, 463);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(561, 351);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.Red;
            btn_Reset.Location = new Point(532, 352);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(115, 40);
            btn_Reset.TabIndex = 31;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Addbill
            // 
            btn_Addbill.BackColor = Color.Green;
            btn_Addbill.Location = new Point(315, 352);
            btn_Addbill.Name = "btn_Addbill";
            btn_Addbill.Size = new Size(150, 40);
            btn_Addbill.TabIndex = 30;
            btn_Addbill.Text = "Add bill";
            btn_Addbill.UseVisualStyleBackColor = false;
            btn_Addbill.Click += btn_Addbill_Click;
            // 
            // txt_Billedby
            // 
            txt_Billedby.BorderStyle = BorderStyle.FixedSingle;
            txt_Billedby.Location = new Point(287, 123);
            txt_Billedby.Name = "txt_Billedby";
            txt_Billedby.ReadOnly = true;
            txt_Billedby.Size = new Size(168, 27);
            txt_Billedby.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(337, 84);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 27;
            label10.Text = "Billed by";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(750, 210);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 25;
            label9.Text = "Quantity";
            // 
            // txt_Price
            // 
            txt_Price.BorderStyle = BorderStyle.FixedSingle;
            txt_Price.Location = new Point(511, 248);
            txt_Price.Name = "txt_Price";
            txt_Price.ReadOnly = true;
            txt_Price.Size = new Size(162, 27);
            txt_Price.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 210);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 23;
            label8.Text = "Price";
            // 
            // txt_Item
            // 
            txt_Item.BorderStyle = BorderStyle.FixedSingle;
            txt_Item.Location = new Point(287, 248);
            txt_Item.Name = "txt_Item";
            txt_Item.ReadOnly = true;
            txt_Item.Size = new Size(168, 27);
            txt_Item.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 210);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 19;
            label6.Text = "Item";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(281, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1336, 57);
            panel2.TabIndex = 18;
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
            panel1.Controls.Add(btn_Customer);
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
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
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
            // btn_Customer
            // 
            btn_Customer.BackColor = Color.Green;
            btn_Customer.FlatAppearance.BorderSize = 0;
            btn_Customer.FlatStyle = FlatStyle.Flat;
            btn_Customer.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            btn_Customer.ForeColor = SystemColors.ActiveCaptionText;
            btn_Customer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Customer.Location = new Point(60, 499);
            btn_Customer.Name = "btn_Customer";
            btn_Customer.Size = new Size(216, 42);
            btn_Customer.TabIndex = 45;
            btn_Customer.Text = "Customer";
            btn_Customer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Customer.UseVisualStyleBackColor = false;
            btn_Customer.Click += btn_Customer_Click;
            // 
            // btn_Billing
            // 
            btn_Billing.BackColor = Color.LightCyan;
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
            btn_Category.Click += btn_Category_Click;
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
            btn_Item.Click += btn_Item_Click;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1289, 264);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 35;
            label13.Text = "Billing List";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Id, Item, Price, Quantity, Totalprice });
            dataGridView2.Location = new Point(1044, 287);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(561, 401);
            dataGridView2.TabIndex = 34;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Item
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            Item.DefaultCellStyle = dataGridViewCellStyle2;
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Totalprice
            // 
            Totalprice.HeaderText = "Totalprice";
            Totalprice.MinimumWidth = 6;
            Totalprice.Name = "Totalprice";
            Totalprice.Width = 125;
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(rdo_UPI);
            guna2GroupBox1.Controls.Add(rdo_Card);
            guna2GroupBox1.Controls.Add(rdo_Cash);
            guna2GroupBox1.CustomizableEdges = customizableEdges1;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(1044, 84);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GroupBox1.Size = new Size(561, 146);
            guna2GroupBox1.TabIndex = 36;
            guna2GroupBox1.Text = "Payment mode";
            // 
            // rdo_UPI
            // 
            rdo_UPI.AutoSize = true;
            rdo_UPI.Location = new Point(461, 75);
            rdo_UPI.Name = "rdo_UPI";
            rdo_UPI.Size = new Size(52, 24);
            rdo_UPI.TabIndex = 40;
            rdo_UPI.TabStop = true;
            rdo_UPI.Text = "UPI";
            rdo_UPI.UseVisualStyleBackColor = true;
            // 
            // rdo_Card
            // 
            rdo_Card.AutoSize = true;
            rdo_Card.Location = new Point(249, 75);
            rdo_Card.Name = "rdo_Card";
            rdo_Card.Size = new Size(61, 24);
            rdo_Card.TabIndex = 39;
            rdo_Card.TabStop = true;
            rdo_Card.Text = "Card";
            rdo_Card.UseVisualStyleBackColor = true;
            // 
            // rdo_Cash
            // 
            rdo_Cash.AutoSize = true;
            rdo_Cash.Location = new Point(29, 75);
            rdo_Cash.Name = "rdo_Cash";
            rdo_Cash.Size = new Size(61, 24);
            rdo_Cash.TabIndex = 38;
            rdo_Cash.TabStop = true;
            rdo_Cash.Text = "Cash";
            rdo_Cash.UseVisualStyleBackColor = true;
            // 
            // cmb_Quantity
            // 
            cmb_Quantity.FormattingEnabled = true;
            cmb_Quantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmb_Quantity.Location = new Point(713, 248);
            cmb_Quantity.Name = "cmb_Quantity";
            cmb_Quantity.Size = new Size(151, 28);
            cmb_Quantity.TabIndex = 37;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1293, 766);
            button1.Name = "button1";
            button1.Size = new Size(148, 48);
            button1.TabIndex = 38;
            button1.Text = "Paid";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // txt_Customerid
            // 
            txt_Customerid.BorderStyle = BorderStyle.FixedSingle;
            txt_Customerid.Location = new Point(511, 123);
            txt_Customerid.Name = "txt_Customerid";
            txt_Customerid.Size = new Size(162, 27);
            txt_Customerid.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 85);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 39;
            label2.Text = "Customerid";
            // 
            // txt_FinalCost
            // 
            txt_FinalCost.BorderStyle = BorderStyle.FixedSingle;
            txt_FinalCost.Font = new Font("Segoe UI", 9F);
            txt_FinalCost.ForeColor = Color.ForestGreen;
            txt_FinalCost.Location = new Point(1443, 722);
            txt_FinalCost.Name = "txt_FinalCost";
            txt_FinalCost.ReadOnly = true;
            txt_FinalCost.Size = new Size(162, 27);
            txt_FinalCost.TabIndex = 41;
            txt_FinalCost.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1348, 729);
            label14.Name = "label14";
            label14.Size = new Size(86, 20);
            label14.TabIndex = 42;
            label14.Text = "Grand Total";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // txt_Productid
            // 
            txt_Productid.BorderStyle = BorderStyle.FixedSingle;
            txt_Productid.Location = new Point(713, 123);
            txt_Productid.Name = "txt_Productid";
            txt_Productid.ReadOnly = true;
            txt_Productid.Size = new Size(168, 27);
            txt_Productid.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(750, 85);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 44;
            label1.Text = "Productid";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            lbl_User.Location = new Point(88, 37);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(0, 25);
            lbl_User.TabIndex = 47;
            lbl_User.TextAlign = ContentAlignment.MiddleCenter;
            lbl_User.Click += lbl_User_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 24);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(55, 47);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 48;
            pictureBox8.TabStop = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1617, 826);
            Controls.Add(label1);
            Controls.Add(txt_Productid);
            Controls.Add(label14);
            Controls.Add(txt_FinalCost);
            Controls.Add(txt_Customerid);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(cmb_Quantity);
            Controls.Add(guna2GroupBox1);
            Controls.Add(label13);
            Controls.Add(dataGridView2);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Addbill);
            Controls.Add(txt_Billedby);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_Price);
            Controls.Add(label8);
            Controls.Add(txt_Item);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox7;
        private Label label12;
        private DataGridView dataGridView1;
        private Button btn_Reset;
        private Button btn_Addbill;
        private TextBox txt_Billedby;
        private Label label10;
        private Label label9;
        private TextBox txt_Price;
        private Label label8;
        private TextBox txt_Item;
        private Label label6;
        private Panel panel2;
        private Panel panel1;
        private Label label13;
        private DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private ComboBox cmb_Quantity;
        private Button button1;
        private RadioButton rdo_UPI;
        private RadioButton rdo_Card;
        private RadioButton rdo_Cash;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private TextBox txt_Customerid;
        private Label label2;
        private TextBox txt_FinalCost;
        private Label label14;
        private Button btn_Logout;
        private Button btn_Customer;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Totalprice;
        private Label label1;
        private TextBox txt_Productid;
        private Label lbl_User;
        private PictureBox pictureBox8;
    }
}