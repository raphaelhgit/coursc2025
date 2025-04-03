
using System;
// namespace playground;

public static class Triangle
{

    public static void Pascal()
    {
        Console.WriteLine("nombre de lignes :"); 
        long nbrligne = long.Parse(Console.ReadLine()); 
        if (nbrligne >= 1 && nbrligne <= 20)
        {
        int[,] triangle = new int[nbrligne, nbrligne+1];
        
        triangle[0, 1] = 1;
        for (int i = 0; i < nbrligne; i++)
        {
            for (int j = 0; j < nbrligne; j++)
            {
                if (i ==j || j==0)
                {
                    triangle[i, j] = 0;
                }
                else if(j>i)
                {
                    triangle[i, j] = 0;
                }
                else if (i != j)
                {
                    triangle[i, j] = triangle[i-1, j - 1] + triangle[i-1, j];
                }
                Console.Write($"{triangle[i, j],5 }");
            }
            Console.WriteLine();   
            }
        }
        else
        {
            Console.WriteLine("nombre de lignes invalide");
        }
    }
}
