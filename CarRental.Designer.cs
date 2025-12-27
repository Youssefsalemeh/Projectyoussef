namespace FinalProject
{
    partial class CarRental
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRental));
            label10 = new Label();
            Fees = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            RentalDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label5 = new Label();
            btn_deleterent = new Button();
            btn_editrent = new Button();
            btn_addrent = new Button();
            txt_rentid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            label1 = new Label();
            daterent = new DateTimePicker();
            datereturn = new DateTimePicker();
            carregtxt = new ComboBox();
            custumers = new ComboBox();
            label6 = new Label();
            Nameofcustomer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)RentalDGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(1096, 0);
            label10.Name = "label10";
            label10.Size = new Size(32, 34);
            label10.TabIndex = 11;
            label10.Text = "x";
            label10.Click += label10_Click;
            // 
            // Fees
            // 
            Fees.Location = new Point(837, 430);
            Fees.Margin = new Padding(5, 4, 5, 4);
            Fees.Name = "Fees";
            Fees.Size = new Size(250, 32);
            Fees.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(653, 311);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(122, 25);
            label8.TabIndex = 0;
            label8.Text = "Rent Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(653, 437);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 0;
            label9.Text = "Fees:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(652, 379);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 0;
            label7.Text = "Return Date:";
            // 
            // RentalDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            RentalDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            RentalDGV.BackgroundColor = Color.Silver;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            RentalDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            RentalDGV.ColumnHeadersHeight = 4;
            RentalDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            RentalDGV.DefaultCellStyle = dataGridViewCellStyle3;
            RentalDGV.GridColor = Color.FromArgb(231, 229, 255);
            RentalDGV.Location = new Point(177, 54);
            RentalDGV.Margin = new Padding(5, 4, 5, 4);
            RentalDGV.Name = "RentalDGV";
            RentalDGV.ReadOnly = true;
            RentalDGV.RowHeadersVisible = false;
            RentalDGV.RowHeadersWidth = 51;
            RentalDGV.Size = new Size(910, 224);
            RentalDGV.TabIndex = 16;
            RentalDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            RentalDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            RentalDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            RentalDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            RentalDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            RentalDGV.ThemeStyle.BackColor = Color.Silver;
            RentalDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            RentalDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            RentalDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            RentalDGV.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RentalDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            RentalDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            RentalDGV.ThemeStyle.HeaderStyle.Height = 4;
            RentalDGV.ThemeStyle.ReadOnly = true;
            RentalDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            RentalDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            RentalDGV.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RentalDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            RentalDGV.ThemeStyle.RowsStyle.Height = 29;
            RentalDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            RentalDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            RentalDGV.CellClick += RentalDGV_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(554, 15);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 17;
            label5.Text = "Cars On Rent";
            // 
            // btn_deleterent
            // 
            btn_deleterent.BackColor = Color.Black;
            btn_deleterent.FlatStyle = FlatStyle.Popup;
            btn_deleterent.ForeColor = Color.White;
            btn_deleterent.Location = new Point(970, 489);
            btn_deleterent.Margin = new Padding(5, 4, 5, 4);
            btn_deleterent.Name = "btn_deleterent";
            btn_deleterent.Size = new Size(143, 36);
            btn_deleterent.TabIndex = 10;
            btn_deleterent.Text = "Delete";
            btn_deleterent.UseVisualStyleBackColor = false;
            btn_deleterent.Click += btn_deleterent_Click;
            // 
            // btn_editrent
            // 
            btn_editrent.BackColor = Color.Black;
            btn_editrent.FlatStyle = FlatStyle.Popup;
            btn_editrent.ForeColor = Color.White;
            btn_editrent.Location = new Point(807, 489);
            btn_editrent.Margin = new Padding(5, 4, 5, 4);
            btn_editrent.Name = "btn_editrent";
            btn_editrent.Size = new Size(143, 36);
            btn_editrent.TabIndex = 9;
            btn_editrent.Text = "Edit";
            btn_editrent.UseVisualStyleBackColor = false;
            btn_editrent.Click += btn_editrent_Click;
            // 
            // btn_addrent
            // 
            btn_addrent.BackColor = Color.Black;
            btn_addrent.FlatStyle = FlatStyle.Popup;
            btn_addrent.ForeColor = Color.White;
            btn_addrent.Location = new Point(653, 489);
            btn_addrent.Margin = new Padding(5, 4, 5, 4);
            btn_addrent.Name = "btn_addrent";
            btn_addrent.Size = new Size(143, 36);
            btn_addrent.TabIndex = 8;
            btn_addrent.Text = "Add";
            btn_addrent.UseVisualStyleBackColor = false;
            btn_addrent.Click += btn_addrent_Click;
            // 
            // txt_rentid
            // 
            txt_rentid.Location = new Point(342, 311);
            txt_rentid.Margin = new Padding(5, 4, 5, 4);
            txt_rentid.Name = "txt_rentid";
            txt_rentid.Size = new Size(250, 32);
            txt_rentid.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 445);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 0;
            label4.Text = "Customer ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 379);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 0;
            label3.Text = "Car Reg:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 318);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 0;
            label2.Text = "Rent ID:";
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
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(14, 120);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(135, 57);
            button4.TabIndex = 0;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 273);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Rental";
            // 
            // daterent
            // 
            daterent.Location = new Point(837, 304);
            daterent.Name = "daterent";
            daterent.Size = new Size(250, 32);
            daterent.TabIndex = 5;
            daterent.Value = new DateTime(2025, 12, 18, 0, 0, 0, 0);
            // 
            // datereturn
            // 
            datereturn.Location = new Point(837, 368);
            datereturn.Name = "datereturn";
            datereturn.Size = new Size(250, 32);
            datereturn.TabIndex = 6;
            datereturn.Value = new DateTime(2025, 12, 17, 0, 0, 0, 0);
            // 
            // carregtxt
            // 
            carregtxt.DropDownStyle = ComboBoxStyle.DropDownList;
            carregtxt.FormattingEnabled = true;
            carregtxt.Location = new Point(342, 371);
            carregtxt.Name = "carregtxt";
            carregtxt.Size = new Size(250, 33);
            carregtxt.TabIndex = 2;
            carregtxt.SelectedIndexChanged += carregtxt_SelectedIndexChanged;
            carregtxt.SelectionChangeCommitted += carregtxt_SelectionChangeCommitted;
            // 
            // custumers
            // 
            custumers.FormattingEnabled = true;
            custumers.Location = new Point(342, 437);
            custumers.Name = "custumers";
            custumers.Size = new Size(250, 33);
            custumers.TabIndex = 3;
            custumers.SelectionChangeCommitted += custumers_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 500);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 0;
            label6.Text = "Name:";
            // 
            // Nameofcustomer
            // 
            Nameofcustomer.Location = new Point(342, 493);
            Nameofcustomer.Margin = new Padding(5, 4, 5, 4);
            Nameofcustomer.Name = "Nameofcustomer";
            Nameofcustomer.Size = new Size(250, 32);
            Nameofcustomer.TabIndex = 4;
            // 
            // CarRental
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 546);
            Controls.Add(Nameofcustomer);
            Controls.Add(label6);
            Controls.Add(custumers);
            Controls.Add(carregtxt);
            Controls.Add(datereturn);
            Controls.Add(daterent);
            Controls.Add(label10);
            Controls.Add(Fees);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(RentalDGV);
            Controls.Add(label5);
            Controls.Add(btn_deleterent);
            Controls.Add(btn_editrent);
            Controls.Add(btn_addrent);
            Controls.Add(txt_rentid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "CarRental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarRental";
            Load += CarRental_Load;
            ((System.ComponentModel.ISupportInitialize)RentalDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox txt_color;
        private TextBox Fees;
        private Label label8;
        private Label label9;
        private ComboBox txt_carreg;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView RentalDGV;
        private Label label5;
        private Button btn_deleterent;
        private Button btn_editrent;
        private Button btn_addrent;
        private TextBox txt_rentid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button button4;
        private Label label1;
        private DateTimePicker daterent;
        private DateTimePicker datereturn;
        private ComboBox carregtxt;
        private ComboBox custumers;
        private Label label6;
        private TextBox Nameofcustomer;
        private PictureBox pictureBox1;
    }
}
