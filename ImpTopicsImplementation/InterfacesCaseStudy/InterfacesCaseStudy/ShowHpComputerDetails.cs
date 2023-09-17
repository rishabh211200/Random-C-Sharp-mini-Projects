using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesCaseStudy
{
    class ShowHpComputerDetails : ComputerList
    {
        string ComputerFeature = " ";
        double ComputerPrice = 0;
        public void ShowComputerFeature(string feature)
        {
            this.ComputerFeature = feature;
            Console.WriteLine(" \n The features of the system are : " + ComputerFeature);
        }
        public void ShowComputerPrice(double price)
        {
            this.ComputerPrice = price;
            Console.WriteLine("\n The prices of the systems are : " + ComputerPrice);
        }
    }
}
