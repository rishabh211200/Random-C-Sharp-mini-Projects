using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    public class Dog : IComparable<Dog>
    {
        public string Name { get; set; }
        //
        public int Weight { get; set; }
        
        public Dog(string name, int weight)
        {
            Name = name;
            Weight = weight;
            //Version = version;
        }
        public Dog() { }

        public int CompareTo(Dog other)
        {
            int value = Name.CompareTo(other.Name);
            if(value == 0)
            {
                value = Weight.CompareTo(other.Weight);
            }
            return value;
        }

    }
}
