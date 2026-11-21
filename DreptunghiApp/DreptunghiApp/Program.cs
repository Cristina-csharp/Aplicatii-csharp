using System;

class Program
{
    static double CitesteValoarePozitiva(string mesaj)
    {
        double valoare;
        while (true)
        {
            Console.Write(mesaj);
            string? text = Console.ReadLine();
            if (double.TryParse(text, out valoare) && valoare > 0)
            {
                return valoare;
            }
            Console.WriteLine("Eroare: introduceti un numar mai mare decat 0.");
        }
    }

    static void Main()
    {
        double lungime = CitesteValoarePozitiva("Lungime: ");
        double latime = CitesteValoarePozitiva("Latime: ");

        double arie = lungime * latime;
        double perimetru = 2 * (lungime + latime);

        Console.WriteLine($"Aria = {arie}");
        Console.WriteLine($"Perimetrul = {perimetru}");
        double diagonala = Math.Sqrt(lungime * lungime + latime * latime);
        Console.WriteLine($"Diagonala = {diagonala:F2}");
    }
}