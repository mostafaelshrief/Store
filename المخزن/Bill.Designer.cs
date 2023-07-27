namespace المخزن
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label9 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            Total = new Button();
            label11 = new Label();
            dataGridView2 = new DataGridView();
            CountTotal = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            AddBtn = new Button();
            FeatchData = new Button();
            BillSelectedlist = new ComboBox();
            ItemName = new TextBox();
            label5 = new Label();
            itemOut = new TextBox();
            label4 = new Label();
            itemPrice = new TextBox();
            label3 = new Label();
            RealAmount = new TextBox();
            label2 = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(10, 17);
            label8.Name = "label8";
            label8.Size = new Size(74, 30);
            label8.TabIndex = 13;
            label8.Text = "<رجوع";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(849, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(766, 17);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 11;
            label1.Text = "الفاتورة";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 513);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 34);
            button1.TabIndex = 22;
            button1.Text = "طباعه";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(25, 35);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 24;
            label9.Text = "نوع الفاتورة";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(Total);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(CountTotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(FeatchData);
            panel1.Controls.Add(BillSelectedlist);
            panel1.Controls.Add(ItemName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(itemOut);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(itemPrice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RealAmount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 69);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 636);
            panel1.TabIndex = 10;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(139, 372);
            button5.Name = "button5";
            button5.Size = new Size(116, 34);
            button5.TabIndex = 63;
            button5.Text = "احذف الفاتورة";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // Total
            // 
            Total.FlatStyle = FlatStyle.Flat;
            Total.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Total.Location = new Point(139, 514);
            Total.Name = "Total";
            Total.Size = new Size(81, 34);
            Total.TabIndex = 61;
            Total.Text = "الاجمالى";
            Total.UseVisualStyleBackColor = true;
            Total.Click += Total_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(854, 13);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 58;
            label11.Text = "الفواتير";
            label11.Click += label11_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(398, 91);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(567, 514);
            dataGridView2.TabIndex = 56;
            dataGridView2.CellClick += dataGridView2_CellContentClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // CountTotal
            // 
            CountTotal.AutoSize = true;
            CountTotal.BackColor = Color.Silver;
            CountTotal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CountTotal.Location = new Point(296, 528);
            CountTotal.Name = "CountTotal";
            CountTotal.Size = new Size(0, 20);
            CountTotal.TabIndex = 54;
            CountTotal.Click += CountTotal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 185);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 53;
            label6.Text = "الوقت";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(25, 214);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(113, 23);
            dateTimePicker1.TabIndex = 52;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(12, 372);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(82, 34);
            AddBtn.TabIndex = 50;
            AddBtn.Text = "إضافه";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // FeatchData
            // 
            FeatchData.FlatStyle = FlatStyle.Flat;
            FeatchData.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FeatchData.Location = new Point(296, 372);
            FeatchData.Name = "FeatchData";
            FeatchData.Size = new Size(96, 34);
            FeatchData.TabIndex = 49;
            FeatchData.Text = "جيب الداتا";
            FeatchData.UseVisualStyleBackColor = true;
            FeatchData.Click += button2_Click;
            // 
            // BillSelectedlist
            // 
            BillSelectedlist.FormattingEnabled = true;
            BillSelectedlist.Items.AddRange(new object[] { "البار", "المطبخ", "الاستاف", "الفندق" });
            BillSelectedlist.Location = new Point(25, 58);
            BillSelectedlist.Name = "BillSelectedlist";
            BillSelectedlist.Size = new Size(113, 23);
            BillSelectedlist.TabIndex = 14;
            // 
            // ItemName
            // 
            ItemName.Location = new Point(211, 58);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(114, 23);
            ItemName.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(211, 35);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 43;
            label5.Text = "الاسم";
            // 
            // itemOut
            // 
            itemOut.Location = new Point(211, 132);
            itemOut.Name = "itemOut";
            itemOut.Size = new Size(114, 23);
            itemOut.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(211, 109);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 41;
            label4.Text = "كميه الخرج";
            // 
            // itemPrice
            // 
            itemPrice.Location = new Point(25, 132);
            itemPrice.Name = "itemPrice";
            itemPrice.Size = new Size(113, 23);
            itemPrice.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 109);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 39;
            label3.Text = "سعر الوحده";
            label3.Click += label3_Click;
            // 
            // RealAmount
            // 
            RealAmount.Location = new Point(207, 208);
            RealAmount.Name = "RealAmount";
            RealAmount.Size = new Size(118, 23);
            RealAmount.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(207, 185);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 37;
            label2.Text = "الكميه الفعليه";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(952, 13);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 57;
            label10.Text = "السجل";
            label10.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(975, 32);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(35, 64);
            dataGridView1.TabIndex = 51;
            dataGridView1.Visible = false;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1183, 702);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
            Load += Bill_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label9;
        private Panel panel1;
        private ComboBox BillSelectedlist;
        private TextBox ItemName;
        private Label label5;
        private TextBox itemOut;
        private Label label4;
        private TextBox itemPrice;
        private Label label3;
        private TextBox RealAmount;
        private Label label2;
        private Button FeatchData;
        private Button Homebtn;
        private DateTimePicker dateTimePicker1;
        private Button AddBtn;
        private Label label6;
        private Label CountTotal;
        private Label label11;
        private DataGridView dataGridView2;
        private Button Total;
        private Button button5;
        private Label label10;
        private DataGridView dataGridView1;
    }
}