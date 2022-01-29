namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnMySql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectionSqlServer = new System.Windows.Forms.Button();
            this.btnListarSqlServer = new System.Windows.Forms.Button();
            this.btnListarMysql = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnListarSqlServerDataSet = new System.Windows.Forms.Button();
            this.btnListarMySqlDataset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnMySql
            // 
            this.btnConnMySql.Location = new System.Drawing.Point(12, 38);
            this.btnConnMySql.Name = "btnConnMySql";
            this.btnConnMySql.Size = new System.Drawing.Size(290, 37);
            this.btnConnMySql.TabIndex = 0;
            this.btnConnMySql.Text = "Conexao MySql";
            this.btnConnMySql.UseVisualStyleBackColor = true;
            this.btnConnMySql.Click += new System.EventHandler(this.btnConnMySql_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADO.NET";
            // 
            // btnConnectionSqlServer
            // 
            this.btnConnectionSqlServer.Location = new System.Drawing.Point(317, 38);
            this.btnConnectionSqlServer.Name = "btnConnectionSqlServer";
            this.btnConnectionSqlServer.Size = new System.Drawing.Size(290, 37);
            this.btnConnectionSqlServer.TabIndex = 2;
            this.btnConnectionSqlServer.Text = "Conexao Sql Server";
            this.btnConnectionSqlServer.UseVisualStyleBackColor = true;
            this.btnConnectionSqlServer.Click += new System.EventHandler(this.btnConnectionSqlServer_Click);
            // 
            // btnListarSqlServer
            // 
            this.btnListarSqlServer.Location = new System.Drawing.Point(317, 81);
            this.btnListarSqlServer.Name = "btnListarSqlServer";
            this.btnListarSqlServer.Size = new System.Drawing.Size(290, 37);
            this.btnListarSqlServer.TabIndex = 4;
            this.btnListarSqlServer.Text = "Listar Sql Server [DataReader]";
            this.btnListarSqlServer.UseVisualStyleBackColor = true;
            this.btnListarSqlServer.Click += new System.EventHandler(this.btnListarSqlServer_Click);
            // 
            // btnListarMysql
            // 
            this.btnListarMysql.Location = new System.Drawing.Point(12, 81);
            this.btnListarMysql.Name = "btnListarMysql";
            this.btnListarMysql.Size = new System.Drawing.Size(290, 37);
            this.btnListarMysql.TabIndex = 3;
            this.btnListarMysql.Text = "Listar no MySql [DataReader]";
            this.btnListarMysql.UseVisualStyleBackColor = true;
            this.btnListarMysql.Click += new System.EventHandler(this.btnListarMysql_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 139);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(317, 124);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(290, 139);
            this.listBox2.TabIndex = 6;
            // 
            // btnListarSqlServerDataSet
            // 
            this.btnListarSqlServerDataSet.Location = new System.Drawing.Point(317, 269);
            this.btnListarSqlServerDataSet.Name = "btnListarSqlServerDataSet";
            this.btnListarSqlServerDataSet.Size = new System.Drawing.Size(290, 37);
            this.btnListarSqlServerDataSet.TabIndex = 8;
            this.btnListarSqlServerDataSet.Text = "Listar Sql Server [DataSet]";
            this.btnListarSqlServerDataSet.UseVisualStyleBackColor = true;
            this.btnListarSqlServerDataSet.Click += new System.EventHandler(this.btnListarSqlServerDataSet_Click);
            // 
            // btnListarMySqlDataset
            // 
            this.btnListarMySqlDataset.Location = new System.Drawing.Point(12, 269);
            this.btnListarMySqlDataset.Name = "btnListarMySqlDataset";
            this.btnListarMySqlDataset.Size = new System.Drawing.Size(290, 37);
            this.btnListarMySqlDataset.TabIndex = 7;
            this.btnListarMySqlDataset.Text = "Listar no MySql [DataSet]";
            this.btnListarMySqlDataset.UseVisualStyleBackColor = true;
            this.btnListarMySqlDataset.Click += new System.EventHandler(this.btnListarMySqlDataset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(290, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(317, 312);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(290, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 508);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListarSqlServerDataSet);
            this.Controls.Add(this.btnListarMySqlDataset);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListarSqlServer);
            this.Controls.Add(this.btnListarMysql);
            this.Controls.Add(this.btnConnectionSqlServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnMySql);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConnMySql;
        private Label label1;
        private Button btnConnectionSqlServer;
        private Button btnListarSqlServer;
        private Button btnListarMysql;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnListarSqlServerDataSet;
        private Button btnListarMySqlDataset;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}