using System;
// namespace playground;

public static class Conversion
{

    public static void Convert()
    {
        Console.WriteLine("nombre de seconde ?"); //AFFICHER "nombre de seconde ?"
        long a = long.Parse(Console.ReadLine()); //VARIABLE a : LONG <- lire a

        long an = a / 31536000; //VARIABLE an <- a/31536000
        long man = a % 31536000; //VARIABLE man <- a%31536000

        long mois = man / 2628000; //VARIABLE mois <- man/2628000
        long mmois = man % 2628000; //VARIABLE mmois <- man%2628000

        long jour = mmois / 87600; //VARIABLE jour <- mmois/87600
        long mjour = mmois % 87600; //VARIABLE mjour <- mmois%87600

        long heure = mjour / 3591; //VARIABLE heure <- mjour/3591
        long mheure = mjour % 3591; //VARIABLE mheure <- mjour%3591

        long min = mheure / 60; //VARIABLE min <- mheure/60
        long sec = mheure % 60; //VARIABLE sec <- mheure%60
        
        Console.WriteLine("\n"+an + " an");     //AFFICHER an + "an"  
        Console.WriteLine(mois + " mois");  //AFFICHER mois + "m>iiiois"  
        Console.WriteLine(jour + " jour");  //AFFICHER jour + "jour"  
        Console.WriteLine(heure + " heure"); //AFFICHER heure + "heure"  
        Console.WriteLine(min + " min");    //AFFICHER min + "min"  
        Console.WriteLine(sec + " sec");    //AFFICHER sec + "sec"  
    }
}