using System.Windows.Forms;

namespace PR_2
{
	public partial class Form1 : Form
	{
		private const string FORM_TEXT = "Practice work 2, ({0},{1})";
		private Form2 form2 = new Form2();
		public Form1()
		{
			InitializeComponent();
			dataGridView1.Rows.Add("1", "2", "3", "4", "5");
			dataGridView1.Rows.Add("6", "7", "8", "9", "10");
			dataGridView1.Rows.Add("11", "12", "13", "14", "15");
			resetDataGridViewHeaderTexts();
			setFormHeader(0, 0);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			form2.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Width *= 3;
			this.Height *= 3;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			(dataGridView1[1, 0].Value, dataGridView1[1, 1].Value) = (dataGridView1[1, 1].Value, dataGridView1[1, 0].Value);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Opacity = 1;
		}

		private void setFormHeader(int col, int row)
		{
			this.Text = String.Format(FORM_TEXT, col, row);
		}

		private void resetDataGridViewHeaderTexts()
		{
			dataGridView1.Columns[0].HeaderText = "First";
			dataGridView1.Columns[1].HeaderText = "Second";
			dataGridView1.Columns[2].HeaderText = "Third";
			dataGridView1.Columns[3].HeaderText = "Four";
			dataGridView1.Columns[4].HeaderText = "Five";

			dataGridView1.Rows[0].HeaderCell.Value = "First";
			dataGridView1.Rows[1].HeaderCell.Value = "Second";
			dataGridView1.Rows[2].HeaderCell.Value = "Third";
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			resetDataGridViewHeaderTexts();

			setFormHeader(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex);

			dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText = dataGridView1.CurrentCell.ColumnIndex.ToString();
			dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].HeaderCell.Value = dataGridView1.CurrentCell.RowIndex.ToString();
		}
	}
}