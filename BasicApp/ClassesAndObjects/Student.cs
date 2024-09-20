class Student
{
    public string name;
    public int rollNumber;
    public DateTime dateOfBirth;
    string resume;
    public char gender;

    public void PrintDetails()
    {
        // var output = name + ", " + rollNumber + ", " +  dateOfBirth.ToLongDateString(); 

        // string interpolation
        var message = $"{name}\t{rollNumber}\t{dateOfBirth.ToLongDateString()}";
        Console.WriteLine(message);
    }
}
