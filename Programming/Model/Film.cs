using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        private string _title;
        private int _durationInMinutes;
        private int _yearOfRelease;
        private string _genre;
        private double _rating;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set { _durationInMinutes = value * 60; }
        }
        public int YearOfRelease
        {
            get { return _yearOfRelease; }
            set
            {
                if (_yearOfRelease>1900 && _yearOfRelease < 2023)
                {
                    _yearOfRelease = value;
                }
                else
                {
                    throw new ArgumentException("Введён не верный год");
                }
            }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value>0 && value< 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentException("Не верно введён рейтинг");
                }
            }
        }
        public Film(  string title, int durationInMinutes,int yearOfRelease, string genre, double rating)
        {
            Title= title;
            DurationInMinutes= durationInMinutes;
            YearOfRelease= yearOfRelease;
            Genre= genre;
            Rating= rating;
        }
        public Film() { }
    }
}
