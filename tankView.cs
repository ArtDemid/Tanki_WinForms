using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanki_WF
{
    class TankView
    {
        string whoIs;
        public Bitmap tankImg;

        public TankView(string whoIs, int power)
        //public TankView(UInt16 power)
        {
            this.whoIs = whoIs;
            switch (whoIs)
            {
                case "player":
                    tankImg = new Bitmap(@"img\player_tank_r.png");
                    break;
                case "enemy":
                    tankImg = new Bitmap(@"img\enemy_tank_r.png");
                    break;
                case "boss":
                    break;
                default:
                    break;
            }  
        }

        public void ChangeView(string whoIs, string direction)
        {
            if(whoIs == "player")
            {
                switch (direction)
                {
                    case "right":
                        tankImg = new Bitmap(@"img\player_tank_r.png");
                        break;
                    case "left":
                        tankImg = new Bitmap(@"img\player_tank_l.png");
                        break;
                    case "up":
                        tankImg = new Bitmap(@"img\player_tank_u.png");
                        break;
                    case "down":
                        tankImg = new Bitmap(@"img\player_tank_d.png");
                        break;
                    default:
                        break;
                }
            }

            if (whoIs == "enemy")
            {
                switch (direction)
                {
                    case "right":
                        tankImg = new Bitmap(@"img\enemy_tank_r.png");
                        break;
                    case "left":
                        tankImg = new Bitmap(@"img\enemy_tank_l.png");
                        break;
                    case "up":
                        tankImg = new Bitmap(@"img\enemy_tank_u.png");
                        break;
                    case "down":
                        tankImg = new Bitmap(@"img\enemy_tank_d.png");
                        break;
                    default:
                        break;
                }
            }
        }


        
    }
}
