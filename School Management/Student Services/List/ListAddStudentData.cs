using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.Student_Services.List
{
    internal class ListAddStudentData
    {
        static void EnterStudentData(List<Studenttype> students, int i)
        {

            Studenttype student = new Studenttype();
            Console.WriteLine($"{i}:Student Details");


            Console.WriteLine("First Name:");
            student.firstname = Console.ReadLine();

            Console.WriteLine("Last Name:");
            student.lastname = Console.ReadLine();

            Console.WriteLine("ID:");
            student.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Grade:0->Preschool,1->Elementary,2->Middle,3->High");
            Enums.Grade grrade;
            Enum.TryParse(Console.ReadLine(), out grrade);
            student.grade = grrade;

            //showing the output
            //Console.WriteLine($"Name:{student.firstname} {student.lastname}");
            //Console.WriteLine($"ID:{student.ID}");
            //Console.WriteLine($"Grade:{student.grade}");

            students.Add(student);


            Console.WriteLine("Entry Successfull");



        }
    }
}
