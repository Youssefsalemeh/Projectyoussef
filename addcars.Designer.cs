namespace FinalProject
{
    partial class addcars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcars));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            label1 = new Label();
            label6 = new Label();
            carDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label5 = new Label();
            btn_deletecar = new Button();
            btn_editcar = new Button();
            btn_addcar = new Button();
            txt_model = new TextBox();
            txt_brand = new TextBox();
            txt_regNo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            txt_available = new ComboBox();
            txt_color = new TextBox();
            txtprice = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Available = new Button();
            refleshbtn = new Button();
            text_search = new TextBox();
            search_btn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDGV).BeginInit();
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
            panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
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
            button4.Location = new Point(5, 129);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(156, 60);
            button4.TabIndex = 0;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 279);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Cars";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1547, -2);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 34);
            label6.TabIndex = 25;
            label6.Text = "x";
            // 
            // carDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            carDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            carDGV.BackgroundColor = Color.Silver;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            carDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            carDGV.ColumnHeadersHeight = 4;
            carDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            carDGV.DefaultCellStyle = dataGridViewCellStyle3;
            carDGV.GridColor = Color.FromArgb(231, 229, 255);
            carDGV.Location = new Point(179, 69);
            carDGV.Margin = new Padding(5, 4, 5, 4);
            carDGV.Name = "carDGV";
            carDGV.ReadOnly = true;
            carDGV.RowHeadersVisible = false;
            carDGV.RowHeadersWidth = 51;
            carDGV.Size = new Size(913, 292);
            carDGV.TabIndex = 20;
            carDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            carDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            carDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            carDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            carDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            carDGV.ThemeStyle.BackColor = Color.Silver;
            carDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            carDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            carDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            carDGV.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            carDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            carDGV.ThemeStyle.HeaderStyle.Height = 4;
            carDGV.ThemeStyle.ReadOnly = true;
            carDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            carDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            carDGV.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            carDGV.ThemeStyle.RowsStyle.Height = 29;
            carDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            carDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            carDGV.CellContentClick += carDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 22);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 16;
            label5.Text = "Cars List";
            // 
            // btn_deletecar
            // 
            btn_deletecar.BackColor = Color.Black;
            btn_deletecar.FlatStyle = FlatStyle.Popup;
            btn_deletecar.ForeColor = Color.White;
            btn_deletecar.Location = new Point(918, 491);
            btn_deletecar.Margin = new Padding(5, 4, 5, 4);
            btn_deletecar.Name = "btn_deletecar";
            btn_deletecar.Size = new Size(143, 36);
            btn_deletecar.TabIndex = 9;
            btn_deletecar.Text = "Delete";
            btn_deletecar.UseVisualStyleBackColor = false;
            btn_deletecar.Click += btn_deletecar_Click;
            // 
            // btn_editcar
            // 
            btn_editcar.BackColor = Color.Black;
            btn_editcar.FlatStyle = FlatStyle.Popup;
            btn_editcar.ForeColor = Color.White;
            btn_editcar.Location = new Point(918, 434);
            btn_editcar.Margin = new Padding(5, 4, 5, 4);
            btn_editcar.Name = "btn_editcar";
            btn_editcar.Size = new Size(143, 36);
            btn_editcar.TabIndex = 8;
            btn_editcar.Text = "Edit";
            btn_editcar.UseVisualStyleBackColor = false;
            btn_editcar.Click += btn_editcar_Click;
            // 
            // btn_addcar
            // 
            btn_addcar.BackColor = Color.Black;
            btn_addcar.FlatStyle = FlatStyle.Popup;
            btn_addcar.ForeColor = Color.White;
            btn_addcar.Location = new Point(918, 370);
            btn_addcar.Margin = new Padding(5, 4, 5, 4);
            btn_addcar.Name = "btn_addcar";
            btn_addcar.Size = new Size(143, 36);
            btn_addcar.TabIndex = 7;
            btn_addcar.Text = "Add";
            btn_addcar.UseVisualStyleBackColor = false;
            btn_addcar.Click += btn_addcar_Click;
            // 
            // txt_model
            // 
            txt_model.Location = new Point(306, 490);
            txt_model.Margin = new Padding(5, 4, 5, 4);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(175, 32);
            txt_model.TabIndex = 3;
            // 
            // txt_brand
            // 
            txt_brand.Location = new Point(306, 431);
            txt_brand.Margin = new Padding(5, 4, 5, 4);
            txt_brand.Name = "txt_brand";
            txt_brand.Size = new Size(175, 32);
            txt_brand.TabIndex = 2;
            // 
            // txt_regNo
            // 
            txt_regNo.Location = new Point(306, 369);
            txt_regNo.Margin = new Padding(5, 4, 5, 4);
            txt_regNo.Name = "txt_regNo";
            txt_regNo.Size = new Size(175, 32);
            txt_regNo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 497);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 0;
            label4.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 434);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 0;
            label3.Text = "Brand:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 376);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 0;
            label2.Text = "RegNo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(551, 434);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 0;
            label7.Text = "Available:";
            // 
            // txt_available
            // 
            txt_available.FormattingEnabled = true;
            txt_available.Items.AddRange(new object[] { "Yes", "No" });
            txt_available.Location = new Point(673, 431);
            txt_available.Name = "txt_available";
            txt_available.Size = new Size(181, 33);
            txt_available.TabIndex = 5;
            // 
            // txt_color
            // 
            txt_color.Location = new Point(673, 373);
            txt_color.Margin = new Padding(5, 4, 5, 4);
            txt_color.Name = "txt_color";
            txt_color.Size = new Size(181, 32);
            txt_color.TabIndex = 4;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(673, 490);
            txtprice.Margin = new Padding(5, 4, 5, 4);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(181, 32);
            txtprice.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(551, 376);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 0;
            label8.Text = "Color:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(551, 497);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 0;
            label9.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(1251, 10);
            label10.Name = "label10";
            label10.Size = new Size(32, 34);
            label10.TabIndex = 32;
            label10.Text = "x";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(1096, 0);
            label11.Name = "label11";
            label11.Size = new Size(32, 34);
            label11.TabIndex = 14;
            label11.Text = "x";
            label11.Click += label11_Click;
            // 
            // Available
            // 
            Available.BackColor = Color.Black;
            Available.FlatStyle = FlatStyle.Popup;
            Available.ForeColor = Color.White;
            Available.Location = new Point(196, 16);
            Available.Margin = new Padding(5, 4, 5, 4);
            Available.Name = "Available";
            Available.Size = new Size(143, 36);
            Available.TabIndex = 10;
            Available.Text = "Available Car";
            Available.UseVisualStyleBackColor = false;
            Available.Click += Available_Click;
            // 
            // refleshbtn
            // 
            refleshbtn.BackColor = Color.Black;
            refleshbtn.FlatStyle = FlatStyle.Popup;
            refleshbtn.ForeColor = Color.White;
            refleshbtn.Location = new Point(349, 16);
            refleshbtn.Margin = new Padding(5, 4, 5, 4);
            refleshbtn.Name = "refleshbtn";
            refleshbtn.Size = new Size(143, 36);
            refleshbtn.TabIndex = 11;
            refleshbtn.Text = "Refresh";
            refleshbtn.UseVisualStyleBackColor = false;
            refleshbtn.Click += refleshbtn_Click;
            // 
            // text_search
            // 
            text_search.Location = new Point(682, 20);
            text_search.Name = "text_search";
            text_search.Size = new Size(200, 32);
            text_search.TabIndex = 12;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.Black;
            search_btn.FlatStyle = FlatStyle.Popup;
            search_btn.ForeColor = Color.White;
            search_btn.Location = new Point(890, 22);
            search_btn.Margin = new Padding(5, 4, 5, 4);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(202, 36);
            search_btn.TabIndex = 13;
            search_btn.Text = "Search By RegNo";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // addcars
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 546);
            Controls.Add(search_btn);
            Controls.Add(text_search);
            Controls.Add(refleshbtn);
            Controls.Add(Available);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txt_color);
            Controls.Add(txtprice);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txt_available);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(carDGV);
            Controls.Add(label5);
            Controls.Add(btn_deletecar);
            Controls.Add(btn_editcar);
            Controls.Add(btn_addcar);
            Controls.Add(txt_model);
            Controls.Add(txt_brand);
            Controls.Add(txt_regNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "addcars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addcars";
            Load += addcars_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button4;
        private Label label1;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView carDGV;
        private Label label5;
        private Button btn_deletecar;
        private Button btn_editcar;
        private Button btn_addcar;
        private TextBox txt_model;
        private TextBox txt_brand;
        private TextBox txt_regNo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private ComboBox txt_available;
        private TextBox txt_color;
        private TextBox txtprice;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label11;
        private Button Available;
        private Button refleshbtn;
        private TextBox text_search;
        private Button search_btn;
    }
}