namespace ConsoleApplication11
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            
            var emailbook = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "stop")
            {
                var name = input;
                var email = Console.ReadLine().Split('.').ToList();
                if (email[1] != "us" || email[1] != "uk")
                {
                    emailbook[name] += email;
                }
                input = Console.ReadLine();
            }
            foreach(var name in emailbook)
            {
                var Name = name.Key;
                var Number = name.Value;
                Console.WriteLine($"{Name} -> {Number} ");
            }

        }
    }
}