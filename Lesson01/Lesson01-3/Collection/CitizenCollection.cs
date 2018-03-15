using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_3.Collection
{
    using System.Collections;

    using Lesson01_3.Model;

    public class CitizenCollection : IEnumerable
    {
        private readonly object syncRoot = new object();

        private Citizen[] elements;

        public CitizenCollection()
        {
            this.elements = new Citizen[0];
        }

        public int Count => this.elements.Length;

        public IEnumerator GetEnumerator() => this.elements.GetEnumerator();

        public int Add(Citizen person)
        {
            if (this.elements.Contains(person))
            {
                Console.WriteLine("Person with pass no '" + person.PassNo + "' already exists");

                return -1;
            }
            else
            {
                Citizen[] arr = new Citizen[this.Count + 1];
                if (person.GetType() == typeof(Pensioner))
                {
                    for (var i = 0; i < this.Count; i++)
                    {
                        if (this.elements[i].GetType() == typeof(Pensioner))
                        {
                            arr[i] = this.elements[i];
                            continue;
                        }

                        arr[i] = person;
                        var j = i + 1;
                        Array.ConstrainedCopy(this.elements, i, arr, i + 1, this.Count - i);

                        this.elements = arr;

                        return i;
                    }
                }

                Array.ConstrainedCopy(this.elements, 0, arr, 0, this.Count);
                arr[this.Count] = person;

                this.elements = arr;

                return this.Count - 1;
            }
        }

        public void Remove(Citizen person)
        {
            if (this.Contains(person, out var index))
            {
                Citizen[] arr = new Citizen[this.Count - 1];
                var j = 0;
                for (int i = 0; i < this.Count; i++)
                {
                    if (i == index)
                        continue;
                    arr[j] = this.elements[i];
                    j++;
                }

                this.elements = arr;
            }            
        }

        public void Remove()
        {
            Citizen[] arr = new Citizen[this.Count - 1];

            Array.ConstrainedCopy(this.elements, 1, arr, 0, this.Count - 1);

            this.elements = arr;
        }

        public bool Contains(Citizen person, out int index)
        {
            index = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(person))
                {
                    index = i;
                    return true;
                }
            }

            return false;
        }

        public Citizen ReturnLast(out int index)
        {
            if (this.Count > 0)
            {
                index = this.Count - 1;
                return this.elements[index];
            }
            else
            {
                index = -1;
                return null;
            }
        }

        public void Clear()
        {
            this.elements = new Citizen[0];
        }
    }
}
