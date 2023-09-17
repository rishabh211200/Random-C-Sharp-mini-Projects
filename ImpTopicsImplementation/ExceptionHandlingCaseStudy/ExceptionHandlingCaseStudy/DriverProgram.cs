using System;


namespace ExceptionHandlingCaseStudy
{
    class DriverProgram
    {
        static void Main(string[] args)
        {
            ExceptionHandlers eh = new ExceptionHandlers();
            eh.DisplayErrors_type1();
            eh.DisplayErrors_type2();
            eh.DisplayErrors_type3();
            eh.DisplayErrors_type4();
            eh.DisplayErrors_type5();
        }
    }
}
