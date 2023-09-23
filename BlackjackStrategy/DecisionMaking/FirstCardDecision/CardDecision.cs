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
        public static readonly List<List<int>> HardChart = new List<List<int>>() 
        {         
            new List<int>(){ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },//player's 5
            new List<int>(){ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },//player's 6
            new List<int>(){ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },//player's 7
            new List<int>(){ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },//player's 8
            new List<int>(){ 1, 3, 3, 3, 3, 1, 1, 1, 1, 1 },//player's 9
            new List<int>(){ 3, 3, 3, 3, 3, 3, 3, 3, 1, 1 },//player's 10
            new List<int>(){ 3, 3, 3, 3, 3, 3, 3, 3, 3, 1 },//player's 11
            new List<int>(){ 1, 1, 2, 2, 2, 1, 1, 1, 1, 1 },//player's 12
            new List<int>(){ 2, 2, 2, 2, 2, 1, 1, 1, 1, 1 },//player's 13
            new List<int>(){ 2, 2, 2, 2, 2, 1, 1, 1, 1, 1 },//player's 14
            new List<int>(){ 2, 2, 2, 2, 2, 1, 1, 1, 5, 1 },//player's 15
            new List<int>(){ 2, 2, 2, 2, 2, 1, 1, 5, 5, 5 },//player's 16
            new List<int>(){ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's 17
            new List<int>(){ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's 18
            new List<int>(){ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's 19
            new List<int>(){ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's 20
        };
        public static readonly List<List<int>> SoftChart = new List<List<int>>()
        {
            new List<int>(){ 1, 1, 1, 3, 3, 1, 1, 1, 1, 1 },//player's soft 13 / A2
            new List<int>(){ 1, 1, 1, 3, 3, 1, 1, 1, 1, 1 },//player's soft 14 / A3
            new List<int>(){ 1, 1, 3, 3, 3, 1, 1, 1, 1, 1 },//player's soft 15 / A4
            new List<int>(){ 1, 1, 3, 3, 3, 1, 1, 1, 1, 1 },//player's soft 16 / A5
            new List<int>(){ 1, 3, 3, 3, 3, 1, 1, 1, 1, 1 },//player's soft 17 / A6
            new List<int>(){ 2, 4, 4, 4, 4, 2, 2, 1, 1, 1 },//player's soft 18 / A7
            new List<int>(){ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's soft 19 / A8
            new List<int>(){ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//player's soft 20 / A9
        };
        public static readonly List<List<int>> PairsChart = new List<List<int>>()
        {
            new List<int>(){ 5, 5, 5, 5, 5, 5, 1, 1, 1, 1 },//22
            new List<int>(){ 5, 5, 5, 5, 5, 5, 1, 1, 1, 1 },//33
            new List<int>(){ 1, 1, 1, 5, 5, 1, 1, 1, 1, 1 },//44
            new List<int>(){ 3, 3, 3, 3, 3, 3, 3, 3, 1, 1 },//55
            new List<int>(){ 5, 5, 5, 5, 5, 1, 1, 1, 1, 1 },//66
            new List<int>(){ 5, 5, 5, 5, 5, 5, 1, 1, 1, 1 },//77
            new List<int>(){ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },//88
            new List<int>(){ 5, 5, 5, 5, 5, 2, 5, 5, 2, 2 },//99
            new List<int>(){ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },//10 10
            new List<int>(){ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },//AA
        };

    }
}
