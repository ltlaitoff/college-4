using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_5_6
{
	public partial class Form2 : Form
	{
		public int selectRow = -1;

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";

			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;

			string sql = "SELECT * FROM Виды_услуг";
			OleDbCommand myCommand = new OleDbCommand(sql, connection);
			connection.Open();

			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
			connection.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";

			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			OleDbCommand myCommand;

			string sql;

			string name = textBox1.Text.ToString();

			sql = "INSERT INTO Виды_услуг (Название_вида) VALUES ('" + name + "')";

			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			myCommand.ExecuteNonQuery();
			connection.Close();

			connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			sql = "SELECT * FROM Виды_услуг";
			myCommand = new OleDbCommand(sql, connection);

			connection.Open();
			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
			connection.Close();

			groupBox1.Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			groupBox1.Visible = false;
		}



		private void button4_Click(object sender, EventArgs e)
		{
			if (selectRow == -1 || selectRow >= dataGridView1.RowCount - 1)
			{
				MessageBox.Show("Выберите в сетке строку для редактирования!");
				return;
			}

			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";
			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			OleDbCommand myCommand;
			string sql;

			string code = textBox2.Text.ToString();
			string name = textBox3.Text.ToString();

			sql = "UPDATE Виды_услуг SET " +
				"Название_вида = '" + name + "'" +
				"WHERE Код_вида = " + code;

			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			myCommand.ExecuteNonQuery();
			connection.Close();

			connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			sql = "SELECT * FROM Виды_услуг";
			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
			connection.Close();

			groupBox2.Visible = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			groupBox2.Visible = false;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";

			selectRow = dataGridView1.CurrentCell.RowIndex;
			if (selectRow < (dataGridView1.RowCount - 1))
			{
				textBox2.Text = dataGridView1[0, selectRow].Value.ToString();
				textBox3.Text = dataGridView1[1, selectRow].Value.ToString();

				textBox4.Text = dataGridView1[0, selectRow].Value.ToString();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";

			selectRow = dataGridView1.CurrentCell.RowIndex;
			if (selectRow < (dataGridView1.RowCount - 1))
			{
				textBox2.Text = dataGridView1[0, selectRow].Value.ToString();
				textBox3.Text = dataGridView1[1, selectRow].Value.ToString();

				textBox4.Text = dataGridView1[0, selectRow].Value.ToString();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (selectRow == -1 || selectRow >= dataGridView1.RowCount - 1)
			{
				MessageBox.Show("Выберите в сетке строку для редактирования!");
				return;
			}

			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";
			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			OleDbCommand myCommand;
			string sql;

			string code = textBox4.Text;

			sql = "DELETE * FROM Виды_услуг WHERE Код_вида = " + code;

			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			myCommand.ExecuteNonQuery();
			connection.Close();

			connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			sql = "SELECT * FROM Виды_услуг";
			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
			connection.Close();

			groupBox3.Visible = false;
		}

		private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			groupBox1.Visible = true;
			groupBox2.Visible = false;
			groupBox3.Visible = false;
			groupBox4.Visible = false;
		}

		private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
			textBox3.Text = "";

			groupBox1.Visible = false;
			groupBox2.Visible = true;
			groupBox3.Visible = false;
			groupBox4.Visible = false;
		}

		private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
		{
			textBox4.Text = "";

			groupBox1.Visible = false;
			groupBox2.Visible = false;
			groupBox3.Visible = true;
			groupBox4.Visible = false;
		}

		private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = -1;
			textBox5.Text = "";

			groupBox1.Visible = false;
			groupBox2.Visible = false;
			groupBox3.Visible = false;
			groupBox4.Visible = true;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			groupBox3.Visible = false;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex < 0)
			{
				MessageBox.Show("Выберите критерий поиска!");
				return;
			}

			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";
			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			OleDbCommand myCommand;
			string sql;
			sql = "SELECT * FROM Виды_услуг";

			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
			connection.Close();

			groupBox4.Visible = false;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex < 0)
			{
				MessageBox.Show("Выберите критерий поиска!");
				return;
			}

			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";

			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			OleDbCommand myCommand;

			string kriteriy = comboBox1.SelectedItem.ToString();
			string znachenie = textBox5.Text.ToString();

			string sql = "SELECT * FROM Виды_услуг WHERE " +
				kriteriy + " Like '" + znachenie + "'";

			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;

			connection.Close();
		}


	}
}
