using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        }

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
            if (dgvMembers.CurrentRow == null)
                return null;

            object value = dgvMembers.CurrentRow.Cells["MemberId"].Value;

            if (value == null || value == DBNull.Value)
                return null;

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
                cmd.Parameters.AddWithValue("@Phone",
                    string.IsNullOrWhiteSpace(Phonetxt.Text) ? (object)DBNull.Value : Phonetxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Email",
                    string.IsNullOrWhiteSpace(Emailtxt.Text) ? (object)DBNull.Value : Emailtxt.Text.Trim());

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

            if (confirm != DialogResult.Yes)
                return;

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

        // START BOOK MANAGEMENT CODE
        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
            dataGridBooks.ClearSelection();
        }
        */
        private void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Title, Author, Call Number, Avaliable Copies FROM Books";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridBooks.DataSource = dt;
            }
        }

        private int? GetSelectedBookNum()
        {
            if (dataGridBooks.CurrentRow == null)
                return null;

            object value = dataGridBooks.CurrentRow.Cells["Call Number"].Value;

            if (value == null || value == DBNull.Value)
                return null;

            return Convert.ToInt32(value);
        }
        private void dataGridBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridBooks.CurrentRow == null) return;

            Titletxt.Text = dgvMembers.CurrentRow.Cells["Title"].Value?.ToString();
            Phonetxt.Text = dgvMembers.CurrentRow.Cells["Author"].Value?.ToString();
            Emailtxt.Text = dgvMembers.CurrentRow.Cells["Call Number"].Value?.ToString();
        }

        // BOOK TAB EVENTS

        // Search Books
        private void bksearchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books WHERE Title LIKE @Title";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Book", "%" + Searchtxt.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridBooks.DataSource = dt;
            }
        }

        // Add New Book
        private void Newbookbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Books (Title, Author, Call Number, Available Copies) VALUES (@Title, @Author, @Call Number, @Available Copies)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Title", Titletxt.Text);
                cmd.Parameters.AddWithValue("@Author", string.IsNullOrEmpty(Authortxt.Text) ? (object)DBNull.Value : Authortxt.Text);
                cmd.Parameters.AddWithValue("@Call Number", string.IsNullOrEmpty(Callnumtxt.Text) ? (object)DBNull.Value : Callnumtxt.Text);
                cmd.Parameters.AddWithValue("@Available Copies", string.IsNullOrEmpty(Numcopiestxt.Text) ? (object)DBNull.Value : Numcopiestxt.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMembers();
            ClearMemberInputs();
        }

        // Delete Book
        private void Dltbookbtn_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedBookNum();
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

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Books WHERE Call Number=@Call Number";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Call Number", id.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadBooks();
            ClearBookInputs();
        }

        // Update Book Info
        private void Updatebkbtn_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedBookNum();
            if (id == null)
            {
                MessageBox.Show("Select a book to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Books SET Title=@Title, Author=@Author, Available Copies=@Available Copies WHERE Call Number=@Call Number";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Call Number", id.Value);
                cmd.Parameters.AddWithValue("@Title", Titletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Author",
                    string.IsNullOrWhiteSpace(Authortxt.Text) ? (object)DBNull.Value : Authortxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Available Copies",
                    string.IsNullOrWhiteSpace(Numcopiestxt.Text) ? (object)DBNull.Value : Numcopiestxt.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMembers();
        }

        // Clear Book
        private void Clearbooks_Click(object sender, EventArgs e)
        {

            ClearBookInputs();
            dataGridBooks.ClearSelection();
        }

        private void ClearBookInputs()
        {
            Titletxt.Clear();
            Authortxt.Clear();
            Callnumtxt.Clear();
            Numcopiestxt.Clear();
        }

        // Manage number of copies avaliable
        // Increase/ decrease as books are loaned out
        // Don't allow a loan if 0 copies avaliable

    }
}
