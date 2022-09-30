﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_5_6
{
	public partial class Form3 : Form
	{
		public int selectRow = -1;
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";
			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;

			string sql = "SELECT * FROM Услуги";
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

			string code = textBox1.Text.ToString();
			string format = textBox2.Text.ToString();
			string count = textBox3.Text.ToString();
			string units = textBox4.Text.ToString();
			string price = textBox5.Text.ToString();


			sql = "INSERT INTO Услуги (Код_вида, Формат, Количество, Единицы_измерения, Стоимость)" +
				"VALUES (" + code + ", " + "'" + format + "'" + ", " + count + ", " + "'" + units + "'" + ", " + price + ")";

			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			myCommand.ExecuteNonQuery();
			connection.Close();

			connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			sql = "SELECT * FROM Услуги";
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



		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			textBox9.Text = "";
			textBox10.Text = "";
			textBox11.Text = "";
			textBox12.Text = "";
			selectRow = dataGridView1.CurrentCell.RowIndex;

			if (selectRow < (dataGridView1.RowCount - 1))
			{
				textBox6.Text = dataGridView1[0, selectRow].Value.ToString();
				textBox7.Text = dataGridView1[1, selectRow].Value.ToString();
				textBox8.Text = dataGridView1[2, selectRow].Value.ToString();
				textBox9.Text = dataGridView1[3, selectRow].Value.ToString();
				textBox10.Text = dataGridView1[4, selectRow].Value.ToString();
				textBox11.Text = dataGridView1[5, selectRow].Value.ToString();

				textBox12.Text = dataGridView1[0, selectRow].Value.ToString();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			textBox9.Text = "";
			textBox10.Text = "";
			textBox11.Text = "";
			textBox12.Text = "";
			selectRow = dataGridView1.CurrentCell.RowIndex;

			if (selectRow < (dataGridView1.RowCount - 1))
			{
				textBox6.Text = dataGridView1[0, selectRow].Value.ToString();
				textBox7.Text = dataGridView1[1, selectRow].Value.ToString();
				textBox8.Text = dataGridView1[2, selectRow].Value.ToString();
				textBox9.Text = dataGridView1[3, selectRow].Value.ToString();
				textBox10.Text = dataGridView1[4, selectRow].Value.ToString();
				textBox11.Text = dataGridView1[5, selectRow].Value.ToString();

				textBox12.Text = dataGridView1[0, selectRow].Value.ToString();
			}
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
			string code_service = textBox6.Text.ToString();
			string code_kind = textBox7.Text.ToString();
			string format = textBox8.Text.ToString();
			string count = textBox9.Text.ToString();
			string units = textBox10.Text.ToString();
			string price = Convert.ToDouble(textBox11.Text.ToString()).ToString(CultureInfo.InvariantCulture);

			sql = "UPDATE Услуги SET " +
				"Код_вида = " + code_kind + ", " +
				"Формат = '" + format + "', " +
				"Количество = " + count + ", " +
				"Единицы_измерения = '" + units + "', " +
				"Стоимость = " + price + " " +
				"WHERE Код_услуги = " + code_service;

			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			myCommand.ExecuteNonQuery();
			connection.Close();

			connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			sql = "SELECT * FROM Услуги";
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
		private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";

			groupBox1.Visible = true;
			groupBox2.Visible = false;
			groupBox3.Visible = false;
			groupBox4.Visible = false;
		}

		private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
		{
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			textBox9.Text = "";
			textBox10.Text = "";
			textBox11.Text = "";

			groupBox1.Visible = false;
			groupBox2.Visible = true;
			groupBox3.Visible = false;
			groupBox4.Visible = false;
		}


		private void button5_Click(object sender, EventArgs e)
		{
			groupBox3.Visible = false;
		}

		private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
		{
			groupBox1.Visible = false;
			groupBox2.Visible = false;
			groupBox3.Visible = true;
			groupBox4.Visible = false;

		}
		private void findToolStripMenuItem_Click(object sender, EventArgs e)
		{
			groupBox1.Visible = false;
			groupBox2.Visible = false;
			groupBox3.Visible = false;
			groupBox4.Visible = true;
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

			string code = textBox12.Text;

			sql = "DELETE * FROM Услуги WHERE Код_услуги = " + code;

			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			myCommand.ExecuteNonQuery();
			connection.Close();

			connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			sql = "SELECT * FROM Услуги";
			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
			connection.Close();

			groupBox3.Visible = false;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex < 0)
			{
				MessageBox.Show("Выберите критерий поиска!");
				return;
			}
			// иначе поиск данных в бд
			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";
			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			OleDbCommand myCommand;
			string sql;
			// считывание критерия поиска из выпадающего списка
			string kriteriy = comboBox1.SelectedItem.ToString();
			// считывание данных с поля ввода
			string znachenie = textBox13.Text;
			// формирование запроса на поиск
			sql = "SELECT * FROM Услуги WHERE " +
				kriteriy + " Like '" + znachenie + "'";
			// выполнение запроса
			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
			connection.Close();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex < 0)
			{
				MessageBox.Show("Выберите критерий поиска!");
				return;
			}
			// иначе поиск данных в бд
			string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=center.mdb";
			OleDbConnection connection = new OleDbConnection();
			connection.ConnectionString = ConnectionString;
			OleDbCommand myCommand;
			string sql;
			sql = "SELECT * FROM Услуги";
			// выполнение запроса
			myCommand = new OleDbCommand(sql, connection);
			connection.Open();
			OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
			DataSet ds = new DataSet();
			da.Fill(ds, "Результат");
			dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
			connection.Close();

			// скрываю не нужный групбокс
			groupBox4.Visible = false;
		}


	}
}
