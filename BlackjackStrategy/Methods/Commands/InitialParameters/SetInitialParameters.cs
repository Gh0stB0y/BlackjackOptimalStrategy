
using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void SetInitialParameters()
        {
            SetTableParameters();
            SetSeatsParameters(TableModel.SeatsNumber);
            SetPlayerParameters();
            if (TableModel.BotPlayers == true) AssignBotsToSeats();
            PlayerModel.InitialBankroll = PlayerModel.Bankroll; 
            
        }
    }
}
