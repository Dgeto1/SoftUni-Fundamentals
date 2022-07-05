using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command;
            while((command=Console.ReadLine())!="End")
            {
                string[] segments = command.Split();
                Person person = new Person(segments[0], segments[1], int.Parse(segments[2]));
                if (people.Count == 0)
                {
                    people.Add(person);
                }
                else
                {
                    foreach(Person x in people)
                    {
                        if (segments[1] == x.Id)
                        {
                            x.Name = segments[0];
                            x.Age = int.Parse(segments[2]);
                        }
                        else
                        {
                            people.Add(person);
                        }
                    }
                }
            }
            var sortedPeople = people.OrderBy(x => x.Age);
            foreach(Person x in sortedPeople)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}

