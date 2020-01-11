using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAwayII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = player_box.Location.X;

            if (e.KeyCode == Keys.Right && x < 1166) x += 144;
            else if (e.KeyCode == Keys.Left && 14 < x) x -= 144;

            if (e.KeyCode == Keys.Escape) this.Close();

            player_box.Location = new Point(x, 890);
        }

        private Movement M = new Movement();


        private void pause(object sender, EventArgs e)
        {
            
        }

        private void Speed1_Tick(object sender, EventArgs e)
        {
            int y = enemy_1.Location.Y;
            enemy_1.Location = new Point(14, y + 10);

            M.y1 = y;
            speed1.Interval = M.Spd_1; 
        }
    }
}
