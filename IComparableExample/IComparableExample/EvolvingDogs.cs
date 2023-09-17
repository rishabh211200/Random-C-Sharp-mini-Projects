using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    public class EvolvingDog :Dog, IVersion,IComparable<EvolvingDog> 
    {
        public int Version { get; set; }
        int IVersion.Version { get=>Version; set=>Version=value ; }
        public EvolvingDog() { }
        public EvolvingDog(string name,int version,int weight)
        {
            Name = name;
            Version = version;
            Weight = weight;
        }

        public int CompareTo(EvolvingDog other)
        {
            int value = Version.CompareTo(other.Version);

           
            if (value == 0)
            {
                value = Weight.CompareTo(other.Weight);
            }
            else if (value == 0)
            {
                value = Name.CompareTo(other.Name);
            }
            
            return value;
        }
    }
}
