using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {

        private string name;
        private int studentId;
        private int numberOfCredits;
        private double gpa;

        public string Name
        {
            get; set;
        }

        public int StudentId
        {
            get { return studentId; }

            internal set { studentId = value; }
        }

        public int NumberOfCredits
        {
            get; set;
        }

        public double Gpa
        {
            get; set;
        }

    }
}
