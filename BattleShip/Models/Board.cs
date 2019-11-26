using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class Board
    {
        public int BoardSize { get; set; }

        public class Player1
        {
            public List<ShipTypes> P1Ships { get; set; }
            public List<int> P1AttackHistory { get; set; }
        }
        public class Player2
        {
            public List<ShipTypes> P2Ships { get; set; }
            public List<int> P2AttackHistory{ get; set; }
        }
    }
    
}
