using System;
// namespace playground;

public static class Motif
{

    public static void Star()
    {
        Console.WriteLine("motif :"); //AFFICHER "combien de note voulez-vous entrer :"
        int motif = int.Parse(Console.ReadLine()); //VARIABLE nbrnote : INT <- lire nbrnote
        int taille = 0;
        string[,] forme = new string[1,1];
        bool status = false;
        switch (motif)
        {
            case 1: //triangle rectangle
                Console.WriteLine("taille :"); //AFFICHER "Entrez la note" +(i+1)
                taille = int.Parse(Console.ReadLine()); //VARIABLE notes : array[i] <- lire nbrnote
                forme = new string[taille, taille]; //VARIABLE notes : ARRAY[ENTIER]
                for (int i = 0; i < taille; i++)
                {
                    forme[i, i] = "*";
                    forme[i, 0] = "*";
                    forme[taille-1, i] = "*";
                }
                AfficherMatrice(forme);
                break;
            
            case 2: //triangle isocele
                Console.WriteLine("taille :"); //AFFICHER "Entrez la note" +(i+1)
                taille = int.Parse(Console.ReadLine()); //VARIABLE notes : array[i] <- lire nbrnote
                forme = new string[taille, taille]; //VARIABLE notes : ARRAY[ENTIER]
                for (int j = 0; j < taille; j++)
                {
                    forme[0, j] = "*";
                    for (int i = 0; i < (taille/2)+0.5; i++)
                    {
                        forme[2*i, i] = "*";
                        forme[2*i, taille - 1 - i] = "*"; 
                   
                    } 
                }

                       
                AfficherMatrice(forme);
                break;
            
            
            case 3: //carré
                Console.WriteLine("taille :"); //AFFICHER "Entrez la note" +(i+1)
                taille = int.Parse(Console.ReadLine()); //VARIABLE notes : array[i] <- lire nbrnote
                forme = new string[taille, taille]; //VARIABLE notes : ARRAY[ENTIER]
                for (int i = 0; i < taille; i++)
                {
                    for (int j = 0; j < taille; j++)
                    {
                        forme[i, j] = "*";
                    }

                }
                AfficherMatrice(forme);
                break;
            
            case 4: //carré vide
                Console.WriteLine("taille :"); //AFFICHER "Entrez la note" +(i+1)
                taille = int.Parse(Console.ReadLine()); //VARIABLE notes : array[i] <- lire nbrnote
                forme = new string[taille, taille]; //VARIABLE notes : ARRAY[ENTIER]
                for (int i = 0; i < taille; i++)
                {
                    forme[i, 0] = "*";
                    forme[0, i] = "*";
                    forme[taille-1, i] = "*";
                    forme[i, taille - 1] = "*";
                }
                AfficherMatrice(forme);
                break;
            case 5:
                Console.WriteLine("taille :"); //AFFICHER "Entrez la note" +(i+1)
                taille = int.Parse(Console.ReadLine()); //VARIABLE notes : array[i] <- lire nbrnote
                forme = new string[taille, taille+1]; //VARIABLE notes : ARRAY[ENTIER]
                
                for (int i = 0; i < taille; i++)
                {
                    if (i%2==0)
                    {
                        forme[i, 0]="*";
                    }
                    for (int j = 0; j < taille+1; j++)
                    {
                        if (j%2!=0) {
                            forme[i, j] = "*";
                        }
                        else
                        {
                            if (status==false)
                            {
                                forme[i, j+1] = "*";
                                status = true;
                            }
                            else
                            {
                                forme[i, j] = "*";
                            }
                            
                        }
                        
                    }
                    status = false;
                }
                
                
                AfficherMatrice(forme);
                break;
            default:
                break;
                
        }
    }
    
    
    
    public static void AfficherMatrice<T>(T[,] matrice)
    {
        int lignes = matrice.GetLength(0);
        int colonnes = matrice.GetLength(1);

        for (int i = 0; i < lignes; i++)
        {
            for (int j = 0; j < colonnes; j++)
            {
                Console.Write(matrice[i, j] + "\t"); // \t pour aligner les éléments
            }
            Console.WriteLine(); // Nouvelle ligne après chaque ligne de la matrice
        }
    } 
}
