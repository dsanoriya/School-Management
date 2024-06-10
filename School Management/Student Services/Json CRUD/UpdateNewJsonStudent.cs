using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;


namespace School_Management
{
    internal class UpdateNewJsonStudent
    {
        public static void AddNewSchoolJsondata()
        {   

            //accepting new data 
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("First Name:");
            var firstname1 = Console.ReadLine();

            Console.WriteLine("Last Name:");
            var lastname1 = Console.ReadLine();

            Console.WriteLine("ID:");
            var ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Grade:0->Preschool,1->Elementary,2->Middle,3->High");
            Enums.Grade grrade;
            Enum.TryParse(Console.ReadLine(), out grrade);
            var grade1 = grrade;
            //creating new json data

            string newstudentdetail = "{ 'firstname': '" + firstname1 + "', 'lastname': '" + lastname1 + "', 'ID': " + ID + ", 'Grade': '" + grade1 + "'}";
            Console.WriteLine(newstudentdetail);

            var json = File.ReadAllText(Program.jsonFile);
            //parse existing json file
            var jsonObject = JObject.Parse(json);
            //retrieves the value associated with student key 
            var StudentArray = jsonObject.GetValue("students") as JArray;
            //parse new added data
            var newstudentdata = JObject.Parse(newstudentdetail);
            StudentArray.Add(newstudentdata);

            jsonObject["students"] = StudentArray;
            //serialize the parsed jobject back to json string 
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Program.jsonFile, newJsonResult);

        }
    }
}
