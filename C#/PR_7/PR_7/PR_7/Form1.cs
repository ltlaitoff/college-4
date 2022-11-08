namespace PR_7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double usd;
			double k;
			double grn;

			try
			{
				k = Convert.ToDouble(textBox1.Text);
				usd = Convert.ToDouble(textBox2.Text);

				grn = usd * k;
				label3.Text = "Сума = " + grn.ToString();
			}
			catch
			{
				label3.Text = "Невірні початкові дані";
				textBox1.Focus();
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			label3.Text = "";

			if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
			{
				button1.Enabled = false;
				return;
			}

			button1.Enabled = true;
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsControl(e.KeyChar))
			{
				if (e.KeyChar == (Char)Keys.Enter)
				{
					textBox2.Focus();
				}
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsControl(e.KeyChar))
			{
				if (e.KeyChar == (Char)Keys.Enter)
				{
					button1.Focus();
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double eur;
			double k;
			double grn;

			try
			{
				k = Convert.ToDouble(textBox3.Text);
				eur = Convert.ToDouble(textBox4.Text);

				grn = eur * k;
				label6.Text = "Сума = " + grn.ToString();
			}
			catch
			{
				label6.Text = "Невірні початкові дані";
				textBox3.Focus();
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}