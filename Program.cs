class Course
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
    public Course(int duration, string name, int credits)
    {
        Duration = duration;
        Name = name;
        Credits = credits;
    }
}

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