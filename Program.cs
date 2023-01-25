using SchoolManagementDemo;

try
{
    Course software = new Course(10, "Software Developer", 6);

    Student phil = new Student("Phil Wiggins", new DateTime(1991, 10, 10), "Spain");
    Student bob = new Student("Bob Wiggins", new DateTime(1991, 10, 10), "Spain");
    Student harry = new Student("Harry Wiggins", new DateTime(1991, 10, 10), "Spain");

    // "BIDIRECTIONAL relationship" -- both objects can refer to each other

    software.RegisterStudent(phil);
    software.RegisterStudent(bob);
    software.RegisterStudent(harry);

    Console.WriteLine(software.GetStudentList().Keys.Count);
    Console.WriteLine($"{bob.Name} is registered in the course {bob.Course.Name} with {bob.Course.GetStudentList().Keys.Count} other students.");

} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
