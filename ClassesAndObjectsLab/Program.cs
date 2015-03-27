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

            Student newStudent = new Student("Seth");

            Console.WriteLine(newStudent.ToString());

            Console.ReadLine();
        }
    }
}
