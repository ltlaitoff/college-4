﻿namespace PR_8
{
	public partial class Form1 : Form
	{
		Student[] students = new Student[5];

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.ColumnCount = 5;

			students[0] = new Student();

			students[1] = new Student("Second", "2G", 5, 5);
			students[2] = new Student("Third", "3G", 4, 3);
			students[3] = new Student("Four", "2G", 5, 4);

			students[4] = new Student(students[3]);

			showStudentsToGrid(students);
			updateCountOfInstances(Student.countOfInstances);
			updateGlobal(Student.global);
		}

		void updateCountOfInstances(int count)
		{
			label1.Text = "CountOfInstances: " + count.ToString();
		}

		void updateGlobal(string global)
		{
			label2.Text = "Global: " + global;
		}

		/* Logic */
		private void showStudentsToGrid(Student[] students)
		{
			dataGridView1.Rows.Clear();


			foreach (Student student in students)
			{
				dataGridView1.Rows.Add(student.surname, student.group, student.programmingScore, student.physicsScore, student.getAverageScore().ToString());
			}
		}

		private bool checkOnExcellent(Student student)
		{
			return student.getAverageScore() == 5;
		}

		private void showExcellentStudentsToListBox()
		{
			listBox1.Items.Clear();

			foreach (Student student in students)
			{
				if (checkOnExcellent(student))
				{
					listBox1.Items.Add(student.surname + " : " + student.group + " : " + student.getAverageScore());
				}
			}
		}

		/* Form logic */
		private void button1_Click(object sender, EventArgs e)
		{
			students[0] = new Student("First", "1G", 5, 5);

			showStudentsToGrid(students);
			updateCountOfInstances(Student.countOfInstances);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			showExcellentStudentsToListBox();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Student.global = "global";
			updateGlobal(Student.global);
		}
	}
}