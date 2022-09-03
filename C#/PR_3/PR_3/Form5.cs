using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_3
{
	public partial class Form5 : Form
	{
		private class KeyValue<KeyT, ValueT>
		{
			public KeyT Key { get; set; }
			public ValueT Value { get; set; }

			public KeyValue() { }

			public KeyValue(KeyT key, ValueT value)
			{
				this.Key = key;
				this.Value = value;
			}
		}

		KeyValue<string, int>[] countries = new KeyValue<string, int>[] {
			new KeyValue<string, int>("Kiev", 1),
			new KeyValue<string, int>("Charkov", 2),
			new KeyValue<string, int>("Zaporizhzhia", 3),
			new KeyValue<string, int>("Dnipro", 4),
			new KeyValue<string, int>("Odesa", 5),
			new KeyValue<string, int>("Donetsk", 6),
			new KeyValue<string, int>("Vinnytsia", 7),
			new KeyValue<string, int>("Poltava", 8),
			new KeyValue<string, int>("Lutsk", 9)
		};

		public Form5()
		{
			InitializeComponent();
			setRows(countries);
		}

		private void setRows(KeyValue<string, int>[] value)
		{
			dataGridView1.Rows.Clear();

			foreach (KeyValue<string, int> v in value)
			{
				dataGridView1.Rows.Add(v.Key, v.Value);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double value = decimal.ToDouble(numericUpDown1.Value);

			for (int i = 0; i < countries.Length; i++)
			{
				if (countries[i].Value < value)
				{
					countries[i].Value *= 2;
				}

			}

			setRows(countries);
		}
	}
}
