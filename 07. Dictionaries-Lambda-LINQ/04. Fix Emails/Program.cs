using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main()
        {
            string inputString = null;
            var inputText = new List<string>();

            while (inputString != "stop")
            {
                inputString = Console.ReadLine();
                inputText.Add(inputString);
            }

            var namesAndEmails = new Dictionary<string, string>();

            for (int i = 0; i < inputText.Count - 1; i += 2)
            {
                string name = inputText[i];
                string email = inputText[i + 1];
                if (namesAndEmails.ContainsKey(name))
                {
                    namesAndEmails[name] = email;
                }
                else if (!email.Contains(".uk") && !email.Contains(".us"))
                {
                    namesAndEmails.Add(name, email);
                }
            }

            foreach (var pair in namesAndEmails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}