using System;


namespace GenericsImplementation
{
    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
        public static bool Check<I>(I a, I b)
        {
            bool c = a.Equals(b);
            return c;
        }
    }
}
