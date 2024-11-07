using Hello_World.Names;

namespace HelloWord;
class Program //Default: internal
{
    static void Main() 
    {
        GetName name = new GetName();
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Me livrei da maldição :)");
        Console.Write("Digite seu nome: ");
        var userName = name.getUserName();
        Console.Write("Seu nome é: ");
        ShowName(userName);
    }

    private static void ShowName(string name) //Default: Private
    {
        Console.WriteLine(name);
    }
}