using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class frmNivedificil2 : Form
    {

        private int _tempo; 
        public frmNivedificil2()
        {
            InitializeComponent();
            movetostart();
            timer1.Start();
        }

        private void movetostart()
        {
            timer1.Start();
            Point startingpoint = panel1.Location;
            startingpoint.Offset(18, 59);
            Cursor.Position = PointToScreen(startingpoint);
        }



        private void hit_wall(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Você Bateu no Muro", "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (MessageBox.Show("Deseja Jogar Novamente?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                movetostart();
                _tempo = 0;
            }
            else
            {
                frmEscolha voltar = new frmEscolha();
                voltar.Show();
                this.Close();
            }


        }

        private void finish_point(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Você Venceu!!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTempo.Text = "Você Terminou em " + _tempo.ToString() + " Segundos";
            if (MessageBox.Show("Deseja Jogar Novamente?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                movetostart();
                _tempo = 0;
            }
            else
            {
                frmEscolha voltar = new frmEscolha();
                voltar.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tempo++;
            lblTempo.Text = "Pontuação " + _tempo.ToString();
        }
    }
}
