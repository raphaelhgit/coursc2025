using System;
// namespace playground;

public static class Calc
{

    public static void Multi()
    {
        Console.WriteLine("nombre 1 : "); //AFFICHER "nombre 1 :"
        int nbr1 = int.Parse(Console.ReadLine()); //VARIABLE nbr1 : INT <- lire nbr1
        Console.WriteLine("nombre 2 : "); //AFFICHER "nombre 2 :"
        int nbr2 = int.Parse(Console.ReadLine()); //VARIABLE nbr2 : INT <- lire nbr2
        int calc = 0; //VARIABLE calc : INT <- 0
        bool negatif = false; //VARIABLE negatif : BOOL <- false

        if ((nbr1 < 0) || (nbr2 < 0)) //SI nbr1 < 0 OU nbr2 < 0 ALORS 
        {
            negatif = true; //VARIABLE negatif <- true
            if ((nbr1 < 0) && (nbr2 < 0)) //SI nbr1 < 0 ET nbr2 < 0 ALORS
            {
                negatif = false; //VARIABLE negatif <- false
            }
            if (nbr1 < 0) //SI nbr1 < 0 ALORS
            {
                nbr1 = nbr1 * (-1); //VARIABLE nbr1 = nbr1 * (-1)
            
            }
            if (nbr2 < 0) //SI nbr2 < 0 ALORS
            {
                nbr2 = nbr2 * (-1);//VARIABLE nbr2 = nbr2 * (-1)
            }
        }
        
        for (int i = 0;i < nbr2; i++){ //FOR i in range i < nbr2 i++
            calc = calc + nbr1; //VARIABLE calc <- calc + nbr1
        }

        if (negatif == true) //SI negatif = true ALORS
        {
            calc = calc*(-1); //VARIABLE calc = cals*(-1)
        }
        Console.WriteLine(calc); //AFFICHER calc

    }
}
