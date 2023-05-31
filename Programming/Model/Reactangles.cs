using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Reactangles
    {
        private double _heigth;
        private double _width;
        private string _colors;

        public double Heigth
        {
            get { return _heigth; }
            set
            {
                if (value > 0)
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
                if (value > 0)
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
        public Reactangles(double heigth, double width, string сolors)
        {
            Heigth= heigth;
            Width= width;
            Colors= сolors;
        }
        public Reactangles() { }
    }
}
