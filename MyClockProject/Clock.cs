using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClockProject
{
    internal class Clock
    {
        public ClockHand Hour { get; set; }
        public ClockHand Minute { get; set; }
        public ClockHand Second { get; set; }

        public Clock()
        {
            CreateHands(0, 0, 0);
        }

        public Clock(int hour, int minute, int second)
        {
            CreateHands(hour, minute, second);

        }

        private void CreateHands(int hour, int minute, int second)
        {
            Hour = new ClockHand("Saat", hour);
            Minute = new ClockHand("Dakika", minute);
            Second = new ClockHand("Saniye", second);
        }

        public void ChangeHour(int hour)
        {
            Hour.Value = hour;
        }

        public void ChangeMinute (int minute)
        {
            Minute.Value = minute;
        }

        public void ChangeSecond(int second)
        {
            Second.Value = second;
        }

        public void IncreaseTimeByTimer()
        {
            Second.Value = Second.Value + 1;

            if (Second.Value == 60)
            {
                Minute.Value = Minute.Value + 1;
                Second.Value = 0;
            }

            if (Minute.Value == 60)
            {
                Hour.Value = Hour.Value + 1;
                Minute.Value = 0;
            }

            if(Hour.Value == 24)
            {
                Hour.Value = 0;
            }
        }


        public string GetTime()
        {
            string result = string.Format("{0}:{1}:{2}", Hour.Value, Minute.Value, Second.Value);
            return result;
        }
    }
}
