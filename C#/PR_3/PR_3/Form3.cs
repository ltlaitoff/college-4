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
	public partial class Form3 : Form
	{
		private const double PRICE_BEFORE_EQUAL_100 = 0.24;
		private const double PRICE_AFTER_100 = 0.22;
		private const string RESULT_STRING = "Result(coef = {0}) = {1}";
		public Form3()
		{
			InitializeComponent();
		}

		private void setResult(double coef, double result)
		{
			label1.Text = String.Format(RESULT_STRING, coef, result);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double value = decimal.ToDouble(numericUpDown1.Value);

			if (value > 100)
			{
				setResult(PRICE_AFTER_100, PRICE_AFTER_100 * value);
				return;
			}

			setResult(PRICE_BEFORE_EQUAL_100, PRICE_BEFORE_EQUAL_100 * value);
		}
	}
}
