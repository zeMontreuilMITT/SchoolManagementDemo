// Create a system in which Students can register for Courses
// A student may only take one Course, where a Course can have many students

// Student Class
// Course Class

// one-to-many relationship
using SchoolManagementDemo;

Course Software = new Course(200, "Software Developer", 30);
Student Jimmy = new Student(1000, "Jimmy", "Smith");

// a course can have many students in it
// and a student can take one course
// one-to-many relationship (one course, many students)

// "one" component needs a collection of the many (course needs a collection of students)
// "many" component needs a property for the "one" (student needs a property of Course)

// something outside of the objects creating the relationship between them

RegisterStudent(Jimmy, Software);
Console.WriteLine(Jimmy.Course.Title);

void RegisterStudent(Student student, Course course)
{
    // look to see if a student is already registered in a course
    // search for the student in the course's student list
    if(course.GetStudentInCourse(student.StudentId) == null)
    {
        // if not, add that student to the course's student list
        course.AddStudentToCourse(student);

        // set the course as the student's currently registered course
        student.Course = course;
    }
    else
    {
        throw new Exception($"Student with id {student.StudentId} already registered in Course {course.Title}");
    }
}
