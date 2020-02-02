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

        private Time T = new Time();
        void Master_Tick(object sender, EventArgs e)
        {
            speed1.Enabled = T.t1;
            speed2.Enabled = T.t2;
            speed3.Enabled = T.t3;
            speed4.Enabled = T.t4;
            speed5.Enabled = T.t5;
            speed6.Enabled = T.t6;
            speed7.Enabled = T.t7;
            speed8.Enabled = T.t8;
            speed9.Enabled = T.t9;
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = player_box.Location.X;
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.P) T.pausing();
            if (e.KeyCode == Keys.Space) T.start();
            if (e.KeyCode == Keys.S) music();
            if (mov > 0 && speed1.Enabled == false) if (e.KeyCode == Keys.R) reset();
            if (mov > 0 && speed1.Enabled == false) if (e.KeyCode == Keys.M) menu();
            if (speed1.Enabled == true)
            {
                if (e.KeyCode == Keys.Right && x < 1166) x += 144;
                else if (e.KeyCode == Keys.Left && 14 < x) x -= 144;
                player_box.Location = new Point(x, 890);
            } 
        }
        
        void reset()
        {
            T.stop();
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
        }

        void loose_Tick(object sender, EventArgs e)
        {
            score.Text = pontos.ToString();
            if (player_box.Bounds.IntersectsWith(enemy_1.Bounds) || player_box.Bounds.IntersectsWith(enemy_2.Bounds) || player_box.Bounds.IntersectsWith(enemy_3.Bounds) || player_box.Bounds.IntersectsWith(enemy_4.Bounds) || player_box.Bounds.IntersectsWith(enemy_5.Bounds) || player_box.Bounds.IntersectsWith(enemy_6.Bounds) || player_box.Bounds.IntersectsWith(enemy_7.Bounds) || player_box.Bounds.IntersectsWith(enemy_8.Bounds) || player_box.Bounds.IntersectsWith(enemy_9.Bounds)) 
            {
                T.stop();
            }
        }

        void menu()
        {
            if (label1.Visible == true) label1.Visible = false; else label1.Visible = true;
            if (label2.Visible == true) label2.Visible = false; else label2.Visible = true;
            if (label3.Visible == true) label3.Visible = false; else label3.Visible = true;
            if (help.Visible == true) help.Visible = false; else help.Visible = true;
        }

        private int mov = 0;
        private int pontos = 0;
        private int bit = 0;
        private bool on = false;

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

        void pause(object sender, EventArgs e)
        {
            T.pausing();
        }

        private Movement M = new Movement();
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

        //private const string sHTMLHelpFileName = "Ajuda.chm";
        private void Help_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"\" + sHTMLHelpFileName);
        }

        public void music()
        {
            System.IO.Stream str = Properties.Resources.dance;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            if (on == false) { snd.PlayLooping(); on = true; Sound_Box.BackColor = Color.Lime; }
            else { snd.Stop(); on = false; Sound_Box.BackColor = Color.Crimson; }
        }

        private void som(object sender, EventArgs e)
        {
            music();
        }
    }
}