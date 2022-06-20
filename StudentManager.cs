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
    public class StudentManager
    {
        public List<Student> studentsList = new List<Student>();

        public List<Student> StudentList()
        {
            return studentsList;
        }

        public void Add()
        {
            Student newStudent = new Student();

            newStudent.Id = Guid.NewGuid();
            Console.Write("Name: ");
            newStudent.Name = Console.ReadLine();
            Console.Write("Surame: ");
            newStudent.Surmane = Console.ReadLine();
            Console.Write("E-mail: ");
            newStudent.Email = Console.ReadLine();

            this.studentsList.Add(newStudent);
        }

        public void Update()
        {
            var guidToUpdate = Console.ReadLine();
            foreach (var student in this.studentsList)
            {
                if (student.Id.ToString() == guidToUpdate)
                {   
                    Student newStudent = new Student();
                    newStudent = student;

                    Console.Write("Name: ");
                    newStudent.Name = Console.ReadLine();
                    Console.Write("Surame: ");
                    newStudent.Surmane = Console.ReadLine();
                    Console.Write("E-mail: ");
                    newStudent.Email = Console.ReadLine();
                }
            }
        }

        public void Delete()
        {
            var idToRemove = Console.ReadLine();
            this.studentsList.RemoveAll(s => s.Id.ToString() == idToRemove);
        }

        public void ListAll()
        {
            foreach (var student in this.studentsList)
            {
                Console.WriteLine(student.ToString());
            }
            Console.ReadLine();
        }
    }
}

