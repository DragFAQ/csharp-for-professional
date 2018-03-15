using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_3.Model
{
    public abstract class Citizen
    {
        protected Citizen(string name, string passNo)
        {
            this.Name = name;
            this.PassNo = passNo;
        }

        public string Name { get; set; }

        public string PassNo { get; set; }

        public override string ToString()
        {
            return this.GetType().ToString() + ": " + this.Name + " with pass no: " + this.PassNo;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Citizen personObj))
            {
                return false;
            }
            else
            {
                return this.PassNo.Equals(personObj.PassNo);
            }
        }

        public override int GetHashCode()
        {
            return this.PassNo.GetHashCode();
        }
    }
}
