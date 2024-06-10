using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.Student_Services.List
{
    internal class DisplayStudentData
    {
        static void displayallstudentdata(List<Studenttype> students)
        {
            //using list

            if (students.Count > 0)
            {
                foreach (Studenttype particularstudent in students)
                {
                    Console.WriteLine($" name:{particularstudent.firstname} {particularstudent.lastname}");
                    Console.WriteLine($"id:{particularstudent.ID}");
                    Console.WriteLine($"grade:{particularstudent.grade}\n");

                }
            }
            else
            {
                Console.WriteLine("no student data entered");
            }

            //using json



        }
    }
}
