using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asking basic details



            
            Console.WriteLine("Write your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Write you roll no. :");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Write you standard:");
            int standard = int.Parse(Console.ReadLine());


            // Asking marks 



            Console.WriteLine("Enter your English marks");
            int e = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter your Maths marks");
            int m = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter your Physics marks");
            int p = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter your Chemistry marks");
            int c = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter your Biology marks ");
            int b = int.Parse(Console.ReadLine());
            

            // solution phase
            
            Console.WriteLine("\n\n\n------------------Marksheet----------------\n\n\n");
            int obt = e + m + p + c + b;
            Console.WriteLine("Your obtained marks are : {0}",obt);
            int per = (obt * 100) / 500;
            Console.WriteLine("Your percentage is : {0}", per);


            // Grade calculator


            if (per >= 90)
            {
                Console.WriteLine("Your grade is : A1");
            }
            else if (per >= 80)
            {
                Console.WriteLine("Your grade is : A2");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Your grade is : B1");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Your grade is : B2");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Your grade is : C");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Your grade is : D");
            }
            else if (per >= 33)
            {
                Console.WriteLine("Your grade is : E");
            }
            else
            {
                Console.WriteLine("Your grade is : F (You are failed)");
            }

            // back subjectwise
            int back = 0;
            if(e < 33)
            {
                back++;
            }
            if(m < 33)
            {
                back++;
            }
            if(p < 33)
            {
                back++;
            }
            if(c < 33)
            {
                back++;
            }
            if(b < 33)
            {
                back++;
            }

            Console.WriteLine("You have backs in {0} subjects",back);
    
            Console.ReadLine();
        }
    }
}
