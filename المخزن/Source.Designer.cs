namespace المخزن
{
    partial class Source
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            panel1 = new Panel();
            button4 = new Button();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            button5 = new Button();
            button2 = new Button();
            label10 = new Label();
            button1 = new Button();
            label7 = new Label();
            Delete = new Button();
            SaveBtn = new Button();
            itemPrice = new TextBox();
            lastMonthItem = new TextBox();
            itemEnter = new TextBox();
            ItemName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(itemPrice);
            panel1.Controls.Add(lastMonthItem);
            panel1.Controls.Add(itemEnter);
            panel1.Controls.Add(ItemName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-1, 52);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 468);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(300, 154);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 33;
            button4.Text = "البيانات";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(865, 435);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 32;
            label15.Text = "Profit";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(835, 434);
            label14.Name = "label14";
            label14.Size = new Size(15, 15);
            label14.TabIndex = 31;
            label14.Text = "=";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(696, 434);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 30;
            label12.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(736, 434);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 29;
            label13.Text = "اجمالى الخروج";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(620, 434);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 27;
            label11.Text = "الاجمالى";
            label11.Click += label11_Click;
            // 
            // button3
            // 
            button3.Location = new Point(475, 430);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 26;
            button3.Text = "الناتج";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(3, 180);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1021, 239);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // button5
            // 
            button5.Location = new Point(781, 154);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 24;
            button5.Text = "اطبع";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(412, 154);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 21;
            button2.Text = "تعديل";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(577, 61);
            label10.Name = "label10";
            label10.Size = new Size(19, 21);
            label10.TabIndex = 20;
            label10.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(535, 154);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 19;
            button1.Text = "إحسب";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(919, 58);
            label7.Name = "label7";
            label7.Size = new Size(19, 21);
            label7.TabIndex = 18;
            label7.Text = "0";
            // 
            // Delete
            // 
            Delete.Location = new Point(652, 154);
            Delete.Margin = new Padding(3, 2, 3, 2);
            Delete.Name = "Delete";
            Delete.Size = new Size(82, 22);
            Delete.TabIndex = 16;
            Delete.Text = "حذف";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(191, 154);
            SaveBtn.Margin = new Padding(3, 2, 3, 2);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(82, 22);
            SaveBtn.TabIndex = 15;
            SaveBtn.Text = "حفظ";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // itemPrice
            // 
            itemPrice.Location = new Point(677, 61);
            itemPrice.Margin = new Padding(3, 2, 3, 2);
            itemPrice.Name = "itemPrice";
            itemPrice.Size = new Size(151, 23);
            itemPrice.TabIndex = 13;
            // 
            // lastMonthItem
            // 
            lastMonthItem.Location = new Point(300, 61);
            lastMonthItem.Margin = new Padding(3, 2, 3, 2);
            lastMonthItem.Name = "lastMonthItem";
            lastMonthItem.Size = new Size(203, 23);
            lastMonthItem.TabIndex = 10;
            // 
            // itemEnter
            // 
            itemEnter.Location = new Point(160, 61);
            itemEnter.Margin = new Padding(3, 2, 3, 2);
            itemEnter.Name = "itemEnter";
            itemEnter.Size = new Size(110, 23);
            itemEnter.TabIndex = 9;
            // 
            // ItemName
            // 
            ItemName.Location = new Point(11, 61);
            ItemName.Margin = new Padding(3, 2, 3, 2);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(122, 23);
            ItemName.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(875, 21);
            label9.Name = "label9";
            label9.Size = new Size(96, 21);
            label9.TabIndex = 7;
            label9.Text = "اجمالى السعر";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(677, 21);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 6;
            label8.Text = "سعر الوحده الواحده";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(535, 21);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 4;
            label6.Text = "الكميه الفعليه";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(270, 21);
            label5.Name = "label5";
            label5.Size = new Size(219, 21);
            label5.TabIndex = 3;
            label5.Text = "الكميه المتبقيه من الشهر الماضى";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(185, 21);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 2;
            label4.Text = "دخول";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 21);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 1;
            label3.Text = "اسم الصنف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(920, 12);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 1;
            label1.Text = "البضاعه";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 12);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 2;
            label2.Text = "<  رجوع";
            label2.Click += label2_Click;
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
            // Source
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1025, 521);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Source";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Source";
            Load += Source_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox itemPrice;
        private TextBox lastMonthItem;
        private TextBox itemEnter;
        private TextBox ItemName;
        private Button SaveBtn;
        private Button Delete;
        private Button button1;
        private Label label7;
        private Label label10;
        private Button button2;
        private Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private Label label13;
        private Label label11;
        private Button button3;
        private Label label15;
        private Label label14;
        private Label label12;
        private Button button4;
    }
}