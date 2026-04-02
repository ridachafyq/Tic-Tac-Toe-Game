using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;


namespace Tic_Tac_Toe_Game
{
    public partial class frmGame : Form
    {       
        struct stClick
        {
            public int Picture1;
            public int Picture2;
            public int Picture3;
            public int Picture4;
            public int Picture5;
            public int Picture6;
            public int Picture7;
            public int Picture8;
            public int Picture9;
        }

        stClick click;
        public frmGame()
        {
            InitializeComponent();
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            lWinner.Text = "In Progress";
            lTurn.Text = UpdateTurnText();        
        }
        private void frmGame_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 6;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 400, 400, 400, 90);
            e.Graphics.DrawLine(pen, 550, 400, 550, 90);

            e.Graphics.DrawLine(pen, 250, 200, 700, 200);
            e.Graphics.DrawLine(pen, 250, 300, 700, 300);
        }
        void UpdatePicture(object sender, EventArgs e)
        {
            if (lTurn.Text == "Player 1")    
                ((PictureBox)sender).Image = Resources.X;
            else
                ((PictureBox)sender).Image = Resources.O;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click.Picture1 += 1;
            if (click.Picture1 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            click.Picture2 += 1;
            if (click.Picture2 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            click.Picture3 += 1;
            if (click.Picture3 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            click.Picture4 += 1;
            if (click.Picture4 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText(); 
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            click.Picture5 += 1;
            if (click.Picture5 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText();     
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            click.Picture6 += 1;
            if (click.Picture6 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            click.Picture7 += 1;
            if (click.Picture7 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            click.Picture8 += 1;
            if (click.Picture8 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            click.Picture9 += 1;
            if (click.Picture9 > 1)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePicture(sender, e);
            whoWin(sender, e);

            lTurn.Text = UpdateTurnText();
        }
        string UpdateTurnText()
        {
            if (lWinner.Text == lTurn.Text)
                return "Game Over";
             if (lTurn.Text == "Player 1")
                return "Player 2";
            else
                return "Player 1";
        }
        void WhoClick(object sender, EventArgs e)
        {
            if (lTurn.Text == "Player 1")
                ((PictureBox)sender).Tag = "x";             
            else
                ((PictureBox)sender).Tag = "o";
        }
        void whoWin(object sender, EventArgs e)
        {
            WhoClick(sender, e);

            if (pictureBox1.Tag == pictureBox2.Tag && pictureBox2.Tag == pictureBox3.Tag)
            {
                DisablePicture();

                UpdateColerPicture(pictureBox1);
                UpdateColerPicture(pictureBox2);
                UpdateColerPicture(pictureBox3);

                Message_Box();
            }
            else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox4.Tag == pictureBox7.Tag)
            {
                DisablePicture();

                UpdateColerPicture(pictureBox1);
                UpdateColerPicture(pictureBox4);
                UpdateColerPicture(pictureBox7);

                Message_Box();
            }
            else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox9.Tag)
            {
                DisablePicture();

                UpdateColerPicture(pictureBox1);
                UpdateColerPicture(pictureBox5);
                UpdateColerPicture(pictureBox9);

                Message_Box();
            }

            else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox6.Tag)
            {
                DisablePicture();

                UpdateColerPicture(pictureBox4);
                UpdateColerPicture(pictureBox5);
                UpdateColerPicture(pictureBox6);

                Message_Box();
            }
            else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox8.Tag == pictureBox9.Tag)
            {
                DisablePicture();

                UpdateColerPicture(pictureBox7);
                UpdateColerPicture(pictureBox8);
                UpdateColerPicture(pictureBox9);

                Message_Box();
            }
            else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox7.Tag)
            {
                DisablePicture();

                UpdateColerPicture(pictureBox5);
                UpdateColerPicture(pictureBox7);
                UpdateColerPicture(pictureBox3);

                Message_Box();
            }

            else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox8.Tag)
            {
                DisablePicture();

                UpdateColerPicture(pictureBox5);
                UpdateColerPicture(pictureBox2);
                UpdateColerPicture(pictureBox8);

                Message_Box();
            }
            else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox6.Tag == pictureBox9.Tag)
            {
                DisablePicture();

                UpdateColerPicture(pictureBox9);
                UpdateColerPicture(pictureBox6);
                UpdateColerPicture(pictureBox3);

                Message_Box();
            }

            else if (click.Picture1 == 1 && click.Picture2 == 1 && click.Picture3 == 1 && click.Picture4 == 1 && click.Picture5 == 1 && click.Picture6 == 1 && click.Picture7 == 1 && click.Picture8 == 1 && click.Picture9 == 1)
            {
                Message_Box();
                lWinner.Text = "Draw";
                lTurn.Text = lWinner.Text;
            }
        }
        void DisablePicture()
        {
            lWinner.Text = lTurn.Text;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;

            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;

            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }
        void RestartImage()
        {
            pictureBox1.Image = Resources.question_mark_96;
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureBox2.Image = Resources.question_mark_96;
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureBox3.Image = Resources.question_mark_96;
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureBox4.Image = Resources.question_mark_96;
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureBox5.Image = Resources.question_mark_96;
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureBox6.Image = Resources.question_mark_96;
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureBox7.Image = Resources.question_mark_96;
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureBox8.Image = Resources.question_mark_96;
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureBox9.Image = Resources.question_mark_96;
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
        void RestartTag()
        {
            pictureBox1.Tag = "1";
            pictureBox2.Tag = "2";
            pictureBox3.Tag = "3";

            pictureBox4.Tag = "4";
            pictureBox5.Tag = "5";
            pictureBox6.Tag = "6";

            pictureBox7.Tag = "7";
            pictureBox8.Tag = "8";
            pictureBox9.Tag = "9";
        }
        void EnabelPicture()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;

            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;

            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

            click.Picture1 = 0;
            click.Picture2 = 0;
            click.Picture3 = 0;

            click.Picture4 = 0;
            click.Picture5 = 0;
            click.Picture6 = 0;

            click.Picture7 = 0;
            click.Picture8 = 0;
            click.Picture9 = 0;

            RestartImage();

            RestartTag();
        }
        void UpdateColerPicture(object sender)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(0, 255, 0);
        }
       void bRestartGame_Click(object sender, EventArgs e)
       {
            EnabelPicture();
           
            frmGame_Load( sender,  e);
       }
        void Message_Box()
        {
            MessageBox.Show("GameOver","GameOver",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bRestartGame_MouseHover(object sender, EventArgs e)
        {
            bRestartGame.BackColor = Color.Green;
            bRestartGame.ForeColor = Color.White;
        }

        private void bRestartGame_MouseLeave(object sender, EventArgs e)
        {
            bRestartGame.BackColor = Color.White;
            bRestartGame.ForeColor = Color.IndianRed;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void bRestartGame_MouseDown(object sender, MouseEventArgs e)
        {
            bRestartGame.BackColor = Color.Red;
            bRestartGame.ForeColor = Color.White;
        }
    }
}