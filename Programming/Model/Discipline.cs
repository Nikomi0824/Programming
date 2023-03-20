using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Discipline
    {
        private string _academicSubject;
        private int _estimation;
        

        public string AcademicSubject
        {
            get { return _academicSubject; }
            set { _academicSubject = value;}
        }
        public int Estimation
        {
            get { return _estimation; }
            set
            {
                if (_estimation>2 && _estimation < 5)
                {
                    _estimation = value;
                }
                else
                {
                    throw new ArgumentException("Не верно введина оценка");
                }
            }
        }
        public Discipline(string _academicSubject, int _estimation) 
        {
            AcademicSubject= _academicSubject;
            Estimation= _estimation;
        }
        public Discipline() { }
    }
}
