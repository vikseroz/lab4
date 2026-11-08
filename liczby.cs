 // 1. Liczby od 1 do 10 za pomocą while
        Console.Write("While: ");

        int i = 1;

        while (i <= 10)
        {
            Console.Write(i + " ");
            i++;
        }

        Console.WriteLine();
        
        
        Console.Write("Do-while: ");

        int j = 1;

        do
        {
            Console.Write(j + " ");
            j++;
        }
        while (j <= 10);

        Console.WriteLine();

        // 3. Liczby od 1 do 10 za pomocą for
        Console.Write("For: ");

        for (int k = 1; k <= 10; k++)
        {
            Console.Write(k + " ");
        }

        Console.WriteLine();

        // 4. Liczby od 10 do 1
        Console.Write("Malejąco: ");

        for (int a = 10; a >= 1; a--)
        {
            Console.Write(a + " ");
        }

        Console.WriteLine();

        // 5. Liczby parzyste od 0 do 20
        Console.Write("Parzyste: ");

        for (int b = 0; b <= 20; b += 2)
        {
            Console.Write(b + " ");
        }

        Console.WriteLine();

        // 6. Komunikat Start!
        Console.WriteLine("Start!");