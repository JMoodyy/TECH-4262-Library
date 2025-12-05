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

    }
}
