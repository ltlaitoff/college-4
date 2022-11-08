using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_8
{
	internal class Student
	{
		public string surname;
		public string group;
		public int programmingScore;
		public int physicsScore;

		public static string global;
		public static int countOfInstances;


		public Student()
		{
			surname = "surname";
			group = "group";
			programmingScore = 3;
			physicsScore = 3;
			countOfInstances++;
		}

		public Student(string _surname, string _group, int _programmingScore, int _physicsScore)
		{
			surname = _surname;
			group = _group;
			programmingScore = _programmingScore;
			physicsScore = _physicsScore;
			countOfInstances++;
		}

		public Student(Student student)
		{
			surname = student.surname;
			group = student.group;
			programmingScore = student.programmingScore;
			physicsScore = student.physicsScore;
			countOfInstances++;
		}

		~Student()
		{
			countOfInstances--;
		}

		public double getAverageScore()
		{
			return (programmingScore + physicsScore) / (double)2;
		}
	}
}
