using System;

namespace RadioDatabase
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            int addedSongCount = 0;
            int songsLength = 0;

            for (int i = 0; i < numberOfSongs; i++)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] inputArgs = input.Split(new char[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                    Validation.IsValidSongName(input.Split(";"));
                    Validation.IsValidSongLength(input.Split(":"));

                    string artistName = inputArgs[0];
                    string songName = inputArgs[1];
                    int minutes = int.Parse(inputArgs[2]);
                    int seconds = int.Parse(inputArgs[3]);

                    Song song = new Song(artistName, songName, minutes, seconds);
                    Console.WriteLine("Song added.");
                    addedSongCount++;
                    songsLength += minutes * 60 + seconds;
                }
                catch (Exception em)
                {
                    Console.WriteLine(em.Message);
                }
            }

            Console.WriteLine($"Songs added: {addedSongCount}");
            Console.WriteLine($"Playlist length: {LengthCalculator.SongLengthCalculator(songsLength)}");
        }
    }
}
