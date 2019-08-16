namespace RadioDatabase
{
    public static class LengthCalculator
    {
        public static string SongLengthCalculator(int songsLengthInSeconds)
        {
            int hours;
            int minutes;
            int seconds;

            hours = songsLengthInSeconds / 3600;
            songsLengthInSeconds %= 3600;
            minutes = songsLengthInSeconds / 60;
            seconds = songsLengthInSeconds % 60;
            return $"{hours}h {minutes}m {seconds}s";
        }
    }
}