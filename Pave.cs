using System;
// namespace playground;

public static class Pave
{

    public static void taille()
    {
        Console.WriteLine("longeur ?"); //AFFICHER "longeur ?"
        int l = int.Parse(Console.ReadLine()); //VARIABLE l : INT <- lire l

        Console.WriteLine("largeur ?"); //AFFICHER "largeur ?"
        int L = int.Parse(Console.ReadLine()); //VARIABLE L : INT <- lire L

        Console.WriteLine("hauteur ?"); //AFFICHER "hauteur ?"
        int h = int.Parse(Console.ReadLine()); //VARIABLE h : INT <- lire h

        int volume = l*L*h; //VARIABLE volume : INT <- l*L*h

        Console.WriteLine("le volume est de : " + volume); //AFFICHER "le volume est de : " + volume
    }
}