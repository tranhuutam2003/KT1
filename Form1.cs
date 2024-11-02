using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTH2
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=LAPTOP-7NSHMMSK;Initial Catalog=BTCK;Integrated Security=True";
        
        public Form1()
        {
            InitializeComponent();
            loadData();
            loadLoaiTacPham();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO sachvjp (matacpham, tentacgia, tentacpham, loaitacpham) VALUES (@matacpham, @tentacgia, @tentacpham, @loaitacpham)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matacpham", txtmatacpham.Text);
                cmd.Parameters.AddWithValue("@tentacgia", txttentacgia.Text);
                cmd.Parameters.AddWithValue("@tentacpham", txttentacpham.Text);
                cmd.Parameters.AddWithValue("@loaitacpham", cbbloaitacpham.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm tác phẩm thành công");
                loadData();
            }
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM sachvjp";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void loadLoaiTacPham()
        {
            cbbloaitacpham.Items.Clear();
            cbbloaitacpham.Items.Add("Âm nhạc");
            cbbloaitacpham.Items.Add("Truyện ngắn");
            cbbloaitacpham.Items.Add("Phóng sự");
            cbbloaitacpham.SelectedIndex = 0; 
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtmatacpham.Text))
            {
                MessageBox.Show("Mã tác phẩm không được để trống");
                txtmatacpham.Focus();
                return false;
            }
            if (txtmatacpham.Text.Length > 10)
            {
                MessageBox.Show("Mã tác phẩm không được vượt quá 10 ký tự");
                txtmatacpham.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txttentacgia.Text))
            {
                MessageBox.Show("Tên tác giả không được để trống");
                txttentacgia.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txttentacpham.Text))
            {
                MessageBox.Show("Tên tác phẩm không được để trống");
                txttentacpham.Focus();
                return false;
            }
            return true;
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE sachvjp SET tentacgia=@tentacgia, tentacpham=@tentacpham, loaitacpham=@loaitacpham WHERE matacpham=@matacpham";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@matacpham", txtmatacpham.Text);
                    cmd.Parameters.AddWithValue("@tentacgia", txttentacgia.Text);
                    cmd.Parameters.AddWithValue("@tentacpham", txttentacpham.Text);
                    cmd.Parameters.AddWithValue("@loaitacpham", cbbloaitacpham.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa tác phẩm thành công");
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tác phẩm để sửa");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmatacpham.Text))
            {
                MessageBox.Show("Vui lòng chọn một tác phẩm để xóa");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM sachvjp WHERE matacpham=@matacpham";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@matacpham", txtmatacpham.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa tác phẩm thành công");
                    loadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tác phẩm để xóa");
            }
        }

        private void btnlamoi_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtmatacpham.Clear();
            txttentacgia.Clear();
            txttentacpham.Clear();
            cbbloaitacpham.SelectedIndex = 0; 
        }

        private void btntimtentacpham_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM sachvjp WHERE tentacpham LIKE @tentacpham";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@tentacpham", "%" + txttentacpham.Text + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtmatacpham.Text = row.Cells["matacpham"].Value.ToString();
                txttentacgia.Text = row.Cells["tentacgia"].Value.ToString();
                txttentacpham.Text = row.Cells["tentacpham"].Value.ToString();
                cbbloaitacpham.SelectedItem = row.Cells["loaitacpham"].Value.ToString();
            }
        }
        private void btnxuatexxel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files|*.csv";
                saveFileDialog.Title = "Save a CSV File";
                saveFileDialog.FileName = "DataExport.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvContent = new StringBuilder();

                    // Thêm tiêu đề cột từ DataGridView
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        csvContent.Append(dataGridView1.Columns[i].HeaderText + ",");
                    }
                    csvContent.AppendLine();

                    // Thêm dữ liệu từ DataGridView vào CSV
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            csvContent.Append(dataGridView1.Rows[i].Cells[j].Value?.ToString() + ",");
                        }
                        csvContent.AppendLine();
                    }

                    // Lưu file
                    File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
                    MessageBox.Show("Dữ liệu đã được xuất ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
