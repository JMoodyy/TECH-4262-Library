using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryLendingSystem
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMembers();
            dgvMembers.ClearSelection();

            LoadBooks();
            dgvBooks.ClearSelection();

            LoadLoans();
            dgvLoans.ClearSelection();

            LoadLoanMembers();
            LoadLoanBooks();
        }

        // ===================== MEMBERS TAB =====================
        private void LoadMembers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MemberId, Name, Phone, Email FROM Members";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMembers.DataSource = dt;
            }
        }

        private int? GetSelectedMemberId()
        {
            if (dgvMembers.CurrentRow == null) return null;

            object value = dgvMembers.CurrentRow.Cells["MemberId"].Value;
            if (value == null || value == DBNull.Value) return null;

            return Convert.ToInt32(value);
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null) return;

            Nametxt.Text = dgvMembers.CurrentRow.Cells["Name"].Value?.ToString();
            Phonetxt.Text = dgvMembers.CurrentRow.Cells["Phone"].Value?.ToString();
            Emailtxt.Text = dgvMembers.CurrentRow.Cells["Email"].Value?.ToString();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Members (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", Nametxt.Text);
                cmd.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(Phonetxt.Text) ? (object)DBNull.Value : Phonetxt.Text);
                cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(Emailtxt.Text) ? (object)DBNull.Value : Emailtxt.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMembers();
            ClearMemberInputs();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Members WHERE Name LIKE @Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", "%" + Searchtxt.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMembers.DataSource = dt;
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedMemberId();
            if (id == null)
            {
                MessageBox.Show("Select a member to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Members SET Name=@Name, Phone=@Phone, Email=@Email WHERE MemberId=@MemberId";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MemberId", id.Value);
                cmd.Parameters.AddWithValue("@Name", Nametxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(Phonetxt.Text) ? (object)DBNull.Value : Phonetxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(Emailtxt.Text) ? (object)DBNull.Value : Emailtxt.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMembers();
        }

        private void Deletebtn_Click_1(object sender, EventArgs e)
        {
            int? id = GetSelectedMemberId();
            if (id == null)
            {
                MessageBox.Show("Select a member to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this member?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Members WHERE MemberId=@MemberId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberId", id.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMembers();
            ClearMemberInputs();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ClearMemberInputs();
            dgvMembers.ClearSelection();
        }

        private void ClearMemberInputs()
        {
            Nametxt.Clear();
            Phonetxt.Clear();
            Emailtxt.Clear();
        }

        // ===================== BOOKS TAB =====================
        private void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT BookId, Author, Title, ISBN, availablebooks, totalbooks FROM Books";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBooks.DataSource = dt;
            }
        }

        private int? GetSelectedBookId()
        {
            if (dgvBooks.CurrentRow == null) return null;

            object value = dgvBooks.CurrentRow.Cells["BookId"].Value;
            if (value == null || value == DBNull.Value) return null;

            return Convert.ToInt32(value);
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null) return;

            Authortxt.Text = dgvBooks.CurrentRow.Cells["Author"].Value?.ToString();
            Titletxt.Text = dgvBooks.CurrentRow.Cells["Title"].Value?.ToString();
            ISBNtxt.Text = dgvBooks.CurrentRow.Cells["ISBN"].Value?.ToString();
            Totaltxt.Text = dgvBooks.CurrentRow.Cells["totalbooks"].Value?.ToString();
        }

        private void NewBbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Authortxt.Text) || string.IsNullOrWhiteSpace(Titletxt.Text))
            {
                MessageBox.Show("Author and Title are required.");
                return;
            }

            int total = 0;
            int.TryParse(Totaltxt.Text, out total);
            int available = total;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Books (Author, Title, ISBN, totalbooks, availablebooks) " +
                               "VALUES (@Author, @Title, @ISBN, @TotalBooks, @AvailableBooks)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Author", Authortxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Title", Titletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@ISBN", string.IsNullOrWhiteSpace(ISBNtxt.Text) ? (object)DBNull.Value : ISBNtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalBooks", total);
                cmd.Parameters.AddWithValue("@AvailableBooks", available);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadBooks();
            ClearBookInputs();
        }

        private void SearchBbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books WHERE Title LIKE @Title";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", "%" + SearchBtxt.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBooks.DataSource = dt;
            }
        }

        private void UpdateBbtn_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedBookId();
            if (id == null)
            {
                MessageBox.Show("Select a book to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Titletxt.Text))
            {
                MessageBox.Show("A book title is required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Books SET Author=@Author, Title=@Title, ISBN=@ISBN, Totalbooks=@Totalbooks WHERE BookId=@BookId";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@BookId", id.Value);
                cmd.Parameters.AddWithValue("@Author", Authortxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Title", string.IsNullOrWhiteSpace(Titletxt.Text) ? (object)DBNull.Value : Titletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@ISBN", string.IsNullOrWhiteSpace(ISBNtxt.Text) ? (object)DBNull.Value : ISBNtxt.Text.Trim());

                int total = 0;
                int.TryParse(Totaltxt.Text, out total);
                cmd.Parameters.AddWithValue("@Totalbooks", total);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadBooks();
        }

        private void DeleteBbtn_Click_1(object sender, EventArgs e)
        {
            int? id = GetSelectedBookId();
            if (id == null)
            {
                MessageBox.Show("Select a book to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this book?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Books WHERE BookId=@BookId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookId", id.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadBooks();
            ClearBookInputs();
        }

        private void ClearBbtn_Click(object sender, EventArgs e)
        {
            ClearBookInputs();
            dgvBooks.ClearSelection();
        }

        private void ClearBookInputs()
        {
            Authortxt.Clear();
            Titletxt.Clear();
            ISBNtxt.Clear();
            Totaltxt.Clear();
        }
        //=====================Loan Section=================

        private void LoadLoans()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                Loans.LoanID,
                Loans.MemberId,
                Loans.BookId,
                Members.Name AS MemberName,
                Books.Title AS BookTitle,
                Loans.LoanDate,
                Loans.DueDate
            FROM Loans
            JOIN Members ON Loans.MemberId = Members.MemberId
            JOIN Books   ON Loans.BookId = Books.BookId";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLoans.DataSource = dt;

                dgvLoans.Columns["MemberId"].Visible = false;
                dgvLoans.Columns["BookId"].Visible = false;
            }
        }
        private void LoadLoanMembers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MemberId, Name FROM Members ORDER BY Name";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Namecb.DisplayMember = "Name";
                Namecb.ValueMember = "MemberId";
                Namecb.DataSource = dt;
                Namecb.SelectedIndex = -1;
            }
        }
        private void LoadLoanBooks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT BookId, Title FROM Books ORDER BY Title";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Titlecb.DisplayMember = "Title";
                Titlecb.ValueMember = "BookId";
                Titlecb.DataSource = dt;
                Titlecb.SelectedIndex = -1;
            }
        }

        private int? GetSelectedLoanId()
        {
            if (dgvLoans.CurrentRow == null) return null;

            object value = dgvLoans.CurrentRow.Cells["LoanID"].Value;
            if (value == null || value == DBNull.Value) return null;

            return Convert.ToInt32(value);
        }

        private void dgvLoans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow == null) return;


            if (dgvLoans.CurrentRow.Cells["MemberId"].Value != DBNull.Value)
            {
                int memberId = Convert.ToInt32(dgvLoans.CurrentRow.Cells["MemberId"].Value);
                Namecb.SelectedValue = memberId;
            }

            if (dgvLoans.CurrentRow.Cells["BookId"].Value != DBNull.Value)
            {
                int bookId = Convert.ToInt32(dgvLoans.CurrentRow.Cells["BookId"].Value);
                Titlecb.SelectedValue = bookId;
            }


            if (dgvLoans.CurrentRow.Cells["LoanDate"].Value != DBNull.Value)
                Borrowdtp.Value = Convert.ToDateTime(dgvLoans.CurrentRow.Cells["LoanDate"].Value);

            if (dgvLoans.CurrentRow.Cells["DueDate"].Value != DBNull.Value)
                Duedtp.Value = Convert.ToDateTime(dgvLoans.CurrentRow.Cells["DueDate"].Value);

            if (dgvLoans.CurrentRow.Cells["BookId"].Value != DBNull.Value)
            {
                int bookId = Convert.ToInt32(dgvLoans.CurrentRow.Cells["BookId"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT Title, totalbooks, availablebooks 
                         FROM Books 
                         WHERE BookId = @BookId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookId", bookId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Btitlelbl.Text = reader["Title"].ToString();
                        Tbooklbl.Text =  reader["TotalBooks"].ToString();
                        ABookslbl.Text = reader["AvailableBooks"].ToString();
                    }
                }
            }
        }

        private void Loanbtn_Click(object sender, EventArgs e)
        {
            if (Namecb.SelectedIndex == -1 || Titlecb.SelectedIndex == -1)
            {
                MessageBox.Show("Select a member and a book.");
                return;
            }

            int memberId = (int)Namecb.SelectedValue;
            int bookId = (int)Titlecb.SelectedValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

               
                string query = @"INSERT INTO Loans (MemberId, BookId, LoanDate, DueDate)
                         VALUES (@MemberId, @BookId, @LoanDate, @DueDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@BookId", bookId);
                cmd.Parameters.AddWithValue("@LoanDate", Borrowdtp.Value.Date);
                cmd.Parameters.AddWithValue("@DueDate", Duedtp.Value.Date);
                cmd.ExecuteNonQuery();

                
                string updateAvailability = "UPDATE Books SET AvailableBooks = AvailableBooks - 1 WHERE BookID = @BookID";
                SqlCommand updateCmd = new SqlCommand(updateAvailability, conn);
                updateCmd.Parameters.AddWithValue("@BookID", bookId);
                updateCmd.ExecuteNonQuery();   
            }

            LoadLoans();
            LoadBooks();   
            ClearLoanInputs();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            int? loanId = GetSelectedLoanId();
            if (loanId == null)
            {
                MessageBox.Show("Select a loan to Return.");
                return;
            }

            int bookId = Convert.ToInt32(dgvLoans.CurrentRow.Cells["BookID"].Value);

            var confirm = MessageBox.Show(
                "Are you sure you want to return this loan?",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                string updateAvailability = "UPDATE Books SET AvailableBooks = AvailableBooks + 1 WHERE BookID = @BookID";
                SqlCommand updateCmd = new SqlCommand(updateAvailability, conn);
                updateCmd.Parameters.AddWithValue("@BookID", bookId);
                updateCmd.ExecuteNonQuery();  

                
                string query = "DELETE FROM Loans WHERE LoanID=@LoanID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoanID", loanId.Value);
                cmd.ExecuteNonQuery();
            }

            LoadLoans();
            LoadBooks();   
            ClearLoanInputs();
        }


        private void ClearLoanInputs()
        {
            Namecb.SelectedIndex = -1;
            Titlecb.SelectedIndex = -1;

            
            Borrowdtp.Value = DateTime.Today;
            Duedtp.Value = DateTime.Today;
        }
    }
}
