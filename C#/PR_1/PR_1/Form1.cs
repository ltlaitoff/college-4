namespace PR_1
{
	public partial class Form1 : Form
	{
		private const string NOT_NUMBER = "-";
		private const int MIN_COUNTER_VALUE = 0;
		private const int MAX_COUNTER_VALUE = 10;
		private const int NUMBER_VOID = -1;
		private const string STRING_NUMBER = "{0} число";

		private int counter = MIN_COUNTER_VALUE;

		private int[] numbers = new int[MAX_COUNTER_VALUE] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

		public Form1()
		{
			InitializeComponent();
			setNextText(getNumberString(numbers[counter]));
		}

		private void setNextText(string value)
		{
			textBox1.Text = value;
		}

		private void setPrevText(string value)
		{
			listBox1.Items.Add(value);
		}

		private int getNextCounterValue(int currentCounterValue)
		{
			int nextCounterValue = ++currentCounterValue;

			if (nextCounterValue > MAX_COUNTER_VALUE - 1) return NUMBER_VOID;

			return nextCounterValue;
		}

		private string getNumberString(int value)
		{
			if (value == NUMBER_VOID) return NOT_NUMBER;

			return String.Format(STRING_NUMBER, value);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (counter < MIN_COUNTER_VALUE) return;

			setPrevText(getNumberString(numbers[counter]));

			counter = getNextCounterValue(counter);

			if (counter == NUMBER_VOID)
			{
				setNextText(getNumberString(NUMBER_VOID));
				return;
			}

			setNextText(getNumberString(numbers[counter]));
		}
	}
}