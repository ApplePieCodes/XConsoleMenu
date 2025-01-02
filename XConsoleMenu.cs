namespace XConsoleMenu
{
    public class XConsoleMenu
    {
        public static int DisplayMenu(string title, string[] menuItems, ConsoleColor foreground = ConsoleColor.Green, ConsoleColor background = ConsoleColor.Black, bool showNumbers = true)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;

            Console.Clear();

            int currentSelection = 0;

            while (true)
            {
                Console.WriteLine(title + "\n");

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == currentSelection)
                    {
                        Console.ForegroundColor = background;
                        Console.BackgroundColor = foreground;
                    }

                    if (showNumbers)
                    {
                        if (i <= 9)
                        {
                            if (i != 9)
                            {
                                Console.Write(i + 1 + ". ");
                            }
                            else
                            {
                                Console.Write("0. ");
                            }
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }

                    Console.WriteLine(menuItems[i]);

                    if (i == currentSelection)
                    {
                        Console.ForegroundColor = foreground;
                        Console.BackgroundColor = background;
                    }
                }

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        return 0;
                    case ConsoleKey.D2:
                        return 1;
                    case ConsoleKey.D3:
                        return 2;
                    case ConsoleKey.D4:
                        return 3;
                    case ConsoleKey.D5:
                        return 4;
                    case ConsoleKey.D6:
                        return 5;
                    case ConsoleKey.D7:
                        return 6;
                    case ConsoleKey.D8:
                        return 7;
                    case ConsoleKey.D9:
                        return 8;
                    case ConsoleKey.D0:
                        return 9;
                    case ConsoleKey.UpArrow:
                        if (currentSelection > 0)
                        {
                            currentSelection--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (currentSelection < menuItems.Length - 1)
                        {
                            currentSelection++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        return currentSelection;
                }
            }
        }
    }
}
