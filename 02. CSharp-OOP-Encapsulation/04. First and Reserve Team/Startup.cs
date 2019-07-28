using System;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            int playersCount = int.Parse(Console.ReadLine());

            Team players = new Team("SoftUni");

            for (int i = 0; i < playersCount; i++)
            {
                var input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                decimal salary = decimal.Parse(input[3]);
                Person player = new Person(firstName, lastName, age, salary);

                players.AddPlayer(player);
            }

            players.GetPlayersCount();
        }
    }
}
