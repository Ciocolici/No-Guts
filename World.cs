using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGuts
{
    abstract class World
    {
        string name;
        int alter;

        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }

        public static void GameRules()
        {
            Console.WriteLine("Game Rules:\n\t01. Namen sollen keine Zahlen oder Sonderzeichen haben.\n\t02. Alter soll in Zahlen geschrieben werden, und darf nicht kleiner als 18 oder größer als 67 sein.\n\t03. Die Storyauswähle sollen mit die Zahlen 1, 2 und 3 ausgewählt werden.\n\nP.S.: Dein Charakter ist männlich. Because patriarchy and stuff, sorry!");
            Thread.Sleep(5000);
            bool wiederholEinverstanden;
            do
            {
                wiederholEinverstanden = false;
                Console.WriteLine("\n\n\nSind Sie einverstanden ?");
                string einverstanden = Console.ReadLine().ToLower();
                switch (einverstanden)
                {
                    case "ja":
                        break;
                    case "nein":
                        Console.WriteLine("Verständlich. Drücken Sie dann bitte ENTER um das Spiel zu schließen.");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\"ja\" oder \"nein\" bitte reinschreiben.");
                        wiederholEinverstanden = true;
                        break;
                }
            } while (wiederholEinverstanden == true);
        }
        public static void Credits()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Drücken Sie ENTER um den Abspann einzusehen.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Credits:\n\nCirjeu Daniel Marian");
            Thread.Sleep(1500);
            Console.WriteLine("\n\nIch");
            Thread.Sleep(1500);
            Console.WriteLine("\n\nCioco (also ich)");
            Thread.Sleep(1500);
            Console.WriteLine("\n\nIch selbst");
            Thread.Sleep(1500);
            Console.WriteLine("\n\nNicht du");
            Thread.Sleep(1500);
            Console.WriteLine("\n\n\nVielen Dank, dass Sie mein.. Ding.. gespielt haben! (:\n\nDrücken Sie ENTER um das Spiel zu beenden.");
            Console.ReadLine();
        }

        public static void NoGuts()
        {
                GameRules();
                Story.Start();
                Credits();
                Console.Clear();
        }
    }
}
