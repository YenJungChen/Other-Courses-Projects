namespace candygame
{
    partial class Form2
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
            this.lab_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_sc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moneyTime = new System.Windows.Forms.Timer(this.components);
            this.eat = new System.Windows.Forms.Timer(this.components);
            this.catchgirl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.catchgirl)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.BackColor = System.Drawing.Color.Transparent;
            this.lab_time.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_time.Location = new System.Drawing.Point(68, 27);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(94, 64);
            this.lab_time.TabIndex = 0;
            this.lab_time.Text = "25";
            this.lab_time.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_sc
            // 
            this.lab_sc.AutoSize = true;
            this.lab_sc.BackColor = System.Drawing.Color.Transparent;
            this.lab_sc.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_sc.Location = new System.Drawing.Point(642, 19);
            this.lab_sc.Name = "lab_sc";
            this.lab_sc.Size = new System.Drawing.Size(56, 61);
            this.lab_sc.TabIndex = 1;
            this.lab_sc.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(602, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time: ";
            // 
            // moneyTime
            // 
            this.moneyTime.Tick += new System.EventHandler(this.moneyTime_Tick);
            // 
            // eat
            // 
            this.eat.Enabled = true;
            this.eat.Tick += new System.EventHandler(this.eat_Tick);
            // 
            // catchgirl
            // 
            this.catchgirl.BackColor = System.Drawing.Color.Transparent;
            this.catchgirl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.catchgirl.Image = global::candygame.Properties.Resources.catchgirl_angel;
            this.catchgirl.Location = new System.Drawing.Point(328, 415);
            this.catchgirl.Name = "catchgirl";
            this.catchgirl.Size = new System.Drawing.Size(101, 127);
            this.catchgirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catchgirl.TabIndex = 4;
            this.catchgirl.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::candygame.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(749, 542);
            this.Controls.Add(this.catchgirl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_sc);
            this.Controls.Add(this.lab_time);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.catchgirl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_sc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox catchgirl;
        private System.Windows.Forms.Timer moneyTime;
        private System.Windows.Forms.Timer eat;
    }
}