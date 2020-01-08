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

            if (e.KeyCode == Keys.Right) x += 144;
            else if (e.KeyCode == Keys.Left) x -= 144;

            if (e.KeyCode == Keys.Escape) this.Close();

            player_box.Location = new Point(x, 890);
        }


        /*private Movement M = new Movement();

        private void mexe(object sender, EventArgs e)
        {

            M.recebe = enemy_1.Location.Y;

            int y1 = M.v1;
            enemy_1.Location = new Point(14, y1);
        }


        */
        private void Falling_Tick(object sender, EventArgs e)
        {
            //int y1 = M.v1;
            enemy_1.Location = new Point(14, text);
        }

        private Movement M;

        private void Form1_Load(object sender, EventArgs e)
        {
            Movement M = new Movement(this);
        }

        public void test(string text)
        {
            score.Text = text;
        }

        private void pause(object sender, EventArgs e)
        {
            M = new Movement(this);
            M.testexmaple();
        }
    }
}
