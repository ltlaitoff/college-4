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
	public partial class Form4 : Form
	{
		private const string RESULT_STRING = "Result: {0}";
		public Form4()
		{
			InitializeComponent();
		}

		private void setResult(double value)
		{
			label1.Text = String.Format(RESULT_STRING, value);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double result = 1;
			double x = decimal.ToDouble(numericUpDown1.Value);

			for (int i = 1; i < 24; i++)
			{
				result *= 1 - x / (i + 1);
			}

			setResult(result);
		}
	}
}
