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
            RajzlapKirajzolasa();

            Console.ReadKey(true);

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
            Console.Write("DRAWING AREA");
        }

        static void RajzlapKirajzolasa()
        {
            for (int sor = 0; sor < rajzMagassag; sor++)
            {
                Console.SetCursorPosition(rajzKezdoX, rajzKezdoY + sor);
                for (int oszlop = 0; oszlop < rajzSzelesseg; oszlop++)
                {
                    Console.ForegroundColor = lapSzin[sor, oszlop];
                    Console.Write(lapKarakter[sor, oszlop]);
                    Console.ResetColor();
                }
            }
        }
    }
}
