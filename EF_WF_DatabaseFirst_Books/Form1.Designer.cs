namespace EF_WF_DatabaseFirst_Books
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbCnt = new System.Windows.Forms.TabControl();
            this.TbPgBook = new System.Windows.Forms.TabPage();
            this.DtGridVwShow = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdpublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnAddBook = new System.Windows.Forms.Button();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtIdAuthor = new System.Windows.Forms.TextBox();
            this.bttnChangeBook = new System.Windows.Forms.Button();
            this.bttnDeleteBook = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnSaveChng = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBxBook = new System.Windows.Forms.ListBox();
            this.TbPgAuthor = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BttnAuthorClear = new System.Windows.Forms.Button();
            this.BttnAuthorAdd = new System.Windows.Forms.Button();
            this.txtLastNameAuthor = new System.Windows.Forms.TextBox();
            this.BttnAuthorChange = new System.Windows.Forms.Button();
            this.BttnAuthorDel = new System.Windows.Forms.Button();
            this.txtFirstNameAuthor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listBxAuthor = new System.Windows.Forms.ListBox();
            this.TbPgPublishers = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.lstBxPublisher = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnnPublisherClear = new System.Windows.Forms.Button();
            this.btnnPublisherAdd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnnPublisherChange = new System.Windows.Forms.Button();
            this.btnnPublisherDel = new System.Windows.Forms.Button();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.TbCnt.SuspendLayout();
            this.TbPgBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridVwShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TbPgAuthor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TbPgPublishers.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCnt
            // 
            this.TbCnt.Controls.Add(this.TbPgBook);
            this.TbCnt.Controls.Add(this.TbPgAuthor);
            this.TbCnt.Controls.Add(this.TbPgPublishers);
            this.TbCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbCnt.HotTrack = true;
            this.TbCnt.Location = new System.Drawing.Point(1, 0);
            this.TbCnt.Margin = new System.Windows.Forms.Padding(0);
            this.TbCnt.Name = "TbCnt";
            this.TbCnt.Padding = new System.Drawing.Point(70, 3);
            this.TbCnt.SelectedIndex = 0;
            this.TbCnt.Size = new System.Drawing.Size(775, 547);
            this.TbCnt.TabIndex = 0;
            // 
            // TbPgBook
            // 
            this.TbPgBook.BackColor = System.Drawing.Color.Silver;
            this.TbPgBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPgBook.Controls.Add(this.DtGridVwShow);
            this.TbPgBook.Controls.Add(this.groupBox1);
            this.TbPgBook.Controls.Add(this.bttnSaveChng);
            this.TbPgBook.Controls.Add(this.label1);
            this.TbPgBook.Controls.Add(this.lstBxBook);
            this.TbPgBook.Location = new System.Drawing.Point(4, 29);
            this.TbPgBook.Margin = new System.Windows.Forms.Padding(0);
            this.TbPgBook.Name = "TbPgBook";
            this.TbPgBook.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgBook.Size = new System.Drawing.Size(767, 514);
            this.TbPgBook.TabIndex = 0;
            this.TbPgBook.Text = "Books";
            // 
            // DtGridVwShow
            // 
            this.DtGridVwShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridVwShow.Location = new System.Drawing.Point(-5, 46);
            this.DtGridVwShow.Name = "DtGridVwShow";
            this.DtGridVwShow.ReadOnly = true;
            this.DtGridVwShow.RowTemplate.Height = 24;
            this.DtGridVwShow.Size = new System.Drawing.Size(771, 467);
            this.DtGridVwShow.TabIndex = 6;
            this.DtGridVwShow.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnClear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdpublisher);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bttnAddBook);
            this.groupBox1.Controls.Add(this.txtPages);
            this.groupBox1.Controls.Add(this.txtIdAuthor);
            this.groupBox1.Controls.Add(this.bttnChangeBook);
            this.groupBox1.Controls.Add(this.bttnDeleteBook);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(405, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 469);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // bttnClear
            // 
            this.bttnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnClear.ForeColor = System.Drawing.Color.Maroon;
            this.bttnClear.Location = new System.Drawing.Point(32, 343);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(134, 69);
            this.bttnClear.TabIndex = 31;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(20, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Введите id публикации данной книги";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(28, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Введите id автора данной книги";
            // 
            // txtIdpublisher
            // 
            this.txtIdpublisher.Location = new System.Drawing.Point(131, 231);
            this.txtIdpublisher.Name = "txtIdpublisher";
            this.txtIdpublisher.Size = new System.Drawing.Size(211, 27);
            this.txtIdpublisher.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(28, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "IdPublisher:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(131, 180);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(211, 27);
            this.txtPrice.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(28, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price:";
            // 
            // bttnAddBook
            // 
            this.bttnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnAddBook.ForeColor = System.Drawing.Color.Maroon;
            this.bttnAddBook.Location = new System.Drawing.Point(179, 283);
            this.bttnAddBook.Name = "bttnAddBook";
            this.bttnAddBook.Size = new System.Drawing.Size(134, 54);
            this.bttnAddBook.TabIndex = 17;
            this.bttnAddBook.Text = "Add Book";
            this.bttnAddBook.UseVisualStyleBackColor = true;
            this.bttnAddBook.Click += new System.EventHandler(this.bttnAddBook_Click);
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(131, 135);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(211, 27);
            this.txtPages.TabIndex = 16;
            // 
            // txtIdAuthor
            // 
            this.txtIdAuthor.Location = new System.Drawing.Point(131, 82);
            this.txtIdAuthor.Name = "txtIdAuthor";
            this.txtIdAuthor.Size = new System.Drawing.Size(211, 27);
            this.txtIdAuthor.TabIndex = 15;
            // 
            // bttnChangeBook
            // 
            this.bttnChangeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnChangeBook.ForeColor = System.Drawing.Color.Maroon;
            this.bttnChangeBook.Location = new System.Drawing.Point(179, 343);
            this.bttnChangeBook.Name = "bttnChangeBook";
            this.bttnChangeBook.Size = new System.Drawing.Size(134, 69);
            this.bttnChangeBook.TabIndex = 28;
            this.bttnChangeBook.Text = "Change Book";
            this.bttnChangeBook.UseVisualStyleBackColor = true;
            this.bttnChangeBook.Click += new System.EventHandler(this.bttnChangeBook_Click);
            // 
            // bttnDeleteBook
            // 
            this.bttnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnDeleteBook.ForeColor = System.Drawing.Color.Maroon;
            this.bttnDeleteBook.Location = new System.Drawing.Point(32, 283);
            this.bttnDeleteBook.Name = "bttnDeleteBook";
            this.bttnDeleteBook.Size = new System.Drawing.Size(134, 54);
            this.bttnDeleteBook.TabIndex = 17;
            this.bttnDeleteBook.Text = "Del Book";
            this.bttnDeleteBook.UseVisualStyleBackColor = true;
            this.bttnDeleteBook.Click += new System.EventHandler(this.bttnDeleteBook_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(131, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 27);
            this.txtTitle.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(28, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pages:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "IdAuthor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title:";
            // 
            // bttnSaveChng
            // 
            this.bttnSaveChng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnSaveChng.ForeColor = System.Drawing.Color.Maroon;
            this.bttnSaveChng.Location = new System.Drawing.Point(584, 4);
            this.bttnSaveChng.Name = "bttnSaveChng";
            this.bttnSaveChng.Size = new System.Drawing.Size(174, 33);
            this.bttnSaveChng.TabIndex = 3;
            this.bttnSaveChng.Text = "Show Change";
            this.bttnSaveChng.UseVisualStyleBackColor = true;
            this.bttnSaveChng.Click += new System.EventHandler(this.bttnSaveChng_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(100, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список книг:";
            // 
            // lstBxBook
            // 
            this.lstBxBook.FormattingEnabled = true;
            this.lstBxBook.HorizontalScrollbar = true;
            this.lstBxBook.ItemHeight = 20;
            this.lstBxBook.Location = new System.Drawing.Point(2, 46);
            this.lstBxBook.Name = "lstBxBook";
            this.lstBxBook.Size = new System.Drawing.Size(388, 464);
            this.lstBxBook.TabIndex = 0;
            this.lstBxBook.SelectedIndexChanged += new System.EventHandler(this.lstBxBook_SelectedIndexChanged);
            // 
            // TbPgAuthor
            // 
            this.TbPgAuthor.BackColor = System.Drawing.Color.Silver;
            this.TbPgAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPgAuthor.Controls.Add(this.label16);
            this.TbPgAuthor.Controls.Add(this.groupBox2);
            this.TbPgAuthor.Controls.Add(this.listBxAuthor);
            this.TbPgAuthor.Location = new System.Drawing.Point(4, 29);
            this.TbPgAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.TbPgAuthor.Name = "TbPgAuthor";
            this.TbPgAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgAuthor.Size = new System.Drawing.Size(767, 514);
            this.TbPgAuthor.TabIndex = 1;
            this.TbPgAuthor.Text = "Authors";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(102, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 29);
            this.label16.TabIndex = 7;
            this.label16.Text = "Список авторов:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BttnAuthorClear);
            this.groupBox2.Controls.Add(this.BttnAuthorAdd);
            this.groupBox2.Controls.Add(this.txtLastNameAuthor);
            this.groupBox2.Controls.Add(this.BttnAuthorChange);
            this.groupBox2.Controls.Add(this.BttnAuthorDel);
            this.groupBox2.Controls.Add(this.txtFirstNameAuthor);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(407, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 469);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // BttnAuthorClear
            // 
            this.BttnAuthorClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnAuthorClear.ForeColor = System.Drawing.Color.Maroon;
            this.BttnAuthorClear.Location = new System.Drawing.Point(6, 162);
            this.BttnAuthorClear.Name = "BttnAuthorClear";
            this.BttnAuthorClear.Size = new System.Drawing.Size(124, 211);
            this.BttnAuthorClear.TabIndex = 31;
            this.BttnAuthorClear.Text = "Clear";
            this.BttnAuthorClear.UseVisualStyleBackColor = true;
            this.BttnAuthorClear.Click += new System.EventHandler(this.BttnAuthorClear_Click);
            // 
            // BttnAuthorAdd
            // 
            this.BttnAuthorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnAuthorAdd.ForeColor = System.Drawing.Color.Maroon;
            this.BttnAuthorAdd.Location = new System.Drawing.Point(136, 162);
            this.BttnAuthorAdd.Name = "BttnAuthorAdd";
            this.BttnAuthorAdd.Size = new System.Drawing.Size(211, 54);
            this.BttnAuthorAdd.TabIndex = 17;
            this.BttnAuthorAdd.Text = "Add Author";
            this.BttnAuthorAdd.UseVisualStyleBackColor = true;
            this.BttnAuthorAdd.Click += new System.EventHandler(this.BttnAuthorAdd_Click);
            // 
            // txtLastNameAuthor
            // 
            this.txtLastNameAuthor.Location = new System.Drawing.Point(136, 102);
            this.txtLastNameAuthor.Name = "txtLastNameAuthor";
            this.txtLastNameAuthor.Size = new System.Drawing.Size(211, 27);
            this.txtLastNameAuthor.TabIndex = 15;
            // 
            // BttnAuthorChange
            // 
            this.BttnAuthorChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnAuthorChange.ForeColor = System.Drawing.Color.Maroon;
            this.BttnAuthorChange.Location = new System.Drawing.Point(136, 319);
            this.BttnAuthorChange.Name = "BttnAuthorChange";
            this.BttnAuthorChange.Size = new System.Drawing.Size(211, 54);
            this.BttnAuthorChange.TabIndex = 28;
            this.BttnAuthorChange.Text = "Change Author";
            this.BttnAuthorChange.UseVisualStyleBackColor = true;
            this.BttnAuthorChange.Click += new System.EventHandler(this.BttnAuthorChange_Click);
            // 
            // BttnAuthorDel
            // 
            this.BttnAuthorDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnAuthorDel.ForeColor = System.Drawing.Color.Maroon;
            this.BttnAuthorDel.Location = new System.Drawing.Point(136, 241);
            this.BttnAuthorDel.Name = "BttnAuthorDel";
            this.BttnAuthorDel.Size = new System.Drawing.Size(211, 54);
            this.BttnAuthorDel.TabIndex = 17;
            this.BttnAuthorDel.Text = "Del Author";
            this.BttnAuthorDel.UseVisualStyleBackColor = true;
            this.BttnAuthorDel.Click += new System.EventHandler(this.BttnAuthorDel_Click);
            // 
            // txtFirstNameAuthor
            // 
            this.txtFirstNameAuthor.Location = new System.Drawing.Point(136, 48);
            this.txtFirstNameAuthor.Name = "txtFirstNameAuthor";
            this.txtFirstNameAuthor.Size = new System.Drawing.Size(211, 27);
            this.txtFirstNameAuthor.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(29, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "LastName:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(28, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "FirstName:";
            // 
            // listBxAuthor
            // 
            this.listBxAuthor.FormattingEnabled = true;
            this.listBxAuthor.HorizontalScrollbar = true;
            this.listBxAuthor.ItemHeight = 20;
            this.listBxAuthor.Location = new System.Drawing.Point(4, 45);
            this.listBxAuthor.Name = "listBxAuthor";
            this.listBxAuthor.Size = new System.Drawing.Size(388, 464);
            this.listBxAuthor.TabIndex = 6;
            // 
            // TbPgPublishers
            // 
            this.TbPgPublishers.BackColor = System.Drawing.Color.Silver;
            this.TbPgPublishers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPgPublishers.Controls.Add(this.label9);
            this.TbPgPublishers.Controls.Add(this.lstBxPublisher);
            this.TbPgPublishers.Controls.Add(this.groupBox3);
            this.TbPgPublishers.Location = new System.Drawing.Point(4, 29);
            this.TbPgPublishers.Margin = new System.Windows.Forms.Padding(0);
            this.TbPgPublishers.Name = "TbPgPublishers";
            this.TbPgPublishers.Size = new System.Drawing.Size(767, 514);
            this.TbPgPublishers.TabIndex = 2;
            this.TbPgPublishers.Text = "Publishers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(102, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Список издателей:";
            // 
            // lstBxPublisher
            // 
            this.lstBxPublisher.FormattingEnabled = true;
            this.lstBxPublisher.HorizontalScrollbar = true;
            this.lstBxPublisher.ItemHeight = 20;
            this.lstBxPublisher.Location = new System.Drawing.Point(4, 45);
            this.lstBxPublisher.Name = "lstBxPublisher";
            this.lstBxPublisher.Size = new System.Drawing.Size(388, 464);
            this.lstBxPublisher.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(6, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(2, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "PublisherName:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnnPublisherClear);
            this.groupBox3.Controls.Add(this.btnnPublisherAdd);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.btnnPublisherChange);
            this.groupBox3.Controls.Add(this.btnnPublisherDel);
            this.groupBox3.Controls.Add(this.txtPublisherName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(407, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 469);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // btnnPublisherClear
            // 
            this.btnnPublisherClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnnPublisherClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnnPublisherClear.Location = new System.Drawing.Point(6, 252);
            this.btnnPublisherClear.Name = "btnnPublisherClear";
            this.btnnPublisherClear.Size = new System.Drawing.Size(124, 211);
            this.btnnPublisherClear.TabIndex = 31;
            this.btnnPublisherClear.Text = "Clear";
            this.btnnPublisherClear.UseVisualStyleBackColor = true;
            this.btnnPublisherClear.Click += new System.EventHandler(this.btnnPublisherClear_Click);
            // 
            // btnnPublisherAdd
            // 
            this.btnnPublisherAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnnPublisherAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnnPublisherAdd.Location = new System.Drawing.Point(136, 252);
            this.btnnPublisherAdd.Name = "btnnPublisherAdd";
            this.btnnPublisherAdd.Size = new System.Drawing.Size(211, 54);
            this.btnnPublisherAdd.TabIndex = 17;
            this.btnnPublisherAdd.Text = "Add Publisher";
            this.btnnPublisherAdd.UseVisualStyleBackColor = true;
            this.btnnPublisherAdd.Click += new System.EventHandler(this.btnnPublisherAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(136, 182);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 27);
            this.txtAddress.TabIndex = 15;
            // 
            // btnnPublisherChange
            // 
            this.btnnPublisherChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnnPublisherChange.ForeColor = System.Drawing.Color.Maroon;
            this.btnnPublisherChange.Location = new System.Drawing.Point(136, 409);
            this.btnnPublisherChange.Name = "btnnPublisherChange";
            this.btnnPublisherChange.Size = new System.Drawing.Size(211, 54);
            this.btnnPublisherChange.TabIndex = 28;
            this.btnnPublisherChange.Text = "Change Publisher";
            this.btnnPublisherChange.UseVisualStyleBackColor = true;
            this.btnnPublisherChange.Click += new System.EventHandler(this.btnnPublisherChange_Click);
            // 
            // btnnPublisherDel
            // 
            this.btnnPublisherDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnnPublisherDel.ForeColor = System.Drawing.Color.Maroon;
            this.btnnPublisherDel.Location = new System.Drawing.Point(136, 339);
            this.btnnPublisherDel.Name = "btnnPublisherDel";
            this.btnnPublisherDel.Size = new System.Drawing.Size(211, 54);
            this.btnnPublisherDel.TabIndex = 17;
            this.btnnPublisherDel.Text = "Del Publisher";
            this.btnnPublisherDel.UseVisualStyleBackColor = true;
            this.btnnPublisherDel.Click += new System.EventHandler(this.btnnPublisherDel_Click);
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(136, 102);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(211, 27);
            this.txtPublisherName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(776, 547);
            this.Controls.Add(this.TbCnt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TbCnt.ResumeLayout(false);
            this.TbPgBook.ResumeLayout(false);
            this.TbPgBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridVwShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TbPgAuthor.ResumeLayout(false);
            this.TbPgAuthor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TbPgPublishers.ResumeLayout(false);
            this.TbPgPublishers.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbCnt;
        private System.Windows.Forms.TabPage TbPgAuthor;
        private System.Windows.Forms.TabPage TbPgPublishers;
        private System.Windows.Forms.TabPage TbPgBook;
        private System.Windows.Forms.DataGridView DtGridVwShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdpublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttnAddBook;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.TextBox txtIdAuthor;
        private System.Windows.Forms.Button bttnChangeBook;
        private System.Windows.Forms.Button bttnDeleteBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnSaveChng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBxBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BttnAuthorClear;
        private System.Windows.Forms.Button BttnAuthorAdd;
        private System.Windows.Forms.TextBox txtLastNameAuthor;
        private System.Windows.Forms.Button BttnAuthorChange;
        private System.Windows.Forms.Button BttnAuthorDel;
        private System.Windows.Forms.TextBox txtFirstNameAuthor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBxAuthor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstBxPublisher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnnPublisherClear;
        private System.Windows.Forms.Button btnnPublisherAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnnPublisherChange;
        private System.Windows.Forms.Button btnnPublisherDel;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

