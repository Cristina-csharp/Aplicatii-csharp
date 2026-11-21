using System;

class Program
{
    static void Main()
    {
        string? optiune;

        do
        {
            Console.WriteLine();
            Console.WriteLine("APLICATIE GESTIUNE");
            Console.WriteLine("1. Clienti");
            Console.WriteLine("2. Programari");
            Console.WriteLine("3. Rapoarte");
            Console.WriteLine("4. Iesire");
            Console.Write("Alegeti optiunea: ");
            optiune = Console.ReadLine();

            switch (optiune)
            {
                case "1": Console.WriteLine("Modul Clienti"); break;
                case "2": Console.WriteLine("Modul Programari"); break;
                case "3": Console.WriteLine("Modul Rapoarte"); break;
                case "4": Console.WriteLine("La revedere!"); break;
                default: Console.WriteLine("Optiune invalida"); break;
            }
        }
        while (optiune != "4");
    }
}