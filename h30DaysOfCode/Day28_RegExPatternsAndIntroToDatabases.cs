using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day28_RegExPatternsAndIntroToDatabases
    {
        public class Person
        {
            public string FirstName;
            public string Email;
        }
        public static void Main1(string[] args)
        {
            List<Person> contacts = new List<Person>();
            
            int N = Convert.ToInt32(Console.ReadLine());

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                contacts.Add(new Person
                {
                    FirstName = firstNameEmailID[0],
                    Email = firstNameEmailID[1]
                });
            }

            contacts.Sort(delegate (Person x, Person y)
            {
                return x.FirstName.CompareTo(y.FirstName);
            });

            foreach (var item in contacts)
            {
                if(item.Email.EndsWith("@gmail.com"))
                    Console.WriteLine($"{item.FirstName}");
            }
        }
    }
}
