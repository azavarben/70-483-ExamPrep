using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing256
    {
        internal static void ImplementingIEnumerable()
        {
            Person[] peopleArray = { new Person("Joe", "Sixer"), new Person("Jim", "Bob") };

            People people = new People(peopleArray);

            foreach(var person in people)
            {                
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }

    public class People : IEnumerable<Person>
    {
        private Person[] people;

        public People(Person[] people)
        {
            this.people = people;
        }

        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < people.Length; i++)
            {
                yield return people[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
