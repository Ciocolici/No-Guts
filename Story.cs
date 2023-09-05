using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NoGuts
{
    internal class Story
    {
        public static void Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n███▄▄▄▄    ▄██████▄          ▄██████▄  ███    █▄      ███        ▄████████      \r\n███▀▀▀██▄ ███    ███        ███    ███ ███    ███ ▀█████████▄   ███    ███      \r\n███   ███ ███    ███        ███    █▀  ███    ███    ▀███▀▀██   ███    █▀       \r\n███   ███ ███    ███       ▄███        ███    ███     ███   ▀   ███             \r\n███   ███ ███    ███      ▀▀███ ████▄  ███    ███     ███     ▀███████████      \r\n███   ███ ███    ███        ███    ███ ███    ███     ███              ███      \r\n███   ███ ███    ███        ███    ███ ███    ███     ███        ▄█    ███      \r\n ▀█   █▀   ▀██████▀         ████████▀  ████████▀     ▄████▀    ▄████████▀       \r\n                                                                                ");
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;

            Charakter character1 = new Charakter("", 0, 0);

            Console.Clear();
            Console.WriteLine("Große Bart, nicht so gesellig wie seiner Arbeitskollegen, aber er liebt seiner Arbeit.\nProgrammierung ist ja seiner Hobby.\n\nWie heißt er?");
            string charakterName = Console.ReadLine().ToLower();
            charakterName = char.ToUpper(charakterName[0]) + charakterName.Substring(1);
            character1.Name = charakterName;
            Console.Clear();
            bool wiederholungAlt = true;
            do
            {
                Console.WriteLine("Nicht zu jung, aber auch nicht zu alt.\n\nWie alt ist er überhaupt?");
                character1.Alter = Convert.ToInt32(Console.ReadLine());
                if (character1.Alter >= 18 && character1.Alter <= 67)
                {
                    wiederholungAlt = false;
                }
                else
                {
                    Console.Clear();
                }
            } while (wiederholungAlt);

            Console.Clear();
            Console.WriteLine($"{character1.Name} hat feierabend gehabt und geht gerne nach Hause.\nSo müde, er duscht sich nicht mal (nicht, dass er das sowieso zu oft tut), und liegt sich sofort ins Bett.\n30 Sekunden später eingeschlafen.");
            Thread.Sleep(5000);

            int ersteAuswahl;
            int zweiteAuswahl;
            int dritteAuswahl;
            bool keineWiederholungAuswahl;
            do
            {
                keineWiederholungAuswahl = true;
                Console.WriteLine($"\nNächste Tag wacht er auf, nur zu merken, dass es schon 14 Uhr ist.\nSeiner Wecker hat gar nicht geklingelt.Er fängt normalerweise um 07 Uhr schon zu arbeiten.\n\nMit ein Selbstwert von {character1.Selbstwert}, was tut {character1.Name} jetzt?");
                Console.WriteLine("\n\n(1).Er versucht seiner Arbeitgeber anzurufen, sich zu entschuldigen.\n(2).Rennt schnell zum Arbeit, vielleicht wird doch niemand merken.\n(3).Macht ein Bier auf.");

                ersteAuswahl = Convert.ToInt32(Console.ReadLine());
                if (ersteAuswahl == 1)
                {
                    character1.ArbeitgeberAnruf();
                }
                else if (ersteAuswahl == 2)
                {
                    character1.Selbstwert = character1.Selbstwert - 1;
                    do
                    {
                        Console.Clear();
                        keineWiederholungAuswahl = true;
                        Console.WriteLine($"{character1.Name} zieht sich nicht mal um, und fliegt sofort draußen.\nViel zu spät merkt er aber, dass er keine Kleidung, außer seiner Unterhose, hat. Zwei Mädels gucken schon an ihm und lachen. -1 Selbstwert. Aktuell: {character1.Selbstwert}.\n\nWas macht dann {character1.Name}?");
                        Console.WriteLine("\n\n(1).Er flirtet mit die Mädels.\n(2).Er fängt an zu weinen, und fliegt sofort zurück nach Hause.\n(3).Rennt weiter zum Arbeit.");
                        zweiteAuswahl = Convert.ToInt32(Console.ReadLine());
                        if (zweiteAuswahl == 1)
                        {
                            character1.Selbstwert = character1.Selbstwert + 5;
                            do
                            {
                                Console.Clear();
                                keineWiederholungAuswahl = true;
                                Console.WriteLine($"Zwinker, zwinker, und weckte er das Interesse beider Mädchen. 10 Minuten später hat er die Handynr. von beiden.\nSeiner Glück? Sie sind beide besoffen gewesen. +5 Selbstwert. Aktuell: {character1.Selbstwert}\n{character1.Name} findet raus, dass sie schwestern sind und beide zusammen wohnen. Er ist mit sie beiden nach (ihre) Hause gegangen. Nicht weit von seiner.\nNicht mal rein in ihre Wohnung gegangen, dass sie eingeschlafen sind. Weil er kein böse Junge ist, hat nur sich mit männliche Kleidungen (unbekannt wem gehören) umgezogen, die ihm nicht gehören. Also ja, er hat die geklaut.\n\nLeise geht er wieder draußen, und nun muss er sich entscheiden was er weiter tut.");
                                Console.WriteLine("\n\n(1).Rennt weiter zur Arbeit.\n(2).Er versucht seiner Arbeitgeber anzurufen, sich zu entschuldigen.");
                                dritteAuswahl = Convert.ToInt32(Console.ReadLine());
                                if (dritteAuswahl == 1)
                                {
                                    character1.ArbeitRennen();
                                }
                                else if (dritteAuswahl == 2)
                                {
                                    character1.ArbeitgeberAnruf();
                                }
                            } while (keineWiederholungAuswahl == false);
                        }
                        else if (zweiteAuswahl == 2)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert - 1;
                            Console.WriteLine($"Ihm war echt peinlich. Wie macht er das immer? Es ist nicht das erste mal wann er seiner Kleidungen einfach vergisst. -1 Selbstwert. Aktuell: {character1.Selbstwert}.\nMit Tränen in den Augen, er hat nicht mal bemerkt, dass er seiner Zuhause verpasst hat.");
                        }
                        else if (zweiteAuswahl == 3)
                        {
                            character1.ArbeitRennen();
                        }
                        else
                        {
                            keineWiederholungAuswahl = false;
                        }
                    } while (keineWiederholungAuswahl == false);
                }
                else if (ersteAuswahl == 3)
                {
                    character1.Selbstwert = character1.Selbstwert + 1;
                    int bierAuswahl;
                    do
                    {
                        Console.Clear();
                        for (int i = 0; i < 4; i++)
                        {

                            keineWiederholungAuswahl = true;
                            Console.WriteLine($"Wenn {character1.Name} bis jetzt nicht genug sich vertraut hat, jetzt vertraut er sich sicher.. +1 Selbstwert. Aktuell: {character1.Selbstwert}.\n\nWas macht er dann?\n\n(1).Macht noch eins auf.\n(2).Er versucht seiner Arbeitgeber anzurufen, sich zu entschuldigen.\n(3).Rennt zum Arbeit.");
                            bierAuswahl = Convert.ToInt32(Console.ReadLine());
                            if (bierAuswahl == 1 && character1.Selbstwert < 4)
                            {
                                Console.Clear();
                                character1.Selbstwert = character1.Selbstwert + 1;
                                Console.WriteLine($"Hmmm... schmeckt gut!");
                            }
                            else if (bierAuswahl == 1 && character1.Selbstwert >= 4)
                            {
                                int weiterAuswahl;
                                bool keineWiederholungWeiter;
                                do
                                {
                                    keineWiederholungWeiter = true;
                                    Console.Clear();
                                    Console.WriteLine($"Das ist schon genug, sonst wird er besoffen sein. (wenn er nicht schon ist)\n\nWas macht er weiter?");
                                    Console.WriteLine("\n\n(1).Rennt zum Arbeit.\n(2).Er versucht seiner Arbeitgeber anzurufen, sich zu entschuldigen.");
                                    weiterAuswahl = Convert.ToInt32(Console.ReadLine());
                                    if (weiterAuswahl == 1)
                                    {
                                        character1.ArbeitRennen();
                                    }
                                    else if (weiterAuswahl == 2)
                                    {
                                        character1.ArbeitgeberAnruf();
                                    }
                                    else
                                    {
                                        keineWiederholungWeiter = false;
                                    }
                                } while (keineWiederholungWeiter == false);
                                break;
                            }
                            else if (bierAuswahl == 2)
                            {
                                character1.ArbeitgeberAnruf();
                                break;
                            }
                            else if (bierAuswahl == 3)
                            {
                                character1.ArbeitRennen();
                                break;
                            }
                            else
                            {
                                keineWiederholungAuswahl = false;
                                break;
                            }
                        }
                    } while (keineWiederholungAuswahl == false);
                }
                else
                {
                    keineWiederholungAuswahl = false;
                    Console.Clear();
                }
            } while (keineWiederholungAuswahl == false);

            Freund freund1 = new Freund("", true);

            Console.WriteLine($"\n\nAuf den Weg trifft {character1.Name} ein Bekannter.\n\nWem hat er getroffen?");
            int bekannterAuswahl;
            do
            {
                Console.WriteLine("\n\n(1).Altair Ibn-La'Ahad.\n(2).Illidan Stormrage.\n(3).Alan Wake");
                bekannterAuswahl = Convert.ToInt32(Console.ReadLine());
                keineWiederholungAuswahl = true;
                if (bekannterAuswahl == 1)
                {
                    freund1.Name = "Altair Ibn-La'Ahad";
                }
                else if (bekannterAuswahl == 2)
                {
                    freund1.Name = "Illidan Stormrage";
                }
                else if (bekannterAuswahl == 3)
                {
                    freund1.Name = "Alan Wake";
                }
                else
                {
                    keineWiederholungAuswahl = false;
                    Console.Clear();
                }

            } while (keineWiederholungAuswahl == false);

            Console.Clear();
            Console.WriteLine($"Wie ist seiner Beziehung mit ihm?");
            Console.WriteLine("\n\n(1).Ein gute Freund.\n(2).Nur ein Bekannter.");
            int freundschaftAuswahl = Convert.ToInt32(Console.ReadLine());
            do
            {
                keineWiederholungAuswahl = true;
                if (freundschaftAuswahl == 1)
                {
                    freund1.Freundschaft = true;
                }
                else if (freundschaftAuswahl == 2)
                {
                    freund1.Freundschaft = false;
                }
                else
                {
                    keineWiederholungAuswahl = false;
                }

            } while (keineWiederholungAuswahl == false);

            do
            {
                keineWiederholungAuswahl = true;
                Console.Clear();
                Console.WriteLine($"\"HI!\" wurde {character1.Name} von {freund1.Name} begrußt. Sobald {character1.Name} das gehört hat, fühlte er wie der Himmel ihm auf den Kopf fiel.\n\nWas soll seiner Reaktion sein?");
                Console.WriteLine("\n\n(1).Er stoppt und begrüßt ihm zurück.\n(2).Ignoriert ihm und versucht weiter zu gehen.");
                bekannterAuswahl = Convert.ToInt32(Console.ReadLine());
                if (bekannterAuswahl == 1)
                {
                    Console.Clear();
                    character1.Selbstwert = character1.Selbstwert + 1;
                    Console.WriteLine($"\"Oh, servus, {freund1.Name}, seit lang nicht gesehen, wie geht es dir?\"\nUnglaublich, er hat geschafft zu antworten ohne ohnmächtig zu werden. +1 Selbstwert. Aktuell: {character1.Selbstwert}.");
                    if (freund1.Freundschaft == true)
                    {
                        character1.Selbstwert = character1.Selbstwert + 1;
                        Console.WriteLine($"\n\"My Men, Bro, Digga, wassup, ma BruddAh!? Mir geht es echt gut BroOoOo. So froh, dass ich ein Freund wie du hier treffe!\"\nDiese Antwort hat zu {character1.Name} ein sehr gutes Gefühl gegeben. +1 Selbstwert. Aktuell: {character1.Selbstwert}");
                    }
                    else
                    {
                        character1.Selbstwert = character1.Selbstwert - 1;
                        Console.WriteLine($"\n\"Oh, du bist nur... {character1.Name}. Ich dachte du bist ein Freund von mir.. naja.. mir geht es gut, dir?\"\nDiese Antwort hat {character1.Name} sehr weh getan. -1 Selbstwert. Aktuell: {character1.Selbstwert}");
                    }
                    Console.WriteLine($"\"Mir nicht so gut. Ich habe verschlaffen und muss schnell zur Arbeit gehen...\" sagte {character1.Name}.\n\nWas macht er weiter?");
                    do
                    {
                        keineWiederholungAuswahl = true;
                        Console.WriteLine($"\n\n(1).Er fragt ihm ob er mit Auto ist. Vielleicht könnte {freund1.Name} {character1.Name} zur Arbeit fahren.\n(2).Fragt ihm ob er gern was trinken würde und über ihre Vergangenheit reden.");
                        bekannterAuswahl = Convert.ToInt32(Console.ReadLine());
                        if (bekannterAuswahl == 1)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert - 5;
                            Console.WriteLine($"\"Alter, du bist immer noch so faul wie bevor. Echt jetzt. Weißt du was? Ich hab für dich echt Mitleid. Du nutzt nur Leute aus. Vergiss, dass ich existiere. DU KRIEGST AUCH KEIN TSCHÜSS VOR MIR!..CIAO!\"\n{character1.Name} hat das bestimmt nicht erwartet... -5 Selbstwert. Aktuell: {character1.Selbstwert}.");
                        }
                        else if (bekannterAuswahl == 2)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert + 5;
                            Console.WriteLine($"\"Naja, ich würde es gern tun, du weißt, ich mag es mit dir mich zu unterhalten, aber leider habe ich nicht genug Zeit. Aber hey, nächste mal, ok? Viel Glück mit dein Arbeit-ding-problem!\"\nZu hören, dass {freund1.Name} gern mit ihm was tun würde, ist schon was für {character1.Name}! +5 Selbstwert. Aktuell: {character1.Selbstwert}");
                        }
                        else
                        {
                            keineWiederholungAuswahl = false;
                            Console.Clear();
                        }
                        do
                        {
                            keineWiederholungAuswahl = true;
                            Console.WriteLine("\nWas tut er jetzt?");
                            Console.WriteLine("\n\n(1).Rennt zum Arbeit.\n(2).Er versucht seiner Arbeitgeber anzurufen, sich zu entschuldigen.");
                            bekannterAuswahl = Convert.ToInt32(Console.ReadLine());
                            if (bekannterAuswahl == 1)
                            {
                                character1.ArbeitRennen();
                            }
                            else if (bekannterAuswahl == 2)
                            {
                                character1.ArbeitgeberAnruf();
                            }
                            else
                            {
                                keineWiederholungAuswahl = false;
                                Console.Clear();
                            }
                        } while (keineWiederholungAuswahl == false);
                    } while (keineWiederholungAuswahl == false);

                }
                else if (bekannterAuswahl == 2)
                {
                    Console.Clear();
                    character1.Selbstwert = character1.Selbstwert - 1;
                    Console.WriteLine($"\"Hey, warte, kenn ich dich!?\"schreite {freund1.Name} von weit weg.\nVoll beschämt, {character1.Name}, guckt an ihm und versteht sofort, dass er weißt, dass er ihm ignorieren versucht hat. -1 Selbstwert. Aktuell: {character1.Selbstwert}.\n\"Ohh.. Hi,{freund1.Name}, ich habe dich nicht.. gesehen. Wie geht's?\" sagte {character1.Name} richtig leise, wie er gar nicht gehört sein wollte.");
                    if (freund1.Freundschaft == true)
                    {
                        character1.Selbstwert = character1.Selbstwert + 1;
                        Console.WriteLine($"\n\"My Men, Bro, Digga, wassup, ma BruddAh!? Mir geht es echt gut BroOoOo. So froh, dass ich ein Freund wie du hier treffe!\"\nDiese Antwort hat zu {character1.Name} ein sehr gutes Gefühl gegeben. +1 Selbstwert. Aktuell: {character1.Selbstwert}");
                    }
                    else
                    {
                        character1.Selbstwert = character1.Selbstwert - 1;
                        Console.WriteLine($"\n\"Oh, du bist nur... {character1.Name}. Ich dachte du bist ein Freund von mir.. naja.. mir geht es gut, dir?\"\nDiese Antwort hat {character1.Name} sehr weh getan. -1 Selbstwert. Aktuell: {character1.Selbstwert}");
                    }
                    do
                    {
                        keineWiederholungAuswahl = true;
                        Console.WriteLine($"\n\n(1).{character1.Name} fragt dann {freund1.Name} wie es seiner Mutter geht.\n(2).Rolls eyes and walks away.");
                        bekannterAuswahl = Convert.ToInt32(Console.ReadLine());
                        if (bekannterAuswahl == 1)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert - 5;
                            Console.WriteLine($"\nAuch nicht heute weißt niemand ob es eine ernste Frage war. Es ist aber zu {freund1.Name} ganz egal gewesen. {character1.Name} hat eins, und dann zwei, ins Gesicht bekommen. -5 Selbstwert. Aktuell: {character1.Selbstwert}.");
                        }
                        else if (bekannterAuswahl == 2)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert + 5;
                            Console.WriteLine($"\n\"Hey, warte, ich rede mit dir!\" sagte {freund1.Name}, als {character1.Name} weg gelaufen ist. LiK3 A b0$$! +5 Selbstwert. Aktuell: {character1.Selbstwert}");
                        }
                        else
                        {
                            keineWiederholungAuswahl = false;
                            Console.Clear();
                        }
                        do
                        {
                            keineWiederholungAuswahl = true;
                            Console.WriteLine("\nWas tut er jetzt?");
                            Console.WriteLine("\n\n(1).Rennt zur Arbeit.\n(2).Er versucht seiner Arbeitgeber anzurufen, sich zu entschuldigen.");
                            bekannterAuswahl = Convert.ToInt32(Console.ReadLine());
                            if (bekannterAuswahl == 1)
                            {
                                character1.ArbeitRennen();
                            }
                            else if (bekannterAuswahl == 2)
                            {
                                character1.ArbeitgeberAnruf();
                            }
                            else
                            {
                                keineWiederholungAuswahl = false;
                                Console.Clear();
                            }
                        } while (keineWiederholungAuswahl == false);
                    } while (keineWiederholungAuswahl == false);
                }
                else
                {
                    keineWiederholungAuswahl = false;
                }
            } while (keineWiederholungAuswahl == false);

            Freundin freundin1 = new Freundin("", 0, true);

            freundin1.Alter = character1.Alter + 5;
            Console.WriteLine($"\n\nAuf den Weg trifft {character1.Name} seiner Ex-freundin. Ja, unglaublich, aber er hat auch mal eins gehabt. Die einzige, aber das ist nur Details.\n\nWas war ihre Name?");
            int freundinAuswahl;
            do
            {
                Console.WriteLine("\n\n(1).Hinata Hyuga.\n(2).Jaina Proudmoore.\n(3).Tiny Tina");
                freundinAuswahl = Convert.ToInt32(Console.ReadLine());
                keineWiederholungAuswahl = true;
                if (freundinAuswahl == 1)
                {
                    freundin1.Name = "Hinata Hyuga";
                }
                else if (freundinAuswahl == 2)
                {
                    freundin1.Name = "Jaina Proudmoore";
                }
                else if (freundinAuswahl == 3)
                {
                    freundin1.Name = "Tiny Tina";
                }
                else
                {
                    keineWiederholungAuswahl = false;
                    Console.Clear();
                }

            } while (keineWiederholungAuswahl == false);

            Console.Clear();
            Console.WriteLine($"Wie war {freundin1.Name}?");
            Console.WriteLine("\n\n(1).Smexy.\n(2).Looks are not everything.");
            int smexyAuswahl = Convert.ToInt32(Console.ReadLine());
            do
            {
                keineWiederholungAuswahl = true;
                if (smexyAuswahl == 1)
                {
                    freundin1.Smexy = true;
                }
                else if (smexyAuswahl == 2)
                {
                    freundin1.Smexy = false;
                }
                else
                {
                    keineWiederholungAuswahl = false;
                }

            } while (keineWiederholungAuswahl == false);

            do
            {
                keineWiederholungAuswahl = true;
                Console.Clear();
                Console.WriteLine($"\"BOYAAAH!\" wurde {character1.Name} von {freundin1.Name} erschreckt.\nWie kann das überhaupt sein? Zwei Leute am gleiche Tag zu treffen? Er sieht normalerweiße niemand außer seiner Arbeitskollegen jeden Tag...\n\nWas soll er tun?");
                Console.WriteLine("\n\n(1).Bleibt einfach sprachlos und sabbert.\n(2).Versucht mit sie zu kommunizieren, wie normale Menschen.");
                freundinAuswahl = Convert.ToInt32(Console.ReadLine());
                if (freundinAuswahl == 1)
                {
                    Console.Clear();
                    character1.Selbstwert = character1.Selbstwert + 3;
                    Console.WriteLine($"Er guckt an sie sprachlos und sabbert, während sie.. das gleichte tut, an ihm. Für 10 ganze Minuten. Nur danach versteht {character1.Name}, dass {freundin1.Name} high ist.\nAber trotzdem.. jemand hat an ihm 10 Minuten konsekutiv geguckt. +3 Selbstwert. Aktuell: {character1.Selbstwert}.");
                    if (freundin1.Smexy == true)
                    {
                        character1.Selbstwert = character1.Selbstwert + 2;
                        Console.WriteLine($"\nNoch dazu, dass {freundin1.Name} so smexy ist, ist schon was für seiner Selbstvertraut. Egal was, eine sexy Lady guckt an ihm. Immer noch. +2 Selbstwert. Aktuell: {character1.Selbstwert}");
                    }
                    else
                    {
                        character1.Selbstwert = character1.Selbstwert - 2;
                        Console.WriteLine($"\nEr wacht aber sofort auf, wann er besser an sie guckt. {freundin1.Name} ist echt hässlich geworden.\nUhm, sie war auch bevor. Aber jetzt findet er sie noch hässlicher irgendwie. -2 Selbstwert. Aktuell: {character1.Selbstwert}");
                    }
                    Console.WriteLine($"So viel Zeit für nichts verloren, er muss schnell sich entscheiden was er tun will.\nEr erinnert sich nur ein Detail.. sie ist 5 Jahre älter als ihm. Er fragt sich aber... \"Magt sie immer noch jungere Männer?\" \n\nWas macht er weiter?");
                    do
                    {
                        keineWiederholungAuswahl = true;
                        Console.WriteLine($"\n\n(1).Er fragt {freundin1.Name} ob sie gern mit ihm nach Hause gehen würde.\n(2).Er erzählt seiner Situation und bittet um Verständnis weg zu gehen.");
                        freundinAuswahl = Convert.ToInt32(Console.ReadLine());
                        if (freundinAuswahl == 1)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert - 5;
                            Console.WriteLine($"\"Boooy, ich hab an dich geguckt nur weil ich mich gut fühle.. du denkst nicht, dass ich dich vermisse oder sooowasssss...\nIch bin {freundin1.Alter} Jahren alt, und du nur {character1.Alter}.. Seit wann ich mit Bruce Willis war, habe ich verstanden, dass ältere Männer geiler sind. Also verbiss dich! Bye-Bye!!\"\n{character1.Name} hat das bestimmt nicht erwartet... -5 Selbstwert.Aktuell: {character1.Selbstwert}.");
                        }
                        else if (freundinAuswahl == 2)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert + 5;
                            Console.WriteLine($"\"Alles klar, darling, ich verstehe. Ich habe dich echt vermisst, aber wenn es so ist, ist es so.\nMach dir keine Sorgen, sehen wir uns irgendwann. Viel Gluck mit dein Ding!\"\nZu hören, dass {freundin1.Name} ihm vermisst hat... ist schon was für {character1.Name}! +5 Selbstwert. Aktuell: {character1.Selbstwert}");
                        }
                        else
                        {
                            keineWiederholungAuswahl = false;
                            Console.Clear();
                        }
                        do
                        {
                            keineWiederholungAuswahl = true;
                            Console.WriteLine("\nWas tut er jetzt?");
                            Console.WriteLine("\n\n(1).Rennt zur Arbeit.\n(2).Er versucht seiner Arbeitgeber anzurufen, sich zu entschuldigen.");
                            freundinAuswahl = Convert.ToInt32(Console.ReadLine());
                            if (freundinAuswahl == 1)
                            {
                                character1.ArbeitRennen();
                            }
                            else if (freundinAuswahl == 2)
                            {
                                character1.ArbeitgeberAnruf();
                            }
                            else
                            {
                                keineWiederholungAuswahl = false;
                                Console.Clear();
                            }
                        } while (keineWiederholungAuswahl == false);
                    } while (keineWiederholungAuswahl == false);

                }
                else if (freundinAuswahl == 2)
                {
                    Console.Clear();
                    character1.Selbstwert = character1.Selbstwert - 2;
                    Console.WriteLine($"Er versucht mit sie zu kommunizieren, aber leider was raus kommt ist nur \"HmUhmHHHHHHHmmmUHmm\". -2 Selbstwert. Aktuell: {character1.Selbstwert}.");
                    if (freundin1.Smexy == true)
                    {
                        character1.Selbstwert = character1.Selbstwert - 2;
                        Console.WriteLine($"Gegeben, dass {freundin1.Name} auch so smexy ist, fühlte er sich noch schlimmer... -2 Selbstwert. Aktuell: {character1.Selbstwert}");
                    }
                    else
                    {
                        character1.Selbstwert = character1.Selbstwert + 2;
                        Console.WriteLine($"Gott sei Dank ist {freundin1.Name} aber voll hässlisch. Deswegen tut es gar nicht weh, dass er so dumm ist. +2 Selbstwert. Aktuell: {character1.Selbstwert}");
                    }
                    do
                    {
                        keineWiederholungAuswahl = true;
                        Console.WriteLine($"\nWeiter?\n\n(1).{character1.Name} + {freundin1.Name} = L0v3.\n(2).Zwinker, zwinker, tschüss!");
                        freundinAuswahl = Convert.ToInt32(Console.ReadLine());
                        if (freundinAuswahl == 1)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert - 5;
                            Console.WriteLine($"{character1.Name} war nie gut mit flirten. Also man kann sich schon vorstellen was danach passiert ist.\nNatürlich wann {character1.Name} zu {freundin1.Name} zu Kaffee eingeladen hat, es hat Minuten gedauert für ihm die Frage zu stelle. Wann er aber seiner Augen wieder auf gemacht hat, war sie gar nicht mehr da.. -5 Selbstwert. Aktuell: {character1.Selbstwert}.");
                        }
                        else if (freundinAuswahl == 2)
                        {
                            Console.Clear();
                            character1.Selbstwert = character1.Selbstwert + 5;
                            Console.WriteLine($"Er hat sich erinnert, dass sie jungere Männer magt. Gegeben, dass er {character1.Alter} Jahren alt ist, und sie 5 Jahren älter, also {freundin1.Alter}, hat er das gleiche getan, was er vor Jahren getan hat.\nZwinker, zwinker, und ein Tschüss, und sie war schon neben ihm für ein Date zu gebittet. Er hat sich danach natürlich entschuldigt, weil der coole Mensch {character1.Name} hatte doch was anderes dringend zu tun. +5 Selbstwert. Aktuell: {character1.Selbstwert}");
                        }
                        else
                        {
                            keineWiederholungAuswahl = false;
                            Console.Clear();
                        }
                        do
                        {
                            keineWiederholungAuswahl = true;
                            Console.WriteLine("\nWas tut er jetzt?");
                            Console.WriteLine("\n\n(1).Rennt zum Arbeit.\n(2).Er versucht seiner Arbeitgeber anzurufen, sich zu entschuldigen.");
                            freundinAuswahl = Convert.ToInt32(Console.ReadLine());
                            if (freundinAuswahl == 1)
                            {
                                character1.ArbeitRennen();
                            }
                            else if (freundinAuswahl == 2)
                            {
                                character1.ArbeitgeberAnruf();
                            }
                            else
                            {
                                keineWiederholungAuswahl = false;
                                Console.Clear();
                            }
                        } while (keineWiederholungAuswahl == false);
                    } while (keineWiederholungAuswahl == false);
                }
                else
                {
                    keineWiederholungAuswahl = false;
                }
            } while (keineWiederholungAuswahl == false);

            if (character1.Selbstwert < 5)
            {
                Console.WriteLine($"\n{character1.Name}, mit nur {character1.Selbstwert} Selbstwert hat verstanden, dass er nur eine Ameise im Maßstab des Universums ist.\nSo er hat sich entschieden seiner Arbeit zu verlassen und Droggen zu verkaufen. Weil es leichter ist, und mehr profitabel natürlich.\nLeider 10 Minuten später wurde er von Polizei erwischt und sofort in Gefängnis geschmissen.\nWo er 2 Tage später tot gefunden wurde. Niemand weißt warum, aber auch niemand fragt sich lol.\n\nWas lernen wir? Sei nicht wie {character1.Name}, oder doch, who cares?! I don't. ^^");
                Thread.Sleep(3000);
                Console.WriteLine("\n\nDrücken Sie ENTER um fortzufahren.");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  \r\n ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒\r\n▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒\r\n░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  \r\n░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒\r\n ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░\r\n  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░\r\n░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ \r\n      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     \r\n                                                     ░                   ");
                Thread.Sleep(1000);
                Console.WriteLine("\n\n  ▄▄▄▄    ▄▄▄      ▓█████▄    ▓█████  ███▄    █ ▓█████▄  ██▓ ███▄    █   ▄████ \r\n▓█████▄ ▒████▄    ▒██▀ ██▌   ▓█   ▀  ██ ▀█   █ ▒██▀ ██▌▓██▒ ██ ▀█   █  ██▒ ▀█▒\r\n▒██▒ ▄██▒██  ▀█▄  ░██   █▌   ▒███   ▓██  ▀█ ██▒░██   █▌▒██▒▓██  ▀█ ██▒▒██░▄▄▄░\r\n▒██░█▀  ░██▄▄▄▄██ ░▓█▄   ▌   ▒▓█  ▄ ▓██▒  ▐▌██▒░▓█▄   ▌░██░▓██▒  ▐▌██▒░▓█  ██▓\r\n░▓█  ▀█▓ ▓█   ▓██▒░▒████▓    ░▒████▒▒██░   ▓██░░▒████▓ ░██░▒██░   ▓██░░▒▓███▀▒\r\n░▒▓███▀▒ ▒▒   ▓▒█░ ▒▒▓  ▒    ░░ ▒░ ░░ ▒░   ▒ ▒  ▒▒▓  ▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒ \r\n▒░▒   ░   ▒   ▒▒ ░ ░ ▒  ▒     ░ ░  ░░ ░░   ░ ▒░ ░ ▒  ▒  ▒ ░░ ░░   ░ ▒░  ░   ░ \r\n ░    ░   ░   ▒    ░ ░  ░       ░      ░   ░ ░  ░ ░  ░  ▒ ░   ░   ░ ░ ░ ░   ░ \r\n ░            ░  ░   ░          ░  ░         ░    ░     ░           ░       ░ \r\n      ░            ░                            ░                             ");
                Thread.Sleep(3000);
            }
            else
            {
                character1.ArbeitgeberAnruf();
            }
        }
    }
}
