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

            ElvalasztoEsFejlec();
            Console.ReadKey(true);

            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = true;
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
    }
}