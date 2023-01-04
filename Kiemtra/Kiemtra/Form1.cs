using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost;Initial Catalog=HRR;Persist Security Info=True;User ID=sa; Password=son";
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Employee values( @IdEmployee, @Name, @DateBirth, @Gender, @PlaceBirth,@NameDepartment)", conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", tbMa.Text));
            cmd.Parameters.Add(new SqlParameter("@Name", tbHoten.Text));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", dateTimePicker1.Text));
            cmd.Parameters.Add(new SqlParameter("@Gender", checkBox1.Checked));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", tbNoisinh.Text));
            cmd.Parameters.Add(new SqlParameter("@NameDepartment", cbDonvi.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            dtgHR.Rows.Add(tbMa.Text, tbHoten.Text, dateTimePicker1.Text, checkBox1.Checked, tbNoisinh.Text, cbDonvi.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost;Initial Catalog=HRR;Persist Security Info=True;User ID=sa; Password=son";
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Employee where IdEmployee=@IdEmployee", conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", tbMa.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dtgHR.CurrentCell.RowIndex;
            dtgHR.Rows.RemoveAt(idx);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost;Initial Catalog=HRR;Persist Security Info=True;User ID=sa; Password=son";
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Employee set Name=@Name, DateBirth=@DateBirth,PlaceBirth=@PlaceBirth, Gender=@Gender, NameDepartment=@NameDepartment where IdEmployee=@IdEmployee", conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", tbMa.Text));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", dateTimePicker1.Text));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", tbNoisinh.Text));
            cmd.Parameters.Add(new SqlParameter("@Name", tbHoten.Text));
            cmd.Parameters.Add(new SqlParameter("@Gender", checkBox1.Checked));
            cmd.Parameters.Add(new SqlParameter("@NameDepartment", cbDonvi.Text));
            //cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dtgHR.CurrentCell.RowIndex;
            dtgHR.Rows[idx].Cells[0].Value = tbMa.Text;
            dtgHR.Rows[idx].Cells[1].Value = tbHoten.Text;
            dtgHR.Rows[idx].Cells[2].Value = dateTimePicker1.Text;
            dtgHR.Rows[idx].Cells[3].Value = checkBox1.Checked;
            dtgHR.Rows[idx].Cells[4].Value = tbNoisinh.Text;
            dtgHR.Rows[idx].Cells[5].Value = cbDonvi.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            btnThoat.Enabled = true;
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost;Initial Catalog=HRR;Persist Security Info=false;User ID=sa; Password=son";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Employee.IdEmployee,Employee.Name, Employee.DateBirth,Employee.Gender,Employee.PlaceBirth,Department.NameDepartment FROM Employee " +
                "INNER JOIN Department ON Department.IdDepartment = Employee.IdDepartment", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dtgHR.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2), reader.GetBoolean(3), reader.GetString(4), reader.GetString(5));
                }
            }
            conn.Close();
        }

        private void dtgHR_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dtgHR.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbMa.Text = row.Cells[0].Value.ToString();
                tbHoten.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.CustomFormat = row.Cells[2].Value.ToString();
                cbDonvi.Text = row.Cells[5].Value.ToString();
                tbNoisinh.Text = row.Cells[4].Value.ToString();
                checkBox1.Checked = bool.Parse(dtgHR.Rows[idx].Cells[3].Value.ToString());
            }
        }
    }
}
