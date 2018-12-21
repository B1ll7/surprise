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
            int usernumber;
            int counter;

            Console.WriteLine("Are you a mr or a mrs?");
            usergender = Console.ReadLine();
            Console.WriteLine("what's your name " + usergender + "?");
            username = Console.ReadLine();
            Console.WriteLine("Enter a number please more than 0");
            usernumber = Console.ReadLine();
            Console.WriteLine("Merry Christmast " + usergender + " " + username + " ! \x01");
            counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("|");
                i++;
            }



        }
    }
}
