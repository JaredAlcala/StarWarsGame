using StarWarsGameLibrary;
using System.Threading;

namespace StarWarsGame
{
    internal class MainGame
    {
        static void Main(string[] args)
        {
            Console.Title = "*^*^*^*^*^* Star Wars: A Bounty Hunting Game *^*^*^*^*^*";
            Console.WriteLine("            ________   ___   ____\r\n           / __   __| / _ \\ |  _ \\\r\n     ______> \\ | |   |  _  ||    /_____________________________\r\n    / _______/ |_|   |_| |_||_|\\______________________________ \\\r\n   / /                                                        \\ \\\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                  A Bounty Hunter Game!                   | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n   \\ \\____________________________    _   ___   ____   _______/ /\r\n    \\___________________________  |  | | / _ \\ |  _ \\ / _______/\r\n                                | |/\\| ||  _  ||    / > \\          \r\n                                 \\_/\\_/ |_| |_||_|\\_\\|__/");

            Console.WriteLine("\nPress any key to continue to game...");
            Console.ReadLine();
            Console.Clear();
            Console.Title = "+*+*+*+* LOADING *+*+*+*+";
            Console.WriteLine("                c==o\r\n              _/____\\_\r\n       _.,--'\" ||^ || \"`z._\r\n      /_/^ ___\\||  || _/o\\ \"`-._\r\n    _/  ]. L_| || .||  \\_/_  . _`--._\r\n   /_~7  _ . \" ||. || /] \\ ]. (_)  . \"`--.\r\n  |__7~.(_)_ []|+--+|/____T_____________L|\r\n  |__|  _^(_) /^   __\\____ _   _|\r\n  |__| (_){_) J ]K{__ L___ _   _]\r\n  |__| . _(_) \\v     /__________|________\r\n  l__l_ (_). []|+-+-<\\^   L  . _   - ---L|\r\n   \\__\\    __. ||^l  \\Y] /_]  (_) .  _,--'\r\n     \\~_]  L_| || .\\ .\\\\/~.    _,--'\"\r\n      \\_\\ . __/||  |\\  \\`-+-<'\"\r\n        \"`---._|J__L|X o~~|[\\\\      \"Millenium Falcon\"\r\n               \\____/ \\___|[//      Modified Corellian YT-1300 Transport (1)\r\n                `--'   `--+-'");
            Console.WriteLine("\nLoading...");
            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            Console.Title = "*^*^*^*^*^* Star Wars: A Bounty Hunting Game *^*^*^*^*^*";


            Console.WriteLine("          ___\r\n         /---\\\r\n        | @ @:|\r\n        |  \" :|\r\n         \\_-_/\r\n       _.d._.b.__\r\n   +\"i\\  |\\_/|  /i\"+\r\n   [_| \\ |   | / |_]\r\n  .' |  ):===:(  | `.\r\n  |:.'+-\" | | \"-+`.:|\r\n  |_| |-. |_|   | |_|\r\n  \\:\\ |-' /+\\   ! |:|\r\n   \\ \\|n._\\+/_.n| / /\r\n    \\XT::::-::::T/ /\r\n     \"l-. `\"' .-lXX\r\n      |: \\   / :|\r\n      |:  i-i  :|\r\n      |:  | |  :| \r\n      |:  | |  :|\r\n     \\|;_ | |__;|/\r\n      (__() ()__)      \r\n      |:  | |  :|");
            Console.WriteLine("\nHello Young Bounty Hunter!" +
                "\nI'm C5-08." +
                "\nI'm a Servant Droid from the Bounty Hunters Guild. I'm here to help you get your Bounty Hunting Career started." +
                "\nAnd for you to make a name for yourself in this DANGEROUS life of Bounty Hunting....");


            #region Player Creation
            //Variable to keep score
            int score = 0;
            int bounties = 0;

            // Weapon creation
            //Potential Expantion - Displays a list of weapons and let them pick
            bool end = false;
            // Play object creation
            //Potential Expantion - let them enter their own name and show them the races and let them pick one
            string playerName = " ";
            Race playerRace = new Race();
            string raceChoice;
            #endregion

            #region Character
            Console.WriteLine("\n\nPlease Enter your Bounty Hunter's Name...");
            playerName = Console.ReadLine();

            Console.WriteLine($"\nWelcome to the start of your career in bounty hunting {playerName}\n");
            #endregion
            #region Character input/Menu
            bool validRace = false;
            bool chosen = true;
            bool noChosen = false;
            do
            {
                Console.WriteLine("Please choose a race\n" +
                        "(please enter the number you wish below)\n" +
                        "\t1.) Rodians,\n" +
                        "\t2.) Trandoshan,\n" +
                        "\t3.) Wookie,\n" +
                        "\t4.) Mandalorian,\n" +
                        "\t5.) Human,\n" +
                        "\t6.) Duros,\n");

                raceChoice = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("          ___\r\n         /---\\\r\n        | @ @:|\r\n        |  \" :|\r\n         \\_-_/\r\n       _.d._.b.__\r\n   +\"i\\  |\\_/|  /i\"+\r\n   [_| \\ |   | / |_]\r\n  .' |  ):===:(  | `.\r\n  |:.'+-\" | | \"-+`.:|\r\n  |_| |-. |_|   | |_|\r\n  \\:\\ |-' /+\\   ! |:|\r\n   \\ \\|n._\\+/_.n| / /\r\n    \\XT::::-::::T/ /\r\n     \"l-. `\"' .-lXX\r\n      |: \\   / :|\r\n      |:  i-i  :|\r\n      |:  | |  :| \r\n      |:  | |  :|\r\n     \\|;_ | |__;|/\r\n      (__() ()__)      \r\n      |:  | |  :|");
                switch (raceChoice)
                {
                    case "1":
                        playerRace = Race.Rodians;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\nPress any key to continue...");
                        ConsoleKey user = Console.ReadKey(true).Key;
                        if (true)
                        {
                            chosen = true;
                        }
                        break;
                    case "2":
                        playerRace = Race.Trandoshan;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\nPress any key to continue...");
                        ConsoleKey user2 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            chosen = true;
                        }
                        break;
                    case "3":
                        playerRace = Race.Wookie;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\nPress any key to continue...");
                        ConsoleKey user3 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            chosen = true;
                        }
                        break;
                    case "4":
                        playerRace = Race.Mandalorian;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\nPress any key to continue...");
                        ConsoleKey user4 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            chosen = true;
                        }
                        break;
                    case "5":
                        playerRace = Race.Human;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\nPress any key to continue...");
                        ConsoleKey user5 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            chosen = true;
                        }
                        break;
                    case "6":
                        playerRace = Race.Duros;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\nPress any key to continue...");
                        ConsoleKey user6 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            chosen = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            } while (!validRace);
            Weapons type = new Weapons(4, 2, " Fists", 5, false, WeaponTypes.Fists);
            Player player = new Player(playerName, 40, 70, 5, playerRace, type);

            #endregion

            Console.Clear();
            Console.WriteLine("          ___\r\n         /---\\\r\n        | @ @:|\r\n        |  \" :|\r\n         \\_-_/\r\n       _.d._.b.__\r\n   +\"i\\  |\\_/|  /i\"+\r\n   [_| \\ |   | / |_]\r\n  .' |  ):===:(  | `.\r\n  |:.'+-\" | | \"-+`.:|\r\n  |_| |-. |_|   | |_|\r\n  \\:\\ |-' /+\\   ! |:|\r\n   \\ \\|n._\\+/_.n| / /\r\n    \\XT::::-::::T/ /\r\n     \"l-. `\"' .-lXX\r\n      |: \\   / :|\r\n      |:  i-i  :|\r\n      |:  | |  :| \r\n      |:  | |  :|\r\n     \\|;_ | |__;|/\r\n      (__() ()__)      \r\n      |:  | |  :|");
            Console.WriteLine("Before you get started here are some possible bounties, Then when you're ready to start collecting press any key...\n\n");
            Console.WriteLine("                      _    _  __  _  _ _____  ___ ___\r\n                      | /\\ | |__| |\\ |   |   |___ |  \\\r\n                      |/  \\| |  | | \\|   |   |___ |__/\r\n\r\n         F O R   C R I M E S   A G A I N S T   T H E   E M P I R E\r\n ________________________  _________________________  _______________________\r\n|        .......         ||      .x%%%%%%x.         ||  ,.------;:~~:-.      |\r\n|      ::::::;;::.       ||     ,%%%%%%%%%%%        || /:.\\`;;|||;:/;;:\\     |\r\n|    .::;::::;::::.      ||    ,%%%'  )'  \\%        ||:')\\`:\\||::/.-_':/)    |\r\n|   .::::::::::::::      ||   ,%x%) __   _ Y        ||`:`\\\\\\ ;'||'.''/,.:\\   |\r\n|   ::`_```_```;:::.     ||   :%%% ~=-. <=~|        ||==`;.:`|;::/'/./';;=   |\r\n|   ::=-) :=-`  ::::     ||   :%%::. .:,\\  |        ||:-/-%%% | |%%%;;_- _:  |\r\n| `::|  / :     `:::     ||   `;%:`\\. `-' .'        ||=// %wm)..(mw%`_ :`:\\  |\r\n|   '|  `~'     ;:::     ||    ``x`. -===-;         ||;;--', /88\\ -,- :-~~|  |\r\n|    :-:==-.   / :'      ||     / `:`.__.;          ||-;~~::'`~^~:`::`/`-=:) |\r\n|    `. _    .'.d8:      ||  .d8b.  :: ..`.         ||(;':)%%%' `%%%.`:``:)\\ |\r\n| _.  |88bood88888._     || d88888b.  '  /8         ||(\\ %%%/dV##Vb`%%%%:`-. |\r\n|~  `-+8888888888P  `-. _||d888888888b. ( 8b       /|| |);/( ;~~~~ :)\\`;;.``\\|\r\n|-'     ~~^^^^~~  `./8 ~ ||~   ~`888888b  `8b     /:|| //\\'/,/|;;|:(: |.|\\;|\\|\r\n|8b /  /  |   \\  \\  `8   ||  ' ' `888888   `8. _ /:/||/) |(/ | / \\|\\\\`( )- ` |\r\n|P        `          8   ||'      )88888b   8b |):X ||;):):)/.):|/) (`:`\\\\`-`|\r\n|                    8b  ||   ~ - |888888   `8b/:/:\\||;%/ //;/(\\`.':| ::`\\\\;`|\r\n|                    `8  ||       |888888    88\\/~~;||;/~( \\|./;)|.|):;\\. \\\\-|\r\n|                     8b ||       (888888b   88|  / ||/',:\\//) ||`.|| (:\\)):%|\r\n| LS      .           `8 ||\\       \\888888   8-:   /||,|/;/(%;.||| (|(\\:- ; :|\r\n|________/_\\___________8_||_\\_______\\88888_.'___\\__/||_%__%:__;_:`_;_:_.\\%_`_|\r\n\r\nL u k e  S k y w a l k e r      H a n   S o l o          C h e w b a c c a\r\n\r\nSelf-Proclaimed Jedi Knight     Smuggler, Pirate         Smuggler, Pirate\r\n     500,000 credits            200,000 Credits          100,000 credits\r\n\r\n               The above are wanted for the following crimes:\r\n\r\n    - Liberation of a known criminal, Princess Leia Organa of Alderaan -\r\n         - Direct involvement in armed revolt against the Empire -\r\n                              - High treason -\r\n                               - Espionage -\r\n                               - Conspiracy -\r\n                    - Destruction of Imperial Property -\r\n\r\n           These individuals are considered extremely dangerous.\r\n\r\n       E X P E R I E N C E D   B O U N T Y   H U N T E R S   O N L Y\r\n\r\n  The Empire will not  be held  responsible  for any  injuries or property\r\n  loss arising from the  attempted apprehension of these  notorious crimi-\r\n  nals. Bounty is for live capture only! For more information contact your\r\n  local Imperial Intelligence Office.");
            Console.ReadLine();
            Console.Clear();
            Console.Title = "+*+*+*+* LOADING *+*+*+*+";
            Console.WriteLine("                                               ____________\r\n                                --)-----------|____________|\r\n                                              ,'       ,'\r\n                -)------========            ,'  ____ ,'\r\n                         `.    `.         ,'  ,'__ ,'\r\n                           `.    `.     ,'       ,'\r\n                             `.    `._,'_______,'__\r\n                               [._ _| ^--      || |\r\n                       ____,...-----|__________ll_|\\\r\n      ,.,..-------\"\"\"\"\"     \"----'                 ||\r\n  .-\"\"  |=========================== ______________ |\r\n   \"-...l_______________________    |  |'      || |_]\r\n                                [`-.|__________ll_|      Incom's T-65B X-wing\r\n                              ,'    ,' `.        `.      Space Superiority\r\n                            ,'    ,'     `.    ____`.    Starfighter (2)\r\n                -)---------========        `.  `.____`.\r\n                                             `.        `.\r\n                                               `.________`.\r\n                               --)-------------|___________|");
            Console.WriteLine("\nLoading...");
            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            Console.Title = "*^*^*^*^*^* Star Wars: A Bounty Hunting Game *^*^*^*^*^*";




            #region Main Game Loop
            bool exit = false;
            string main;
            do
            {
                //TODID Generate a random room
                Console.WriteLine(GetRoom());

                //TODID Select a random monster to inhabit the room
                Bounties bounty = Bounties.GetBounty();
                Console.WriteLine($"{bounty.Name}, ");

                #region Gamplay menu loop
                bool reloadRoom = false;
                do
                {
                    //TODID Gameplay menu
                    Console.Write("\nPlease choose an action:\n" +
                       "A) Attack\n" +
                       "R) Run away\n" +
                       "P) Player Info\n" +
                       "B) Bounty Info\n" +
                       "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    //Weapons userweapons = Weapons.GetWeapon();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //Combat
                            SpaceCombat.DoBattle(player, bounty);
                            if (bounty.Life <= 0)
                            {
                                //combat rewards -> money, health, weapon
                                Console.ForegroundColor = ConsoleColor.Green;
                                //WeaponTypes userType = Weapons();
                                Weapons newWeapon = Weapons.GetWeapon();
                                Console.WriteLine($"You captured {bounty.Name}! You also found a {newWeapon.Name}.\n\n" +
                                    $"Would you like to trade your {player.EquippedWeapon.Name} for the {newWeapon.Name}? Y/N:");
                                ConsoleKey weaponInput = Console.ReadKey(true).Key;
                                if (weaponInput == ConsoleKey.Y)
                                {
                                    player.EquippedWeapon = newWeapon;
                                Console.WriteLine($"You took the {newWeapon.Name}");
                                }

                                Console.ResetColor();
                                //max life again
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                
                                Console.ResetColor();
                                //flip the inner-loop bool to true to get another monster
                                reloadRoom = true;
                                score++;
                            }

                            Console.WriteLine("CAPTURE THEM!!!!!!!!!!!!!!!!");
                            break;

                        case ConsoleKey.R:
                            // Attack of opportunity
                            Console.WriteLine($"{bounty.Name} attacks while you try to flee");
                            SpaceCombat.DoAttack(bounty, player);
                            Console.WriteLine();//formatting
                            reloadRoom = true;
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine("Player info: ");
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("Bounty info: ");
                            Console.WriteLine(bounty);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            Console.WriteLine("Maybe this life isn't for you, however you can always try again...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid input, please try again");
                            break;
                    }


                    //Check player life -> if loop
                    if (player.Life <= 0)
                    {
                        Console.WriteLine($"You died while trying to capture {bounty.Name}..... Shame, maybe the next Bounty Hunter will have better luck....");
                        exit = true;
                    }

                } while (reloadRoom != true && exit != true);
            } while (exit != true);
            #endregion
            //show the score
            Console.WriteLine("You captured " + score + " Bount" +
          (score == 1 ? "y." : "ies."));

            #endregion
        }//end main
        private static string GetRoom()
        {
            string[] rooms =
            {
                 "You have flown to a Yavin-4, the original base of operations for the Rebel Alliance. Becarful they don't take kindly to Bounty Hunters...",
                "You have tracked your bounty to Tatooine, a harsh desert world orbiting twin suns in the galaxy’s Outer Rim.\nYou better act fast as the world is heavly populated with other Bounty Hunters...",
                "You've landed on Coruscant and located your bounty in it's underworld. Becareful here. Your bounty isn't the only low life hiding here... ",
                "Your bounty has been spoted on Pagodon, an ice world, on the outter rim. Watch out for Ravinaks, there's a rumor they can drag ships under the ice...",
                 "A bounty was spotted on Jakku. A frontier desert world, Jakku is home to thieves, outlaws and scavengers.\n" +
                 "It also holds the remains of a massive battle between the Empire and Rebel forces...",
                 "You've landed in Cloud City, on Bespin, make sure you don't fall. It would be a long fall...",
                 "Welcome to Bracca, once in Imperial hands. Now belongs to the Scrappers Guild. There are many places for your bounty to hide. Good luck...",
            };

            Random rand = new Random();

            int index = rand.Next(rooms.Length);

            string room = rooms[index];
            //possible refacttor

            return room;
            //return room[new Random().Next(rooms.Length)];
        }//end GetRoom
    }
}