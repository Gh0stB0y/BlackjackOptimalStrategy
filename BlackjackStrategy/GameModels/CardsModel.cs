using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GameModels
{
    public static class CardsModel
    {
        public static readonly List<string> CardNames = new List<string>() {"2 kier","2 karo","2 pik","2 trefl",
                                                                    "3 kier","3 karo","3 pik","3 trefl",
                                                                    "4 kier","4 karo","4 pik","4 trefl",
                                                                    "5 kier","5 karo","5 pik","5 trefl",
                                                                    "6 kier","6 karo","6 pik","6 trefl",
                                                                    "7 kier","7 karo","7 pik","7 trefl",
                                                                    "8 kier","8 karo","8 pik","8 trefl",
                                                                    "9 kier","9 karo","9 pik","9 trefl",
                                                                    "10 kier","10 karo","10 pik","10 trefl",
                                                                    "Walet kier","Walet karo","Walet pik","Walet trefl",
                                                                    "Dama kier","Dama karo","Dama pik","Dama trefl",
                                                                    "Krol kier","Krol karo","Krol pik","Krol trefl",
                                                                    "As kier","As karo","As pik","As trefl"};
        public static readonly List<int> CardValues = new List<int>() { 2,2,2,2,
                                                                3,3,3,3,
                                                                4,4,4,4,
                                                                5,5,5,5,
                                                                6,6,6,6,
                                                                7,7,7,7,
                                                                8,8,8,8,
                                                                9,9,9,9,
                                                                10,10,10,10,
                                                                10,10,10,10,
                                                                10,10,10,10,
                                                                10,10,10,10,
                                                                11,11,11,11 };
    }
}
