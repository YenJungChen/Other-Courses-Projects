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
    public partial class Form2 : Form
    {
        bool jg = false;
        public Form2(string strTextMsg)
        {
            InitializeComponent();
            lab_sc.Text = strTextMsg;
            moneyTime.Enabled = true;
            moneyTime.Interval = 700;
            eat.Enabled = true;
            SoundPlayer myMusic = new SoundPlayer(Properties.Resources.bonous);
            myMusic.Play();
           
        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {                     
            lab_time.Text = (Convert.ToInt32(lab_time.Text) - 1).ToString();           
                 
            if (Convert.ToInt32(lab_time.Text) <= 0)
            {
                timer1.Stop();
                moneyTime.Enabled = false;
                eat.Enabled = false;
                this.Close();
            }
            //Application.DoEvents();
        }
       
        public string TextBoxMsg
        {
            set
            {
                lab_sc.Text = value;
            }
            get
            {
                return lab_sc.Text;
            }
        }
       
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Right)
            {
                if (this.catchgirl.Left < 650 - (this.catchgirl.Width))
                {
                    catchgirl.Left += 8;

                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (catchgirl.Left >= 0 && catchgirl.Top >= 100)
                    catchgirl.Left -= 8;
                else if(catchgirl.Left >= 150)
                    catchgirl.Left -= 8;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (catchgirl.Top >= 0 && catchgirl.Left >= 150)
                    catchgirl.Top -= 8;
                else if (catchgirl.Top >= 100)
                    catchgirl.Top -= 8;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (this.catchgirl.Top < 540 - (this.catchgirl.Height))
                    catchgirl.Top += 8;
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            catchgirl.Visible = true;
            lab_sc.Visible = true;
            lab_time.Visible = true;

            //timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void moneyTime_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            PictureBox p = new PictureBox();
            int i = r.Next(1, 4);
            if (i == 3 && jg == false)
            {
                int j = r.Next(0, 8);
                if (j == 3)
                {
                    i = 3;
                    jg = true;
                }
                else
                {
                    i = 1;
                }
            }
            else
            {
                i = 2;
            }
            p = new PictureBox();
            p.Image = (Image)Properties.Resources.ResourceManager.GetObject("money" + i.ToString());
            p.Name = "money" + i.ToString();

            p.SizeMode = PictureBoxSizeMode.StretchImage;
            if (i ==1)
            {
                p.Height = 20;
                p.Width = 20;
            }
            else
            {
                p.Height = 50;
                p.Width = 50;
            }
            p.BackColor = Color.Transparent;
            //p.Visible = false;
            this.Controls.Add(p);

            //p = pic[r.Next(1, 11)];
            p.Left = r.Next(100, 750 - p.Width - 150);
            p.Top = r.Next(100, 750 - p.Height - 200);
            p.Visible = true;
            
           
        }

        private void eat_Tick(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].Name.Contains("money"))
                {
                    if ((this.Controls[i].Top + this.Controls[i].Height - 5) >= catchgirl.Top
                        && (this.Controls[i].Top + this.Controls[i].Height - 5) <= (this.catchgirl.Top +this.catchgirl.Height) +50
                        && this.Controls[i].Left >= catchgirl.Left && this.Controls[i].Left <= (this.catchgirl.Width + this.catchgirl.Left))
                    {
                        Debug.Print(this.Controls[i].Top.ToString());
                        int candyI = Convert.ToInt32(this.Controls[i].Name.Substring(this.Controls[i].Name.IndexOf("y") + 1));
                        switch (candyI)
                        {
                            case 1:
                                lab_sc.Text = (Convert.ToInt32(lab_sc.Text) + 1).ToString();
                                break;
                            case 2: 
                                lab_sc.Text = (Convert.ToInt32(lab_sc.Text) + 3).ToString();
                                break;
                            case 3:
                                SoundPlayer myMusic = new SoundPlayer(Properties.Resources.bonous_pfm);
                                myMusic.Play();
                                catchgirl.Height += 300 ;
                                catchgirl.Width += 300;
                                break;
                        }
                        this.Controls[i].Visible = false;
                        this.Controls.RemoveAt(i);
                    }
                }
            }
        }
    }
}
