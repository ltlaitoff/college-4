using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_2
{
	public partial class Form2 : Form
	{
		private const string RESULT_STRING = "Result: {0}";

		public Form2()
		{
			InitializeComponent();
		}

		private void setResultValue(decimal value)
		{
			label1.Text = String.Format(RESULT_STRING, value);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			decimal a = numericUpDown1.Value;
			decimal b = numericUpDown2.Value;
			decimal c = numericUpDown3.Value;

			setResultValue(a + 2 * b / c);
		}
	}
}
