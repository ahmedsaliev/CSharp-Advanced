using System;

namespace Problem_4._Telephony
{
    public class Program
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] webSites = Console.ReadLine().Split();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                try
                {
                    ICallingFunctionality smartphone = new Smartphone(phoneNumbers[i]);
                    Console.WriteLine(smartphone.Call());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < webSites.Length; i++)
            {
                try
                {
                    IBrowsingFunctionality smartphone = new Smartphone(webSites[i]);
                    Console.WriteLine(smartphone.Browse());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}