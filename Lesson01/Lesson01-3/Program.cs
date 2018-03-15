using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_3
{
    using Lesson01_3.Collection;
    using Lesson01_3.Model;

    class Program
    {
        static void Main(string[] args)
        {
            CitizenCollection persons = new CitizenCollection();

            Pensioner pensioner = new Pensioner("p3", "p3");
            persons.Add(new Student("s1", "s1"));
            persons.Add(new Worker("w1", "w1"));
            persons.Add(new Pensioner("p1", "p1"));
            LogPersons(persons);
            persons.Add(new Student("s2", "s2"));
            persons.Add(new Worker("w2", "w2"));
            persons.Add(new Pensioner("p2", "p2"));
            LogPersons(persons);
            persons.Add(new Pensioner("p2", "p2"));
            persons.Add(pensioner);
            LogPersons(persons);
            persons.Remove();
            persons.Remove(pensioner);
            LogPersons(persons);
        }

        private static void LogPersons(CitizenCollection persons)
        {
            Console.WriteLine("---");
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
