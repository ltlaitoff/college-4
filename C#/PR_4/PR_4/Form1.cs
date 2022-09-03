using System.Windows.Forms;

namespace PR_4
{
	public partial class Form1 : Form
	{
		private Form2 _form2 = new Form2();
		private const string VALUES_STRING = "Values: {0}";
		private const string LENGTH_STRING = "Length: {0}";
		private const string MIN_STRING = "Min module: {0}";
		public Form1()
		{
			InitializeComponent();
		}

		private void setValues(string values)
		{
			label1.Text = String.Format(VALUES_STRING, values);
		}

		private void setLength(int length)
		{
			label2.Text = String.Format(LENGTH_STRING, length);
		}

		private void setMinModule(int value)
		{
			label3.Text = String.Format(MIN_STRING, value);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int count = dataGridView1.RowCount - 1;
			int minModule = 999999999;

			List<string> values = new List<string>();

			for (int i = 0; i < count; i++)
			{
				string value = dataGridView1[0, i].Value.ToString();

				if (Int32.TryParse(value, out int j))
				{
					if (minModule > Math.Abs(j))
					{
						minModule = j;
					}
				}

				values.Add(value);
			}


			setLength(count);
			setValues(String.Join(',', values));
			setMinModule(minModule);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_form2.Show();
		}
	}
}