﻿using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void PlayerRuined()
        {
            PlayerModel.Busted = true;
            //Console.WriteLine("Player lost all of his money");
            UpdateStatistics();          
        }
    }
}
