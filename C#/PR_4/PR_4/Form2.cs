using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_4
{
	public partial class Form2 : Form
	{
		Random random = new Random();

		private const string RESULT_STRING = "Result({0}, {1}): {2}";
		private const int N = 10;

		public Form2()
		{
			InitializeComponent();
		}


		private void setResult(int firstValue, int secondValue, int result)
		{
			label2.Text = String.Format(RESULT_STRING, firstValue, secondValue, result);
		}

		private void button1_Click(object sender, EventArgs e)
		{

			int[,] DATA = new int[N, N];

			dataGridView1.RowCount = N;
			dataGridView1.ColumnCount = N;

			int min = 9999999;
			int max = -9999999;

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					DATA[i, j] = random.Next(7, 33);
					dataGridView1[j, i].Value = Convert.ToString(DATA[i, j]);
					if (i == j)
					{
						if (min > DATA[i, j]) min = DATA[i, j];
						if (max < DATA[i, j]) max = DATA[i, j];
					}
				}
			}

			setResult(min, max, min * max);
		}
	}
}
