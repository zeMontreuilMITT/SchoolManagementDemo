using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    public class Course
    {
        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value > 0)
                {
                    _duration = value;
                }
                else
                {
                    throw new Exception("Duration must exceed zero");
                }
            }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Name must have more than one character.");
                }
                else
                {
                    _name = value;
                }
            }
        }


        private int _credits;
        public int Credits
        {
            get { return _credits; }
            set
            {
                if (value > 0)
                {
                    _credits = value;
                }
                else if (value > MaxCredits)
                {
                    throw new Exception($"Credits cannot exceed maximum of {MaxCredits}");
                }
                else
                {
                    throw new Exception("Duration must exceed zero");

                }
            }
        }

        private static int MaxCredits = 6;

        // easier to work with private Collection fields using public methods rather than public properties
        private Dictionary<Student, int> Students = new Dictionary<Student, int>();
        public void RegisterStudent(Student student)
        {
            string studentName = student.Name;

            if (GetStudentByName(studentName) == null)
            {
                // course has Dictionary of students
                Students.Add(student, 0);
                // student has reference to their course
                student.Course = this;
            }
            else
            {
                throw new Exception("Student already registered");
            }
        }
        public Student? GetStudentByName(string name)
        {
            foreach (Student s in Students.Keys)
            {
                if (s.Name.Equals(name))
                {
                    return s;
                }
            }

            return null;
        }
        public Dictionary<Student, int> GetStudentList()
        {
            return Students;
        }

        public Course(int duration, string name, int credits)
        {
            Duration = duration;
            Name = name;
            Credits = credits;
        }
    }
}
