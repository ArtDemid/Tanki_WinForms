using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanki_WF
{
    public partial class Tanki : Form
    {
        Player player;
        Enemy enemy;
        List<Tank> enemyList;
        string lastDirection;
        int rate = 10;
        static object locker = new object();
        //bool unboard;

        public Tanki()
        {
            InitializeComponent();
            battleField_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            player = new Player("player",battleField_panel.Left, battleField_panel.Top);
            enemy = new Enemy("enemy", battleField_panel.Left, battleField_panel.Top);
            //enemy = new Enemy("enemy", battleField_panel.Right - enemy.plPB.Width, battleField_panel.Bottom - enemy.plPB.Height * 2);

            Thread enemyThread = new Thread(new ThreadStart(ComputerMove));
            
            Show();
            
            //ComputerMove();
            this.KeyDown += Tanki_KeyDown;
            this.KeyUp += Tanki_KeyUp;

            enemyThread.Start();
        }

        private void Tanki_KeyUp(object sender, KeyEventArgs e)
        {
            //unboard = false;
        }

        private void Tanki_KeyDown(object sender, KeyEventArgs e)
        {
            //rate = 10;
            //unboard = CheckBoards();
            //if (unboard == true)
            //{
            //    rate = 0;
            //}
            //else
            //{
            //    rate = 10;
            //}

            if (e.KeyCode == Keys.Down)
            {
                string direction = "down";
                lastDirection = direction;
                player.Move(direction, rate);
                Show();

            }

            if (e.KeyCode == Keys.Up)
            {
                string direction = "up";
                lastDirection = direction;
                player.Move(direction, rate);
                Show();
            }

            if (e.KeyCode == Keys.Right)
            {
                string direction = "right";
                lastDirection = direction;
                player.Move(direction, rate);
                Show();
            }

            if (e.KeyCode == Keys.Left)
            {
                string direction = "left";
                lastDirection = direction;
                //lock (locker) {
                    player.Move(direction, rate);
                    
                //}
                Show();

            }
        }

        public void Show()
        {
            exlb.Text = player.plPB.Location.X.ToString();
            eylb.Text = player.plPB.Location.Y.ToString();
            ehlb.Text = player.plPB.Height.ToString();
            ewlb.Text = player.plPB.Width.ToString();

            battleField_panel.Controls.Add(player.plPB);
            battleField_panel.Controls.Add(enemy.plPB);

            battleField_panel.Show();
            Color color = Color.LightGray;
            battleField_panel.BackColor = color;
        }

        public void ComputerMove()
        {
            Random rnd = new Random();
            while (true)
            {
                string direction = "left";
                lastDirection = direction;
                enemy.Move(direction, 10);
            }
        }

        //public bool CheckBoards()
        //{
        //    unboard = false;
        //    if (player.plPB.Location.X < 0 ||
        //        player.plPB.Location.X > 425 ||
        //        player.plPB.Location.Y < 0 ||
        //        player.plPB.Location.Y > 350)
        //    {

        //        //unboard = true;
        //    }
        //    return unboard;
        //}
    }
}
