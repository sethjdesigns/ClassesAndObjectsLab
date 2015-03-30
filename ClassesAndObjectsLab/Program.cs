using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsLab
{   
    class Program
    { 
        static void Main()
        {   
            List<Student> allStudents = new List<Student>();

            for (int i = 0; i < 10; i++)
            {

                Student student = new Student(string.Format("John Doe {0}", i));
                allStudents.Add(student);

                Console.WriteLine(student);
            }

        }
    }
}