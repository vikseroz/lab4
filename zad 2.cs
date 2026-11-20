 Console.Write("Ile dni trwa wyprawa? ");
        int dni = int.Parse(Console.ReadLine());

        int sumaZlota = 0;
        int udaneDni = 0;

        for (int i = 1; i <= dni; i++)
        {
            Console.Write("Zloto w dniu " + i + ": ");
            int zloto = int.Parse(Console.ReadLine());

            sumaZlota += zloto;

            if (zloto > 10)
            {
                udaneDni++;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Lacznie znaleziono: " + sumaZlota + " sztuk zlota.");
        Console.WriteLine("Dni z wynikiem powyzej 10: " + udaneDni + ".");