using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surprise_un
{
    class Program
    {
        static void Main(string[] args)
        {
            // je vais essayer d'afficher un sapin de noël avec des slash et des anti-slash ansi que des pipe 
            String usergender;
            String username;
            String space;
            int usernumber;
            int counter;

            Console.WriteLine("Are you a mr or a mrs?");
            usergender = Console.ReadLine();// Recupère le genre l'utilisateur
            Console.WriteLine("what's your name " + usergender + "?");
            username = Console.ReadLine(); // Recupère le nom de l'utilisateur
            Console.WriteLine("Enter a number please more than 0");
            usernumber = int.Parse(Console.ReadLine()); //enregistre un nombre, utile pour plus tard
            Console.WriteLine("Merry Christmast " + usergender + " " + username + " ! \x01"); // Affiche le joyeux noël à l'utilisateur
            // A partir de la nous allons essayer de dessiner le sapin
            counter = 0;
            space = " ";
            while(usernumber <= 0)
            { Console.WriteLine("We thinks there is a mistake in the number please choose a number more than 0"); } // Elimine le cas 0 et les cas negatifs 
            if(usernumber > 0)
            {
                Console.SetCursorPosition(10, 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*");
                while (counter < usernumber)
                {
                    Console.WriteLine("/\\");
                    counter++;
                }
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("||");
            }
        }
    }
}
