using System;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Robot";
            Robot r1 = new Robot("Alpha");
            Console.WriteLine($"\n{r1}");
            r1.avance();
            Console.WriteLine($"Apres avoir avancer \n{r1}");
            r1.tourner();
            Console.WriteLine($"Apres avoir tourner \n{r1}");
            RobotNG r2 = new RobotNG("Alpha");
            Console.WriteLine($"\n{r2}");
            r2.avance(10);
            Console.WriteLine($"Apres avoir avancer \n{r2}");
            r2.TournerGauche();
            Console.WriteLine($"Apres avoir tourner \n{r2}");
            Console.Read();
        }
    }
}
