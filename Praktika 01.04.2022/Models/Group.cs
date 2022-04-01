using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_01._04._2022.Models
{
    public class Group
    {
        public string GroupNo { get; set; }
        private int _studentsLimit;
        private Student[] _students = new Student[0];

        //StudentLimit - qrupda ola biləcək tələbə sayını göstərir minumum 5 maximum 18 ola bilər.
        public int StudentsLimit
        {
            get
            {
                return _studentsLimit;
            }
            set
            {
                if (value >= 5 || value <= 18)
                {
                    _studentsLimit = value;
                }
            }
        }
        public Group(string groupNo, int studentsLimit)
        {
            GroupNo = groupNo;
            StudentsLimit = studentsLimit;
        }

        // CheckGroupNo() - parametr olaraq string bir groupNo dəyəri alır və qrupun nömrəsini yoxlayır geriyə true/false dəyərləri qaytarır.
        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 5 && string.IsNullOrEmpty(groupNo) && string.IsNullOrWhiteSpace(groupNo))
            {
                bool HasDigit = false;
                bool HasUpper = false;
                for (int i = 0; i < groupNo.Length; i++)
                {
                    if (char.IsDigit(groupNo[i])) HasDigit = true;
                    else if (char.IsUpper(groupNo[i])) HasUpper = true;
                    if (HasDigit && HasUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void Addstudents(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public Student GetStudent(int? id)
        {
            if(id != null)
            {
                foreach(Student st in _students)
                {
                    if (st.Id.Equals(id) == true)
                    {
                        return st;
                    }
                }
            }
            throw new DllNotFoundException("Student tapilmadi");
        }
        public Student [] GetAllStudents()
        {
            return _students;
        }
    }
}
