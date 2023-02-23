using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;


namespace StreetCricket  // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static string User1_Name, User2_Name, User3_Name, User4_Name, winner;
        static int overs = 0, ball = 0, toss;
        static int total, total1, total2, total3;
        static int user1 = 0, user2 = 0, user3 = 0, user4 = 0;
        static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        //TOSS
        static int SinglePlayertoss()
        {
            int randomint, result = -1;
            int b = 0;
            int a = 0;
            while (b != 1)
            {
                try
                {
                    while (a != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ENTER 1 FOR HEAD AND 2 FOR TAIL : ");
                        toss = Convert.ToInt32(Console.ReadLine());
                        if (toss > 0 && toss < 3)
                        {
                            b = 1;
                            a = 1;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Input!!\n");
                        }
                    }
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input..Must be a number\n");
                }
            }

            switch (toss)
            {
                case 1:
                    {
                        Random rnd = new Random();
                        randomint = rnd.Next(1, 3);
                        if (randomint == 1)
                        {
                            Console.WriteLine("Its HEAD : YOU won the toss!");
                            Console.WriteLine("YOU will bat first!");
                            Console.WriteLine();
                            result = 1;
                        }
                        else if (randomint == 2)
                        {
                            Console.WriteLine("Its TAIL : BOT won the toss!");
                            Console.WriteLine("BOT will bat first!");
                            Console.WriteLine();
                            result = 0;
                        }
                        break;
                    }
                case 2:
                    {
                        Random rnd = new Random();
                        randomint = rnd.Next(1, 3);
                        if (randomint == 1)
                        {
                            Console.WriteLine("Its HEAD : BOT won the toss!");
                            Console.WriteLine("BOT will bat first!");
                            Console.WriteLine();
                            result = 0;
                        }
                        else if (randomint == 2)
                        {
                            Console.WriteLine("Its TAIL : YOU won the toss!");
                            Console.WriteLine("YOU will bat first!");
                            Console.WriteLine();
                            result = 1;
                        }
                        break;
                    }
            }
            return result;
        }
        static int MultiPlayerToss(string User1_Name, string User2_Name)
        {
            int toss = -1, result = -1, randomint;
            Random rnd = new Random();
            randomint = rnd.Next(1, 3);
            if (randomint == 1)
            {
                int a = 0, b = 0;
                while (b != 1)
                {
                    try
                    {
                        while (a != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{User1_Name.ToUpper()} please choose HEAD or TAIL for toss.");
                            Console.Write("ENTER 1 FOR HEAD AND 2 FOR TAIL : ");
                            toss = Convert.ToInt32(Console.ReadLine());
                            if (toss > 0 && toss < 3)
                            {
                                b = 1;
                                a = 1;
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input!!\n");
                            }
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input..Must be a number\n");
                    }
                }
                int coinTossed = rnd.Next(1, 3);
                switch (toss)
                {
                    case 1:
                        {
                            if (coinTossed == 1)
                            {
                                Console.WriteLine($"Its HEAD : {User1_Name.ToUpper()} won the toss!");
                                Console.WriteLine($"{User1_Name.ToUpper()} you will bat first!");
                                result = 0;
                            }
                            else if (coinTossed == 2)
                            {
                                Console.WriteLine($"Its TAIL : {User2_Name.ToUpper()} won the toss!");
                                Console.WriteLine($"{User2_Name.ToUpper()} will bat first!");
                                result = 1;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (coinTossed == 1)
                            {
                                Console.WriteLine($"Its HEAD : {User2_Name.ToUpper()} won the toss!");
                                Console.WriteLine($"{User2_Name.ToUpper()} will bat first!");
                                result = 1;
                            }
                            else if (coinTossed == 2)
                            {
                                Console.WriteLine($"Its TAIL : {User1_Name.ToUpper()} won the toss!");
                                Console.WriteLine($"{User1_Name.ToUpper()} you will bat first!");
                                result = 0;
                            }
                            break;
                        }
                }
            }
            else if (randomint == 2)
            {
                int a = 0, b = 0;
                while (b != 1)
                {
                    try
                    {
                        while (a != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{User2_Name.ToUpper()} please choose HEAD or TAIL for toss.");
                            Console.Write("ENTER 1 FOR HEAD AND 2 FOR TAIL : ");
                            toss = Convert.ToInt32(Console.ReadLine());
                            if (toss > 0 && toss < 3)
                            {
                                b = 1;
                                a = 1;
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input!!\n");
                            }
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input..Must be a number\n");
                    }
                }
                int coinTossed = rnd.Next(1, 3);
                switch (toss)
                {
                    case 1:
                        {
                            if (coinTossed == 1)
                            {
                                Console.WriteLine($"Its HEAD : {User2_Name.ToUpper()} won the toss!");
                                Console.WriteLine($"{User2_Name.ToUpper()} you will bat first!");
                                result = 1;
                            }
                            else if (coinTossed == 2)
                            {
                                Console.WriteLine($"Its TAIL : {User1_Name.ToUpper()} won the toss!");
                                Console.WriteLine($"{User1_Name.ToUpper()} will bat first!");
                                result = 0;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (coinTossed == 1)
                            {
                                Console.WriteLine($"Its HEAD : {User1_Name.ToUpper()} won the toss!");
                                Console.WriteLine($"{User1_Name.ToUpper()} will bat first!");
                                result = 0;
                            }
                            else if (coinTossed == 2)
                            {
                                Console.WriteLine($"Its TAIL : {User2_Name.ToUpper()} won the toss!");
                                Console.WriteLine($"{User2_Name.ToUpper()} you will bat first!");
                                result = 1;
                            }
                            break;
                        }
                }
            }
            return result;
        }


        // Overs 
        static void over()
        {
            int b = 0;
            int a = 0;
            while (b != 1)
            {
                try
                {
                    while (a != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("ENTER OVERS (Must be less than or equal to 5) : ");
                        overs = Convert.ToInt32(Console.ReadLine());
                        if ((overs > 0) && (overs <= 5))
                        {
                            ball = overs * 6;
                            a = 1;
                            b = 1;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("INVALID INPUT\n");
                        }
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input must be a number less than or equal to 5\n");
                }
            }

        }
        //RULES OF GAME
        static void Singleplayerrule()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("Single Player Game Rules:");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("[1]This gameplay is between user and computer.");
            Console.WriteLine("[2]It will be a limited overs match (5 Maximum).");
            Console.WriteLine("[3]The team with more runs will win in the limited over match.");
            Console.WriteLine("[4]Enter runs from \"1-6\" otherwise it will be considered as \"0\".");
            Console.WriteLine("");
            Console.WriteLine("{0,35}", "GOOD LUCK");
            Console.WriteLine();
            SinglePlayerMatch();
        }
        static void Multiplayerrule()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("MultiPlayer Game Rules:");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("[1]You can play with your friends and challenge them");
            Console.WriteLine("[2]You are not allowed to watch screen while rival is batting");
            Console.WriteLine("[3]The team with more runs will win in the limited over match.");
            Console.WriteLine("[4]Enter runs from \"1-6\" otherwise it will be considered as \"0\".");
            Console.WriteLine("");
            Console.WriteLine("{0,35}", "GOOD LUCK");
            MultiPlayerMatch();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        static void Tournamentrule()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("Tournament Game Rules:");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.WriteLine("[1]Enter runs from \"1-6\" otherwise it will be considered as \"0\".");
            Console.WriteLine("[2]It allows you to play with 4 players");
            Console.WriteLine("[3]You are not allowed to watch screen while rival is batting");
            Console.WriteLine("[4]The user wins the final will win the Tournament Championship ");
            Console.WriteLine("");
            Console.WriteLine("{0,35}", "GOOD LUCK");
            Console.WriteLine();
            TournamentMatch();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        //GAME BEGINS
        static void SinglePlayerMatch()
        {
            int comp;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            try
            {
                Console.Write("Enter your Name : ");
                User1_Name = Console.ReadLine();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Name");
            }
            if (User1_Name == "") User1_Name = "player1";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            //overs
            over();
            Console.WriteLine();
            switch (SinglePlayertoss())
            {
                case 0:
                    {
                        Console.WriteLine("\n\n\t ------------------------------------");
                        Console.WriteLine("\t\t  FIRST INNINGS");
                        Console.WriteLine("\t\t  BOT's BATING!");
                        Console.WriteLine("\t ------------------------------------");
                        for (int j = 0; j < ball; j++)
                        {
                            Random rnd = new Random();
                            comp = rnd.Next(1, 7);
                            Console.Write($"{User1_Name.ToUpper()} scores : ");
                            try
                            {
                                user1 = Convert.ToInt32(Console.ReadLine());
                                if (user1 < 1 || user1 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user1 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) ");
                                }
                            }
                            catch
                            {
                                user1 = 0;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Rule Violated.. (0 run)");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("BOT scored : " + comp);
                            Console.WriteLine();
                            if (user1 != comp)
                            {
                                total1 = total1 + comp;
                            }
                            else if (user1 == comp)
                            {
                                break;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t  ------------------------------------");
                        Console.WriteLine("\t\t  INNINGS END");
                        Console.WriteLine($"\t\t BOT scored : {total1}");
                        Console.WriteLine("\t  ------------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\n***TEA_BREAK**\n\n");
                        Console.WriteLine("\n\n\t ------------------------------------");
                        Console.WriteLine("\t\t  SECOND INNINGS");
                        Console.WriteLine($"\t\t {User1_Name.ToUpper()}'s BATING!");
                        Console.WriteLine("\t ------------------------------------");
                        for (int i = 0; i < ball; i++)
                        {
                            Console.Write($"{User1_Name.ToUpper()} scores : ");
                            try
                            {
                                user1 = Convert.ToInt32(Console.ReadLine());
                                if (user1 < 1 || user1 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user1 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) ");
                                }
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                user1 = 0;
                                Console.WriteLine("Rule Violated.. (0 run) ");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Random rnd = new Random();
                            comp = rnd.Next(1, 7);
                            Console.WriteLine("BOT scored : " + comp);
                            Console.WriteLine();
                            if (user1 != comp)
                            {
                                total = total + user1;
                            }
                            else if (user1 == comp)
                            {
                                break;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t  ------------------------------------");
                        Console.WriteLine("\t\t   INNINGS END");
                        Console.WriteLine($"\t\t  YOU scored : {total}");
                        Console.WriteLine("\t  ------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("\n\n\t ------------------------------------");
                        Console.WriteLine("\t\t   FIRST INNINGS");
                        Console.WriteLine($"\t\t  {User1_Name.ToUpper()}'s BATING!");
                        Console.WriteLine("\t ------------------------------------");
                        for (int i = 0; i < ball; i++)
                        {
                            Console.Write($"{User1_Name.ToUpper()} scores : ");
                            try
                            {
                                user1 = Convert.ToInt32(Console.ReadLine());
                                if (user1 < 1 || user1 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user1 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) ");
                                }
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                user1 = 0;
                                Console.WriteLine("Rule Violated.. (0 run) ");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Random rnd = new Random();
                            comp = rnd.Next(1, 7);
                            Console.WriteLine("BOT scored : " + comp);
                            Console.WriteLine();
                            if (user1 != comp)
                            {
                                total = total + user1;
                            }
                            else if (user1 == comp)
                            {
                                break;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t  ------------------------------------");
                        Console.WriteLine("\t\t     INNINGS END");
                        Console.WriteLine($"\t\t  YOU scored : {total}");
                        Console.WriteLine("\t  ------------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\n***TEA_BREAK**\n\n");
                        Console.WriteLine("\n\n\t ------------------------------------");
                        Console.WriteLine("\t\t  SECOND INNINGS");
                        Console.WriteLine("\t\t  BOT's BATING!");
                        Console.WriteLine("\t ------------------------------------");
                        for (int j = 0; j < ball; j++)
                        {
                            Random rnd = new Random();
                            comp = rnd.Next(1, 7);
                            Console.Write($"{User1_Name.ToUpper()} scores : ");
                            try
                            {
                                user1 = Convert.ToInt32(Console.ReadLine());
                                if (user1 < 1 || user1 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user1 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) ");
                                }
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                user1 = 0;
                                Console.WriteLine("Rule Violated.. (0 run)");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("BOT scored : " + comp);
                            Console.WriteLine();
                            if (user1 != comp)
                            {
                                total1 = total1 + comp;
                            }
                            else if (user1 == comp)
                            {
                                break;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t  ------------------------------------");
                        Console.WriteLine($"\t\t  BOT scored : {total1}");
                        Console.WriteLine("\t\t   INNINGS END");
                        Console.WriteLine("\t  ------------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("INVALID INPUT");
                        break;
                    }
            }
            Console.Write("Press Enter for Game Results : ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n***GAME RESULTS*\n");
            string winner = null;
            if (total > total1)
            {
                winner = $"{User1_Name.ToUpper()} wins";
                Console.WriteLine("\t\t  ------------------------------------");
                Console.WriteLine($"\t\t\t  {User1_Name.ToUpper()} WINS");
                Console.WriteLine("\t\t  ------------------------------------");
            }
            else if (total1 > total)
            {
                winner = "BOT wins";
                Console.WriteLine("\t\t  ------------------------------------");
                Console.WriteLine($"\t\t\t  BOT WINS");
                Console.WriteLine("\t\t  ------------------------------------");
            }
            else
            {
                winner = "Match Tied";
                Console.WriteLine("\t\t  ------------------------------------");
                Console.WriteLine($"\t\t\t  {winner}");
                Console.WriteLine("\t\t  ------------------------------------");
            }


            // Console.WriteLine("-------------------------------");
            // Console.WriteLine("Total = " + total);
            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("----------Computer Bats-----------");



            // Console.WriteLine("-------------------------------");
            // Console.WriteLine("total=" + total1);

            string filename = @"SinglePlayerMatchRecord.txt";
            FileStream stream = null;
            try
            {
                stream = new FileStream(filename, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine();
                    writer.WriteLine("-------------");
                    writer.WriteLine("Score Record");
                    writer.WriteLine("-------------");
                    writer.WriteLine("Single Player Match");
                    writer.WriteLine("{1} Scored: {0}", total, User1_Name);
                    writer.WriteLine("Bot Scored: {0}", total1);
                    writer.WriteLine(winner);
                }
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do you want to play again?");
            Console.Write("Choose yes or no : ");
            string play = "";
            try
            {
                play = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            if (play.ToLower() == "yes")
            {
                Main();
            }
        }
        static void MultiPlayerMatch()
        {
            Console.Write("Player-1 enter your name : ");
            User1_Name = Console.ReadLine();
            Console.Write("Player-2 enter your name : ");
            User2_Name = Console.ReadLine();
            Console.WriteLine();
            if (User1_Name == "") User1_Name = "player1";
            if (User2_Name == "") User2_Name = "player2";
            over();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n\t\t {User1_Name.ToUpper()}   VS   {User2_Name.ToUpper()}");
            Console.WriteLine("------------------------------------------------------------------\n\n");
            //Multiplayer Match
            GamePlay(ref winner, user1, user2, ref total, ref total1, User1_Name, User2_Name);
            string filename = @"MultiPlayerMatchRecord.txt";
            FileStream stream = null;
            try
            {
                stream = new FileStream(filename, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("Score Record");
                    writer.WriteLine("__");
                    writer.WriteLine("Multi Player Match");
                    writer.WriteLine($"{User1_Name.ToUpper()} Score: {total}");
                    writer.WriteLine($"{User2_Name.ToUpper()} Score: {total1}");
                    writer.WriteLine(winner);
                    writer.WriteLine();
                }
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do you want to play again?");
            Console.Write("Choose Yes or No : ");
            string play = Console.ReadLine();
            if (play.ToLower() == "yes")
            {
                Main();
            }
            else
                Console.WriteLine("Good Bye");

        }
        static void TournamentMatch()
        {
            //match1
            Console.Write("Player-1 enter your name : ");
            User1_Name = Console.ReadLine();
            Console.Write("Player-2 enter your name : ");
            User2_Name = Console.ReadLine();
            Console.Write("Player-3 enter your name : ");
            User3_Name = Console.ReadLine();
            Console.Write("Player-4 enter your name : ");
            User4_Name = Console.ReadLine();
            Console.WriteLine();
            //toss
            if (User1_Name == "") User1_Name = "player1";
            if (User2_Name == "") User2_Name = "player2";
            if (User3_Name == "") User3_Name = "player3";
            if (User4_Name == "") User4_Name = "player4";
            over();
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("\t\t\t*MATCh 1*");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"\t\t {User1_Name.ToUpper()}   VS   {User2_Name.ToUpper()}");
            Console.WriteLine("------------------------------------------------------------------\n");
            GamePlay(ref winner, user1, user2, ref total, ref total1, User1_Name, User2_Name);
            Console.Write("Press any key to Continue");
            Console.ReadLine();
            Console.Clear();

            string filename = @"TournamentMatch1Record.txt";
            FileStream stream = null;
            try
            {
                stream = new FileStream(filename, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("Score Record");
                    writer.WriteLine("__");
                    writer.WriteLine("Tournament Match 1");
                    writer.WriteLine($"{User1_Name.ToUpper()} Score: {total}");
                    writer.WriteLine($"{User2_Name.ToUpper()} Score: {total1}");
                    writer.WriteLine(winner);
                    writer.WriteLine();
                }
            }

            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("\t\t\t*MATCh 2*");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"\t\t {User3_Name.ToUpper()}   VS   {User4_Name.ToUpper()}");
            Console.WriteLine("------------------------------------------------------------------\n");
            GamePlay(ref winner, user3, user4, ref total2, ref total3, User3_Name, User4_Name);
            Console.Write("Press any key to Continue");
            Console.ReadLine();
            Console.Clear();
            string filename2 = @"TournamentMatch2Record.txt";
            FileStream stream2 = null;
            try
            {
                stream2 = new FileStream(filename2, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(stream2, Encoding.UTF8))
                {
                    writer.WriteLine("Score Record");
                    writer.WriteLine("__");
                    writer.WriteLine("Tournament Match 1");
                    writer.WriteLine($"{User3_Name.ToUpper()} Score: {total2}");
                    writer.WriteLine($"{User4_Name.ToUpper()} Score: {total3}");
                    writer.WriteLine(winner);
                    writer.WriteLine();
                }
            }

            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }

            string filenameFinal = @"FinalMatchRecord.txt";
            FileStream fs = null;

            // fs = new FileStream(filenameFinal, FileMode.Append);
            // using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("\t\t\t*FINAL MATCh*");
            //final condition1
            if (total > total1 && total2 > total3)
            {
                total = 0; total2 = 0;
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"\t\t {User1_Name.ToUpper()}   VS   {User3_Name.ToUpper()}");
                Console.WriteLine("------------------------------------------------------------------\n");
                GamePlay(ref winner, user1, user3, ref total, ref total2, User1_Name, User3_Name);
                Console.Write("Press any key to Continue");
                Console.ReadLine();
                Console.Clear();
                try
                {
                    fs = new FileStream(filenameFinal, FileMode.Append);
                    using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                    {
                        writer.WriteLine("Score Record");
                        writer.WriteLine("__");
                        writer.WriteLine("Final Match");
                        writer.WriteLine($"{User1_Name.ToUpper()} Score: {total}");
                        writer.WriteLine($"{User3_Name.ToUpper()} Score: {total2}");
                        writer.WriteLine(winner);
                        writer.WriteLine();
                    }
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                }
            }

            // final condition2
            else if (total1 > total && total3 > total2)
            {
                total1 = 0; total3 = 0;
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"\t\t {User2_Name.ToUpper()}   VS   {User4_Name.ToUpper()}");
                Console.WriteLine("------------------------------------------------------------------\n");
                GamePlay(ref winner, user2, user4, ref total1, ref total3, User2_Name, User4_Name);
                Console.Write("Press any key to Continue");
                Console.ReadLine();
                Console.Clear();
                try
                {
                    fs = new FileStream(filenameFinal, FileMode.Append);
                    using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                    {
                        writer.WriteLine("Score Record");
                        writer.WriteLine("__");
                        writer.WriteLine("Final Match");
                        writer.WriteLine($"{User2_Name.ToUpper()} Score: {total1}");
                        writer.WriteLine($"{User4_Name.ToUpper()} Score: {total3}");
                        writer.WriteLine(winner);
                        writer.WriteLine();
                    }
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                }
            }
            //final condition 3
            else if (total > total1 && total3 > total2)
            {
                total = 0; total3 = 0;
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"\t\t {User1_Name.ToUpper()}   VS   {User4_Name.ToUpper()}");
                Console.WriteLine("------------------------------------------------------------------\n");
                //toss
                GamePlay(ref winner, user1, user4, ref total, ref total3, User1_Name, User4_Name);
                Console.Write("Press any key to Continue");
                Console.ReadLine();
                Console.Clear();
                try
                {
                    fs = new FileStream(filenameFinal, FileMode.Append);
                    using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                    {
                        writer.WriteLine("Score Record");
                        writer.WriteLine(" __");
                        writer.WriteLine("Final Match");
                        writer.WriteLine($"{User1_Name.ToUpper()} Score: {total}");
                        writer.WriteLine($"{User4_Name.ToUpper()} Score: {total3}");
                        writer.WriteLine(winner);
                        writer.WriteLine();
                    }
                }
                catch
                {
                    Console.WriteLine("An error Occured");
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                }
            }

            //final condition4
            else if (total1 > total && total2 > total3)
            {
                total1 = 0; total2 = 0;
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"\t\t {User2_Name.ToUpper()}   VS   {User3_Name.ToUpper()}");
                Console.WriteLine("------------------------------------------------------------------\n");
                GamePlay(ref winner, user2, user3, ref total1, ref total2, User2_Name, User3_Name);
                Console.Write("Press any key to Continue");
                Console.ReadLine();
                Console.Clear();
                try
                {
                    fs = new FileStream(filenameFinal, FileMode.Append);
                    using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                    {
                        writer.WriteLine("Score Record");
                        writer.WriteLine("__");
                        writer.WriteLine("Final Match");
                        writer.WriteLine($"{User2_Name.ToUpper()} Score: {total1}");
                        writer.WriteLine($"{User3_Name.ToUpper()} Score: {total2}");
                        writer.WriteLine(winner);
                        writer.WriteLine();
                    }
                }

                finally
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do you want to play again?");
            Console.Write("Choose Yes or No : ");
            string play = Console.ReadLine();
            if (play.ToLower() == "yes")
            {
                Main();
            }
            else
                Console.WriteLine("Good Bye");
        }
        static void GamePlay(ref string winner, int user1, int user2, ref int total, ref int total1, string User1_Name, string User2_Name)
        {
            switch (MultiPlayerToss(User1_Name, User2_Name))
            {
                case 0:
                    {
                        Console.WriteLine("\n\n\t ------------------------------------");
                        Console.WriteLine("\t\t  FIRST INNINGS");
                        Console.WriteLine($"\t\t  {User1_Name}'s BATING!");
                        Console.WriteLine("\t ------------------------------------");
                        for (int i = 0; i < ball; i++)
                        {
                            Console.Write("{0} scores : ", User1_Name.ToUpper());
                            try
                            {
                                user1 = Convert.ToInt32(Console.ReadLine());
                                if (user1 < 1 || user1 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user1 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) \n\n");
                                }
                            }
                            catch
                            {
                                user1 = 0;

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Rule Violated.. (0 run)\n\n");
                            }
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("{0} scores : ", User2_Name.ToUpper());
                            try
                            {
                                user2 = Convert.ToInt32(Console.ReadLine());
                                if (user2 < 1 || user2 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user2 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) \n\n");
                                }
                            }
                            catch
                            {
                                user2 = 0;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Rule Violated.. (0 run)\n\n");
                            }
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{User1_Name.ToUpper()} scored : {user1}");
                            Console.WriteLine($"{User2_Name.ToUpper()} scored : {user2}");
                            Console.WriteLine();
                            if (user1 != user2)
                            {
                                total = total + user1;
                            }
                            else if (user1 == user2)
                            {
                                break;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t  ------------------------------------");
                        Console.WriteLine("\t\t  INNINGS END");
                        Console.WriteLine($"\t\t {User1_Name.ToUpper()} scored : {total}");
                        Console.WriteLine("\t  ------------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\n***TEA_BREAK**\n\n");
                        Console.WriteLine("\n\n\t ------------------------------------");
                        Console.WriteLine("\t\t  SECOND INNINGS");
                        Console.WriteLine($"\t\t {User2_Name.ToUpper()}'s BATING!");
                        Console.WriteLine("\t ------------------------------------");
                        for (int j = 0; j < ball; j++)
                        {
                            Console.Write("{0} scores : ", User2_Name.ToUpper());
                            try
                            {
                                user2 = Convert.ToInt32(Console.ReadLine());
                                if (user2 < 1 || user2 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user2 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) \n\n");
                                }
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                user2 = 0;
                                Console.WriteLine("Rule Violated.. (0 run) \n\n");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                            Console.Write("{0} scores : ", User1_Name.ToUpper());
                            try
                            {
                                user1 = Convert.ToInt32(Console.ReadLine());
                                if (user1 < 1 || user1 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user1 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) \n\n");
                                }
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                user1 = 0;
                                Console.WriteLine("Rule Violated.. (0 run) \n\n");
                            }
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{User2_Name.ToUpper()} scored : {user2}");
                            Console.WriteLine($"{User1_Name.ToUpper()} scored : {user1}");
                            Console.WriteLine();
                            if (user1 != user2)
                            {
                                total1 = total1 + user2;
                            }
                            else if (user1 == user2)
                            {
                                break;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t  ------------------------------------");
                        Console.WriteLine("\t\t   INNINGS END");
                        Console.WriteLine($"\t\t  {User2_Name.ToUpper()} scored : {total1}");
                        Console.WriteLine("\t  ------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("\n\n\t ------------------------------------");
                        Console.WriteLine("\t\t  FIRST INNINGS");
                        Console.WriteLine($"\t\t  {User2_Name}'s BATING!");
                        Console.WriteLine("\t ------------------------------------");
                        for (int i = 0; i < ball; i++)
                        {
                            Console.Write("{0} scores : ", User2_Name.ToUpper());
                            try
                            {
                                user2 = Convert.ToInt32(Console.ReadLine());
                                if (user2 < 1 || user2 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user2 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) \n\n");
                                }
                            }
                            catch
                            {
                                user2 = 0;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Rule Violated.. (0 run)\n\n");
                            }
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("{0} scores : ", User1_Name.ToUpper());
                            try
                            {
                                user1 = Convert.ToInt32(Console.ReadLine());
                                if (user1 < 1 || user1 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user1 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) \n\n");
                                }
                            }
                            catch
                            {
                                user1 = 0;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Rule Violated.. (0 run)\n\n");
                            }
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{User2_Name.ToUpper()} scored : {user2}");
                            Console.WriteLine($"{User1_Name.ToUpper()} scored : {user1}");
                            Console.WriteLine();
                            if (user1 != user2)
                            {
                                total1 = total1 + user2;
                            }
                            else if (user1 == user2)
                            {
                                break;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t  ------------------------------------");
                        Console.WriteLine("\t\t  INNINGS END");
                        Console.WriteLine($"\t\t {User2_Name.ToUpper()} scored : {total1}");
                        Console.WriteLine("\t  ------------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\n***TEA_BREAK**\n\n");
                        Console.WriteLine("\n\n\t ------------------------------------");
                        Console.WriteLine("\t\t  SECOND INNINGS");
                        Console.WriteLine($"\t\t {User1_Name.ToUpper()}'s BATING!");
                        Console.WriteLine("\t ------------------------------------");
                        for (int j = 0; j < ball; j++)
                        {
                            Console.Write("{0} scores : ", User1_Name.ToUpper());
                            try
                            {
                                user1 = Convert.ToInt32(Console.ReadLine());
                                if (user1 < 1 || user1 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user1 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) \n\n");
                                }
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                user1 = 0;
                                Console.WriteLine("Rule Violated.. (0 run) \n\n");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                            Console.Write("{0} scores : ", User2_Name.ToUpper());
                            try
                            {
                                user2 = Convert.ToInt32(Console.ReadLine());
                                if (user2 < 1 || user2 > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    user2 = 0;
                                    Console.WriteLine("Rule Violated.. (0 run) \n\n");
                                }
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                user2 = 0;
                                Console.WriteLine("Rule Violated.. (0 run) \n\n");
                            }
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{User1_Name.ToUpper()} scored : {user1}");
                            Console.WriteLine($"{User2_Name.ToUpper()} scored : {user2}");
                            Console.WriteLine();
                            if (user1 != user2)
                            {
                                total = total + user1;
                            }
                            else if (user1 == user2)
                            {
                                break;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t  ------------------------------------");
                        Console.WriteLine("\t\t   INNINGS END");
                        Console.WriteLine($"\t\t  {User1_Name.ToUpper()} scored : {total}");
                        Console.WriteLine("\t  ------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
            }
            Console.Write("Press Enter for Game Results : ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n***GAME RESULTS*\n");
            winner = null;
            if (total > total1)
            {
                winner = $"{User1_Name.ToUpper()} wins";
                Console.WriteLine("\t\t  ------------------------------------");
                Console.WriteLine($"\t\t\t  {User1_Name.ToUpper()} WINS");
                Console.WriteLine("\t\t  ------------------------------------");
            }
            else if (total1 > total)
            {
                winner = $"{User2_Name.ToUpper()} wins";
                Console.WriteLine("\t\t  ------------------------------------");
                Console.WriteLine($"\t\t\t    {User2_Name.ToUpper()} WINS");
                Console.WriteLine("\t\t  ------------------------------------");
            }
            else
            {
                winner = "Match Tied";
                Console.WriteLine("\t\t  ------------------------------------");
                Console.WriteLine($"\t\t\t  {winner}");
                Console.WriteLine("\t\t  ------------------------------------");
            }


        }
        static void GameMenu()
        {

            Console.WriteLine(" MAIN MENU:");
            Console.WriteLine("CHOOSE OPTION");
            Console.WriteLine("[1] Play Single Player Match");
            Console.WriteLine("[2] Play MultiPlayer Match");
            Console.WriteLine("[3] Play Tournament Matches");
            Console.WriteLine("[0] To Exit ");
            Console.WriteLine("");
        }
        static void Main()
        {
            user1 = 0; user2 = 0; user3 = 0; user4 = 0; total = 0; total1 = 0; total2 = 0; total3 = 0;
            User1_Name = ""; User2_Name = ""; User3_Name = ""; User4_Name = ""; winner = "";
            overs = 0; ball = 0; toss = -1;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t   STREET CRICKET");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\t\tCREATED BY :\n");
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t*_ Mutayyab Imran\t\t\t-->\t[02-131212-063]");
            Console.WriteLine("\t\t*_ Mutayyab Imran \t\t\t-->\t[02-131212-063]");
            Console.WriteLine("\t\t*_ Mutayyab Imran \t\t\t-->\t[02-131212-063]");
            // Console.WriteLine("{0,55}", "|-------------------------|");
            //Console.WriteLine("{0,55}", "|WELCOME TO STREET CRICKET|");
            // Console.WriteLine("{0,55}", "|-------------------------|");

            int i = 1;
            while (i != 0)
            {
                GameMenu();
                int reply = -1;
                int b = 0, a = 0;
                while (b != 1)
                {
                    try
                    {
                        while (a != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("CHOOSE ANYONE OPTION : ");
                            reply = Convert.ToInt32(Console.ReadLine());
                            if (reply >= 0 && reply <= 3)
                            {
                                b = 1;
                                a = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input\n");
                            }
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only Choose from 0-3");
                    }
                }
                switch (reply)
                {
                    case 0:
                        break;
                    case 1:
                        Singleplayerrule();
                        break;
                    case 2:
                        Multiplayerrule();
                        break;
                    case 3:
                        Tournamentrule();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                i = 0;


            }
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();




        }



    }
}