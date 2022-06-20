using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Students
{
    public  class JsonManager

    {
        public string JsonSerialize(List<Student> listOfStudents)
        { 
            return JsonConvert.SerializeObject(listOfStudents);
        }

        public List<Student> JsonDeserialize(string jsonText)
        {
            return JsonConvert.DeserializeObject<List<Student>>(jsonText);
        }
    }
}
