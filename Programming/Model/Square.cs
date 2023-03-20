using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Square
    {
        private double _heigth;
        private double _width;
        private string _colors;

        public double Heigth
        {
            get { return _heigth; }
            set
            {
                if (_heigth > 0)
                {
                    _heigth = value;
                }
                else
                {
                    throw new ArgumentException("Введино отрицательное значение ");
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (_width > 0)
                {
                    _width = value;
                }
                else
                {
                  throw new ArgumentException("Введино отрицательное значение");
                }
            }
        }
        public string Colors
        {
            get { return _colors; }
            set { _colors = value; }
        }
        public Square(double _heigth, double _width, string _colors)
        {
            Heigth= _heigth;
            Width= _width;
            Colors= _colors;
        }
        public Square() { }
    }
}
