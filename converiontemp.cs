using System;
// namespace playground;

public static class Conversiontemp
{

    public static void Converttemp()
    {
    Console.WriteLine("entrez une température :"); //AFFICHER "entrez une température :"
    float a = float.Parse(Console.ReadLine()); //VARIABLE a : FLOAT <- lire a
    
    Console.WriteLine("type de converion (1 pour C->F, 2 pour F->C) :"); //AFFICHER "type de converion (1 pour C->F, 2 pour F->C) :"
    int b = int.Parse(Console.ReadLine()); //VARIABLE b : INT <- lire b
    float temp;

    if (b == 1) //SI b = 1 ALORS
    {
        temp = a*(9/5f)+32; //a <- a*(9/5)+32
        Console.WriteLine($"\n{a:F1}°C sont égale à {temp:F1}°F"); //AFFICHER a + "°C sont égale à" + temp + "°C"
    }
    else if (b==2){ //SINON SI b = 2 ALORS
        temp = (a-32)*(5/9f);//a <- (a-32)*(5/9)

        Console.WriteLine($"\n{a:F1}°F sont égale à {temp:F1}°C"); //AFFICHER a + "°C sont égale à" + temp + "°F"
    }
    else { //SINON
        Console.WriteLine("vide"); //AFFICHER "vide"
    }
    
    }
}