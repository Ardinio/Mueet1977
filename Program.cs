using System;

namespace museum1976
{
    class Program
    {
        static private int roomIndex;
        static private Random random;
        static private bool isFire;
        static private int roomOnFire;
        static private int points;
        private const int startFirer = 0;
        private const int randomnr = 10;


        static void Main(string[] args)
        {
            roomIndex = 0;
            random = new Random();
            isFire = false;
            roomOnFire = -1;
            points = 1;

            //The begining of the program
            Console.Clear();
            Console.WriteLine("Welcome to this museun");
            while (true)
            {
                //The first choice
                Console.WriteLine("To enter pay 15$ to enter [enter/leave]");
                string userInputMainMenu = Console.ReadLine().ToLower();

                //Enter or leave/ yes or no
                if (userInputMainMenu == "enter") break;
                else if (userInputMainMenu == "leave")
                {
                    Console.WriteLine(":(");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("something went wrong try agen");
                }

            }


            while (true)
            {
                //First room
                Console.Clear();
                if (roomIndex == 0)
                {
                    if (isFire)
                    {
                        Console.WriteLine($"You have made it to the lobby while the room's was on fire you'r score is: {points}");
                        Console.WriteLine("The lower points the better wanna try again write [first] to try again write [exit] to leave");
                    }
                    else
                    {
                        Console.WriteLine("You are in loby do you want to go to the first room or exit [first/stock/exit]");
                    }
                    //Reset variabler
                    isFire = false;
                    roomOnFire = -1;
                    points = 1;

                    string userInputLobby = Console.ReadLine().ToLower();

                    if (userInputLobby == "first")
                    {
                        roomIndex = 1;
                    }
                    else if (userInputLobby == "exit")
                    {
                        Console.WriteLine("Welcome Back");
                        Environment.Exit(0);
                    }
                    else if (userInputLobby == "stock")
                    {
                        Console.WriteLine("The stock is look. why do you want to go to the stock?[enter to continue]");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("something went wrong try agen [Enter to continue]");
                        Console.ReadLine();
                        continue;
                    }

                }
                else if (!isFire)
                {
                    CheckOnFire(roomIndex);
                }
                else
                {
                    points++;
                }
                Console.Clear();

                //Begin the guide
                switch (roomIndex)
                {
                    //All the room the room are numberd throw 1 to 6 
                    case 1:
                        while (true)
                        {
                            if (isFire)
                            {
                                Console.WriteLine("you ara in technology room but it is burning. Run");
                            }
                            else
                            {
                                //Give the alternativ to continue
                                Console.WriteLine("In the technology room you can see an old telephone that they had around the 1850s. You can also see the old steam trains and parts of a steamboat");
                            }
                            Console.WriteLine("Do you want to continue or go back to lobby [continue/back]");

                            string userInputRoom = Console.ReadLine().ToLower();

                            if (userInputRoom == "continue")
                            {
                                roomIndex++;
                                break;
                            }
                            else if (userInputRoom == "back")
                            {
                                roomIndex = 0;
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("something went wrong try agien");
                            }
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            if (isFire)
                            {
                                Console.WriteLine("You are in the Egyptian history room but it is burning. Run");
                            }
                            else
                            {
                                Console.WriteLine("In the Egyptian history room you can see pharaohs' coffins and wrapped mummies");
                            }
                            Console.WriteLine("Do you want to continue or go back to lobby [continue/back]");

                            string userInputRoom = Console.ReadLine().ToLower();

                            if (userInputRoom == "continue")
                            {
                                roomIndex++;
                                break;
                            }
                            else if (userInputRoom == "back")
                            {
                                roomIndex = 0;
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("something went wrong try agien");
                            }
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            if (isFire)
                            {
                                Console.WriteLine("You are in the Viking ans swedish histori room but it is burning. Run");
                            }
                            else
                            {
                                Console.WriteLine("In the Viking and Swedish histori room you can see the old Viking's ships and housing. You can also se old kultar and writing");
                            }
                            Console.WriteLine("Do you want to continue or go back to lobby [continue/back]");

                            string userInputRoom = Console.ReadLine().ToLower();

                            if (userInputRoom == "continue")
                            {
                                roomIndex++;
                                break;
                            }
                            else if (userInputRoom == "back")
                            {
                                roomIndex = 0;
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("something went wrong try agien");
                            }
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            if (isFire)
                            {
                                Console.WriteLine("You are in the prehistoric room but it is burning. Run");
                            }
                            else
                            {
                                Console.WriteLine("In the prehistoric room you can see big recreation of dinosaur and how their bones looks and you can also see the remains of a Megalodon");
                            }
                            Console.WriteLine("Do you want to continue or go back to lobby [continue/back]");


                            string userInputRoom = Console.ReadLine().ToLower();

                            if (userInputRoom == "continue")
                            {
                                roomIndex++;
                                break;
                            }
                            else if (userInputRoom == "back")
                            {
                                roomIndex = 0;
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("something went wrong try agien");
                            }
                        }
                        break;
                    case 5:
                        while (true)
                        {
                            if (isFire)
                            {
                                Console.WriteLine("You are in the European History room but it is burning. Run");
                            }
                            else
                            {
                                Console.WriteLine("In the European History Room you can see fantastic artifacts from ancient Rome, both status and writings. You can also see the old Germanic language.");
                            }
                            Console.WriteLine("Do you want to continue or go back to lobby [continue/back]");

                            string userInputRoom = Console.ReadLine().ToLower();

                            if (userInputRoom == "continue")
                            {
                                roomIndex++;
                                break;
                            }
                            else if (userInputRoom == "back")
                            {
                                roomIndex = 0;
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("something went wrong try agien");
                            }
                        }
                        break;
                    case 6:
                        if (isFire)
                        {
                            Console.WriteLine("You are at the coming soon big bang room but it is burning. Run");
                            Console.WriteLine("Run to the lobby");
                        }
                        else
                        {
                            Console.WriteLine("Well, in this room will it be about the creation of the universe but right now it is empty and therefore we will have to end our guide thanks for coming");
                        }
                        Console.WriteLine("[Press enter to exit the guide]");

                        Console.ReadLine();
                        roomIndex = 0;
                        break;
                }
            }
        }

        static private bool CheckOnFire(int roomIndex)
        {
            try
            {
                if (!isFire && random.Next(randomnr) == startFirer)
                {
                    isFire = true;
                    roomOnFire = roomIndex;
                    return true;
                }
                else if (isFire)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error fire");
                Console.ReadLine();
                return false;
            }
        }
    }
}

