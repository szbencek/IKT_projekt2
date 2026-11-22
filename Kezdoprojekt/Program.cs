using System;

namespace KonzolosRajzolo
{
    class Program
    {
        static int width;
        static int height;
        static int menuWidth;
        static int drawingWidth;

        static int rajzKezdoX;
        static int rajzKezdoY = 2;
        static int rajzSzelesseg;
        static int rajzMagassag;

        static char[,] lapKarakter;
        static ConsoleColor[,] lapSzin;

        static int x = 0;
        static int y = 0;
        static char karakter = '#';
        static ConsoleColor szin = ConsoleColor.Cyan;
        static bool tollLent = false;

        static string uzenet = "";

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            width = Console.WindowWidth;
            height = Console.WindowHeight;

            if (width < 60) width = 60;
            if (height < 22) height = 22;

            menuWidth = width / 3;
            drawingWidth = width - menuWidth;

            rajzKezdoX = menuWidth + 2;
            rajzSzelesseg = drawingWidth - 3;
            rajzMagassag = height - rajzKezdoY - 1;

            UresRajzlap();
            ElvalasztoEsFejlec();

            bool fut = true;
            while (fut)
            {
                BalOldalKirajzolasa();
                RajzlapKirajzolasa();

                ConsoleKeyInfo bill = Console.ReadKey(true);
                uzenet = "";

                fut = RajzVezerles(bill);
            }

            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = true;
        }

        static void UresRajzlap()
        {
            lapKarakter = new char[rajzMagassag, rajzSzelesseg];
            lapSzin = new ConsoleColor[rajzMagassag, rajzSzelesseg];

            for (int sor = 0; sor < rajzMagassag; sor++)
            {
                for (int oszlop = 0; oszlop < rajzSzelesseg; oszlop++)
                {
                    lapKarakter[sor, oszlop] = ' ';
                    lapSzin[sor, oszlop] = ConsoleColor.White;
                }
            }
        }

        static void ElvalasztoEsFejlec()
        {
            Console.Clear();

            for (int sor = 0; sor < height; sor++)
            {
                Console.SetCursorPosition(menuWidth, sor);
                Console.Write("|");
            }

            Console.SetCursorPosition(menuWidth + 2, 0);
            Console.Write("Rajzlap");
        }

        static void BalOldalKirajzolasa()
        {
            for (int sor = 0; sor < height; sor++)
            {
                Console.SetCursorPosition(0, sor);
                for (int oszlop = 0; oszlop < menuWidth; oszlop++)
                {
                    Console.Write(" ");
                }
            }

            Console.SetCursorPosition(0, 0);
            Console.Write(" MENÜ");

            Console.SetCursorPosition(1, 2);
            Console.Write("Pozíció: (" + x + ", " + y + ")");

            Console.SetCursorPosition(1, 3);
            Console.Write("Karakter: ");
            Console.ForegroundColor = szin;
            Console.Write(karakter);
            Console.ResetColor();

            Console.SetCursorPosition(1, 4);
            Console.Write("Szín: ");
            Console.ForegroundColor = szin;
            Console.Write(szin);
            Console.ResetColor();

            Console.SetCursorPosition(1, 5);
            if (tollLent == true)
            {
                Console.Write("Eszköz: letéve");
            }
            else
            {
                Console.Write("Eszköz: felemelve");
            }

            if (uzenet != "")
            {
                Console.SetCursorPosition(1, height - 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (uzenet.Length > menuWidth - 2)
                {
                    Console.Write(uzenet.Substring(0, menuWidth - 2));
                }
                else
                {
                    Console.Write(uzenet);
                }
                Console.ResetColor();
            }
        }

        static void RajzlapKirajzolasa()
        {
            for (int sor = 0; sor < rajzMagassag; sor++)
            {
                Console.SetCursorPosition(rajzKezdoX, rajzKezdoY + sor);
                for (int oszlop = 0; oszlop < rajzSzelesseg; oszlop++)
                {
                    if (oszlop == x && sor == y)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = szin;
                        if (lapKarakter[sor, oszlop] == ' ')
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write(lapKarakter[sor, oszlop]);
                        }
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = lapSzin[sor, oszlop];
                        Console.Write(lapKarakter[sor, oszlop]);
                        Console.ResetColor();
                    }
                }
            }
        }

        static bool RajzVezerles(ConsoleKeyInfo bill)
        {
            int ujX = x;
            int ujY = y;

            if (bill.Key == ConsoleKey.UpArrow)
            {
                ujY = y - 1;
            }
            else if (bill.Key == ConsoleKey.DownArrow)
            {
                ujY = y + 1;
            }
            else if (bill.Key == ConsoleKey.LeftArrow)
            {
                ujX = x - 1;
            }
            else if (bill.Key == ConsoleKey.RightArrow)
            {
                ujX = x + 1;
            }
            else if (bill.Key == ConsoleKey.Spacebar)
            {
                tollLent = !tollLent;
                if (tollLent == true)
                {
                    lapKarakter[y, x] = karakter;
                    lapSzin[y, x] = szin;
                }
                return true;
            }
            else
            {
                return true;
            }

            if (ujX < 0 || ujX >= rajzSzelesseg || ujY < 0 || ujY >= rajzMagassag)
            {
                Hiba("Elérted a rajzlap szélét!");
                return true;
            }

            x = ujX;
            y = ujY;

            if (tollLent == true)
            {
                lapKarakter[y, x] = karakter;
                lapSzin[y, x] = szin;
            }

            return true;
        }

        static void Hiba(string szoveg)
        {
            uzenet = szoveg;
            try
            {
                Console.Beep();
            }
            catch
            {
            }
        }
    }
}