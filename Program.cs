using System;
using Newtonsoft.Json;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "John Doe", Age = 30 };

            string json = JsonConvert.SerializeObject(person, Formatting.Indented);
            
            Console.WriteLine(json);
        }
    }
}