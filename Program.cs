using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Students
{
    class Program
    {
        public static void Main(string[] args)
        {
            var ConsoleMenu = new ConsoleMenu();
            while (true) ConsoleMenu.Menu();
        }
    }
}
