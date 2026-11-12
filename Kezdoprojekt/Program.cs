// Konzolos próbaprogram. Windows Terminalban vagy konzolablakban futtasd.
Console.OutputEncoding = System.Text.Encoding.UTF8;

if (Console.IsInputRedirected || Console.IsOutputRedirected)
{
    Console.WriteLine("A próbához nyiss interaktív konzolablakot.");
    return;
}

if (Console.WindowWidth < 76 || Console.WindowHeight < 23)
{
    Console.WriteLine("Nagyítsd a konzolablakot legalább 76 oszloposra és 23 sorosra.");
    return;
}

Console.Clear();
Console.WriteLine("Konzolpróba | F1: színes jel | B: hang | L: fájl | Esc: kilépés");
Console.WriteLine("Az alsó sor az utolsó leütött billentyűt mutatja.");
bool fut = true;
while (fut)
{
    ConsoleKey billentyu = Console.ReadKey(true).Key;
    Console.SetCursorPosition(0, 20);
    Console.Write(("Billentyű: " + billentyu).PadRight(75));

    switch (billentyu)
    {
        case ConsoleKey.F1:
            Console.SetCursorPosition(26, 4); // oszlop, majd sor
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write('#');
            Console.ResetColor();
            break;
        case ConsoleKey.B:
            if (OperatingSystem.IsWindows())
                Console.Beep(800, 120);
            else
                Console.Write("\a");
            break;
        case ConsoleKey.L:
            string utvonal = Path.Combine(AppContext.BaseDirectory, "minta.txt");
            if (File.Exists(utvonal))
            {
                string[] sorok = File.ReadAllLines(utvonal);
                for (int i = 0; i < sorok.Length && i < 5; i++)
                {
                    Console.SetCursorPosition(26, 7 + i);
                    Console.Write(sorok[i]);
                }
            }
            else
            {
                Console.SetCursorPosition(26, 7);
                Console.Write("A mintafájl nem található.");
            }
            break;
        case ConsoleKey.Escape:
            fut = false;
            break;
    }
}

Console.SetCursorPosition(0, 21);
Console.WriteLine("A próba véget ért.");
