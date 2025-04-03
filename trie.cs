using System;
// namespace playground;

public static class Tri
{

    public static void ordre()
    {
        Console.WriteLine("i ?"); //AFFICHER "longeur ?"
        int i = int.Parse(Console.ReadLine()); //VARIABLE i : INT <- lire i

        Console.WriteLine("j ?"); //AFFICHER "largeur ?"
        int j = int.Parse(Console.ReadLine()); //VARIABLE j : INT <- lire j

        Console.WriteLine("k ?"); //AFFICHER "hauteur ?"
        int k = int.Parse(Console.ReadLine()); //VARIABLE k : INT <- lire k

        int temp = 0; //VARIABLE temp : INT <- 0

        if (i > j) //SI i > j ALORS
        {
            temp = i; //VARIABLE temp = i
            i = j; //VARIABLE i = j
            j = temp; //VARIABLE j = temp
        }

        if (j > k) //SI j > k ALORS
        {
            temp = j; //VARIABLE temp = j
            j = k; //VARIABLE j = k
            k = temp; //VARIABLE k = temp
        }

        if (i > j) //si i > j ALORS
        {
            temp = i; //VARIABLE temp = i
            i = j; //VARIABLE i = j
            j = temp; //VARIABLE j = temp
        }
        
        Console.WriteLine($"\nAprès tri: {i}, {j}, {k}"); //AFFICHER "Après tri :" i "," j "," k
    }
}