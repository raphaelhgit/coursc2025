
using System;
// namespace playground;

public static class Table
{

    public static void Multiple()
    {
        Console.WriteLine("table ?"); //AFFICHER "combien de note voulez-vous entrer :"
        int table = int.Parse(Console.ReadLine()); //VARIABLE nbrnote : INT <- lire nbrnote

        for (int i = 1; i < 21; i++){ //FOR i in range i < 21 i++
        
            if (((table * i) % 3) == 0)
            {
                Console.WriteLine(table*i+"*");
            }
            else
            {
                Console.WriteLine(table*i);
            }
        }
    }
}
