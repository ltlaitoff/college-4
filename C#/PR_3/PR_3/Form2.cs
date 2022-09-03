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
	public partial class Form2 : Form
	{
		private const double b = 0.00845;
		private const double x = 0.85431;
		private const double a = 2.31;

		private const string RESULT_Y = "Result Y = {0}";
		private const string RESULT_D = "Result d = {0}";

		public Form2()
		{
			InitializeComponent();
		}

		private void setResultY(double value)
		{
			label1.Text = String.Format(RESULT_Y, value);
		}

		private void setResultD(double value)
		{
			label7.Text = String.Format(RESULT_D, value);
		}

		private double calculateY(double t)
		{
			return b * Math.Pow(t, 2) * x - a / Math.Pow(Math.Sin(x / a), 2);
		}

		private double calculateD(double c)
		{
			return a * Math.Pow(c, -Math.Sqrt(a)) * Math.Cos(b * x);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double t = decimal.ToDouble(numericUpDown1.Value);
			double c = decimal.ToDouble(numericUpDown2.Value);

			setResultY(calculateY(t));
			setResultD(calculateD(c));
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
