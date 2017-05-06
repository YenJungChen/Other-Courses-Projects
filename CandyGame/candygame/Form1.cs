using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Media;
namespace candygame
{
    public partial class Form1 : Form
    {
        PictureBox[] pic = new PictureBox[11];

        public Form1()
        {
            InitializeComponent();

        }

        private int ZOOMSIZE = 25;

        public void musicplayer(int check)
        {
            SoundPlayer myMusic = new SoundPlayer(Properties.Resources.mario_piano);
            if (check == 1)
                myMusic.Play();
            else
                myMusic.Stop();
        }

        private void fall(object f)
        {
            PictureBox fruit = (PictureBox)f;

            while (fruit.Top <= 550)
            {
                int candyI = Convert.ToInt32(fruit.Name.Substring(fruit.Name.IndexOf("y") + 1));

                fruit.Invoke(new Action(() => fruit.Top++));

                if (candyI <= 5)
                    Thread.Sleep(20);
                else if (candyI <= 7)
                    Thread.Sleep(15);
                else if (candyI <= 10)
                    Thread.Sleep(10);
                else
                    Thread.Sleep(5);

            }
        }

        public void falldown()
        {
            Random r = new Random();
            PictureBox p = new PictureBox();
            int i = r.Next(1, 13);
            p = new PictureBox();
            p.Image = (Image)Properties.Resources.ResourceManager.GetObject("candy" + i.ToString());
            p.Name = "candy" + i.ToString();

            p.SizeMode = PictureBoxSizeMode.StretchImage;
            if (i < 6)
            {
                p.Height = 35;
                p.Width = 70;
            }
            else
            {
                p.Height = 50;
                p.Width = 50;
            }
            p.BackColor = Color.Transparent;
            p.Visible = false;
            this.Controls.Add(p);

            //p = pic[r.Next(1, 11)];
            p.Left = r.Next(0, 750 - p.Width - 150);
            p.Top = -p.Height;
            p.Visible = true;
            p.BringToFront();
            ParameterizedThreadStart ParStart = new ParameterizedThreadStart(fall);
            Thread myThread = new Thread(ParStart);

            myThread.Start(p);
            //myThread.Join();
        }

        public void create()
        {
            createTimer.Interval = 10;
            createTimer.Enabled = true;
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            createTimer.Interval = 1000;
            falldown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            die.Visible = false;
            ag.Visible = false;
            again.Visible = false;
            finalscore.Visible = false;
            catchgirl.Visible = false;
            score.Visible = false;
            sky.Visible = true;
            sky.Width = 750;
            sky.Height = 548;
            musicplayer(1);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic2.Visible = pic1.Visible = sky.Visible = false;
            checkCollapse.Enabled = music.Visible = true;
            catchgirl.Visible = true;
            score.Visible = true;
            create();
        }
        private void pic1_MouseEnter(object sender, EventArgs e)
        {
            pic1.Width = pic1.Width + ZOOMSIZE;
            pic1.Height = pic1.Height + (ZOOMSIZE / 2);
            pic1.Top = pic1.Top - (ZOOMSIZE / 4);
            pic1.Left = pic1.Left - (ZOOMSIZE / 2);
        }

        private void pic1_MouseLeave(object sender, EventArgs e)
        {
            pic1.Width = pic1.Width - ZOOMSIZE;
            pic1.Height = pic1.Height - (ZOOMSIZE / 2);
            pic1.Top = pic1.Top + (ZOOMSIZE / 4);
            pic1.Left = pic1.Left + (ZOOMSIZE / 2);
        }

        private void pic2_MouseEnter(object sender, EventArgs e)
        {
            pic2.Width = pic2.Width + ZOOMSIZE;
            pic2.Height = pic2.Height + (ZOOMSIZE / 2);
            pic2.Top = pic2.Top - (ZOOMSIZE / 4);
            pic2.Left = pic2.Left - (ZOOMSIZE / 2);
        }

        private void pic2_MouseLeave(object sender, EventArgs e)
        {
            pic2.Width = pic2.Width - ZOOMSIZE;
            pic2.Height = pic2.Height - (ZOOMSIZE / 2);
            pic2.Top = pic2.Top + (ZOOMSIZE / 4);
            pic2.Left = pic2.Left + (ZOOMSIZE / 2);
        }

        private void music_Click(object sender, EventArgs e)
        {
            music.Visible = false;
            music2.Visible = true;
            musicplayer(0);
        }

        private void music2_Click(object sender, EventArgs e)
        {
            music2.Visible = false;
            music.Visible = true;
            musicplayer(1);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            help.Visible = true;
            close.Visible = true;
            help.Height = 548;
            help.Width = 488;
            music2.Visible = false;
            music.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            help.Visible = false;
            close.Visible = false;
            music.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (catchgirl.Left < 600 - 75)
                {
                    catchgirl.Left += 20;

                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (catchgirl.Left >= 0)
                    catchgirl.Left -= 20;
            }
        }

        private void checkCollapse_Tick(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].Name.Contains("candy"))
                {
                    if ((this.Controls[i].Top + this.Controls[i].Height - 5) >= catchgirl.Top
                        && (this.Controls[i].Top + this.Controls[i].Height - 5) <= catchgirl.Top + 100
                        && this.Controls[i].Left >= catchgirl.Left && this.Controls[i].Left <= (catchgirl.Left + catchgirl.Width / 2))
                    {
                        Debug.Print(this.Controls[i].Top.ToString());
                        int candyI = Convert.ToInt32(this.Controls[i].Name.Substring(this.Controls[i].Name.IndexOf("y") + 1));

                        switch (candyI)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                score.Text = (Convert.ToInt32(score.Text) + 1).ToString();
                                break;
                            case 6:
                            case 7:
                                score.Text = (Convert.ToInt32(score.Text) + 2).ToString();
                                break;
                            case 8:
                            case 9:
                            case 10:
                                score.Text = (Convert.ToInt32(score.Text) + 3).ToString();
                                break;
                            case 11://boom
                                catchgirl.Image = (Image)Properties.Resources.ResourceManager.GetObject("boomgirl");
                                checkCollapse.Enabled = false;
                                createTimer.Enabled = false;
                                die.Visible = true;
                                booooom.Height = 137;
                                booooom.Width = 514;
                                booooom.Visible = true;
                                break;
                            case 12:
                                checkCollapse.Enabled = false;
                                createTimer.Enabled = false;
                                Form2 obj = new Form2(score.Text);
                                obj.ShowDialog();
                                this.score.Text = obj.TextBoxMsg;
                                createTimer.Enabled = true;
                                checkCollapse.Enabled = true;
                                musicplayer(1);
                                break;
                        }

                        this.Controls[i].Visible = false;
                        this.Controls.RemoveAt(i);
                    }
                }
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void die_Click(object sender, EventArgs e)
        {
            die.Visible = false;
            score.Visible = false;
            again.Height = 548;
            again.Width = 488;
            again.Visible = true;
            scoregot.Visible = true;
            finalscore.Height = 224;
            finalscore.Width = 318;
            finalscore.Visible = true;
            catchgirl.Visible = false;
            label1.Text = score.Text;
            label1.Visible = true;
            ag.Visible = true;
            gameover.Visible = true;
            booooom.Visible = false;
        }
        private void die_MouseEnter(object sender, EventArgs e)
        {
            die.Width = die.Width + ZOOMSIZE;
            die.Height = die.Height + (ZOOMSIZE / 2);
            die.Top = die.Top - (ZOOMSIZE / 4);
            die.Left = die.Left - (ZOOMSIZE / 2);
        }

        private void die_MouseLeave(object sender, EventArgs e)
        {
            die.Width = die.Width - ZOOMSIZE;
            die.Height = die.Height - (ZOOMSIZE / 2);
            die.Top = die.Top + (ZOOMSIZE / 4);
            die.Left = die.Left + (ZOOMSIZE / 2);
        }

        private void ag_MouseEnter(object sender, EventArgs e)
        {
            ag.Width = ag.Width + ZOOMSIZE;
            ag.Height = ag.Height + (ZOOMSIZE / 2);
            ag.Top = ag.Top - (ZOOMSIZE / 4);
            ag.Left = ag.Left - (ZOOMSIZE / 2);
        }

        private void ag_MouseLeave(object sender, EventArgs e)
        {
            ag.Width = ag.Width - ZOOMSIZE;
            ag.Height = ag.Height - (ZOOMSIZE / 2);
            ag.Top = ag.Top + (ZOOMSIZE / 4);
            ag.Left = ag.Left + (ZOOMSIZE / 2);
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ag.Width = ag.Width + ZOOMSIZE;
            ag.Height = ag.Height + (ZOOMSIZE / 2);
            ag.Top = ag.Top - (ZOOMSIZE / 4);
            ag.Left = ag.Left - (ZOOMSIZE / 2);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ag.Width = ag.Width - ZOOMSIZE;
            ag.Height = ag.Height - (ZOOMSIZE / 2);
            ag.Top = ag.Top + (ZOOMSIZE / 4);
            ag.Left = ag.Left + (ZOOMSIZE / 2);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            gameover.Width = gameover.Width + ZOOMSIZE;
            gameover.Height = gameover.Height + (ZOOMSIZE / 2);
            gameover.Top = gameover.Top - (ZOOMSIZE / 4);
            gameover.Left = gameover.Left - (ZOOMSIZE / 2);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            gameover.Width = gameover.Width - ZOOMSIZE;
            gameover.Height = gameover.Height - (ZOOMSIZE / 2);
            gameover.Top = gameover.Top + (ZOOMSIZE / 4);
            gameover.Left = gameover.Left + (ZOOMSIZE / 2);
        }

        private void ag_Click(object sender, EventArgs e)
        {
            pic2.Visible = pic1.Visible = sky.Visible = false;
            checkCollapse.Enabled = music.Visible = true;
            catchgirl.Visible = true;
            score.Visible = true;
            again.Visible = false;
            gameover.Visible = false;
            label1.Visible = false;
            finalscore.Visible = false;
            score.Text = (0).ToString();
            catchgirl.Image = (Image)Properties.Resources.ResourceManager.GetObject("catchgirl");
            ag.Visible = false;
            scoregot.Visible = false;
            create();
        }

        private void gameover_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}