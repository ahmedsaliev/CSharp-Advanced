using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] webSites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone(phoneNumbers, webSites);
            Console.WriteLine(smartphone);
        }
    }
}