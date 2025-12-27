namespace FinalProject
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UId = new TextBox();
            UName = new TextBox();
            UPass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            UserDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            bindingSource1 = new BindingSource(components);
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 304);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 546);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 114);
            button4.Name = "button4";
            button4.Size = new Size(162, 65);
            button4.TabIndex = 11;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 410);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 462);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 510);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // UId
            // 
            UId.Location = new Point(320, 403);
            UId.Name = "UId";
            UId.Size = new Size(202, 32);
            UId.TabIndex = 5;
            // 
            // UName
            // 
            UName.Location = new Point(320, 455);
            UName.Name = "UName";
            UName.Size = new Size(202, 32);
            UName.TabIndex = 6;
            // 
            // UPass
            // 
            UPass.Location = new Point(320, 503);
            UPass.Name = "UPass";
            UPass.Size = new Size(202, 32);
            UPass.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(570, 401);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(570, 453);
            button2.Name = "button2";
            button2.Size = new Size(121, 34);
            button2.TabIndex = 9;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(570, 505);
            button3.Name = "button3";
            button3.Size = new Size(121, 34);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(581, 24);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 11;
            label5.Text = "Users List";
            // 
            // UserDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            UserDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UserDGV.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserDGV.ColumnHeadersHeight = 4;
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserDGV.DefaultCellStyle = dataGridViewCellStyle3;
            UserDGV.GridColor = Color.Black;
            UserDGV.Location = new Point(178, 55);
            UserDGV.Name = "UserDGV";
            UserDGV.ReadOnly = true;
            UserDGV.RowHeadersVisible = false;
            UserDGV.RowHeadersWidth = 51;
            UserDGV.Size = new Size(908, 302);
            UserDGV.TabIndex = 12;
            UserDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            UserDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UserDGV.ThemeStyle.BackColor = Color.Gainsboro;
            UserDGV.ThemeStyle.GridColor = Color.Black;
            UserDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            UserDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UserDGV.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UserDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UserDGV.ThemeStyle.HeaderStyle.Height = 4;
            UserDGV.ThemeStyle.ReadOnly = true;
            UserDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UserDGV.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UserDGV.ThemeStyle.RowsStyle.Height = 29;
            UserDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            UserDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            UserDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(1094, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 34);
            label6.TabIndex = 13;
            label6.Text = "x";
            label6.Click += label6_Click;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 546);
            Controls.Add(label6);
            Controls.Add(UserDGV);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UPass);
            Controls.Add(UName);
            Controls.Add(UId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "users";
            Load += users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox UId;
        private TextBox UName;
        private TextBox UPass;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView UserDGV;
        private BindingSource bindingSource1;
        private Label label6;
        private PictureBox pictureBox1;
    }

}
