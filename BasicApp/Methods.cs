class Methods
{
    // Print hello message
    public void SayHello() => Console.Write("Hey There!!!");

    // Pass greetings as argument and method overloading
    public void SayHello(string greeting) => Console.Write(greeting);

    // Capitalize greeting message and return to caller
    public string SayHello(string greeting, string details) => $"{greeting.ToUpper()}\n{details}";

    // Get average of all numbers provided (Using variable number of arguments)
    public float GetAverage(params int[] numbers)
    {
        int sum = 0;
        
        foreach(var num in numbers)
        {
            sum += num;
        }

        var a = (float)sum / numbers.Length;
        return a;
    }

    // Modify above method to return sum and average (Using tuples)
    public (int, float) GetResult(params int[] numbers)
    {
        int sum = 0;
        
        foreach(var num in numbers)
        {
            sum += num;
        }

        var a = (float)sum / numbers.Length;
        return (sum, a);
    }
}