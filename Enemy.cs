using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanki_WF
{
    class Enemy:Tank
    {
        public Enemy(string whoAmI, int location_x, int location_y) : base(whoAmI, location_x, location_y)
        {
        }
    }
}
