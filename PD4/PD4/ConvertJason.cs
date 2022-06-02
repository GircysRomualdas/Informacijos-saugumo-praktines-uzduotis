using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD4
{
    class ConvertJason
    {
        public static List<Slapt> Json_to_cs()
        {
            string fileName = "test.json";
            if (System.IO.File.Exists(fileName))
            {
                string text = File.ReadAllText(fileName);
                List<Slapt> slapt = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Slapt>>(text);
                return slapt;
            }
            return (null);
        }

        public static void Cs_to_json(List<Slapt> slapts)
        {
            var jsonFormttedContent = Newtonsoft.Json.JsonConvert.SerializeObject(slapts);
            string fileName = "test.json";
            if (System.IO.File.Exists(fileName) == false)
            {
                System.IO.File.WriteAllText(fileName, jsonFormttedContent);
            }
            else
            {
                System.IO.File.Delete(fileName);
                System.IO.File.WriteAllText(fileName, jsonFormttedContent);
            }
        }
    }
}
