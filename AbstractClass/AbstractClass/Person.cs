using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        //Two properties firstName and lastName
        public string firstName {  get; set; }
        public string lastName { get; set; }
        //Method SayName()
        public abstract void SayName();
    }
}
