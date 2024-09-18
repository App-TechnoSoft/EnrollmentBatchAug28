class Student
{
    public string name;
    int rollNumber;
    public DateTime dateOfBirth;
    string resume;
    char gender;

    public void PrintDetails()
    {
        Console.WriteLine(name);
        Console.WriteLine(rollNumber);
        Console.WriteLine(dateOfBirth.ToLongDateString());
    }
}