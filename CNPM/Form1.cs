using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CNPM
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=NHUHUYNH\\SQLEXPRESS;Initial Catalog=HSBV_DOAN;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                // Tạo kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Truy vấn SQL để lấy dữ liệu từ bảng (ví dụ: TableName là tên bảng bạn muốn lấy dữ liệu)
                    string query = "SELECT * FROM KHOA";

                    // Tạo một đối tượng SqlDataAdapter để thực hiện truy vấn và lưu kết quả vào DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    // Đổ dữ liệu từ SqlDataAdapter vào DataSet
                    adapter.Fill(dataSet);

                    // Gán dữ liệu từ DataSet vào DataGridView
                    dgv_DSDT.DataSource = dataSet.Tables[0];

                    // Đóng kết nối
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
