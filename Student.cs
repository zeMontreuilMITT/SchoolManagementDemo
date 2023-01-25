using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    class Student
    {
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

        // only initialized in Constructor, readonly
        private DateTime _birthdate;
        public DateTime Birthdate { get { return _birthdate; } }

        private string _nationality;
        public string Nationality { get { return _nationality; } }

        /// <summary>
        /// One-to-many relationship
        /// Many students can each take one course
        /// One course can have many students
        /// </summary>
        private Course? _course;
        public Course? Course
        {
            get { return _course; }
            set
            {
                if (_course == null)
                {
                    _course = value;
                }
                else
                {
                    throw new Exception($"Student already registered in Course {_course.Name}");
                }
            }
        }

        public Student(string name, DateTime birthDate, string nationality)
        {
            Name = name;

            // validate age is less than 100
            DateTime currentDate = DateTime.Now;
            TimeSpan span = currentDate - birthDate;
            if (span.Days / 365 > 100)
            {
                throw new Exception("Birthdate cannot exceed 100 years prior.");
            }
            else
            {
                _birthdate = birthDate;
            }

            // validate nationality
            if (nationality.Length < 2)
            {
                throw new Exception("Nationality input should be greater than one character");
            }
            else
            {
                _nationality = nationality;
            }
        }
    }
}
