using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Student
    {
        string name;
        string sname;
        double gpa;
        /// <summary>
        ///  метод конструктор, который принимает начальные значения полей
        /// </summary>
        /// <param name="name">имя студента</param>
        /// <param name="sname">фамилия студента</param>
        /// <param name="gpa">ср.оценка</param>
        public Student(string name, string sname, double gpa)
        {
            this.name = name;
            this.sname = sname;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return name + " " + sname + " " + gpa;
        }
    }
}
