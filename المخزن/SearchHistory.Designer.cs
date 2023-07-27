namespace المخزن
{
    partial class SearchHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchHistory));
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button2 = new Button();
            panel1 = new Panel();
            BillSelectedlist = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            listBox5 = new ListBox();
            listBox4 = new ListBox();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            RefreshBtn = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(191, 305);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(144, 30);
            button2.TabIndex = 41;
            button2.Text = "بحث فى المخزن";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BillSelectedlist);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listBox5);
            panel1.Controls.Add(listBox4);
            panel1.Controls.Add(listBox3);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(RefreshBtn);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 69);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 352);
            panel1.TabIndex = 10;
            // 
            // BillSelectedlist
            // 
            BillSelectedlist.FormattingEnabled = true;
            BillSelectedlist.Items.AddRange(new object[] { "البار", "المطبخ", "الاستاف", "المركب", "الفندق", "دراجون ", "ميراج ", "البريمو", "سيفيو ", "رامز", "عمر4", "شارك", "بلوهاوس", "بلانت", "فريش فيش", "الكابونى", "فواتير خارجيه" });
            BillSelectedlist.Location = new Point(304, 10);
            BillSelectedlist.Name = "BillSelectedlist";
            BillSelectedlist.Size = new Size(202, 23);
            BillSelectedlist.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(662, 40);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 55;
            label6.Text = "الاجمالى";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(523, 40);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 54;
            label5.Text = "الوقت";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(367, 40);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 53;
            label4.Text = "الخروج";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(222, 40);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 52;
            label3.Text = "السعر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 40);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 51;
            label2.Text = "الاسم";
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(620, 61);
            listBox5.Margin = new Padding(3, 2, 3, 2);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(149, 229);
            listBox5.TabIndex = 50;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(472, 61);
            listBox4.Margin = new Padding(3, 2, 3, 2);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(149, 229);
            listBox4.TabIndex = 49;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(323, 61);
            listBox3.Margin = new Padding(3, 2, 3, 2);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(149, 229);
            listBox3.TabIndex = 48;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(174, 61);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(149, 229);
            listBox2.TabIndex = 47;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(32, 61);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(149, 229);
            listBox1.TabIndex = 42;
            // 
            // RefreshBtn
            // 
            RefreshBtn.FlatStyle = FlatStyle.Popup;
            RefreshBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshBtn.Location = new Point(528, 10);
            RefreshBtn.Margin = new Padding(3, 2, 3, 2);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(82, 24);
            RefreshBtn.TabIndex = 32;
            RefreshBtn.Text = "بحث";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(513, 305);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(135, 30);
            button4.TabIndex = 23;
            button4.Text = "الصفحه الرئسيه";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            label1.Location = new Point(766, 16);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 11;
            label1.Text = "البحث";
            // 
            // SearchHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(918, 431);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchHistory";
            Load += SearchHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button2;
        private Panel panel1;
        private Button RefreshBtn;
        private Button button4;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox5;
        private ListBox listBox4;
        private ListBox listBox3;
        private ListBox listBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox BillSelectedlist;
    }
}