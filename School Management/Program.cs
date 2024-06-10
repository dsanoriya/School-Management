using System;
using System.IO;
using System.Collections.Generic;
using Spectre.Console;
using Newtonsoft.Json.Linq;
using System.ComponentModel.Design;
using System.Linq;
using School_Management.Teacher_Services;
using School_Management.Student_Services.Json;
using School_Management.Teacher_Services.Json;

namespace School_Management
{

    internal class Program
    {

        public static string jsonFile = @"C:\Users\s2wswr\source\repos\School Management\School Management\json\schools.json";
        static void Main(string[] args)
        {
            //AnsiConsole.Write(new Markup("[bold yellow]Hello[/] [red]World![/]"));
            List<Studenttype> liststudents = new List<Studenttype>();
            List<Teachertype> listteachers = new List<Teachertype>();


            int i = 1;
            int j = 1;
            //Develop a program that allows users to choose between entering student data or teacher data (switch case).

            //Console.WriteLine("3-> exit");

            bool flag = true;


            while (flag)
            {
                AnsiConsole.MarkupLine("Choose from the following [red]options[/]");
                //Console.WriteLine("choose between teacher/student");
                //AnsiConsole.MarkupLine("[yellow]1-> Student[/]");
                //Console.WriteLine("1-> student");
                //AnsiConsole.MarkupLine("[purple]2-> Teacher[/]");
                //Console.WriteLine("2-> teacher");
                //AnsiConsole.MarkupLine("[green]3-> Display all Students data[/]");
                //Console.WriteLine("3-> Display all Students data");
                //AnsiConsole.MarkupLine("[blue]4-> Display all Teachers Data[/]");
                //Console.WriteLine("4-> Display all Teachers Data");
                //AnsiConsole.MarkupLine("[red]5-> Exit[/]");
                //Console.WriteLine("5-> Exit");
                //string choose = Console.ReadLine();


                string choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .AddChoices(new[] { "Add Student Data", "Add Teacher Data", "Delete Student Data", "Delete Teacher Data", "Display all Students data", "Display all Teachers data", "Exit" })
                .Title("Choose Options")
                );

                switch (choice)
                {
                    case "Add Student Data":
                        UpdateNewJsonStudent.AddNewSchoolJsondata();
                        //EnterStudentData(liststudents, i);
                        i++;
                        break;
                    case "Add Teacher Data":
                        UpdateNewTeacherJson.AddNewTeacherJsondata();
                        //EnterTeacherData(listteachers, j);
                        j++;
                        break;

                    case "Delete Student Data":
                        DeleteData.DeleteStudentJsonData();
                        break;

                    case "Delete Teacher Data":
                        DeleteDataT.DeleteTeacherJsonData();
                        break;

                    case "Display all Students data":
                        StudentService.GetDetailsStudent();
                        //DisplayAllStudentData(liststudents);
                        break;
                    case "Display all Teachers data":
                        GetTeacherDetail.GetDetailsTeacher();
                        //DisplayAllTeacherData(listteachers);
                        break;
                    case "Exit":
                        Console.WriteLine("Exit Successfull !!!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

            }


        }
    }

}


