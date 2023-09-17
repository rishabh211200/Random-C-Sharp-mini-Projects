using System;

namespace InterfacesCaseStudy
{
    class ComputerList : IHpSystem
    {
        string computercolor = " ";
        string computernames = " ";
        public void ListComputer()
        {
            computernames = "1. HP Pavillion";
            computernames = computernames + "\n2. HP EliteBook";
            computernames = computernames + "\n3. HP ProBook";
            Console.WriteLine("The HP computers are : \n\n" + computernames);
        }
        public void ShowComputerColor(string color)
        {
            this.computercolor = color;
            Console.WriteLine("\n The color of the systems are : " + computercolor, "\n");
        }
        public void ShowComputerFeature(string features) { }
        public void ShowComputerPrice(double price) { }
    }
}
