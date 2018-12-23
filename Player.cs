using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanki_WF
{
    class Player:Tank
    {
        //PictureBox plPB;
        //TankView view;

        

        public Player(string whoAmI, int location_x, int location_y) : base(whoAmI, location_x, location_y)
        {
            //this.whoAmI = whoAmI;
            //plPB = new PictureBox();
            //view = new TankView("player", power);
            //plPB.Image = view.tankImg;
            //plPB.Location = new Point(location_x, location_y);
        }
    }
}
