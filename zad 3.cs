 Console.Write("Podaj wysokosc choinki (2-10): ");
        int wysokosc = int.Parse(Console.ReadLine());

       
        for (int i = 1; i <= wysokosc; i++)
        {
            
            for (int j = 1; j <= wysokosc - i; j++)
            {
                Console.Write(" ");
            }

        
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

   
        for (int i = 1; i <= wysokosc - 1; i++)
        {
            Console.Write(" ");
        }

        Console.WriteLine("*");