using Microsoft.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        string connSqlServer = @"Data Source=localhost;User ID=sa;Password=senha@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Cliente01;";

        void ListarTudoSqlServer()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Produtos", connSqlServer);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListarTudoSqlServer();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string query = $"select * from Produtos where nome like '%{txtNome.Text}%'";

            SqlDataAdapter da = new SqlDataAdapter(query, connSqlServer);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connSqlServer);
            SqlCommand comm = new SqlCommand();
            comm.Connection = connection;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "insert into Produtos (Nome, Cor) values (@Nome, @Cor)";
            comm.Parameters.AddWithValue("@Nome", txtNome.Text);
            comm.Parameters.AddWithValue("@Cor", txtCor.Text);

            comm.Connection.Open();

            comm.ExecuteNonQuery();

            comm.Connection.Close();

            ListarTudoSqlServer();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connSqlServer);
            SqlCommand comm = new SqlCommand();
            comm.Connection = connection;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "update Produtos set Nome = @Nome, Cor = @Cor where Id = @id";
            comm.Parameters.AddWithValue("@Nome", txtNome.Text);
            comm.Parameters.AddWithValue("@Cor", txtCor.Text);
            comm.Parameters.AddWithValue("@id", txtId.Text);

            comm.Connection.Open();

            comm.ExecuteNonQuery();

            comm.Connection.Close();

            ListarTudoSqlServer();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connSqlServer);
            SqlCommand comm = new SqlCommand();
            comm.Connection = connection;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "delete from Produtos where Id = @id";
            comm.Parameters.AddWithValue("@id", txtId.Text);

            comm.Connection.Open();

            comm.ExecuteNonQuery();

            comm.Connection.Close();

            ListarTudoSqlServer();
        }
    }
}
