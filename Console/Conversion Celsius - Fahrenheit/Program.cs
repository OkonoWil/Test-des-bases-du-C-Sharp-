using System;

namespace Conversion_Celsius___Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            char decision = 'O'; string tmp;
            int choix; float resultatConversion; float temperature;
            bool choixValide = false;

            Console.Title = "Conversion";
            Console.WriteLine("CONVERTISSEUR DEGRES CELSIUS ET DEGRES FAHREINEIT");
            Console.WriteLine("-------------------------------------------------");
            do
            {
                Console.WriteLine("Choisissez le mode de conversion :");
                Console.WriteLine("1 - Convertisseur Celsius - Fahrenheit");
                Console.WriteLine("2 - Convertisseur Fahrenheit - Celsius");

                //Test si le choix est correct
                do
                {
                    tmp = Console.ReadLine();
                    if (int.TryParse(tmp, out choix) && (choix == 1 || choix == 2))
                        choixValide = true;
                    else
                        Console.WriteLine("Le choix que vous avez saisi est incorrect...");
                } while (!choixValide);

                if (choix == 1)
                {
                    Console.WriteLine("Température à convertir :");

                    choixValide = false;
                    do
                    {
                        tmp = Console.ReadLine();
                        if (float.TryParse(tmp, out temperature))
                            choixValide = true;
                        else
                            Console.WriteLine("La température que vous avez saisi est invalide...");
                    } while (!choixValide);

                    resultatConversion = (9 * temperature) / 5 + 32;

                    Console.WriteLine(temperature + " °C correspond à : " + resultatConversion + " °F");
                }
                else
                {
                    Console.WriteLine("Température à convertir :");

                    choixValide = false;
                    do
                    {
                        tmp = Console.ReadLine();
                        if (float.TryParse(tmp, out temperature))
                            choixValide = true;
                        else
                            Console.WriteLine("La température que vous avez saisi est invalide...");
                    } while (!choixValide);

                    resultatConversion = ((temperature - 32) * 5) / 9;

                    Console.WriteLine(temperature + " °F correspond à : " + resultatConversion + " °C");
                }

                Console.WriteLine("Souhaitez-vous convertir une autre températur ? (O/N)");
                tmp = Console.ReadLine();
                decision = char.Parse(tmp);

            } while (decision == 'O');

            Console.WriteLine("Au revoir !");
            Console.Read();

        }
    }
}
