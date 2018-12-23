using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanki_WF
{
    class Tank
    {
        int with;
        int height;
        int location_x;
        int location_y;
        int health;
        bool isAlive;
        int lives;
        public string whoAmI;
        public int power;

        public TankView view;
        public PictureBox plPB;

        static object locker = new object();

        //public Tank(string whoAmI, int location_x, int location_y)
        public Tank(string whoAmI, int location_x, int location_y)
        {

            //this.power = 1;
            this.whoAmI = whoAmI;
            this.location_x = location_x;
            this.location_y = location_y;

            //player.plPB.Location = new Point(battleField_panel.Left, battleField_panel.Top);
            //enemy.plPB.Location = new Point(battleField_panel.Right - enemy.plPB.Width, battleField_panel.Bottom - enemy.plPB.Height * 2);

            plPB = new PictureBox();
            view = new TankView(whoAmI, power);
            plPB.Image = view.tankImg;
            plPB.Location = new Point(location_x, location_y);
        }

        public void Move(string direction, int rate)
        {
            switch (direction)
            {
                case "right":
                    view.ChangeView(whoAmI, direction);
                    plPB.Height = view.tankImg.Height;
                    plPB.Width = view.tankImg.Width;
                    plPB.Image = view.tankImg;

                    if (plPB.Location.X > 430)
                    {
                        plPB.Location = new Point(10 + rate, plPB.Location.Y);
                    }
                    else
                    {
                        plPB.Location = new Point(plPB.Location.X + rate, plPB.Location.Y);
                    }
                    break;
                case "left":
                    view.ChangeView(whoAmI, direction);
                    plPB.Height = view.tankImg.Height;
                    plPB.Width = view.tankImg.Width;
                    plPB.Image = view.tankImg;
                    lock (locker)
                    {
                        if (plPB.Location.X < 0)
                        {
                            plPB.Location = new Point(425 + rate, plPB.Location.Y);
                        }
                        else
                        {
                            plPB.Location = new Point(plPB.Location.X - rate, plPB.Location.Y);
                        }
                    }

                    break;
                case "up":
                    view.ChangeView(whoAmI, direction);
                    plPB.Height = view.tankImg.Height;
                    plPB.Width = view.tankImg.Width;
                    plPB.Image = view.tankImg;

                    if (plPB.Location.Y < 0)
                    {
                        plPB.Location = new Point(plPB.Location.X, 350 - rate);
                    }
                    else
                    {
                        plPB.Location = new Point(plPB.Location.X, plPB.Location.Y - rate);
                    }
                    break;
                case "down":
                    view.ChangeView(whoAmI, direction);
                    plPB.Height = view.tankImg.Height;
                    plPB.Width = view.tankImg.Width;
                    plPB.Image = view.tankImg;

                    if (plPB.Location.Y > 350)
                    {
                        plPB.Location = new Point(plPB.Location.X, 0 + rate);
                    }
                    else
                    {
                        plPB.Location = new Point(plPB.Location.X, plPB.Location.Y + rate);
                    }
                    break;
                default:
                    break;
            }
        }

        public void GetHit(UInt16 powerOfHit)
        {

        }

        public void Fire()
        {

        }
    }
}
