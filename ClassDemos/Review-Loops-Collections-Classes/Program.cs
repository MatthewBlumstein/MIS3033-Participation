//Matthew Blumstein
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Loops_Collections_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentIds = new int[3];
            string[] studentFirstNames = new string[3];
            string[] studentsLastNames = { "Harris", "Ackerman", "Johnson" };
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
            studentFirstNames[0] = "Katie";
            studentFirstNames[1] = "Adam";
            studentFirstNames[2] = "Harry";

            for(int i = 0; i < studentIds.Length; i++)
            {
                Console.WriteLine($"{studentsLastNames[i]}, {studentFirstNames[i]} [{studentIds[i]}].");
            }

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Katie Harris");
            students.Add(2, "Adam Ackerman");
            students.Add(3, "Harry Smith");

            //if(students.ContainsKey(1))
            //{
            //    students[1] = "SOME NEW VALUE";
            //}
            //else
            //{
            //    students.Add(1, "SOME VALUE");
            //}

            foreach(var key in students.Keys)
            {
                Console.WriteLine($"{students[key]} [{key}].");
            }

            Console.ReadKey();
        }
    }
}
