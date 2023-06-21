using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUGH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random(52);
            string[] symbol = new string[4] { "Heart", "Spade", "Diamond", "Club" };
            List<int[]> cards = new List<int[]>();
            string[] number = new string[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            int credit = 1000;
            bool start = true;
            bool shufflling = true;
            int[] Symbolint = new int[4];
            int[] Numberint = new int[13];
            //for (int i = 0; i < 4; i++)
            //{
            //    Symbolint[i] = i;
            //}
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 10)
            //    {
            //        for (int x = 1; x <= 4; x++)
            //            Symbolint[i + 1] = x;
            //    }
            //    Numberint[i] = i;

            //}
            //for(int x =0; x<Symbolint.Length; x++)
            //{
            //    for(int y = 0; y<Numberint.Length; y++)
            //    {
            //        int[] pair = new int[2];
            //        pair[0] = Symbolint[x];
            //        pair[1] = Symbolint[y];
            //        cards.Add(pair);
            //    }
            //}

            /*step 1 : Generate card
             players has 1000 credits every game will cost a 100 credits.
            step 2 : display that a credit has been deducted and show the balance, thus the shuffling begins.
             7x shuffle
            then starting of the game commencing, by giving cards to the player and the other players.
            players will draw card, user will draw the card first having the info about it. Then other player
            will just draw the card hidden.
            drawing the card will be twice in each player.
            step 3 : Current hand value will be shown,
            then  a choice will be made to draw or just to stand.
            display every players decision thus need need a randomizer for each range if the players need to take a card or not the lower number 
            higher chance to takes. */
            while (start)
            {
                for (int i = 0; i < 4; i++)
                {
                    Symbolint[i] = i;
                }
                for (int i = 0; i < 13; i++)
                {
                    Numberint[i] = i;
                }
                for (int x = 0; x < Symbolint.Length; x++)
                {
                    for (int y = 0; y < Numberint.Length; y++)
                    {
                        int[] pair = new int[2];
                        pair[0] = Symbolint[x];
                        pair[1] = Symbolint[y];
                        cards.Add(pair);
                    }
                }
            }
            Console.WriteLine("Card Generated........");
            Console.WriteLine("Ready to play the game? you need at least 100 credit to play. Press any key to contine...");
            Console.ReadKey();
            Console.Clear();
            {

            }
            //shuffle card 
            //giving the card to the player
                
            
        }
    }
}


