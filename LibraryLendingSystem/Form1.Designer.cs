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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.ClearBbtn = new System.Windows.Forms.Button();
            this.DeleteBbtn = new System.Windows.Forms.Button();
            this.UpdateBbtn = new System.Windows.Forms.Button();
            this.NewBbtn = new System.Windows.Forms.Button();
            this.ISBNlbl = new System.Windows.Forms.Label();
            this.ISBNtxt = new System.Windows.Forms.TextBox();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Titletxt = new System.Windows.Forms.TextBox();
            this.Authorlbl = new System.Windows.Forms.Label();
            this.Authortxt = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.SearchBbtn = new System.Windows.Forms.Button();
            this.SearchBlbl = new System.Windows.Forms.Label();
            this.SearchBtxt = new System.Windows.Forms.TextBox();
            this.Bookslbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Tbooklbl = new System.Windows.Forms.Label();
            this.ABookslbl = new System.Windows.Forms.Label();
            this.Btitlelbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Duedtp = new System.Windows.Forms.DateTimePicker();
            this.Borrowdtp = new System.Windows.Forms.DateTimePicker();
            this.Titlecb = new System.Windows.Forms.ComboBox();
            this.Namecb = new System.Windows.Forms.ComboBox();
            this.Duelbl = new System.Windows.Forms.Label();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.Loanbtn = new System.Windows.Forms.Button();
            this.Borrowlbl = new System.Windows.Forms.Label();
            this.TitleBlbl = new System.Windows.Forms.Label();
            this.NameBlbl = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.Loanslbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(473, 195);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(105, 23);
            this.Clearbtn.TabIndex = 16;
            this.Clearbtn.Text = "Clear ";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(473, 154);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(105, 23);
            this.Deletebtn.TabIndex = 15;
            this.Deletebtn.Text = "Delete Member";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click_1);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(328, 195);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(105, 23);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update Info";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Newbtn
            // 
            this.Newbtn.Location = new System.Drawing.Point(328, 154);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(105, 23);
            this.Newbtn.TabIndex = 12;
            this.Newbtn.Text = "New Member";
            this.Newbtn.UseVisualStyleBackColor = true;
            this.Newbtn.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(325, 111);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(46, 17);
            this.Emaillbl.TabIndex = 10;
            this.Emaillbl.Text = "Email:";
            // 
            // Emailtxt
            // 
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emailtxt.Location = new System.Drawing.Point(392, 108);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(183, 20);
            this.Emailtxt.TabIndex = 11;
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelbl.Location = new System.Drawing.Point(325, 81);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(53, 17);
            this.Phonelbl.TabIndex = 8;
            this.Phonelbl.Text = "Phone:";
            // 
            // Phonetxt
            // 
            this.Phonetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phonetxt.Location = new System.Drawing.Point(392, 78);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(183, 20);
            this.Phonetxt.TabIndex = 9;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(325, 54);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(49, 17);
            this.Namelbl.TabIndex = 6;
            this.Namelbl.Text = "Name:";
            // 
            // Nametxt
            // 
            this.Nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nametxt.Location = new System.Drawing.Point(392, 51);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(183, 20);
            this.Nametxt.TabIndex = 7;
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(8, 54);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(279, 300);
            this.dgvMembers.TabIndex = 5;
            this.dgvMembers.SelectionChanged += new System.EventHandler(this.dgvMembers_SelectionChanged);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(220, 25);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 23);
            this.Searchbtn.TabIndex = 4;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(6, 31);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(102, 17);
            this.Searchlbl.TabIndex = 2;
            this.Searchlbl.Text = "Search Name: ";
            // 
            // Searchtxt
            // 
            this.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Searchtxt.Location = new System.Drawing.Point(114, 28);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(100, 20);
            this.Searchtxt.TabIndex = 3;
            // 
            // Memberslbl
            // 
            this.Memberslbl.AutoSize = true;
            this.Memberslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memberslbl.Location = new System.Drawing.Point(3, 3);
            this.Memberslbl.Name = "Memberslbl";
            this.Memberslbl.Size = new System.Drawing.Size(94, 25);
            this.Memberslbl.TabIndex = 0;
            this.Memberslbl.Text = "Members";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Totaltxt);
            this.tabPage2.Controls.Add(this.ClearBbtn);
            this.tabPage2.Controls.Add(this.DeleteBbtn);
            this.tabPage2.Controls.Add(this.UpdateBbtn);
            this.tabPage2.Controls.Add(this.NewBbtn);
            this.tabPage2.Controls.Add(this.ISBNlbl);
            this.tabPage2.Controls.Add(this.ISBNtxt);
            this.tabPage2.Controls.Add(this.Titlelbl);
            this.tabPage2.Controls.Add(this.Titletxt);
            this.tabPage2.Controls.Add(this.Authorlbl);
            this.tabPage2.Controls.Add(this.Authortxt);
            this.tabPage2.Controls.Add(this.dgvBooks);
            this.tabPage2.Controls.Add(this.SearchBbtn);
            this.tabPage2.Controls.Add(this.SearchBlbl);
            this.tabPage2.Controls.Add(this.SearchBtxt);
            this.tabPage2.Controls.Add(this.Bookslbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Books";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Total Books:";
            // 
            // Totaltxt
            // 
            this.Totaltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Totaltxt.Location = new System.Drawing.Point(579, 143);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.Size = new System.Drawing.Size(183, 20);
            this.Totaltxt.TabIndex = 35;
            // 
            // ClearBbtn
            // 
            this.ClearBbtn.Location = new System.Drawing.Point(660, 225);
            this.ClearBbtn.Name = "ClearBbtn";
            this.ClearBbtn.Size = new System.Drawing.Size(105, 23);
            this.ClearBbtn.TabIndex = 33;
            this.ClearBbtn.Text = "Clear ";
            this.ClearBbtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBbtn
            // 
            this.DeleteBbtn.Location = new System.Drawing.Point(660, 184);
            this.DeleteBbtn.Name = "DeleteBbtn";
            this.DeleteBbtn.Size = new System.Drawing.Size(105, 23);
            this.DeleteBbtn.TabIndex = 32;
            this.DeleteBbtn.Text = "Delete Book";
            this.DeleteBbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DeleteBbtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBbtn
            // 
            this.UpdateBbtn.Location = new System.Drawing.Point(515, 225);
            this.UpdateBbtn.Name = "UpdateBbtn";
            this.UpdateBbtn.Size = new System.Drawing.Size(105, 23);
            this.UpdateBbtn.TabIndex = 31;
            this.UpdateBbtn.Text = "Update Book";
            this.UpdateBbtn.UseVisualStyleBackColor = true;
            // 
            // NewBbtn
            // 
            this.NewBbtn.Location = new System.Drawing.Point(515, 184);
            this.NewBbtn.Name = "NewBbtn";
            this.NewBbtn.Size = new System.Drawing.Size(105, 23);
            this.NewBbtn.TabIndex = 30;
            this.NewBbtn.Text = "New Book";
            this.NewBbtn.UseVisualStyleBackColor = true;
            // 
            // ISBNlbl
            // 
            this.ISBNlbl.AutoSize = true;
            this.ISBNlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNlbl.Location = new System.Drawing.Point(523, 120);
            this.ISBNlbl.Name = "ISBNlbl";
            this.ISBNlbl.Size = new System.Drawing.Size(43, 17);
            this.ISBNlbl.TabIndex = 28;
            this.ISBNlbl.Text = "ISBN:";
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ISBNtxt.Location = new System.Drawing.Point(579, 117);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(183, 20);
            this.ISBNtxt.TabIndex = 29;
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(527, 90);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(39, 17);
            this.Titlelbl.TabIndex = 26;
            this.Titlelbl.Text = "Title:";
            // 
            // Titletxt
            // 
            this.Titletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titletxt.Location = new System.Drawing.Point(579, 87);
            this.Titletxt.Name = "Titletxt";
            this.Titletxt.Size = new System.Drawing.Size(183, 20);
            this.Titletxt.TabIndex = 27;
            // 
            // Authorlbl
            // 
            this.Authorlbl.AutoSize = true;
            this.Authorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorlbl.Location = new System.Drawing.Point(512, 63);
            this.Authorlbl.Name = "Authorlbl";
            this.Authorlbl.Size = new System.Drawing.Size(54, 17);
            this.Authorlbl.TabIndex = 24;
            this.Authorlbl.Text = "Author:";
            // 
            // Authortxt
            // 
            this.Authortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Authortxt.Location = new System.Drawing.Point(579, 60);
            this.Authortxt.Name = "Authortxt";
            this.Authortxt.Size = new System.Drawing.Size(183, 20);
            this.Authortxt.TabIndex = 25;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(8, 57);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(324, 300);
            this.dgvBooks.TabIndex = 23;
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // SearchBbtn
            // 
            this.SearchBbtn.Location = new System.Drawing.Point(210, 28);
            this.SearchBbtn.Name = "SearchBbtn";
            this.SearchBbtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBbtn.TabIndex = 22;
            this.SearchBbtn.Text = "Search";
            this.SearchBbtn.UseVisualStyleBackColor = true;
            // 
            // SearchBlbl
            // 
            this.SearchBlbl.AutoSize = true;
            this.SearchBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBlbl.Location = new System.Drawing.Point(6, 34);
            this.SearchBlbl.Name = "SearchBlbl";
            this.SearchBlbl.Size = new System.Drawing.Size(92, 17);
            this.SearchBlbl.TabIndex = 20;
            this.SearchBlbl.Text = "Search Title: ";
            // 
            // SearchBtxt
            // 
            this.SearchBtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBtxt.Location = new System.Drawing.Point(104, 31);
            this.SearchBtxt.Name = "SearchBtxt";
            this.SearchBtxt.Size = new System.Drawing.Size(100, 20);
            this.SearchBtxt.TabIndex = 21;
            // 
            // Bookslbl
            // 
            this.Bookslbl.AutoSize = true;
            this.Bookslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookslbl.Location = new System.Drawing.Point(3, 6);
            this.Bookslbl.Name = "Bookslbl";
            this.Bookslbl.Size = new System.Drawing.Size(67, 25);
            this.Bookslbl.TabIndex = 19;
            this.Bookslbl.Text = "Books";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Tbooklbl);
            this.tabPage3.Controls.Add(this.ABookslbl);
            this.tabPage3.Controls.Add(this.Btitlelbl);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.Duedtp);
            this.tabPage3.Controls.Add(this.Borrowdtp);
            this.tabPage3.Controls.Add(this.Titlecb);
            this.tabPage3.Controls.Add(this.Namecb);
            this.tabPage3.Controls.Add(this.Duelbl);
            this.tabPage3.Controls.Add(this.Returnbtn);
            this.tabPage3.Controls.Add(this.Loanbtn);
            this.tabPage3.Controls.Add(this.Borrowlbl);
            this.tabPage3.Controls.Add(this.TitleBlbl);
            this.tabPage3.Controls.Add(this.NameBlbl);
            this.tabPage3.Controls.Add(this.dgvLoans);
            this.tabPage3.Controls.Add(this.Loanslbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Loans";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Tbooklbl
            // 
            this.Tbooklbl.AutoSize = true;
            this.Tbooklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbooklbl.Location = new System.Drawing.Point(452, 214);
            this.Tbooklbl.Name = "Tbooklbl";
            this.Tbooklbl.Size = new System.Drawing.Size(0, 17);
            this.Tbooklbl.TabIndex = 43;
            // 
            // ABookslbl
            // 
            this.ABookslbl.AutoSize = true;
            this.ABookslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABookslbl.Location = new System.Drawing.Point(452, 242);
            this.ABookslbl.Name = "ABookslbl";
            this.ABookslbl.Size = new System.Drawing.Size(0, 17);
            this.ABookslbl.TabIndex = 42;
            // 
            // Btitlelbl
            // 
            this.Btitlelbl.AutoSize = true;
            this.Btitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btitlelbl.Location = new System.Drawing.Point(452, 187);
            this.Btitlelbl.Name = "Btitlelbl";
            this.Btitlelbl.Size = new System.Drawing.Size(0, 17);
            this.Btitlelbl.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(359, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Total Books:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Available Books:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Book Title:";
            // 
            // Duedtp
            // 
            this.Duedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Duedtp.Location = new System.Drawing.Point(415, 139);
            this.Duedtp.Name = "Duedtp";
            this.Duedtp.Size = new System.Drawing.Size(121, 20);
            this.Duedtp.TabIndex = 36;
            // 
            // Borrowdtp
            // 
            this.Borrowdtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Borrowdtp.Location = new System.Drawing.Point(415, 113);
            this.Borrowdtp.Name = "Borrowdtp";
            this.Borrowdtp.Size = new System.Drawing.Size(121, 20);
            this.Borrowdtp.TabIndex = 35;
            // 
            // Titlecb
            // 
            this.Titlecb.FormattingEnabled = true;
            this.Titlecb.Location = new System.Drawing.Point(415, 86);
            this.Titlecb.Name = "Titlecb";
            this.Titlecb.Size = new System.Drawing.Size(121, 21);
            this.Titlecb.TabIndex = 34;
            // 
            // Namecb
            // 
            this.Namecb.FormattingEnabled = true;
            this.Namecb.Location = new System.Drawing.Point(415, 59);
            this.Namecb.Name = "Namecb";
            this.Namecb.Size = new System.Drawing.Size(121, 21);
            this.Namecb.TabIndex = 33;
            // 
            // Duelbl
            // 
            this.Duelbl.AutoSize = true;
            this.Duelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duelbl.Location = new System.Drawing.Point(337, 139);
            this.Duelbl.Name = "Duelbl";
            this.Duelbl.Size = new System.Drawing.Size(72, 17);
            this.Duelbl.TabIndex = 32;
            this.Duelbl.Text = "Due Date:";
            // 
            // Returnbtn
            // 
            this.Returnbtn.Location = new System.Drawing.Point(562, 98);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(105, 23);
            this.Returnbtn.TabIndex = 29;
            this.Returnbtn.Text = "Return Book";
            this.Returnbtn.UseVisualStyleBackColor = true;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // Loanbtn
            // 
            this.Loanbtn.Location = new System.Drawing.Point(562, 59);
            this.Loanbtn.Name = "Loanbtn";
            this.Loanbtn.Size = new System.Drawing.Size(105, 23);
            this.Loanbtn.TabIndex = 28;
            this.Loanbtn.Text = "Loan Book";
            this.Loanbtn.UseVisualStyleBackColor = true;
            this.Loanbtn.Click += new System.EventHandler(this.Loanbtn_Click);
            // 
            // Borrowlbl
            // 
            this.Borrowlbl.AutoSize = true;
            this.Borrowlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowlbl.Location = new System.Drawing.Point(319, 113);
            this.Borrowlbl.Name = "Borrowlbl";
            this.Borrowlbl.Size = new System.Drawing.Size(90, 17);
            this.Borrowlbl.TabIndex = 26;
            this.Borrowlbl.Text = "Borrow Date:";
            // 
            // TitleBlbl
            // 
            this.TitleBlbl.AutoSize = true;
            this.TitleBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBlbl.Location = new System.Drawing.Point(334, 86);
            this.TitleBlbl.Name = "TitleBlbl";
            this.TitleBlbl.Size = new System.Drawing.Size(75, 17);
            this.TitleBlbl.TabIndex = 24;
            this.TitleBlbl.Text = "Book Title:";
            // 
            // NameBlbl
            // 
            this.NameBlbl.AutoSize = true;
            this.NameBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBlbl.Location = new System.Drawing.Point(305, 59);
            this.NameBlbl.Name = "NameBlbl";
            this.NameBlbl.Size = new System.Drawing.Size(104, 17);
            this.NameBlbl.TabIndex = 22;
            this.NameBlbl.Text = "Member Name:";
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(8, 56);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(279, 274);
            this.dgvLoans.TabIndex = 21;
            this.dgvLoans.SelectionChanged += new System.EventHandler(this.dgvLoans_SelectionChanged);
            // 
            // Loanslbl
            // 
            this.Loanslbl.AutoSize = true;
            this.Loanslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loanslbl.Location = new System.Drawing.Point(3, 5);
            this.Loanslbl.Name = "Loanslbl";
            this.Loanslbl.Size = new System.Drawing.Size(66, 25);
            this.Loanslbl.TabIndex = 17;
            this.Loanslbl.Text = "Loans";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Totaltxt;
        private System.Windows.Forms.Button ClearBbtn;
        private System.Windows.Forms.Button DeleteBbtn;
        private System.Windows.Forms.Button UpdateBbtn;
        private System.Windows.Forms.Button NewBbtn;
        private System.Windows.Forms.Label ISBNlbl;
        private System.Windows.Forms.TextBox ISBNtxt;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.TextBox Titletxt;
        private System.Windows.Forms.Label Authorlbl;
        private System.Windows.Forms.TextBox Authortxt;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button SearchBbtn;
        private System.Windows.Forms.Label SearchBlbl;
        private System.Windows.Forms.TextBox SearchBtxt;
        private System.Windows.Forms.Label Bookslbl;
        private System.Windows.Forms.Button Returnbtn;
        private System.Windows.Forms.Button Loanbtn;
        private System.Windows.Forms.Label TitleBlbl;
        private System.Windows.Forms.Label NameBlbl;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Label Loanslbl;
        private System.Windows.Forms.Label Borrowlbl;
        private System.Windows.Forms.Label Duelbl;
        private System.Windows.Forms.DateTimePicker Borrowdtp;
        private System.Windows.Forms.ComboBox Titlecb;
        private System.Windows.Forms.ComboBox Namecb;
        private System.Windows.Forms.DateTimePicker Duedtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Tbooklbl;
        private System.Windows.Forms.Label ABookslbl;
        private System.Windows.Forms.Label Btitlelbl;
    }
}

