using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace IComparableExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new()
            {
                new Dog("Efg", 13),
                new Dog("Cde", 16),
                new Dog("Abc", 25),
                new Dog("Lmn", 15),
                new Dog("Cdf", 30),
                new Dog("Qrs", 40),
                new Dog("Xyz", 19),
                new Dog("Def", 12)
            };
            List<EvolvingDog> evolvingDogs = new()
            {
                new EvolvingDog("Efg", 1, 12),
                new EvolvingDog("Cde", 1, 16),
                new EvolvingDog("Abc", 1, 25),
                new EvolvingDog("Cdf", 1, 25),
                new EvolvingDog("Def", 1, 12)
            };


            Dictionary<string, EvolvingDog> evolvingDogsDict = new();
            Dictionary<string, Dog> dogsDict = new();
            foreach (var item in dogs)
            {
                dogsDict.Add(item.Name, item);
            }
            foreach (var item in evolvingDogs)
            {
                evolvingDogsDict.Add(item.Name, item);
            }
            List<Dog> newDogs = new();
            List<Dog> changedDogs = new();

            Console.WriteLine("evolvingDogs Before Update");
            evolvingDogs.ForEach(evolvingDogs => Console.WriteLine(evolvingDogs.Name + "  " + evolvingDogs.Version + "   " + evolvingDogs.Weight));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("dogs list");
            dogs.ForEach(dogs => Console.WriteLine(dogs.Name + "   " + dogs.Weight));
            for (int i = 0, j = 0; i < dogsDict.Count; i++, j++) //7
            {
                //for (int j = 0; j < evolvingDogsDict.Count; j++) //5


                if (evolvingDogsDict.ElementAt(j).Key == dogsDict.ElementAt(i).Key)
                {
                    int value = evolvingDogsDict.ElementAt(j).Value.CompareTo(dogsDict.ElementAt(i).Value);
                    if (value != 0)
                    {
                        changedDogs.Add(dogs[i]);
                        evolvingDogs[j].Version++;

                    }
                }
                else
                {
                    evolvingDogs.Add(new EvolvingDog(dogs[i].Name, 1, dogs[i].Weight));
                    newDogs.Add(dogs[i]);
                    j--;
                }

            }

            Console.WriteLine();
            Console.WriteLine("List of newDogs");
            newDogs.ForEach(newDogs => Console.WriteLine(newDogs.Name + "     " + newDogs.Weight));

            Console.WriteLine();
            Console.WriteLine("List of changedDogs");
            changedDogs.ForEach(changedDogs => Console.WriteLine(changedDogs.Name + "     " + changedDogs.Weight));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("evolvingDogsDict");
            foreach (var item in evolvingDogsDict)
            {
                Console.WriteLine("key = {0}, Name ={1},Version ={2},Weight ={3}", item.Key + "   ", "     " + item.Value.Name + "   ", "     " + item.Value.Version + "   ", "     " + item.Value.Weight + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("dogsDict");
            foreach (var item in dogsDict)
            {
                Console.WriteLine("key = {0}, Name ={1},Weight ={2}", item.Key + "   ", "     " + item.Value.Name + "   " ,"    "+ item.Value.Weight);
            }

            ////Console.WriteLine("dogs1 list after IComparable evolvingList");
            ////for (int i = 1; i < evolvingDogs.Count; i++)
            ////{
            ////    evolvingDogs[0].CompareTo(evolvingDogs[i]);

            ////    if (evolvingDogs[i].Version == 2)
            ////    {
            ////        Console.WriteLine(evolvingDogs[i].Name + "  " + evolvingDogs[i].Version + "    " + evolvingDogs[i].Weight);
            ////    }

            ////}



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("evolvingDogs after updating ");
            Console.WriteLine();
            evolvingDogs.ForEach(evolvingDogs => Console.WriteLine(evolvingDogs.Name + "     " + evolvingDogs.Version + "     " + evolvingDogs.Weight));
            ////Console.WriteLine();
            ////Console.WriteLine();
            ////Console.WriteLine("dogs1 before sorting");
            ////Console.WriteLine();
            ////evolvingDogs.ForEach(dogs1 => Console.WriteLine(dogs1.Name +  "     " + dogs1.Version + "    " + dogs1.Weight));
            ////Console.WriteLine();
            ////Console.WriteLine();
            ////evolvingDogs.Sort();
            ////evolvingDogs.Reverse();
            ////Console.WriteLine("dogs1 after sorting");
            ////Console.WriteLine();
            ////evolvingDogs.ForEach(dogs1 => Console.WriteLine(dogs1.Name + "     " + dogs1.Version + "    " + dogs1.Weight));
            ////Console.WriteLine();
            ////Console.WriteLine();
            ////Console.WriteLine("dogsChanges");
            ////Console.WriteLine();
            ////dogsChanges.ForEach(dogsChanges => Console.WriteLine(dogsChanges.Name +  "    " + dogsChanges.Weight));

            //for (int i = 0; i < dogs1.Count; i++)
            //{

            //    //dogs[i].CompareTo(dogs1[i]);
            //    int value = dogs[i].CompareTo(dogs1[i]);

            //    if (value != 0)
            //    {
            //        //dogsChanges.Add(dogs[i]);
            //        dogs1[i].Version++;
            //        //dogsChanges.Add(dogs1[i]);
            //    }

            //}
            //Console.WriteLine("Before Sorting");
            //dogs.ForEach(dog => Console.WriteLine(dog.Name +"   " +dog.Weight));
            //dogs1.ForEach(dog1 => Console.WriteLine(dog1.Name +"   " +dog1.Weight));


            ////dogs.Sort();
            //dogs1.Sort();

            //Console.WriteLine("After Sorting");
            //dogs1.ForEach(dog => Console.WriteLine(dog.Name +"   "+ dog.Weight));
        }
    }
}
