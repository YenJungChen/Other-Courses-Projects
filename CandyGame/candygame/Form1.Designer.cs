namespace candygame
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.music = new System.Windows.Forms.Label();
            this.music2 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.sky = new System.Windows.Forms.PictureBox();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.catchgirl = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.checkCollapse = new System.Windows.Forms.Timer(this.components);
            this.die = new System.Windows.Forms.PictureBox();
            this.finalscore = new System.Windows.Forms.PictureBox();
            this.again = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoregot = new System.Windows.Forms.Label();
            this.ag = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.PictureBox();
            this.booooom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchgirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.again)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booooom)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(307, 263);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(149, 45);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pic1.MouseEnter += new System.EventHandler(this.pic1_MouseEnter);
            this.pic1.MouseLeave += new System.EventHandler(this.pic1_MouseLeave);
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(307, 357);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(149, 45);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            this.pic2.MouseEnter += new System.EventHandler(this.pic2_MouseEnter);
            this.pic2.MouseLeave += new System.EventHandler(this.pic2_MouseLeave);
            // 
            // music
            // 
            this.music.AutoSize = true;
            this.music.BackColor = System.Drawing.Color.Transparent;
            this.music.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.music.ForeColor = System.Drawing.Color.Yellow;
            this.music.Image = ((System.Drawing.Image)(resources.GetObject("music.Image")));
            this.music.Location = new System.Drawing.Point(705, 105);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(39, 31);
            this.music.TabIndex = 2;
            this.music.Text = "♫";
            this.music.Click += new System.EventHandler(this.music_Click);
            // 
            // music2
            // 
            this.music2.AutoSize = true;
            this.music2.BackColor = System.Drawing.Color.Transparent;
            this.music2.Font = new System.Drawing.Font("微軟正黑體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.music2.ForeColor = System.Drawing.Color.Yellow;
            this.music2.Image = ((System.Drawing.Image)(resources.GetObject("music2.Image")));
            this.music2.Location = new System.Drawing.Point(705, 105);
            this.music2.Name = "music2";
            this.music2.Size = new System.Drawing.Size(39, 31);
            this.music2.TabIndex = 3;
            this.music2.Text = "♫";
            this.music2.Visible = false;
            this.music2.Click += new System.EventHandler(this.music2_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(2, 1);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(94, 72);
            this.help.TabIndex = 4;
            this.help.TabStop = false;
            this.help.Visible = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(705, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 31);
            this.close.TabIndex = 5;
            this.close.TabStop = false;
            this.close.Visible = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // sky
            // 
            this.sky.Image = ((System.Drawing.Image)(resources.GetObject("sky.Image")));
            this.sky.Location = new System.Drawing.Point(2, 1);
            this.sky.Name = "sky";
            this.sky.Size = new System.Drawing.Size(120, 94);
            this.sky.TabIndex = 7;
            this.sky.TabStop = false;
            this.sky.Visible = false;
            // 
            // createTimer
            // 
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // catchgirl
            // 
            this.catchgirl.BackColor = System.Drawing.Color.Transparent;
            this.catchgirl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.catchgirl.Image = ((System.Drawing.Image)(resources.GetObject("catchgirl.Image")));
            this.catchgirl.Location = new System.Drawing.Point(307, 314);
            this.catchgirl.Name = "catchgirl";
            this.catchgirl.Size = new System.Drawing.Size(149, 196);
            this.catchgirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catchgirl.TabIndex = 8;
            this.catchgirl.TabStop = false;
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(641, 25);
            this.score.Name = "score";
            this.score.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.score.Size = new System.Drawing.Size(103, 48);
            this.score.TabIndex = 10;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkCollapse
            // 
            this.checkCollapse.Interval = 50;
            this.checkCollapse.Tick += new System.EventHandler(this.checkCollapse_Tick);
            // 
            // die
            // 
            this.die.BackColor = System.Drawing.Color.Transparent;
            this.die.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.die.Image = ((System.Drawing.Image)(resources.GetObject("die.Image")));
            this.die.Location = new System.Drawing.Point(301, 67);
            this.die.Name = "die";
            this.die.Size = new System.Drawing.Size(149, 45);
            this.die.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die.TabIndex = 11;
            this.die.TabStop = false;
            this.die.Click += new System.EventHandler(this.die_Click);
            this.die.MouseEnter += new System.EventHandler(this.die_MouseEnter);
            this.die.MouseLeave += new System.EventHandler(this.die_MouseLeave);
            // 
            // finalscore
            // 
            this.finalscore.BackColor = System.Drawing.Color.Transparent;
            this.finalscore.Image = ((System.Drawing.Image)(resources.GetObject("finalscore.Image")));
            this.finalscore.Location = new System.Drawing.Point(327, 166);
            this.finalscore.Name = "finalscore";
            this.finalscore.Size = new System.Drawing.Size(78, 56);
            this.finalscore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalscore.TabIndex = 13;
            this.finalscore.TabStop = false;
            // 
            // again
            // 
            this.again.BackColor = System.Drawing.Color.Transparent;
            this.again.Image = ((System.Drawing.Image)(resources.GetObject("again.Image")));
            this.again.Location = new System.Drawing.Point(2, 1);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(146, 122);
            this.again.TabIndex = 14;
            this.again.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Image = global::candygame.Properties.Resources.cloudd;
            this.label1.Location = new System.Drawing.Point(411, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 85);
            this.label1.TabIndex = 15;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // scoregot
            // 
            this.scoregot.AutoSize = true;
            this.scoregot.BackColor = System.Drawing.Color.Transparent;
            this.scoregot.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scoregot.Location = new System.Drawing.Point(292, 89);
            this.scoregot.Name = "scoregot";
            this.scoregot.Size = new System.Drawing.Size(312, 50);
            this.scoregot.TabIndex = 16;
            this.scoregot.Text = "花媽得到的分數:";
            this.scoregot.Visible = false;
            // 
            // ag
            // 
            this.ag.BackColor = System.Drawing.Color.Transparent;
            this.ag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ag.Image = global::candygame.Properties.Resources.ag;
            this.ag.Location = new System.Drawing.Point(327, 435);
            this.ag.Name = "ag";
            this.ag.Size = new System.Drawing.Size(149, 45);
            this.ag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ag.TabIndex = 17;
            this.ag.TabStop = false;
            this.ag.Visible = false;
            this.ag.Click += new System.EventHandler(this.ag_Click);
            this.ag.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.ag.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.Color.Transparent;
            this.gameover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameover.Image = global::candygame.Properties.Resources.gameover;
            this.gameover.Location = new System.Drawing.Point(496, 435);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(149, 45);
            this.gameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameover.TabIndex = 18;
            this.gameover.TabStop = false;
            this.gameover.Visible = false;
            this.gameover.Click += new System.EventHandler(this.gameover_Click);
            this.gameover.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.gameover.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // booooom
            // 
            this.booooom.BackColor = System.Drawing.Color.Transparent;
            this.booooom.Image = global::candygame.Properties.Resources.booo;
            this.booooom.Location = new System.Drawing.Point(110, 129);
            this.booooom.Name = "booooom";
            this.booooom.Size = new System.Drawing.Size(73, 46);
            this.booooom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.booooom.TabIndex = 19;
            this.booooom.TabStop = false;
            this.booooom.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(219)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(749, 542);
            this.Controls.Add(this.booooom);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.ag);
            this.Controls.Add(this.scoregot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalscore);
            this.Controls.Add(this.die);
            this.Controls.Add(this.catchgirl);
            this.Controls.Add(this.score);
            this.Controls.Add(this.music2);
            this.Controls.Add(this.music);
            this.Controls.Add(this.close);
            this.Controls.Add(this.help);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.sky);
            this.Controls.Add(this.again);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchgirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.again)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booooom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label music;
        private System.Windows.Forms.Label music2;
        public System.Windows.Forms.PictureBox help;
        public System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox sky;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.PictureBox catchgirl;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer checkCollapse;
        private System.Windows.Forms.PictureBox die;
        private System.Windows.Forms.PictureBox finalscore;
        private System.Windows.Forms.PictureBox again;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoregot;
        private System.Windows.Forms.PictureBox ag;
        private System.Windows.Forms.PictureBox gameover;
        private System.Windows.Forms.PictureBox booooom;

    }
}

