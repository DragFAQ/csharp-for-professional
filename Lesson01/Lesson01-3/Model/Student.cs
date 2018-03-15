using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_3.Model
{
    public class Student : Citizen
    {
        public Student(string name, string passNo) : base(name, passNo)
        {
        }
    }
}
