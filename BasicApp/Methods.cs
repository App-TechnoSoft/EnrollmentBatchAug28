class Methods
{
    // Print hello message
    public void SayHello() => Console.Write("Hey There!!!");

    // Pass greetings as argument and method overloading
    public void SayHello(string greeting) => Console.Write(greeting);

    // Capitalize greeting message and return to caller
    public string SayHello(string greeting, string details) => $"{greeting.ToUpper()}\n{details}";

}