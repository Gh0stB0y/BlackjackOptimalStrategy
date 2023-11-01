using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.DecisionMaking
{
    public static class CardDecision
    {
        //https://www.vegashowto.com/support-files/blackjack-basic-strategy.pdf
        //https://stackoverflow.com/questions/27548110/how-to-implement-blackjack-basic-strategy-in-easy-way
        //1 - hit
        //2 - stand
        //3 - double/hit
        //4 - double/stand
        //5 - split
        //6 - surrender
        public static readonly int[,]HardChart =
        {         
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },//player's 5
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },//player's 6
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },//player's 7
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },//player's 8
            { 1, 3, 3, 3, 3, 1, 1, 1, 1, 1 },//player's 9
            { 3, 3, 3, 3, 3, 3, 3, 3, 1, 1 },//player's 10
            { 3, 3, 3, 3, 3, 3, 3, 3, 3, 1 },//player's 11
            { 1, 1, 2, 2, 2, 1, 1, 1, 1, 1 },//player's 12
            { 2, 2, 2, 2, 2, 1, 1, 1, 1, 1 },//player's 13
            { 2, 2, 2, 2, 2, 1, 1, 1, 1, 1 },//player's 14
            { 2, 2, 2, 2, 2, 1, 1, 1, 6, 1 },//player's 15
            { 2, 2, 2, 2, 2, 1, 1, 6, 6, 6 },//player's 16
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's 17
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's 18
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's 19
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's 20
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 } //player's 21
        };
        public static readonly int[,] SoftChart =
        {
            { 1, 1, 1, 3, 3, 1, 1, 1, 1, 1 },//player's soft 13 / A2
            { 1, 1, 1, 3, 3, 1, 1, 1, 1, 1 },//player's soft 14 / A3
            { 1, 1, 3, 3, 3, 1, 1, 1, 1, 1 },//player's soft 15 / A4
            { 1, 1, 3, 3, 3, 1, 1, 1, 1, 1 },//player's soft 16 / A5
            { 1, 3, 3, 3, 3, 1, 1, 1, 1, 1 },//player's soft 17 / A6
            { 2, 4, 4, 4, 4, 2, 2, 1, 1, 1 },//player's soft 18 / A7
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's soft 19 / A8
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's soft 20 / A9
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's soft 21 
        };
        public static readonly int[,] PairsChart =
        {
            { 5, 5, 5, 5, 5, 5, 1, 1, 1, 1 },//22
            { 5, 5, 5, 5, 5, 5, 1, 1, 1, 1 },//33
            { 1, 1, 1, 5, 5, 1, 1, 1, 1, 1 },//44
            { 3, 3, 3, 3, 3, 3, 3, 3, 1, 1 },//55
            { 5, 5, 5, 5, 5, 1, 1, 1, 1, 1 },//66
            { 5, 5, 5, 5, 5, 5, 1, 1, 1, 1 },//77
            { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },//88
            { 5, 5, 5, 5, 5, 2, 5, 5, 2, 2 },//99
            { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//10 10
            { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },//AA
        };

    }
}
