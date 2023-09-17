using System;

namespace ExceptionHandlingCaseStudy
{
    class ExceptionHandlers
    {
        int val1 = 0;
        public void DisplayErrors_type1()
        {
            Console.WriteLine(" This is an example of how to handle " +
                "input from users by catching exceptions");
            Console.WriteLine("Enter any string value instead of a number and see the results. ");
            Console.WriteLine("**************************************************************");
            try
            {
                Console.WriteLine("Please enter a number: ");
                val1 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("**************************************************************");
        }
        public void DisplayErrors_type2()
        {
            Console.WriteLine("This section will show how to catch exceptions and \n display them in proper way");
            try
            {
                Console.WriteLine("Please enter a number: ");
                val1 = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException fe)
            {
                Console.WriteLine("The error is : "+ fe.Message);
            }

            Console.WriteLine("**************************************************************");
        }

        public void DisplayErrors_type3()
        {
            Console.WriteLine("This section will show customised messages \n and show them in proper way.");
            try
            {
                Console.WriteLine("Please enter a number: ");
                val1 = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("The error is that you have not entered the numbers in the input line");
            }
            Console.WriteLine("**************************************************************");
        }

        public void DisplayErrors_type4()
        {
            Console.WriteLine("This section will show customized messages using catch and finally \n and display them" +
                "in proper way");
            try
            {
                Console.WriteLine("Please enter a number: ");
                val1 = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("The error is that you have not entered the numbers in the input line");
            }
            finally
            {
                if (val1.Equals(0))
                {
                    Console.WriteLine("As you have entered a string, the number cannot be displayed.");
                }
                else
                {
                    Console.WriteLine("You have entered: "+val1);
                }
            }
            Console.WriteLine("**************************************************************");
        }
        public void DisplayErrors_type5()
        {
            Console.WriteLine("This section will use multiple catches and finally to \n display customised " +
                "error messages and display them in a proper way");
            try
            {
                Console.WriteLine("Please enter a number: ");
                val1 = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("The error is, you have not entered any number as input " + fe.Message);
            }
            catch (Exception ee)
            {
                Console.WriteLine("The error is that you have not entered numbers in input line. "+ee.Message);
            }
            finally
            {
                if (val1.Equals(0))
                {
                    Console.WriteLine("As you have entered a string, the number cannot be displayed.");
                }
                else
                {
                    Console.WriteLine("You have entered: " + val1);
                }
            }
            Console.WriteLine("**************************************************************");
        }
    }
}
