using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        public static int nextStudentId = 1;

        public string Name { get; set; }

        public int StudentId{ get; set; }

        public int NumberOfCredits{ get; set; }

        public double Gpa { get; set; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId) 
            : this(name, studentId, 0, 0) { }

        public Student(string name) : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            NumberOfCredits += courseCredits;
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += grade;
            Gpa = (totalQualityScore / NumberOfCredits);
        }

        public override bool Equals(Object o)
        {
            Student studentObject = o as Student;
            return StudentId == studentObject.StudentId;
        }

        public override string ToString()
        {
            return $"Name: {Name}(Credits: {NumberOfCredits}, GPA: {Gpa})";
        }
    }




    
}
