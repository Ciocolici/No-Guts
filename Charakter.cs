using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NoGuts
{
    internal class Charakter : World
    {
        int selbstwert;

        public Charakter(string name, int alter, int selbstwert)
        {
            Name = name;
            Alter = alter;
            Selbstwert = selbstwert;
        }

        public int Selbstwert { get => selbstwert; set => selbstwert = value; }

        public void ArbeitgeberAnruf()
        {
            if (Selbstwert >= 5)
            {
                Console.Clear();
                Console.WriteLine($"Mit ein Selbstwert von {Selbstwert} geland es {Name} seiner Arbeitgeber anzurufen. Nach so einem Abentuer, hat er endlich sich vertraut, das zu tun.");
                Thread.Sleep(3000);
                Console.WriteLine($"\nNatürlich wurde er sofort gekündigt, hat kein neues Job gefunden, ist auf die Straße gelandet und 1 Jahr später wurde er von wilden Tiere gefressen, aber das ist nicht das wichtigste.\nWas wichtig ist, ist, dass er endlich seiner Selbstwert gesehen hat.\n\nWas lernen wir aus dieser Geschichte? Keine Ahnung. Überlegen Sie es sich selbst, ich kann nicht alles für Sie tun.");
                Thread.Sleep(3000);
                Console.WriteLine("\n\nDrücken Sie ENTER um fortzufahren.");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ \r\n██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗\r\n██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝\r\n██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗\r\n╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║\r\n ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝\r\n                                                                          ");
                Thread.Sleep(1000);
                Console.WriteLine("\n\n ██████╗  ██████╗  ██████╗ ██████╗     ███████╗███╗   ██╗██████╗ ██╗███╗   ██╗ ██████╗ \r\n██╔════╝ ██╔═══██╗██╔═══██╗██╔══██╗    ██╔════╝████╗  ██║██╔══██╗██║████╗  ██║██╔════╝ \r\n██║  ███╗██║   ██║██║   ██║██║  ██║    █████╗  ██╔██╗ ██║██║  ██║██║██╔██╗ ██║██║  ███╗\r\n██║   ██║██║   ██║██║   ██║██║  ██║    ██╔══╝  ██║╚██╗██║██║  ██║██║██║╚██╗██║██║   ██║\r\n╚██████╔╝╚██████╔╝╚██████╔╝██████╔╝    ███████╗██║ ╚████║██████╔╝██║██║ ╚████║╚██████╔╝\r\n ╚═════╝  ╚═════╝  ╚═════╝ ╚═════╝     ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝ \r\n                                                                                       ");
                Thread.Sleep(1000);
                Console.WriteLine("\n░▀█▀░█▀█░░░▀█▀░█░█░█▀▀░█▀█░█▀▄░█░█\r\n░░█░░█░█░░░░█░░█▀█░█▀▀░█░█░█▀▄░░█░\r\n░▀▀▀░▀░▀░░░░▀░░▀░▀░▀▀▀░▀▀▀░▀░▀░░▀░");
                Thread.Sleep(3000);
                Credits();
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{Name} versucht, und versucht, aber leider ist seiner Selbstwert von {Selbstwert} viel zu wenig seiner Handy in Hand zu halten...\nEr zittert... und fängt an zu weinen... Er versteht jetzt, dass er ein Mindestwert von 5 Selbstwert braucht, sich zu vertrauen seiner Arbeitgeber anzurufen.");
                Selbstwert = Selbstwert - 1;
                int arbeitgeberAuswahl;
                bool wiederholungArbeitgeberAuswahl;
                do
                {
                    wiederholungArbeitgeberAuswahl = false;
                    Console.WriteLine($"Nach ein paar Minuten erinnert er sich, dass er nie was richtig schafft.\n{Name} verliert 1 Selbstwert.Dann {Name}:");
                    Console.WriteLine("\n\n(1).gibt sich 2 Ohrfeigen und erholt sich.\n(2).steht sofort auf.");
                    arbeitgeberAuswahl = Convert.ToInt32(Console.ReadLine());
                    if (arbeitgeberAuswahl == 1)
                    {
                        Console.Clear();
                        Selbstwert = Selbstwert + 1;
                        Console.WriteLine($"{Name} versteht jetzt seiner Sinn im Leben. +1 Selbstwert. Aktuell: {Selbstwert}. Er hat jetzt verstanden, dass er dahin gehen versuchen soll.");
                    }
                    else if (arbeitgeberAuswahl == 2)
                    {
                        if (Selbstwert >= 2)
                        {
                            Console.Clear();
                            Selbstwert = Selbstwert + 2;
                            Console.WriteLine($"Weil er genug Selbstwert hat, hat er sich sicher gefüllt an was er als nächstes zu tun hat, und hat problemlos geschafft aufzustehen.\n+2 Selbstwert. Aktuell: {Selbstwert}. Er hat jetzt verstanden, dass er dahin gehen versuchen soll.");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"{Name}, weil er mit {Selbstwert} Selbstwert nicht sicher genug war, fehlt er wieder unter. -1 Selbstwert. Trotzdem, eine innere Stimme sagt ihm, dass er trotzdem dahin gehen versuchen soll.");
                            Selbstwert = Selbstwert - 1;
                        }
                    }
                    else
                    {
                        wiederholungArbeitgeberAuswahl = true;
                        Console.Clear();
                    }

                } while (wiederholungArbeitgeberAuswahl == true);
            }
        }

        public void ArbeitRennen()
        {
            if (Selbstwert >= 1)
            {
                Console.Clear();
                Console.WriteLine($"Mit ein Selbstwert von {Selbstwert} geland es {Name} zu rennen ohne etwas in die Quere zu kommen. Unglaublich, nä?\nUnd dazu kriegt er noch +5 Selbstwert, weil er nie gedacht hat, dass er 20m kosekutiv rennen kann.");
                Selbstwert = Selbstwert + 3;

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{Name} versucht, und versucht, aber leider ist seiner Selbstwert von {Selbstwert} viel zu wenig rennen zu schaffen, und fällt wie ein Narr auf den Boden. -3 Selbstwert");
                Selbstwert = Selbstwert - 3;
                Console.WriteLine($"Nach ein paar Minuten steht er auf, traurig, und erinnert sich, dass er nie was richtig schafft. Selbstwert aktuell: {Selbstwert}");
            }
        }
    }
}
