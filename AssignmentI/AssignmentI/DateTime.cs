using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentI
{
    internal class DateTime
    {
        public int Hours {  get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        
        public DateTime(int hours = 0, int minutes = 0, int seconds = 0)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public static DateTime operator -(DateTime left, DateTime right)
        {
            DateTime newDateTime = new DateTime();
            int totalLSeconds = left.Hours * 3600 + left.Minutes * 60 + left.Seconds;
            int totalRSeconds = right.Hours * 3600 + right.Minutes * 60 + right.Seconds;
            int resultSeconds = totalLSeconds - totalRSeconds;
            if (resultSeconds < 0) { 
                return new DateTime(); 
            }
            newDateTime.Hours = resultSeconds / 3600;
            resultSeconds -= newDateTime.Hours * 60 * 60;
            newDateTime.Minutes = resultSeconds / 60;
            resultSeconds -= newDateTime.Minutes * 60;
            newDateTime.Seconds = resultSeconds;
            return newDateTime;
        }
        public static DateTime operator +(DateTime left, DateTime right)
        {
            DateTime newDateTime = new DateTime();
            newDateTime.Seconds = (left.Seconds + right.Seconds) % 60;
            newDateTime.Minutes = (left.Minutes + right.Minutes) % 60 + (left.Seconds + right.Seconds) / 60;
            newDateTime.Hours = (left.Hours + right.Hours) + (left.Minutes + right.Minutes) / 60;
            return newDateTime;
        }
        public static DateTime operator +(DateTime DateTime, int secs)
        {
            DateTime newDateTime = new DateTime();
            newDateTime.Hours = secs / 3600;
            secs -= newDateTime.Hours * 60 * 60;
            newDateTime.Minutes = secs / 60;
            secs -= newDateTime.Minutes * 60;
            newDateTime.Seconds = secs;

            return newDateTime + DateTime;
        }
        public static DateTime operator +(int secs, DateTime DateTime)
        {
            DateTime newDateTime = new DateTime();
            newDateTime.Hours = secs / 3600;
            secs -= newDateTime.Hours * 60 * 60;
            newDateTime.Minutes = secs / 60;
            secs -= newDateTime.Minutes * 60;
            newDateTime.Seconds = secs;

            return newDateTime + DateTime;
        }
        public static DateTime operator ++(DateTime DateTime)
        {
            DateTime.Minutes++;
            DateTime.Hours += DateTime.Minutes / 60;
            DateTime.Minutes %= 60;
            return DateTime;
        }
        public static DateTime operator --(DateTime DateTime)
        {
            DateTime.Minutes--;
            if (DateTime.Minutes < 0)
            {
                if (DateTime.Hours > 0)
                {
                    DateTime.Minutes = 59;
                    DateTime.Hours--;
                }
                else DateTime.Minutes = 0;
            }
            return DateTime;
        }
        public static bool operator >(DateTime left, DateTime right)
        {
            if (left.Hours > right.Hours)
            {
                return true;
            }
            else if (left.Hours == right.Hours)
            {
                if (left.Minutes > right.Minutes)
                {
                    return true;
                }
                else if (left.Minutes == right.Minutes)
                {
                    return left.Seconds > right.Seconds;
                }
            }
            return false;
        }
        public static bool operator <(DateTime left, DateTime right)
        {
            if (left.Hours < right.Hours)
            {
                return true;
            }
            else if (left.Hours == right.Hours)
            {
                if (left.Minutes < right.Minutes)
                {
                    return true;
                }
                else if (left.Minutes == right.Minutes)
                {
                    return left.Seconds < right.Seconds;
                }
            }
            return false;
        }
        public static bool operator <=(DateTime left, DateTime right)
        {
            if (left.Hours < right.Hours)
            {
                return true;
            }
            else if (left.Hours == right.Hours)
            {
                if (left.Minutes < right.Minutes)
                {
                    return true;
                }
                else if (left.Minutes == right.Minutes)
                {
                    return left.Seconds <= right.Seconds;
                }
            }
            return false;
        }
        public static bool operator >=(DateTime left, DateTime right)
        {
            if (left.Hours > right.Hours)
            {
                return true;
            }
            else if (left.Hours == right.Hours)
            {
                if (left.Minutes > right.Minutes)
                {
                    return true;
                }
                else if (left.Minutes == right.Minutes)
                {
                    return left.Seconds >= right.Seconds;
                }
            }
            return false;
        }
        public static bool operator ==(DateTime left, DateTime right)
        {
            if (left.Hours == right.Hours && left.Minutes == right.Minutes && left.Seconds == right.Seconds)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(DateTime left, DateTime right)
        {
            if (left.Hours == right.Hours && left.Minutes == right.Minutes && left.Seconds == right.Seconds)
            {
                return false;
            }
            return true;
        }
        public static bool operator true(DateTime DateTime)
        {
            return DateTime.Hours > 0 || DateTime.Minutes > 0 || DateTime.Seconds > 0;
        }
        public static bool operator false(DateTime DateTime)
        {
            return DateTime.Hours == 0 && DateTime.Minutes == 0 && DateTime.Seconds == 0;
        }
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }
    }
}
