using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.Teacher_Services
{
    internal class ListDisplayAllTeacherData
    {
        static void DisplayAllTeacherData(List<Teachertype> teacherlist)
        {
            if (teacherlist.Count > 0)
            {
                foreach (Teachertype particularteacher in teacherlist)
                {
                    Console.WriteLine($"Name:{particularteacher.firstname} {particularteacher.lastname}");
                    Console.WriteLine($"ID:{particularteacher.ID}");
                    Console.WriteLine($"Subject:{particularteacher.subject}\n");
                }
            }
            else
            {
                Console.WriteLine("No Teacher Data Entered");
            }
        }
    }
}
