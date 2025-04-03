using System;
// namespace playground;

public static class Pmath
{

    public static void Pgcdppcm()
    {
        Console.WriteLine("a :"); //AFFICHER "a :"
        long a = long.Parse(Console.ReadLine()); //VARIABLE nbrnote : long <- lire nbrnote
        Console.WriteLine("b :"); //AFFICHER "combien de note voulez-vous entrer :"
        long b = long.Parse(Console.ReadLine()); //VARIABLE nbrnote : long <- lire nbrnote
        long r = a%b;
        long r2 = b;
        long r0 = r;
  
        while (r2 != 0)
        {
            long r3 = r % r2;
            r0 = r2;
            r = r2;
            r2 = r3;
        }
        Console.WriteLine("PGCD : " + r0);
        long ppcm = (a * b) / (r0);
        Console.WriteLine("PPCM : " + ppcm.ToString("N0"));
    }
}


