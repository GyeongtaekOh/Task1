using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17608116_Oh_task1
{
    public partial class RTSGame : Form
    {
        bool team1 = false;
        Timer t = new Timer();
        int T = 0;
        public Map RTSmap = new Map();
        public RangedUnit Runit = new RangedUnit();
        public MeleeUnit Munit = new MeleeUnit();



        public RTSGame()
        {
            InitializeComponent();
        }

        private void RTSGame_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            createMap();

        }
        public void createMap()
        {
            Mapgrid.Controls.Clear();
            RTSmap.createU();



            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button BT = new Button();
                    if (RTSmap.arrMap[i, j] == "E")
                    {
                        BT.Text = "o";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.button_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "FB1")
                    {
                        BT.Text = "FB1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.button_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "FB2")
                    {
                        BT.Text = "FB2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.button_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "RB1")
                    {
                        BT.Text = "RB1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.button_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "RB2")
                    {
                        BT.Text = "RB2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.button_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "M1")
                    {
                        BT.Text = "M1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonM1_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "M2")
                    {
                        BT.Text = "M2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonM2_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "R1")
                    {
                        BT.Text = "R1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonR1_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "R2")
                    {
                        BT.Text = "R2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonR2_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                }
            }
        }
        private void t_Tick(object sender, EventArgs e)
        {
            timerL.Text = "";

            T++;

            timerL.Text += T.ToString();

        }
        private void button_Click(object sender, EventArgs e)
        {
            unitStats.Text = "empty";
        }
        private void buttonM1_Click(object sender, EventArgs e)
        {
            unitStats.Text = "MeleeUnit" + Environment.NewLine + "Team1";
        }
        private void buttonM2_Click(object sender, EventArgs e)
        {
            unitStats.Text = "MeleeUnit" + Environment.NewLine + "Team2";
        }
        private void buttonR1_Click(object sender, EventArgs e)
        {
            unitStats.Text = "RangedUnit" + Environment.NewLine + "Team1";
        }
        private void buttonR2_Click(object sender, EventArgs e)
        {
            unitStats.Text = "RangedUnit" + Environment.NewLine + "Team2";
        }
        private void timer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            //createMap();
            t.Start();

        }

        private void Stop_Click(object sender, EventArgs e)
        {

            t.Stop();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            createMap();
            T = 0;
            timerL.Text = "0";
        }

        private void Mapgrid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class Unit
    {
        protected string TypeUnit;
        private int xPostion;
        private int yPosition;
        private int health;
        private int speed;
        private int attack;
        private int attackRange;
        private int team;
        private string symbol;


        public int XPosition
        {
            get { return xPostion; }
            set { xPostion = value; }
        }
        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public int Team
        {
            get { return team; }
            set { team = value; }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public Unit()
        {

        }
        public virtual void NewPosition()
        {

        }

        public virtual void Combet()
        {

        }

        public virtual void AttackRangeU()
        {

        }

        public virtual void Return()
        {

        }

        public virtual void Death()
        {

        }

        public virtual void Tostring()
        {

        }
    }

    public class MeleeUnit : Unit
    {
        int Runaway;
        double x, y, z;
        bool range = false;
        bool death = false;
        public override void NewPosition()
        {

        }

        public override void Combet()
        {

            Health = 20;
            Attack = 2;
            AttackRangeU();
            while (death == false)
            {
                NewPosition();
                if (range == true)
                {
                    Health = Health - Attack;
                }

            }
        }

        public override void AttackRangeU()
        {
            AttackRange = 1;

            z = Math.Sqrt(x * x + y * y);

            if (z == AttackRange)
            {
                range = true;
            }
        }

        public override void Return()
        {
            int Runaway = Health / 4;
            if (Health <= Runaway)
            {

            }
        }

        public override void Death()
        {
            if (Health <= 0)
            {
                death = true;
            }
        }


        public override void Tostring()
        {
            TypeUnit = "Knight";
        }
    }
    public class RangedUnit : Unit
    {

        /*public string[,] arrMapR = new string[20, 20];            just tried to build another array to assign unit top of the map array
        int m, n;
        public void createU()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    arrMapR[i, j] = "E";
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                arrMapR[m, n] = "R";
            }
        }*/

        int Runaway;
        double x, y, z;
        bool range = false;
        bool death = false;
        public override void NewPosition()
        {

        }

        public override void Combet()
        {

            Health = 20;
            Attack = 1;
            AttackRangeU();
            while (death == false)
            {
                NewPosition();
                if (range == true)
                {
                    Health = Health - Attack;
                }
            }


        }

        public override void AttackRangeU()
        {
            AttackRange = 3;

            z = Math.Sqrt(x * x + y * y);

            if (z == AttackRange)
            {
                range = true;
            }

        }

        public override void Return()
        {



            int Runaway = Health / 4;
            if (Health <= Runaway)
            {

            }

        }

        public override void Death()
        {
            if (Health <= 0)
            {
                death = true;
            }
        }


        public override void Tostring()
        {
            TypeUnit = "Archer";
        }
    }

    public class Map
    {
        int m, n;
        public string[,] arrMap = new string[20, 20];

        public Map()
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    arrMap[i, j] = "E"; // using for loops to assign the empty space as "E"
                }
            }
        }
        public void createU()
        {
            arrMap[0, 1] = "FB1";
            arrMap[19, 18] = "FB2";
            arrMap[0, 0] = "RB1";
            arrMap[19, 19] = "RB2";
            for (int i = 0; i < 20; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2")
                {
                    arrMap[m, n] = "M1";
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "M1" && arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2")
                {
                    arrMap[m, n] = "M2";
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "M1" && arrMap[m, n] != "M2" && arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2")
                {
                    arrMap[m, n] = "R1";
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "M" && arrMap[m, n] != "M2" && arrMap[m, n] != "R1" && arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2")
                {
                    arrMap[m, n] = "R2";
                }
            }

        }
        public void moveU()
        {

        }

        public class GameEngine
        {


            public GameEngine()
            {


            }

        }
    }
}

