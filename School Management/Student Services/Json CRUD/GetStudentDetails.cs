using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace School_Management
{
    internal class StudentService
    {
        public static void GetDetailsStudent()
        {
            //accessing data from existing json file
            var json = File.ReadAllText(Program.jsonFile);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    JArray StudentArrary = (JArray)jObject["students"];
                    if (StudentArrary != null)
                    {
                        foreach (var item in StudentArrary)
                        {
                            Console.WriteLine("Name:" + item["firstname"].ToString() + " " + item["lastname"].ToString());
                            Console.WriteLine("ID :" + item["ID"].ToString());
                            Console.WriteLine("Grade :" + item["Grade"].ToString() + "\n");
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
