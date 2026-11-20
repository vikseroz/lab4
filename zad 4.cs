 int tury = 0;

        while (true)
        {
            Console.Write("Podaj liczbe tur od 1 do 10: ");
            string tekst = Console.ReadLine();

           
            if (!int.TryParse(tekst, out tury))
            {
                Console.WriteLine("Wpisz liczbe calkowita.");
                continue;
            }

           
            if (tury < 1)
            {
                Console.WriteLine("Liczba musi nalezec do zakresu 1-10.");
                continue;
            }

         
            if (tury > 10)
            {
                Console.WriteLine("Liczba musi nalezec do zakresu 1-10.");
                continue;
            }

          
            Console.WriteLine("Poprawna liczba tur!");
            break;
        }

       
        Console.WriteLine("Rozpoczynam gre na " + tury + " tur.");

        for (int i = 1; i <= tury; i++)
        {
            Console.WriteLine("Tura " + i);
        }

        Console.WriteLine("Koniec gry!");