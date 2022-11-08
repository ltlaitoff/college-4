using System.Diagnostics;
using System.Globalization;

namespace PR_7_2
{
	public partial class Form1 : Form
	{
		double baseprice = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			baseprice = 1239000;

			textBox1.Text = baseprice.ToString("C", CultureInfo.CreateSpecificCulture("ua-UA"));

			Bitmap image1 = new Bitmap("1.png");
			pictureBox1.Image = image1;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			baseprice = 2322500;

			textBox1.Text = baseprice.ToString("C", CultureInfo.CreateSpecificCulture("ua-UA"));

			Bitmap image = new Bitmap("2.png");
			pictureBox1.Image = image;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			baseprice = 1232456;

			textBox1.Text = baseprice.ToString("C", CultureInfo.CreateSpecificCulture("ua-UA"));

			Bitmap image = new Bitmap("3.png");
			pictureBox1.Image = image;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			double sum = 0;
			sum += baseprice;

			if (checkBox1.Checked)
			{
				sum += 15000;
			}

			if (checkBox2.Checked)
			{
				sum += 2320;
			}

			sum -= (sum * Convert.ToDouble(comboBox1.SelectedItem)) / 100;
			textBox2.Text = sum.ToString("C", CultureInfo.CreateSpecificCulture("ua-UA"));
		}

		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (radioButton1.Checked)
			{
				Process.Start("https://avto-russia.ru/autos/lexus/");
			}
			if (radioButton2.Checked)
			{
				Process.Start("https://avto-russia.ru/autos/chery/");
			}
			if (radioButton3.Checked)
			{
				Process.Start("https://avto-russia.ru/autos/audi/");
			}
			if (radioButton4.Checked)
			{
				Process.Start("https://avto-russia.ru/autos/bmw/");
			}
			if (radioButton5.Checked)
			{
				Process.Start("https://avto-russia.ru/autos/toyota/");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
			{
				listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
			}
		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			toolTip1.Show("Извините, но вводить можно только цифры", maskedTextBox1, maskedTextBox1.Location, 5000);
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			baseprice = 556677;

			textBox1.Text = baseprice.ToString("C", CultureInfo.CreateSpecificCulture("ua-UA"));

			Bitmap image = new Bitmap("4.png");
			pictureBox1.Image = image;
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			baseprice = 887755;

			textBox1.Text = baseprice.ToString("C", CultureInfo.CreateSpecificCulture("ua-UA"));

			Bitmap image = new Bitmap("5.png");
			pictureBox1.Image = image;
		}
	}
}