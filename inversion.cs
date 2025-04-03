using System;
// namespace playground;

public static class Inversion
{

    public static void Inverse()
    {

        string d = "bonjour"; //VARIABLE d : STRING <- bonjour
        string b = "au revoir"; //VARIABLE b : STRING <- au revoir
        string c = "temporaire"; //VARIABLE c : STRING <- temporaire

        Console.WriteLine("valeur de base de d : " + d); //AFFICHER "valeur de base de d : " + d
        Console.WriteLine("valeur de base de b : " + b); //AFFICHER "valeur de base de b : " + b 

        c = b; //VARIABLE c <- b 
        b = d; //VARIABLE b <- d
        d = c; //VARIABLE d <- c
        Console.WriteLine(""); //saut de ligne
        Console.WriteLine("valeur de fin de d : " + d); //AFFICHER "valeur de fin de d : " + d
        Console.WriteLine("valeur de fin de b : " + b); //AFFICHER "valeur de fin de b : " + b
    }
}
