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
    public partial class RunAwayII : Form
    {
        public RunAwayII()
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
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.P) pausing();
            if (e.KeyCode == Keys.Space) start();
            if (e.KeyCode == Keys.R) reset();
            if (mov > 0 && speed1.Enabled == false) if (e.KeyCode == Keys.M) menu();
            if (speed1.Enabled == true)
            {
                if (e.KeyCode == Keys.Right && x < 1166) x += 144;
                else if (e.KeyCode == Keys.Left && 14 < x) x -= 144;
                player_box.Location = new Point(x, 890);
            } 
        }

        void start()
        {
            speed1.Enabled = true;
            speed2.Enabled = true;
            speed3.Enabled = true;
            speed4.Enabled = true;
            speed5.Enabled = true;
            speed6.Enabled = true;
            speed7.Enabled = true;
            speed8.Enabled = true;
            speed9.Enabled = true;
        }

        void stop()
        {
            speed1.Enabled = false;
            speed2.Enabled = false;
            speed3.Enabled = false;
            speed4.Enabled = false;
            speed5.Enabled = false;
            speed6.Enabled = false;
            speed7.Enabled = false;
            speed8.Enabled = false;
            speed9.Enabled = false;
        }

        void pausing()
        {
            if (speed1.Enabled == true) speed1.Enabled = false; else speed1.Enabled = true;
            if (speed2.Enabled == true) speed2.Enabled = false; else speed2.Enabled = true;
            if (speed3.Enabled == true) speed3.Enabled = false; else speed3.Enabled = true;
            if (speed4.Enabled == true) speed4.Enabled = false; else speed4.Enabled = true;
            if (speed5.Enabled == true) speed5.Enabled = false; else speed5.Enabled = true;
            if (speed6.Enabled == true) speed6.Enabled = false; else speed6.Enabled = true;
            if (speed7.Enabled == true) speed7.Enabled = false; else speed7.Enabled = true;
            if (speed8.Enabled == true) speed8.Enabled = false; else speed8.Enabled = true;
            if (speed9.Enabled == true) speed9.Enabled = false; else speed9.Enabled = true;
        }

        void reset()
        {
            enemy_1.Location = new Point(14, 12);
            enemy_2.Location = new Point(158, 12);
            enemy_3.Location = new Point(302, 12);
            enemy_4.Location = new Point(446, 12);
            enemy_5.Location = new Point(590, 12);
            enemy_6.Location = new Point(734, 12);
            enemy_7.Location = new Point(878, 12);
            enemy_8.Location = new Point(1022, 12);
            enemy_9.Location = new Point(1166, 12);
            player_box.Location = new Point(590, 890);
            pontos = 0;
            stop();
        }

        private Movement M = new Movement();

        private void loose_Tick(object sender, EventArgs e)
        {
            score.Text = pontos.ToString();

            if (player_box.Bounds.IntersectsWith(enemy_1.Bounds) || player_box.Bounds.IntersectsWith(enemy_2.Bounds) || player_box.Bounds.IntersectsWith(enemy_3.Bounds) || player_box.Bounds.IntersectsWith(enemy_4.Bounds) || player_box.Bounds.IntersectsWith(enemy_5.Bounds) || player_box.Bounds.IntersectsWith(enemy_6.Bounds) || player_box.Bounds.IntersectsWith(enemy_7.Bounds) || player_box.Bounds.IntersectsWith(enemy_8.Bounds) || player_box.Bounds.IntersectsWith(enemy_9.Bounds)) 
            {
                stop();
            }
        }

        void menu()
        {
            if (label1.Visible == true) label1.Visible = false; else label1.Visible = true;
            if (label2.Visible == true) label2.Visible = false; else label2.Visible = true;
            if (label3.Visible == true) label3.Visible = false; else label3.Visible = true;
            if (help.Visible == true) help.Visible = false; else help.Visible = true;
        }

        private int mov = 0;                                           //f:25, m:35, d:50
        private int pontos = 0;
        private int bit = 0;

        private void Label1_Click(object sender, EventArgs e)
        {
            mov = 25;
            bit = 1;
            menu();
            reset();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            mov = 35;
            bit = 2;
            menu();
            reset();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            mov = 50;
            bit = 3;
            menu();
            reset();
        }

        private void pause(object sender, EventArgs e)                  
        {
            pausing();
        }

        private void Speed1_Tick(object sender, EventArgs e)            
        {
            int y = enemy_1.Location.Y;
            M.y1 = y;
            speed1.Interval = M.Spd_1;
            enemy_1.Location = new Point(14, y + mov);
            if (y > 890)
            {
                enemy_1.Location = new Point(14, 12);
                pontos += bit;
            }
        }

        private void Speed2_Tick(object sender, EventArgs e)
        {
            int y = enemy_2.Location.Y;
            M.y2 = y;
            speed2.Interval = M.Spd_2;
            enemy_2.Location = new Point(158, y + mov);
            if (y > 890)
            {
                enemy_2.Location = new Point(158, 12);
                pontos += bit;
            }
        }

        private void Speed3_Tick(object sender, EventArgs e)
        {
            int y = enemy_3.Location.Y;
            M.y3 = y;
            speed3.Interval = M.Spd_3;
            enemy_3.Location = new Point(302, y + mov);
            if (y > 890)
            {
                enemy_3.Location = new Point(302, 12);
                pontos += bit;
            }
        }

        private void Speed4_Tick(object sender, EventArgs e)
        {
            int y = enemy_4.Location.Y;
            M.y4 = y;
            speed4.Interval = M.Spd_4;
            enemy_4.Location = new Point(446, y + mov);
            if (y > 890)
            {
                enemy_4.Location = new Point(446, 12);
                pontos += bit;
            }
        }

        private void Speed5_Tick(object sender, EventArgs e)
        {
            int y = enemy_5.Location.Y;
            M.y5 = y;
            speed5.Interval = M.Spd_5;
            enemy_5.Location = new Point(590, y + mov);
            if (y > 890)
            {
                enemy_5.Location = new Point(590, 12);
                pontos += bit;                
            }
        }

        private void Speed6_Tick(object sender, EventArgs e)
        {
            int y = enemy_6.Location.Y;
            M.y6 = y;
            speed6.Interval = M.Spd_6;
            enemy_6.Location = new Point(734, y + mov);
            if (y > 890)
            {
                enemy_6.Location = new Point(734, 12);
                pontos += bit;
            }
        }

        private void Speed7_Tick(object sender, EventArgs e)
        {
            int y = enemy_7.Location.Y;
            M.y7 = y;
            speed7.Interval = M.Spd_7;
            enemy_7.Location = new Point(878, y + mov);
            if (y > 890)
            {
                enemy_7.Location = new Point(878, 12);
                pontos += bit;
            }
        }

        private void Speed8_Tick(object sender, EventArgs e)
        {
            int y = enemy_8.Location.Y;
            M.y8 = y;
            speed8.Interval = M.Spd_8;
            enemy_8.Location = new Point(1022, y + mov);
            if (y > 890)
            {
                enemy_8.Location = new Point(1022, 12);
                pontos += bit;
            }
        }

        private void Speed9_Tick(object sender, EventArgs e)
        {
            int y = enemy_9.Location.Y;
            M.y9 = y;
            speed9.Interval = M.Spd_9;
            enemy_9.Location = new Point(1166, y + mov);
            if (y > 890)
            {
                enemy_9.Location = new Point(1166, 12);
                pontos += bit;
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {

        }
    }
}