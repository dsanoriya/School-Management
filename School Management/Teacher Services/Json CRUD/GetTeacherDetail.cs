using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace School_Management
{
    internal class GetTeacherDetail
    {
        public static void GetDetailsTeacher()
        {

            var json = File.ReadAllText(Program.jsonFile);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    JArray TeacherArrary = (JArray)jObject["teachers"];
                    if (TeacherArrary != null)
                    {
                        foreach (var item in TeacherArrary)
                        {
                            Console.WriteLine("Name:" + item["firstname"].ToString() + " " + item["lastname"].ToString());
                            Console.WriteLine("ID :" + item["ID"].ToString());
                            Console.WriteLine("Subject :" + item["Subject"] + "\n");
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
