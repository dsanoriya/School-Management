using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace School_Management.Teacher_Services
{
    internal class UpdateNewTeacherJson
    {
        public static void AddNewTeacherJsondata()
        {
            //accepting new data 
            Console.WriteLine("Enter Teacher Details");
            Console.WriteLine("First Name:");
            var firstname1 = Console.ReadLine();

            Console.WriteLine("Last Name:");
            var lastname1 = Console.ReadLine();

            Console.WriteLine("ID:");
            var ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Subject:0->Biology\n,1->Physics\n,2->Maths\n,3->SocialScience\n,4->English\n,5->Chemistry");
            Enums.Subject subbject;
            Enum.TryParse(Console.ReadLine(), out subbject);
            var subject1 = subbject;
            //creating new json data

            var newteacherdetail = "{ 'firstname': '" + firstname1 + "', 'lastname':' " + lastname1 + "', 'ID': '" + ID + "' , 'subject': ' " + subject1 + "'}";
            Console.WriteLine(newteacherdetail);

            var json = File.ReadAllText(Program.jsonFile);
            //parse existing json file
            var jsonObject = JObject.Parse(json);
            //retrieves the value associated with teacher key 
            var TeacherArray = jsonObject.GetValue("teachers") as JArray;
            //parse new added data
            var newteacherdata = JObject.Parse(newteacherdetail);
            TeacherArray.Add(newteacherdata);

            jsonObject["teachers"] = TeacherArray;
            //serialize the parsed jobject back to json string 
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Program.jsonFile, newJsonResult);

        }

    }
}
