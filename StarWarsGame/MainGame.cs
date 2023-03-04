using StarWarsGameLibrary;
namespace StarWarsGame
{
    internal class MainGame
    {
        static void Main(string[] args)
        {
Console.Title = "*^*^*^*^*^* Star Wars: A Bounty Hunting Game *^*^*^*^*^*";
Console.WriteLine("            ________   ___   ____\r\n           / __   __| / _ \\ |  _ \\\r\n     ______> \\ | |   |  _  ||    /_____________________________\r\n    / _______/ |_|   |_| |_||_|\\______________________________ \\\r\n   / /                                                        \\ \\\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                  A Bounty Hunter Game!                   | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n  | |                                                          | |\r\n   \\ \\____________________________    _   ___   ____   _______/ /\r\n    \\___________________________  |  | | / _ \\ |  _ \\ / _______/\r\n                                | |/\\| ||  _  ||    / > \\          \r\n                                 \\_/\\_/ |_| |_||_|\\_\\|__/");

            Console.WriteLine("\nPress any key to continue to main menu...");
            Console.ReadLine();
            Console.Clear();
            Console.Title = "+*+*+*+* LOADING MAIN MENU *+*+*+*+";
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
            Console.WriteLine("\n\nPlease Enter your Bounty Hunter's Name...");
            Console.ReadLine() ;
        }
    }
}