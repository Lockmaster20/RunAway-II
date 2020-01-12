namespace RunAwayII
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.score = new System.Windows.Forms.Label();
            this.pause_game = new System.Windows.Forms.Label();
            this.speed1 = new System.Windows.Forms.Timer(this.components);
            this.speed2 = new System.Windows.Forms.Timer(this.components);
            this.speed3 = new System.Windows.Forms.Timer(this.components);
            this.speed4 = new System.Windows.Forms.Timer(this.components);
            this.speed5 = new System.Windows.Forms.Timer(this.components);
            this.speed6 = new System.Windows.Forms.Timer(this.components);
            this.speed7 = new System.Windows.Forms.Timer(this.components);
            this.speed8 = new System.Windows.Forms.Timer(this.components);
            this.speed9 = new System.Windows.Forms.Timer(this.components);
            this.player_box = new System.Windows.Forms.PictureBox();
            this.form_Closer = new System.Windows.Forms.PictureBox();
            this.taskbar = new System.Windows.Forms.PictureBox();
            this.enemy_8 = new System.Windows.Forms.PictureBox();
            this.enemy_6 = new System.Windows.Forms.PictureBox();
            this.enemy_4 = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_7 = new System.Windows.Forms.PictureBox();
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.enemy_9 = new System.Windows.Forms.PictureBox();
            this.enemy_5 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_Closer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(73)))));
            this.score.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.score.Location = new System.Drawing.Point(0, 990);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(181, 34);
            this.score.TabIndex = 22;
            this.score.Text = "0000000";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pause_game
            // 
            this.pause_game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(73)))));
            this.pause_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_game.Location = new System.Drawing.Point(590, 990);
            this.pause_game.Name = "pause_game";
            this.pause_game.Size = new System.Drawing.Size(100, 32);
            this.pause_game.TabIndex = 23;
            this.pause_game.Text = "I I";
            this.pause_game.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pause_game.Click += new System.EventHandler(this.pause);
            // 
            // speed1
            // 
            this.speed1.Enabled = true;
            this.speed1.Interval = 1;
            this.speed1.Tick += new System.EventHandler(this.Speed1_Tick);
            // 
            // speed2
            // 
            this.speed2.Enabled = true;
            this.speed2.Interval = 1;
            this.speed2.Tick += new System.EventHandler(this.Speed2_Tick);
            // 
            // speed3
            // 
            this.speed3.Enabled = true;
            this.speed3.Interval = 1;
            this.speed3.Tick += new System.EventHandler(this.Speed3_Tick);
            // 
            // speed4
            // 
            this.speed4.Enabled = true;
            this.speed4.Interval = 1;
            this.speed4.Tick += new System.EventHandler(this.Speed4_Tick);
            // 
            // speed5
            // 
            this.speed5.Enabled = true;
            this.speed5.Interval = 1;
            this.speed5.Tick += new System.EventHandler(this.Speed5_Tick);
            // 
            // speed6
            // 
            this.speed6.Enabled = true;
            this.speed6.Interval = 1;
            this.speed6.Tick += new System.EventHandler(this.Speed6_Tick);
            // 
            // speed7
            // 
            this.speed7.Enabled = true;
            this.speed7.Interval = 1;
            this.speed7.Tick += new System.EventHandler(this.Speed7_Tick);
            // 
            // speed8
            // 
            this.speed8.Enabled = true;
            this.speed8.Interval = 1;
            this.speed8.Tick += new System.EventHandler(this.Speed8_Tick);
            // 
            // speed9
            // 
            this.speed9.Enabled = true;
            this.speed9.Interval = 1;
            this.speed9.Tick += new System.EventHandler(this.Speed9_Tick);
            // 
            // player_box
            // 
            this.player_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(124)))), ((int)(((byte)(167)))));
            this.player_box.Location = new System.Drawing.Point(590, 890);
            this.player_box.Name = "player_box";
            this.player_box.Size = new System.Drawing.Size(100, 100);
            this.player_box.TabIndex = 16;
            this.player_box.TabStop = false;
            // 
            // form_Closer
            // 
            this.form_Closer.BackColor = System.Drawing.Color.DarkRed;
            this.form_Closer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.form_Closer.Location = new System.Drawing.Point(1248, 997);
            this.form_Closer.Name = "form_Closer";
            this.form_Closer.Size = new System.Drawing.Size(25, 20);
            this.form_Closer.TabIndex = 0;
            this.form_Closer.TabStop = false;
            this.form_Closer.Click += new System.EventHandler(this.FormClose);
            // 
            // taskbar
            // 
            this.taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(73)))));
            this.taskbar.Location = new System.Drawing.Point(0, 990);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(1280, 34);
            this.taskbar.TabIndex = 21;
            this.taskbar.TabStop = false;
            // 
            // enemy_8
            // 
            this.enemy_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_8.BackgroundImage")));
            this.enemy_8.Location = new System.Drawing.Point(1022, 12);
            this.enemy_8.Name = "enemy_8";
            this.enemy_8.Size = new System.Drawing.Size(100, 100);
            this.enemy_8.TabIndex = 20;
            this.enemy_8.TabStop = false;
            // 
            // enemy_6
            // 
            this.enemy_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_6.BackgroundImage")));
            this.enemy_6.Location = new System.Drawing.Point(734, 12);
            this.enemy_6.Name = "enemy_6";
            this.enemy_6.Size = new System.Drawing.Size(100, 100);
            this.enemy_6.TabIndex = 19;
            this.enemy_6.TabStop = false;
            // 
            // enemy_4
            // 
            this.enemy_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_4.BackgroundImage")));
            this.enemy_4.Location = new System.Drawing.Point(446, 12);
            this.enemy_4.Name = "enemy_4";
            this.enemy_4.Size = new System.Drawing.Size(100, 100);
            this.enemy_4.TabIndex = 18;
            this.enemy_4.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_2.BackgroundImage")));
            this.enemy_2.Location = new System.Drawing.Point(158, 12);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(100, 100);
            this.enemy_2.TabIndex = 17;
            this.enemy_2.TabStop = false;
            // 
            // enemy_7
            // 
            this.enemy_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_7.BackgroundImage")));
            this.enemy_7.Location = new System.Drawing.Point(878, 12);
            this.enemy_7.Name = "enemy_7";
            this.enemy_7.Size = new System.Drawing.Size(100, 100);
            this.enemy_7.TabIndex = 15;
            this.enemy_7.TabStop = false;
            // 
            // enemy_3
            // 
            this.enemy_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_3.BackgroundImage")));
            this.enemy_3.Location = new System.Drawing.Point(302, 12);
            this.enemy_3.Name = "enemy_3";
            this.enemy_3.Size = new System.Drawing.Size(100, 100);
            this.enemy_3.TabIndex = 9;
            this.enemy_3.TabStop = false;
            // 
            // enemy_9
            // 
            this.enemy_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_9.BackgroundImage")));
            this.enemy_9.Location = new System.Drawing.Point(1166, 12);
            this.enemy_9.Name = "enemy_9";
            this.enemy_9.Size = new System.Drawing.Size(100, 100);
            this.enemy_9.TabIndex = 8;
            this.enemy_9.TabStop = false;
            // 
            // enemy_5
            // 
            this.enemy_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_5.BackgroundImage")));
            this.enemy_5.Location = new System.Drawing.Point(590, 12);
            this.enemy_5.Name = "enemy_5";
            this.enemy_5.Size = new System.Drawing.Size(100, 100);
            this.enemy_5.TabIndex = 2;
            this.enemy_5.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.enemy_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_1.BackgroundImage")));
            this.enemy_1.Location = new System.Drawing.Point(14, 12);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(100, 100);
            this.enemy_1.TabIndex = 1;
            this.enemy_1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.player_box);
            this.Controls.Add(this.pause_game);
            this.Controls.Add(this.score);
            this.Controls.Add(this.form_Closer);
            this.Controls.Add(this.taskbar);
            this.Controls.Add(this.enemy_8);
            this.Controls.Add(this.enemy_6);
            this.Controls.Add(this.enemy_4);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_7);
            this.Controls.Add(this.enemy_3);
            this.Controls.Add(this.enemy_9);
            this.Controls.Add(this.enemy_5);
            this.Controls.Add(this.enemy_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_Closer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox form_Closer;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_5;
        private System.Windows.Forms.PictureBox enemy_9;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.PictureBox enemy_7;
        private System.Windows.Forms.PictureBox player_box;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox enemy_4;
        private System.Windows.Forms.PictureBox enemy_6;
        private System.Windows.Forms.PictureBox enemy_8;
        private System.Windows.Forms.PictureBox taskbar;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label pause_game;
        private System.Windows.Forms.Timer speed1;
        private System.Windows.Forms.Timer speed2;
        private System.Windows.Forms.Timer speed3;
        private System.Windows.Forms.Timer speed4;
        private System.Windows.Forms.Timer speed5;
        private System.Windows.Forms.Timer speed6;
        private System.Windows.Forms.Timer speed7;
        private System.Windows.Forms.Timer speed8;
        private System.Windows.Forms.Timer speed9;
    }
}

