using System;

namespace GenericsImplementation
{
    
    class GenericsImplementation
    {
        static void Main(string[] args)
        {
            GenericClass<string> gen = new GenericClass<string>("This is generic class");
            GenericClass<int> genI = new GenericClass<int>(101);
            GenericClass<char> getCh = new GenericClass<char>('I');
            Console.WriteLine(GenericClass<bool>.Check("Rishabh","Rishabh"));
            Console.WriteLine(GenericClass<bool>.Check(100, 100));
            Console.WriteLine(GenericClass<bool>.Check('A', 'A'));
            Console.WriteLine(GenericClass<bool>.Check("Rishabh","Rishab"));
            Console.WriteLine(GenericClass<bool>.Check(100, 99));
            Console.WriteLine(GenericClass<bool>.Check('A', 'B'));
        }
    }
}
