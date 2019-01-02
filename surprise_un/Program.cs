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
            while (usergender != "mr" && usergender != "mrs" && usergender != "MR" && usergender != "MRS")
            {
                Console.WriteLine("There is a mistake in your entry please, tell us if you are a mr or a mrs");
                usergender = Console.ReadLine();
            }
            Console.WriteLine("what's your name " + usergender + "?");
            username = Console.ReadLine(); // Recupère le nom de l'utilisateur
            Console.WriteLine("Enter a number please more than 0");
            usernumber = int.Parse(Console.ReadLine()); //enregistre un nombre, utile pour plus tard
            // A partir de la nous allons essayer de dessiner le sapin
            counter = 0;
            space = " "; // on va afficher 1 espace : 1espace = usernumber - 1
            while(usernumber <= 0)
            {
                Console.WriteLine("We thinks there is a mistake in the number please choose a number more than 0");
                usernumber = int.Parse(Console.ReadLine());
            } 
            // Elimine le cas 0 et les cas negatifs 
            if(usernumber > 0)
            {
                if (usernumber == 1)
                {
                    Console.SetCursorPosition(10, 1);//positionne le curseur
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*");
                }
                else
                {
                    while (counter < usernumber)
                    {
                        Console.SetCursorPosition(10 - counter, counter);
                        Console.ForegroundColor = ConsoleColor.Green;//Donne la couleur du texte
                        Console.WriteLine("/\\");
                        counter++;
                    }
                }
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("||");
            }
            Console.WriteLine("Merry Christmast " + usergender + " " + username + " ! \x01"); // Affiche le joyeux noël à l'utilisateur
        }
    }
}