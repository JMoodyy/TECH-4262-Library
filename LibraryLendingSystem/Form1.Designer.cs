namespace LibraryLendingSystem
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Newbtn = new System.Windows.Forms.Button();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Memberslbl = new System.Windows.Forms.Label();
            this.bookstab = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Clearbooks = new System.Windows.Forms.Button();
            this.Dltbookbtn = new System.Windows.Forms.Button();
            this.Updatebkbtn = new System.Windows.Forms.Button();
            this.Newbookbtn = new System.Windows.Forms.Button();
            this.Callnumlbl = new System.Windows.Forms.Label();
            this.Callnumtxt = new System.Windows.Forms.TextBox();
            this.Authorlbl = new System.Windows.Forms.Label();
            this.Authortxt = new System.Windows.Forms.TextBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.Titletxt = new System.Windows.Forms.TextBox();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.bksearchbtn = new System.Windows.Forms.Button();
            this.Searchlbl2 = new System.Windows.Forms.Label();
            this.booksearch = new System.Windows.Forms.TextBox();
            this.bookslbl = new System.Windows.Forms.Label();
            this.Numcopieslbl = new System.Windows.Forms.Label();
            this.Numcopiestxt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.bookstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.bookstab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.Clearbtn);
            this.tabPage1.Controls.Add(this.Deletebtn);
            this.tabPage1.Controls.Add(this.Updatebtn);
            this.tabPage1.Controls.Add(this.Newbtn);
            this.tabPage1.Controls.Add(this.Emaillbl);
            this.tabPage1.Controls.Add(this.Emailtxt);
            this.tabPage1.Controls.Add(this.Phonelbl);
            this.tabPage1.Controls.Add(this.Phonetxt);
            this.tabPage1.Controls.Add(this.Namelbl);
            this.tabPage1.Controls.Add(this.Nametxt);
            this.tabPage1.Controls.Add(this.dgvMembers);
            this.tabPage1.Controls.Add(this.Searchbtn);
            this.tabPage1.Controls.Add(this.Searchlbl);
            this.tabPage1.Controls.Add(this.Searchtxt);
            this.tabPage1.Controls.Add(this.Memberslbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1043, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(631, 240);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(140, 28);
            this.Clearbtn.TabIndex = 16;
            this.Clearbtn.Text = "Clear ";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(631, 190);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(140, 28);
            this.Deletebtn.TabIndex = 15;
            this.Deletebtn.Text = "Delete Member";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click_1);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(437, 240);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(140, 28);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update Info";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Newbtn
            // 
            this.Newbtn.Location = new System.Drawing.Point(437, 190);
            this.Newbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(140, 28);
            this.Newbtn.TabIndex = 12;
            this.Newbtn.Text = "New Member";
            this.Newbtn.UseVisualStyleBackColor = true;
            this.Newbtn.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(433, 137);
            this.Emaillbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(56, 20);
            this.Emaillbl.TabIndex = 10;
            this.Emaillbl.Text = "Email:";
            // 
            // Emailtxt
            // 
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emailtxt.Location = new System.Drawing.Point(523, 133);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(243, 22);
            this.Emailtxt.TabIndex = 11;
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelbl.Location = new System.Drawing.Point(433, 100);
            this.Phonelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(61, 20);
            this.Phonelbl.TabIndex = 8;
            this.Phonelbl.Text = "Phone:";
            // 
            // Phonetxt
            // 
            this.Phonetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phonetxt.Location = new System.Drawing.Point(523, 96);
            this.Phonetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(243, 22);
            this.Phonetxt.TabIndex = 9;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(433, 66);
            this.Namelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(58, 20);
            this.Namelbl.TabIndex = 6;
            this.Namelbl.Text = "Name:";
            // 
            // Nametxt
            // 
            this.Nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nametxt.Location = new System.Drawing.Point(523, 63);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(243, 22);
            this.Nametxt.TabIndex = 7;
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(11, 66);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.Size = new System.Drawing.Size(372, 369);
            this.dgvMembers.TabIndex = 5;
            this.dgvMembers.SelectionChanged += new System.EventHandler(this.dgvMembers_SelectionChanged);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(239, 31);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(100, 28);
            this.Searchbtn.TabIndex = 4;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(8, 38);
            this.Searchlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(72, 20);
            this.Searchlbl.TabIndex = 2;
            this.Searchlbl.Text = "Search: ";
            // 
            // Searchtxt
            // 
            this.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Searchtxt.Location = new System.Drawing.Point(97, 34);
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(133, 22);
            this.Searchtxt.TabIndex = 3;
            // 
            // Memberslbl
            // 
            this.Memberslbl.AutoSize = true;
            this.Memberslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memberslbl.Location = new System.Drawing.Point(4, 4);
            this.Memberslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Memberslbl.Name = "Memberslbl";
            this.Memberslbl.Size = new System.Drawing.Size(119, 29);
            this.Memberslbl.TabIndex = 0;
            this.Memberslbl.Text = "Members";
            // 
            // bookstab
            // 
            this.bookstab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookstab.Controls.Add(this.Numcopieslbl);
            this.bookstab.Controls.Add(this.Numcopiestxt);
            this.bookstab.Controls.Add(this.Clearbooks);
            this.bookstab.Controls.Add(this.Dltbookbtn);
            this.bookstab.Controls.Add(this.Updatebkbtn);
            this.bookstab.Controls.Add(this.Newbookbtn);
            this.bookstab.Controls.Add(this.Callnumlbl);
            this.bookstab.Controls.Add(this.Callnumtxt);
            this.bookstab.Controls.Add(this.Authorlbl);
            this.bookstab.Controls.Add(this.Authortxt);
            this.bookstab.Controls.Add(this.titlelbl);
            this.bookstab.Controls.Add(this.Titletxt);
            this.bookstab.Controls.Add(this.dataGridBooks);
            this.bookstab.Controls.Add(this.bksearchbtn);
            this.bookstab.Controls.Add(this.Searchlbl2);
            this.bookstab.Controls.Add(this.booksearch);
            this.bookstab.Controls.Add(this.bookslbl);
            this.bookstab.Location = new System.Drawing.Point(4, 25);
            this.bookstab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookstab.Name = "bookstab";
            this.bookstab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookstab.Size = new System.Drawing.Size(1043, 510);
            this.bookstab.TabIndex = 1;
            this.bookstab.Text = "Books";
            this.bookstab.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1043, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Loans";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Clearbooks
            // 
            this.Clearbooks.Location = new System.Drawing.Point(624, 283);
            this.Clearbooks.Margin = new System.Windows.Forms.Padding(4);
            this.Clearbooks.Name = "Clearbooks";
            this.Clearbooks.Size = new System.Drawing.Size(140, 28);
            this.Clearbooks.TabIndex = 31;
            this.Clearbooks.Text = "Clear ";
            this.Clearbooks.UseVisualStyleBackColor = true;
            this.Clearbooks.Click += new System.EventHandler(this.Clearbooks_Click);
            // 
            // Dltbookbtn
            // 
            this.Dltbookbtn.Location = new System.Drawing.Point(624, 233);
            this.Dltbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Dltbookbtn.Name = "Dltbookbtn";
            this.Dltbookbtn.Size = new System.Drawing.Size(140, 28);
            this.Dltbookbtn.TabIndex = 30;
            this.Dltbookbtn.Text = "Delete Book";
            this.Dltbookbtn.UseVisualStyleBackColor = true;
            this.Dltbookbtn.Click += new System.EventHandler(this.Dltbookbtn_Click);
            // 
            // Updatebkbtn
            // 
            this.Updatebkbtn.Location = new System.Drawing.Point(430, 283);
            this.Updatebkbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Updatebkbtn.Name = "Updatebkbtn";
            this.Updatebkbtn.Size = new System.Drawing.Size(140, 28);
            this.Updatebkbtn.TabIndex = 29;
            this.Updatebkbtn.Text = "Update Book Info";
            this.Updatebkbtn.UseVisualStyleBackColor = true;
            this.Updatebkbtn.Click += new System.EventHandler(this.Updatebkbtn_Click);
            // 
            // Newbookbtn
            // 
            this.Newbookbtn.Location = new System.Drawing.Point(430, 233);
            this.Newbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Newbookbtn.Name = "Newbookbtn";
            this.Newbookbtn.Size = new System.Drawing.Size(140, 28);
            this.Newbookbtn.TabIndex = 28;
            this.Newbookbtn.Text = "New Book";
            this.Newbookbtn.UseVisualStyleBackColor = true;
            this.Newbookbtn.Click += new System.EventHandler(this.Newbookbtn_Click);
            // 
            // Callnumlbl
            // 
            this.Callnumlbl.AutoSize = true;
            this.Callnumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Callnumlbl.Location = new System.Drawing.Point(408, 134);
            this.Callnumlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Callnumlbl.Name = "Callnumlbl";
            this.Callnumlbl.Size = new System.Drawing.Size(107, 20);
            this.Callnumlbl.TabIndex = 26;
            this.Callnumlbl.Text = "Call Number:\r\n";
            // 
            // Callnumtxt
            // 
            this.Callnumtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Callnumtxt.Location = new System.Drawing.Point(566, 132);
            this.Callnumtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Callnumtxt.Name = "Callnumtxt";
            this.Callnumtxt.Size = new System.Drawing.Size(243, 22);
            this.Callnumtxt.TabIndex = 27;
            // 
            // Authorlbl
            // 
            this.Authorlbl.AutoSize = true;
            this.Authorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorlbl.Location = new System.Drawing.Point(408, 98);
            this.Authorlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Authorlbl.Name = "Authorlbl";
            this.Authorlbl.Size = new System.Drawing.Size(63, 20);
            this.Authorlbl.TabIndex = 24;
            this.Authorlbl.Text = "Author:";
            // 
            // Authortxt
            // 
            this.Authortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Authortxt.Location = new System.Drawing.Point(566, 95);
            this.Authortxt.Margin = new System.Windows.Forms.Padding(4);
            this.Authortxt.Name = "Authortxt";
            this.Authortxt.Size = new System.Drawing.Size(243, 22);
            this.Authortxt.TabIndex = 25;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(408, 64);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(46, 20);
            this.titlelbl.TabIndex = 22;
            this.titlelbl.Text = "Title:";
            // 
            // Titletxt
            // 
            this.Titletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titletxt.Location = new System.Drawing.Point(566, 62);
            this.Titletxt.Margin = new System.Windows.Forms.Padding(4);
            this.Titletxt.Name = "Titletxt";
            this.Titletxt.Size = new System.Drawing.Size(243, 22);
            this.Titletxt.TabIndex = 23;
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(10, 65);
            this.dataGridBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.RowHeadersWidth = 51;
            this.dataGridBooks.Size = new System.Drawing.Size(372, 369);
            this.dataGridBooks.TabIndex = 21;
            // 
            // bksearchbtn
            // 
            this.bksearchbtn.Location = new System.Drawing.Point(237, 29);
            this.bksearchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.bksearchbtn.Name = "bksearchbtn";
            this.bksearchbtn.Size = new System.Drawing.Size(100, 28);
            this.bksearchbtn.TabIndex = 20;
            this.bksearchbtn.Text = "Search";
            this.bksearchbtn.UseVisualStyleBackColor = true;
            this.bksearchbtn.Click += new System.EventHandler(this.bksearchbtn_Click);
            // 
            // Searchlbl2
            // 
            this.Searchlbl2.AutoSize = true;
            this.Searchlbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl2.Location = new System.Drawing.Point(6, 36);
            this.Searchlbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Searchlbl2.Name = "Searchlbl2";
            this.Searchlbl2.Size = new System.Drawing.Size(72, 20);
            this.Searchlbl2.TabIndex = 18;
            this.Searchlbl2.Text = "Search: ";
            // 
            // booksearch
            // 
            this.booksearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booksearch.Location = new System.Drawing.Point(95, 32);
            this.booksearch.Margin = new System.Windows.Forms.Padding(4);
            this.booksearch.Name = "booksearch";
            this.booksearch.Size = new System.Drawing.Size(133, 22);
            this.booksearch.TabIndex = 19;
            // 
            // bookslbl
            // 
            this.bookslbl.AutoSize = true;
            this.bookslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookslbl.Location = new System.Drawing.Point(2, 2);
            this.bookslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookslbl.Name = "bookslbl";
            this.bookslbl.Size = new System.Drawing.Size(84, 29);
            this.bookslbl.TabIndex = 17;
            this.bookslbl.Text = "Books";
            // 
            // Numcopieslbl
            // 
            this.Numcopieslbl.AutoSize = true;
            this.Numcopieslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numcopieslbl.Location = new System.Drawing.Point(408, 164);
            this.Numcopieslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Numcopieslbl.Name = "Numcopieslbl";
            this.Numcopieslbl.Size = new System.Drawing.Size(138, 20);
            this.Numcopieslbl.TabIndex = 32;
            this.Numcopieslbl.Text = "Avaliable Copies:";
            // 
            // Numcopiestxt
            // 
            this.Numcopiestxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numcopiestxt.Location = new System.Drawing.Point(566, 162);
            this.Numcopiestxt.Margin = new System.Windows.Forms.Padding(4);
            this.Numcopiestxt.Name = "Numcopiestxt";
            this.Numcopiestxt.Size = new System.Drawing.Size(243, 22);
            this.Numcopiestxt.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.bookstab.ResumeLayout(false);
            this.bookstab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage bookstab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Memberslbl;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Newbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Clearbooks;
        private System.Windows.Forms.Button Dltbookbtn;
        private System.Windows.Forms.Button Updatebkbtn;
        private System.Windows.Forms.Button Newbookbtn;
        private System.Windows.Forms.Label Callnumlbl;
        private System.Windows.Forms.TextBox Callnumtxt;
        private System.Windows.Forms.Label Authorlbl;
        private System.Windows.Forms.TextBox Authortxt;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.TextBox Titletxt;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.Button bksearchbtn;
        private System.Windows.Forms.Label Searchlbl2;
        private System.Windows.Forms.TextBox booksearch;
        private System.Windows.Forms.Label bookslbl;
        private System.Windows.Forms.Label Numcopieslbl;
        private System.Windows.Forms.TextBox Numcopiestxt;
    }
}

