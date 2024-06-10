using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.Teacher_Services
{
    internal class ListAddNewTeacherData
    {
        static void EnterTeacherData(List<Teachertype> teachers, int j)
        {
            Teachertype teacher = new Teachertype();

            Console.WriteLine($"{j} : Teacher Details");

            try
            {
                Console.WriteLine("First Name:");
                teacher.firstname = Console.ReadLine();



                Console.WriteLine("Last Name:");
                teacher.lastname = Console.ReadLine();

                Console.WriteLine("ID:");
                teacher.ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Subject:0->Biology\n,1->Physics\n,2->Maths\n,3->SocialScience\n,4->English\n,5->Chemistry");
                Enums.Subject subbject;
                Enum.TryParse(Console.ReadLine(), out subbject);
                teacher.subject = subbject;

                teachers.Add(teacher);
                //Console.WriteLine($"Name:{teacher.firstname} {teacher.lastname}");
                //Console.WriteLine($"ID:{teacher.ID}");
                //Console.WriteLine($"Grade:{teacher.subject}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Value");
            }
        }
    }
}
