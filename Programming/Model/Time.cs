using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (_hour>0 && _hour < 24)
                {
                    _hour = value;
                }
                else
                {
                    throw new ArgumentException("Час должен находится от 0 до 24");
                }
            }
        }
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (_minute>0 && _minute < 60)
                {
                    _minute = value;
                }
                else
                {
                    throw new ArgumentException("Минуты должны находится от 0 до 60");
                }
            }
        }
        public int Second
        {
            get { return _second; }
            set
            {
                if (_second > 0 && _second < 60)
                {
                    _second = value;
                }
                else
                {
                    throw new ArgumentException("Секунды должны находится от 0 до 60");
                }
            }
        }
        public Time(int _hour,int _minute, int _second )
        {     
            Hour = _hour;
            Minute = _minute;
            Second = _second;
        }
        public Time() { }
    }
}
