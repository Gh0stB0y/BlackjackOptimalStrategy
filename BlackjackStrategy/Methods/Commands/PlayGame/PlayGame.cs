﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GameModels;
using BlackjackStrategy.Methods.Queries;
using BlackjackStrategy.Testing;
namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        internal static void PlayGame()
        {   
            PlaceYourBets();
            InitialCards();
            
            Decisions();           
            
            DealersTurn();
            GenerateResults();
            UpdateStatistics();
            ClearTable();
            CheckRedCard();
        }
    }
}
