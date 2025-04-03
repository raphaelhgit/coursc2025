
using System;
// namespace playground;

public static class Casino
{

    public static void Gambling()
    {
        var rand = new Random();
        int credit = 100;
        int[] resulat = new int[3];
        string touche = "";
        int counter = 0;
        int nbr15 = 0;
        int nbr150 = 0;
        int nbrdef = 0;
        
        while (credit > 0 && credit <1000)
        {
            //Console.WriteLine("appuie sur entree pour jouer ou q pour quitter :"); //AFFICHER "combien de note voulez-vous entrer :"
            //touche = Console.ReadLine(); // Stocke directement la chaîne //VARIABLE nbrnote : INT <- lire nbrnote
            touche = "r";
            if (touche != "q")
            {
                credit -= 10;
                resulat[0] = rand.Next(1, 6);
                resulat[1] = rand.Next(1, 6);
                resulat[2] = rand.Next(1, 6);
                Console.WriteLine(resulat[0] + "," + resulat[1] + "," + resulat[2]);
                if ((resulat[0] == resulat[1]) && (resulat[1] == resulat[2])) {
                    Console.WriteLine("Vous avez gagné 150 crédits !");
                    credit += 150;
                    Console.WriteLine("Crédit actuel : "+ credit);
                    counter++;
                    nbr150++;
                }
                else if (resulat[0] == resulat[1] || resulat[0] == resulat[2] || resulat[1] == resulat[2]){
                    Console.WriteLine("Vous avez gagné 15 crédits !");
                    credit += 15;
                    Console.WriteLine("Crédit actuel : "+ credit);
                    counter++;
                    nbr15++;
                }
                else
                {
                    Console.WriteLine("Perdu !");
                    Console.WriteLine("Crédit actuel : "+ credit);
                    counter++;
                    nbrdef++;
                }
            }
            else
            {
                Console.WriteLine("Partie quitter, tu devrait continuer jusqu'au gros lot");
                Console.WriteLine("Crédit actuel : "+ credit);
                Console.WriteLine("nombre de partie jouer : "+ counter);
                Console.WriteLine("nombre de +15 : " + nbr15);
                Console.WriteLine("nombre de +150 : " + nbr150);
                Console.WriteLine("nombre de 0 : " + nbrdef);
            break;
            }
        }
        if (credit == 0)
        {
            Console.WriteLine("plus de credit !");
            Console.WriteLine("nombre de partie jouer : "+ counter);
            Console.WriteLine("nombre de +15 : " + nbr15);
            Console.WriteLine("nombre de +150 : " + nbr150);
            Console.WriteLine("nombre de 0 : " + nbrdef);
        }
        else if (credit >= 1100)
        {
            Console.WriteLine("1000 credit gagner, fin de partie !");
            Console.WriteLine("Crédit actuel : "+ credit);
            Console.WriteLine("nombre de partie jouer : "+ counter);
            Console.WriteLine("nombre de +15 : " + nbr15);
            Console.WriteLine("nombre de +150 : " + nbr150);
            Console.WriteLine("nombre de 0 : " + nbrdef);
        }
    }
}
