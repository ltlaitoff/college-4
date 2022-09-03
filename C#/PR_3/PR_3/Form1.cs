namespace PR_3
{
	public partial class Form1 : Form
	{
		private Form2 form2 = new Form2();
		private Form3 form3 = new Form3();
		private Form4 form4 = new Form4();
		private Form5 form5 = new Form5();

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			form2.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			form3.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			form4.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			form5.Show();
		}
	}
}