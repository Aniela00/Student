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
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surmane { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "ID:" + Id + ", Name:" + Name + ", Surname:" + Surmane + ", Email:" + Email;
        }
    }
}
