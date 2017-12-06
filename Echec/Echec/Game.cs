using Echec.Pawns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Echec
{
    class Game
    {
        public Playercs p1, p2, p3;
        public Pawn[,] cases = new Pawn[8, 8];
        public int nbTours;
        public bool IsMyTurn = true;
        public bool TestFinDuJeu = false;

        public Game()
        {
            //On creer les joueurs
            p1 = new Playercs();
            p2 = new Playercs();
            p3 = new Playercs();

            p1.name = "Maurice";
            p2.name = "Janne";

            p1.color = Pawn.Color.White;
            p2.color = Pawn.Color.Black;
            p3 = p1;

            //PLace les pions sur le plateaux
            cases[0, 0] = new Tower(p2.color);
            cases[7, 0] = new Tower(p2.color);
            //cavalier noir
            cases[1, 0] = new HorseMan(p2.color);
            cases[6, 0] = new HorseMan(p2.color);
            //fou noir 
            cases[2, 0] = new bischop(p2.color);
            cases[5, 0] = new bischop(p2.color);
            //rene et roi noir 
            cases[3, 0] = new Queen(p2.color);
            cases[4, 0] = new King(p2.color);
            //Les pieces blanches 
            //tours blanche 
            cases[0, 7] = new Tower(p1.color);
            cases[7, 7] = new Tower(p1.color);
            //cavalier blanc
            cases[1, 7] = new HorseMan(p1.color);
            cases[6, 7] = new HorseMan(p1.color);
            //fou blanc 
            cases[2, 7] = new bischop(p1.color);
            cases[5, 7] = new bischop(p1.color);
            //Reine et roi blanc
            cases[3, 7] = new Queen(p1.color);
            cases[4, 7] = new King(p1.color);
            // pion noir et blanc
            for (int i = 0; i < 8; i++)
            {
                cases[i, 1] = new Piece(p2.color);
                cases[i, 6] = new Piece(p1.color);
            }

            StartGame();
        }

        public void StartGame()
        {
            nbTours = 0;
            while (TestFinDuJeu == false)
            {
                nbTours++;
                GameTurn();
            }
        }

        public void GameTurn()
        {
            PrintGameboard();
            if (IsMyTurn == true)
                p3 = p1;
            else
                p3 = p2;

            Console.WriteLine("Au tour de " + p3.name + " qui a la couleur " + p3.color + ". Ecriver quelle piece vous vouler jouer en donnant les positions avec x en premier et y en deuxième");
            Coordone coordone = AskForPositionne();
            // on test si c'est une piece du joueur 
            while (cases[coordone.x, coordone.y] == null || cases[coordone.x, coordone.y].color != p3.color)
            {
                Console.WriteLine("Ecriver les coordone d'une piece à vous");
                coordone = AskForPositionne();
            }
            // On regarde si la piece peut se deplacer 
            List<Coordone> MouvementPossible = cases[coordone.x, coordone.y].GetUsuableCoordinate(coordone, cases);
            while (MouvementPossible.Count == 0)
            {
                Console.WriteLine("Cette piece na pas de mouvement, choissisez s'en une autre");
                coordone = AskForPositionne();
                MouvementPossible = cases[coordone.x, coordone.y].GetUsuableCoordinate(coordone, cases);
            }
            //on affiche les mouvement possible de la piece
            AfficheMouventPossible(MouvementPossible);
            Coordone NewPosition = AskForPositionne();
            //On test si la piece est dans les coordonnés
            for (int i = 0; i < MouvementPossible.Count; i++)
            {
                if (NewPosition.x == MouvementPossible[i].x && NewPosition.y == MouvementPossible[i].y)
                {
                    break;
                }

                if (i == MouvementPossible.Count -1)
                {
                    i = -1;
                    Console.WriteLine("La postion que vous avez rentre n'est pas dans la liste des possibilité");
                    NewPosition = AskForPositionne();
                }
            }

            //On test si la pièce est le roi qui mettrai la fin au jeu
            if (cases[NewPosition.x, NewPosition.y] != null)
            {
                if (cases[NewPosition.x, NewPosition.y].signe == "K")
                {
                    Console.Clear();
                    Console.WriteLine("La Partie est terminé. Le gagnant est " + p3.name + " avec la couleur " + p3.color + " en " + nbTours + "tours");
                    TestFinDuJeu = true;
                     
                }
            }

            //On échange de position la piece 
            if (TestFinDuJeu == false)
            {
                cases[NewPosition.x, NewPosition.y] = cases[coordone.x, coordone.y];
                cases[coordone.x, coordone.y] = null;

                //On change le tour de jeu
                if (IsMyTurn == true)
                    IsMyTurn = false;
                else
                    IsMyTurn = true;
                Console.Clear();
            }
        }

        public Coordone AskForPositionne()
        {
            string caseChoisi = Console.ReadLine();
            //On test le nombre de caractere
            while (caseChoisi.Length != 2)
            {
                Console.WriteLine("Il faut rentrer 2 caratère");
                caseChoisi = Console.ReadLine();
            }
            //On test que ce sont bien des chiffre qui sont rentrées 
            Regex TestChaine = new Regex("[0-9]");
            while (!TestChaine.Match(caseChoisi).Success)
            {
                Console.WriteLine("Il faut rentrer des chiffres");
                caseChoisi = Console.ReadLine();
            }
            //On test si les coordonne sont inferieur a 8 est superieur a -1
            while ((int)Char.GetNumericValue(caseChoisi[0]) < 0 || (int)Char.GetNumericValue(caseChoisi[0]) > 7 || (int)Char.GetNumericValue(caseChoisi[1]) < 0 || (int)Char.GetNumericValue(caseChoisi[1]) > 7)
            {
                Console.WriteLine("les coordonee ne peuvent pas etre inferieur a 0 ou supperieur a 7");
                caseChoisi = Console.ReadLine();
            }

            //on renvoye la coordonne
            Coordone r = new Coordone((int)Char.GetNumericValue(caseChoisi[0]), (int)Char.GetNumericValue(caseChoisi[1]));
            return r;
        }


        public void AfficheMouventPossible(List<Coordone> coord)
        {
            Console.WriteLine("Vos mouvement Possible sont :");
            for (int i = 0; i < coord.Count; i++)
            {
                Console.WriteLine(coord[i].x + " " + coord[i].y);
            }
        }

        public void PrintGameboard()
        {
            Console.Write("  ");
            for (int i = 0; i < 8; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(i + " " );
            }
            Console.WriteLine();
            for (int y = 0; y < 8; y++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("|");

                for (int x = 0; x < 8; x++)
                {
                    //on test si la case n'est pas null
                    if (cases[x, y] != null)
                    {
                        if (cases[x, y].color == Pawn.Color.Black)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(cases[x, y].signe);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("|");
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(cases[x, y].signe);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        cases[x, y] = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write( " |");
                    }

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
    }
}
