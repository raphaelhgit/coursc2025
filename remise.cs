public static class Remise
{

    public static void promo()
    {
    Console.WriteLine("montant ?"); //AFFICHER "montant ?"
    int a = int.Parse(Console.ReadLine()); //VARIABLE a : INT <- lire a

    if (a >= 100 && a <= 500){
        Console.WriteLine("la promo est de : 5%"); //AFFICHER "la promo est de : 5%"
    }
    else if (a > 500){
        Console.WriteLine("la promo est de : 8%"); //AFFICHER "la promo est de : 8%"
    }
    else 
        Console.WriteLine("pas de promo"); //AFFICHER "pas de promo"
    }
} 