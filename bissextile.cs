using System;
// namespace playground;

public static class Annee
{

    public static void bissextile()
    {
    Console.WriteLine("entrez une année :"); //AFFICHER "entrez une année :"
    float a = float.Parse(Console.ReadLine()); //VARIABLE a : FLOAT <- lire a

    if (((a%4 == 0) && (a%100 != 0)) || (a%400 == 0)){ //SI (a divisible par 4 ET non divisible par 100) OU (a divisible par 400) ALORS  
        Console.WriteLine("\n"+a + " est une année bisextile"); //AFFICHER a + " est une année bisextile"
    }
    else {
        Console.WriteLine("\n"+a + " n'est pas une année bisextile"); //AFFICHER a + " n'est pas une année bisextile"
    }
    }
}