using System;

namespace InterfacesCaseStudy
{
    interface IHpSystem
    {
        void ListComputer();
        void ShowComputerColor(string str);
        void ShowComputerFeature(string feature);
        void ShowComputerPrice(double price);
    }
    
    class ShowComputerFeatures
    {
        static void Main(string[] args)
        {
            ShowHpComputerDetails hpc = new ShowHpComputerDetails();
            hpc.ListComputer();
            hpc.ShowComputerColor("White");
            hpc.ShowComputerColor("Black");
            hpc.ShowComputerColor("Silver");
            hpc.ShowComputerFeature("i5 11th Gen");
            hpc.ShowComputerFeature("i7 11th Gen");
            hpc.ShowComputerFeature("i9 11th Gen");
            hpc.ShowComputerPrice(1000);
            hpc.ShowComputerPrice(1500);
            hpc.ShowComputerPrice(2000);
            
        }
    }
}
