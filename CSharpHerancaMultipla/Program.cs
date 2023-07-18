


using CSharpHerancaMultipla;

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer()
        { SerialNumber = 1080 };

        p.ProcessDoc("My letter");
        p.Print("My letter");

        Scanner s = new Scanner()
        { SerialNumber = 2023 };

        s.ProcessDoc("My Email");
        Console.WriteLine(s.Scan());
        p.Print("My letter");
    }
}