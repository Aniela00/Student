using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class ConsoleMenu
    {
        StudentManager studentManager = new StudentManager();
        JsonManager jsonManager = new JsonManager();
        FileOperations fileOperations = new FileOperations();

        public void Menu()
        {
            Console.WriteLine("Choose what you want to do:");
            Console.WriteLine("1. Add a new student (Name, Surname, Email)");
            Console.WriteLine("2. Update a student data (Name, Surname, Email) by using ID");
            Console.WriteLine("3. Delete a student by using ID");
            Console.WriteLine("4. List all students");
            Console.WriteLine("5. Save to file and exit");
            Console.WriteLine("6. Read data form a file");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    studentManager.Add();
                    break;
                case 2:
                    studentManager.Update();
                    break;
                case 3:
                    studentManager.Delete();
                    break;
                case 4:
                    studentManager.ListAll();
                    break;
                case 5:
                    fileOperations.IsFileExisting();
                    fileOperations.WriteToFile(jsonManager.JsonSerialize(studentManager.StudentList()));
                    System.Environment.Exit(1);
                    break;
                case 6:
                    studentManager.studentsList = jsonManager.JsonDeserialize(fileOperations.ReadFromFile());
                    break;
            }
            Console.Clear();

        }
    }
}

