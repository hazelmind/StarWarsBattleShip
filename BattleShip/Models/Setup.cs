using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BattleShip.Models.Board;
using static BattleShip.Models.ShipTypes;

namespace BattleShip.Models
{
    public class Setup
    {
    
    public bool SetPlayers(string playing)
            {
                if (playing == "Friend")
                {
                    return true;
                }
                //else if (playing == "Computer")
                //{
                //    return false;
                //}
                return false;
            }

    public ShipTypes SetSide(string side)
        {
            if (side == "Light")
            {
                return ShipTypes.Light();
            }
        }
}
}
