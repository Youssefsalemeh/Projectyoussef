namespace FinalProject
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            label1 = new Label();
            label10 = new Label();
            txt_Email = new TextBox();
            txt_birth = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            custDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label5 = new Label();
            btn_deletecust = new Button();
            btn_editcust = new Button();
            btn_addcust = new Button();
            txt_address = new TextBox();
            txt_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_Phone = new TextBox();
            label2 = new Label();
            txt_cid = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)custDGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 546);
            panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(5, 110);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(159, 60);
            button4.TabIndex = 0;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 258);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(1096, 0);
            label10.Name = "label10";
            label10.Size = new Size(32, 34);
            label10.TabIndex = 10;
            label10.Text = "x";
            label10.Click += label10_Click;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(604, 325);
            txt_Email.Margin = new Padding(5, 4, 5, 4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(267, 32);
            txt_Email.TabIndex = 4;
            // 
            // txt_birth
            // 
            txt_birth.Location = new Point(604, 459);
            txt_birth.Margin = new Padding(5, 4, 5, 4);
            txt_birth.Name = "txt_birth";
            txt_birth.Size = new Size(267, 32);
            txt_birth.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(505, 328);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 0;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(511, 466);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 0;
            label9.Text = "Birth:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 395);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 0;
            label7.Text = "Phone:";
            // 
            // custDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            custDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            custDGV.BackgroundColor = Color.Silver;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            custDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            custDGV.ColumnHeadersHeight = 4;
            custDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            custDGV.DefaultCellStyle = dataGridViewCellStyle3;
            custDGV.GridColor = Color.FromArgb(231, 229, 255);
            custDGV.Location = new Point(174, 38);
            custDGV.Margin = new Padding(5, 4, 5, 4);
            custDGV.Name = "custDGV";
            custDGV.ReadOnly = true;
            custDGV.RowHeadersVisible = false;
            custDGV.RowHeadersWidth = 51;
            custDGV.Size = new Size(925, 245);
            custDGV.TabIndex = 13;
            custDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            custDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            custDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            custDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            custDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            custDGV.ThemeStyle.BackColor = Color.Silver;
            custDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            custDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            custDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            custDGV.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            custDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            custDGV.ThemeStyle.HeaderStyle.Height = 4;
            custDGV.ThemeStyle.ReadOnly = true;
            custDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            custDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            custDGV.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            custDGV.ThemeStyle.RowsStyle.Height = 29;
            custDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            custDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            custDGV.CellContentClick += custDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(565, 9);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 14;
            label5.Text = "Customers List";
            // 
            // btn_deletecust
            // 
            btn_deletecust.BackColor = Color.Black;
            btn_deletecust.FlatStyle = FlatStyle.Popup;
            btn_deletecust.ForeColor = Color.White;
            btn_deletecust.Location = new Point(946, 459);
            btn_deletecust.Margin = new Padding(5, 4, 5, 4);
            btn_deletecust.Name = "btn_deletecust";
            btn_deletecust.Size = new Size(143, 36);
            btn_deletecust.TabIndex = 9;
            btn_deletecust.Text = "Delete";
            btn_deletecust.UseVisualStyleBackColor = false;
            btn_deletecust.Click += btn_deletecust_Click;
            // 
            // btn_editcust
            // 
            btn_editcust.BackColor = Color.Black;
            btn_editcust.FlatStyle = FlatStyle.Popup;
            btn_editcust.ForeColor = Color.White;
            btn_editcust.Location = new Point(946, 384);
            btn_editcust.Margin = new Padding(5, 4, 5, 4);
            btn_editcust.Name = "btn_editcust";
            btn_editcust.Size = new Size(143, 36);
            btn_editcust.TabIndex = 8;
            btn_editcust.Text = "Edit";
            btn_editcust.UseVisualStyleBackColor = false;
            btn_editcust.Click += btn_editcust_Click;
            // 
            // btn_addcust
            // 
            btn_addcust.BackColor = Color.Black;
            btn_addcust.FlatStyle = FlatStyle.Popup;
            btn_addcust.ForeColor = Color.White;
            btn_addcust.Location = new Point(946, 314);
            btn_addcust.Margin = new Padding(5, 4, 5, 4);
            btn_addcust.Name = "btn_addcust";
            btn_addcust.Size = new Size(143, 36);
            btn_addcust.TabIndex = 7;
            btn_addcust.Text = "Add";
            btn_addcust.UseVisualStyleBackColor = false;
            btn_addcust.Click += btn_addcust_Click;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(297, 462);
            txt_address.Margin = new Padding(5, 4, 5, 4);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(204, 32);
            txt_address.TabIndex = 3;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(297, 395);
            txt_name.Margin = new Padding(5, 4, 5, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(204, 32);
            txt_name.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 465);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 0;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 395);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(604, 388);
            txt_Phone.Margin = new Padding(5, 4, 5, 4);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(267, 32);
            txt_Phone.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 332);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // txt_cid
            // 
            txt_cid.Location = new Point(297, 325);
            txt_cid.Name = "txt_cid";
            txt_cid.Size = new Size(200, 32);
            txt_cid.TabIndex = 1;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 546);
            Controls.Add(txt_cid);
            Controls.Add(label2);
            Controls.Add(txt_Phone);
            Controls.Add(label10);
            Controls.Add(txt_Email);
            Controls.Add(txt_birth);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(custDGV);
            Controls.Add(label5);
            Controls.Add(btn_deletecust);
            Controls.Add(btn_editcust);
            Controls.Add(btn_addcust);
            Controls.Add(txt_address);
            Controls.Add(txt_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "0";
            Load += Customer_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)custDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button4;
        private Label label1;
        private Label label10;
        private TextBox txt_Email;
        private TextBox txt_birth;
        private Label label8;
        private Label label9;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView custDGV;
        private Label label5;
        private Button btn_deletecust;
        private Button btn_editcust;
        private Button btn_addcust;
        private TextBox txt_address;
        private TextBox txt_name;
        private Label label4;
        private Label label3;
        private TextBox txt_Phone;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txt_cid;
    }
}