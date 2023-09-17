/*
BG International school is an educational institute that provide primary education to Children from KG class to 10th class
.The administrative staff og school has to maintain the records, Which include name, class, roll no. of students studying in 
 different classes.Manually maintaining the record of each student is a tedious process for the administrative staff of school
 . A large number of errors occur when the administrative staff enters the records manually in registers.
 How can school automate the task of entering student records.
 
 Here:-
 Arraylist class can help, It allows us to create an array list.
 The size of array list is fixed at run time, Then created array list would be dynamic. 
*/



using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddStudentDetails
{
    class StudentDetails
    {
        static void Main(string[] args)
        {
            string studname1, studname2, studname3;
            string classname1, classname2, classname3;
            string rollno1, rollno2, rollno3;
            string getresult;
            ArrayList arrlist = new ArrayList();
            Console.WriteLine( "The initial capacity of arraylist = " +arrlist.Capacity );
            Console.WriteLine("The initial elements are =" +arrlist.Count);
            Console.WriteLine("Enter details of student 1: ");
            Console.WriteLine("_______________________________");
            Console.Write("Enter name of student 1 : ");
            studname1 = Console.ReadLine();
            Console.Write("Enter class of student 1 :");
            classname1 = Console.ReadLine();
            Console.Write("Enter roll no. of student 1 : ");
            rollno1 = Console.ReadLine();
            Console.WriteLine("_______________________________");
            Console.Write("Enter name of student 2 : ");
            studname2 = Console.ReadLine();
            Console.Write("Enter class of student 2 :");
            classname2 = Console.ReadLine();
            Console.Write("Enter roll no. of student 2 : ");
            rollno2 = Console.ReadLine();
            Console.WriteLine("_______________________________");
            Console.Write("Enter name of student 3 : ");
            studname3 = Console.ReadLine();
            Console.Write("Enter class of student 3 :");
            classname3 = Console.ReadLine();
            Console.Write("Enter roll no. of student 3 : ");
            rollno3 = Console.ReadLine();
            Console.WriteLine("_______________________________");
            arrlist.Add(studname1);
            arrlist.Add(classname1);
            arrlist.Add(rollno1);
            arrlist.Add(studname2);
            arrlist.Add(classname2);
            arrlist.Add(rollno2);
            arrlist.Add(studname3);
            arrlist.Add(classname3);
            arrlist.Add(rollno3);
            Console.WriteLine("current capacity = " +arrlist.Capacity);
            Console.WriteLine("Arraylist having elements = " +arrlist.Count);
            Console.Write("Arraylist is having content :-");
            for(int i = 0; i < arrlist.Count; i++)
            {
                Console.Write(arrlist[i] + "    ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("To remove 2nd student details press 'y' or to interchange " +
                "student details 1 with student details 3 press 'n'. ");
            getresult = Console.ReadLine();
            if(getresult == "y")
            {
                Console.WriteLine("Removing 2nd Student Details");
                Console.WriteLine("_______________________________");
                arrlist.Remove(studname2);
                arrlist.Remove(classname2);
                arrlist.Remove(rollno2);
                Console.WriteLine("current capacity of Arraylist is now : " +arrlist.Capacity);
                Console.WriteLine("Arraylist is having elements : " +arrlist.Count);
                Console.Write("The elements of Arraylist are now :-");
                for(int m=0; m<arrlist.Count; m++)
                {
                    Console.Write(arrlist[m]+" ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Changing Elements");
                Console.WriteLine("_______________________________");
                arrlist[0] = studname3;
                arrlist[1] = classname3;
                arrlist[2] = rollno3;
                arrlist[6] = studname1;
                arrlist[7] = classname1;
                arrlist[8] = rollno1;
                Console.Write("Now the elements of Arraylist are :- ");
                for(int m =0; m < arrlist.Count; m++)
                {
                    Console.Write(arrlist[m]+" ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
