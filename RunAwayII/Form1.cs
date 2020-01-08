﻿using System;
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

        /*Movement erro = new Movement();
        private void move(object sender, EventArgs e)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }*/

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = player_box.Location.X;

            if (e.KeyCode == Keys.Right) x += 144;
            else if (e.KeyCode == Keys.Left) x -= 144;

            if (e.KeyCode == Keys.Escape) this.Close();

            player_box.Location = new Point(x, 890);
        }

        private void Falling_Tick(object sender, EventArgs e)
        {
            int e5 = enemy_5.Location.Y;
            e5 -= 10;
            enemy_5.Location = new Point(590, e5);
        }
    }
}
