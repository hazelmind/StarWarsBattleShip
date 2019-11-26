using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class ShipTypes
    {
        public class Light
        {
        public List<Ship> LightShips { get; set; }
        }
        public class Dark
        {
        public List<Ship> DarkShips { get; set; }
        }

        internal static ShipTypes Light()
        {
            throw new NotImplementedException();
        }
    }
}
