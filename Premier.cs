using System;
// namespace playground;
public static class Premier
{

    public static void Nombre()
    {
        Console.WriteLine("Entrez un nombre entier positif : ");
        int nbr = int.Parse(Console.ReadLine());

        Console.WriteLine("Nombres premiers entre 1 et " + nbr + " :");

        for (int i = 2; i <= nbr; i++)
        {
            bool premier = true;
            
            if (i < 2)
            {
                premier = false;
            }
            else if (i == 2 || i == 3)
            {
                premier = true;
            }
            else if (i % 2 == 0)
            {
                premier = false;
            }
            else
            {
                int sqrt_int = (int)Math.Sqrt(i);
                for (int j = 3; j <= sqrt_int; j += 2)
                {
                    if (i % j == 0)
                    {
                        premier = false;
                        break;
                    }
                }
            }
    
            // Afficher si premier
            if (premier)
            {
                Console.Write(i + " ");
            }
        }
    }
}

