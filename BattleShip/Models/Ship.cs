using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class Ship
    {
        public string ShipName { get; set; }
        public int ShipSize { get; set; } //total lenght
        public int ShipHealth { get; set; } //1 health point for each space -when hit 0 -when
    }
}
