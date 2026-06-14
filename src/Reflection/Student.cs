using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        public Student(int rollNo, string name)
        {
            RollNo = rollNo;
            Name = name;
        }

        public void DisPlay()
        {
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
        }
    }
}
