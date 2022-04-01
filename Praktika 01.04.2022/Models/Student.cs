using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_01._04._2022.Models
{
    public class Student
    {
        private static int _id;
        public string Fullname { get; set; }
        public int Point { get; set; }
        public int Id { get; }

        public Student(string fullname, int point):this()
        {
            Fullname = fullname;
            Point = point;
        }
        static Student()
        {
            _id = 0;
        }
        private Student()
        {
            _id++;
            Id = _id;
        }

        //StudentInfo() - Student-in bütün məlumatlarını ekrana console-a yazdırır.
        public void StudentsInfo()
        {
            Console.WriteLine($"Id:{Id},Fullname:{Fullname},Point:{Point}");
        }
    }
}
