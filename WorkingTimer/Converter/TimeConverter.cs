using System;

namespace WorkingTimer.Converter
{
    public static class TimeConverter
    {
        public static int ConvertTimeStringToSeconds(string timeString)
        {
            string[] timeParts = timeString.Split(':');
            int minutes = int.Parse(timeParts[0]);
            int seconds = int.Parse(timeParts[1]);

            return (minutes * 60) + seconds;
        }

        public static string ConvertSecondsToTimeString(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            return $"{minutes:D2}:{seconds:D2}";
        }


    }
}