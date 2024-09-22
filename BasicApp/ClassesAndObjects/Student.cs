class Student
{
    // Default parameterless constructor
    // public Student()
    // {        
    // }

    // Parameterized contructor
    public Student(string n, int r, DateTime d, char g)
    {
        name = n;
        rollNumber = r;
        dateOfBirth = d;
        gender = g;
    }

    public string name = "";
    public int rollNumber;
    public DateTime dateOfBirth;
    string resume = "";
    public char gender;

    // Instance member
    public void PrintDetails()
    {
        // var output = name + ", " + rollNumber + ", " +  dateOfBirth.ToLongDateString(); 

        // string interpolation
        var message = $"{name}\t\t{rollNumber}\t\t{dateOfBirth.ToLongDateString()}\t\t{gender}";
        Console.WriteLine(message);
    }

    // Static member
    public static void PrintHeader()
    {
        var header = $"Name\t\tRoll Number\t\tDate Of Birth\t\tGender";
        Console.WriteLine(header);
    }
}
