public static class Note
{

    public static void Nbr()
    {
        Console.WriteLine("combien de note voulez-vous entrer :"); //AFFICHER "combien de note voulez-vous entrer :"
        int nbrnote = int.Parse(Console.ReadLine()); //VARIABLE nbrnote : INT <- lire nbrnote
        int[] notes = new int[nbrnote]; //VARIABLE notes : ARRAY[ENTIER] 
        float moyenne = 0; //VARIABLE moyenne : FLOAT <- 0

        for (int i = 0; i < nbrnote; i++){ //FOR i in range "i < nbrnote) i++
            Console.WriteLine("Entrez la note " + (i+1)); //AFFICHER "Entrez la note" +(i+1)
            notes[i] = int.Parse(Console.ReadLine()); //VARIABLE notes : array[i] <- lire nbrnote
            moyenne = moyenne+notes[i]; //VARIABLE moyenne <- moyenne+notes[i]
        }
            moyenne = moyenne/nbrnote; //VARIABLE moyenne <- moyenne/nbrnote
            Console.WriteLine("\nRésultats :"); //AFFICHER "Résultats :"
            Console.WriteLine("Moyenne : " + moyenne); //AFFICHER "Moyenne : " + moyenne

            Array.Sort(notes); //VARIABLE notes : trié par ordre croissant
            int notemin = notes[0]; //VARIABLE notemis : INT <- notes[0]
            Array.Reverse(notes); //VARIABLE notes : trié par ordre décroissant
            int notemax = notes[0]; //VARIABLE notemax : INT <- notes[0]
            Console.WriteLine("Note la plus haute : " + notemax); //AFFICHER "Note la plus haute : " + notemax
            Console.WriteLine("Note la plus basse : " + notemin); //AFFICHER "Note la plus basee : " + notemin


            if (moyenne >= 16){ //SI moyenne >= 16 ALORS
                Console.WriteLine("Appréciation : Très bien"); //AFFICHER "Appréciation : Très bien"
            }
            else if (moyenne >= 14 && moyenne <16){ //SINON SI moyenne >= 14 && moyenne <16 ALORS
                Console.WriteLine("Appréciation : bien");  //AFFICHER "Appréciation : bien"
            }
            else if (moyenne >= 12 && moyenne <14){ //SINON SI moyenne >= 12 && moyenne <14 ALORS
                Console.WriteLine("Appréciation : Assez bien"); //AFFICHER "Appréciation : Assez bien"
            }
            else if (moyenne >= 10 && moyenne <12){ //SINON SI moyenne >= 10 && moyenne <12 ALORS
                Console.WriteLine("Appréciation : Passable"); //AFFICHER "Appréciation : Passable"
            }
            else { //SINON
                Console.WriteLine("Appréciation : Insuffisant"); //AFFICHER "Appréciation : Insuffisant"
            }
    }
}