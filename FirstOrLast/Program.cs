using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust (eraldi)
            //programm kuvab kumb neist on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit ja perekonnanimes {lastName.Length} sümbolit.");

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimes on rohkem sümboleid.");
            }
            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimes on rohkem sümboleid.");
            }
            else
            {
                Console.WriteLine("Ees- ja perekonnanimes on võrdselt sümboleid!");
            }
        }
    }
}
