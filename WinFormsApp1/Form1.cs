using Microsoft.Data.SqlClient;

using MySql.Data.MySqlClient;

using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnMySql_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = "Server=localhost;Database=Cliente01;Uid=root;Pwd=senha@123;";
            conn.Open();

            MessageBox.Show("Abri conexao com o MySql");

            conn.Close();
        }

        private void btnConnectionSqlServer_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=localhost;User ID=sa;Password=senha@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            conn.Open();

            MessageBox.Show("Abri conexao com o SqlServer");

            conn.Close();
        }

        private void btnListarMysql_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            string conection = @"Server=localhost;Database=Cliente01;Uid=root;Pwd=senha@123;";

            conn.ConnectionString = conection;
            conn.Open();

            MySqlCommand comm = new MySqlCommand();

            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "select * from Produtos";
            comm.Connection = conn;

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader.GetString(1);
                string cor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                listBox1.Items.Add($"{reader.GetInt32(0)}, {nome}, {cor}");
            }

            conn.Close();
        }

        private void btnListarSqlServer_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();


            string conection = @"Data Source=localhost;User ID=sa;Password=senha@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Cliente01;";

            conn.ConnectionString = conection;
            conn.Open();

            SqlCommand comm = new SqlCommand();

            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "select * from Produtos";
            comm.Connection = conn;

            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader.GetString(1);
                string cor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                listBox2.Items.Add($"{reader.GetInt32(0)}, {nome}, {cor}");
            }

            conn.Close();
        }

        private void btnListarMySqlDataset_Click(object sender, EventArgs e)
        {
            string conection = @"Server=localhost;Database=Cliente01;Uid=root;Pwd=senha@123;";
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Produtos", conection);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnListarSqlServerDataSet_Click(object sender, EventArgs e)
        {
            string conection = @"Data Source=localhost;User ID=sa;Password=senha@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Cliente01;";
            SqlDataAdapter da = new SqlDataAdapter("select * from Produtos", conection);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
        }
    }
}