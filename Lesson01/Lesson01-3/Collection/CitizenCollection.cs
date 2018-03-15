using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_3.Collection
{
    using System.Collections;

    using Lesson01_3.Model;

    public class CitizenCollection : ICollection
    {
        private readonly object syncRoot = new object();

        private readonly List<Citizen> elements = new List<Citizen>();

        public int Count => this.elements.Count;

        public object SyncRoot => this.syncRoot;

        public bool IsSynchronized => true;

        public IEnumerator GetEnumerator() => this.elements.GetEnumerator();

        public void CopyTo(Array array, int index)
        {
            var arr = array as object[];

            if (arr == null)
                throw new ArgumentException("Expecting array to be object[]");

            foreach (var item in this.elements)
            {
                arr[index++] = item;
            }
        }

        public int Add(Citizen person)
        {
            if (this.elements.Contains(person))
            {
                Console.WriteLine("Person with pass no '" + person.PassNo + "' already exists");

                return -1;
            }
            else
            {
                if (person.GetType() == typeof(Pensioner))
                {
                    for (var i = 0; i < this.elements.Count; i++)
                    {
                        if (this.elements[i].GetType() == typeof(Pensioner))
                        {
                            continue;
                        }

                        this.elements.Insert(i, person);
                        return i;
                    }
                }

                this.elements.Add(person);
                return this.elements.Count - 1;
            }
        }

        public void Remove(Citizen person = null)
        {
            if (person == null && this.elements.Count > 0)
            {
                this.elements.RemoveAt(0);
            }
            else
            {
                this.elements.Remove(person);
            }
        }

        public bool Contains(Citizen person) => this.elements.Contains(person);

        public int Contains(Citizen person) => this.elements.IndexOf(person);

        public Citizen ReturnLast();

        public void Clear()
        {
            this.elements.Clear();

        }
    }
}
