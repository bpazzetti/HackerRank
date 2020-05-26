using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
	class Day12_Inheritance
	{
		class Person
		{
			protected string firstName;
			protected string lastName;
			protected int id;

			public Person() { }
			public Person(string firstName, string lastName, int identification)
			{
				this.firstName = firstName;
				this.lastName = lastName;
				this.id = identification;
			}
			public void printPerson()
			{
				Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
			}
		}

		class Student : Person
		{
			private int[] testScores;

			/*	
			*   Class Constructor
			*   
			*   Parameters: 
			*   firstName - A string denoting the Person's first name.
			*   lastName - A string denoting the Person's last name.
			*   id - An integer denoting the Person's ID number.
			*   scores - An array of integers denoting the Person's test scores.
			*/
			public Student(string firstName, string lastName, int id, int[] scores)
			{
				this.firstName = firstName;
				this.lastName = lastName;
				this.id = id;
				this.testScores = scores;
			}

			/*	
			*   Method Name: Calculate
			*   Return: A character denoting the grade.
			*/
			public char Calculate()
			{
				double score = testScores.Average();
				if (90 <= score && score <= 100)
					return 'O';
				if (80 <= score && score < 90)
					return 'E';
				if (70 <= score && score < 80)
					return 'A';
				if (55 <= score && score < 70)
					return 'P';
				if (40 <= score && score < 55)
					return 'D';
				else
					return 'T';
			}
		}

		public static void Main1()
		{
			string[] inputs = Console.ReadLine().Split();
			string firstName = inputs[0];
			string lastName = inputs[1];
			int id = Convert.ToInt32(inputs[2]);
			int numScores = Convert.ToInt32(Console.ReadLine());
			inputs = Console.ReadLine().Split();
			int[] scores = new int[numScores];
			for (int i = 0; i < numScores; i++)
			{
				scores[i] = Convert.ToInt32(inputs[i]);
			}

			Student s = new Student(firstName, lastName, id, scores);
			s.printPerson();
			Console.WriteLine("Grade: " + s.Calculate() + "\n");
		}
	}
}
