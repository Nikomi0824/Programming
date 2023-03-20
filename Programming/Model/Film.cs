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
                if (_rating>0 && _rating < 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentException("Не верно введён рейтинг");
                }
            }
        }
        public Film(  string _title, int _durationInMinutes,int _yearOfRelease, string _genre, double _rating)
        {
            Title= _title;
            DurationInMinutes= _durationInMinutes;
            YearOfRelease= _yearOfRelease;
            Genre= _genre;
            Rating= _rating;
        }
        public Film() { }
    }
}
