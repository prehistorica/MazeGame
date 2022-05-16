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
    public partial class Form1 : Form
    {
        private int _tempo; 
        public Form1()
        {
            InitializeComponent();
            movetostart();
            timer1.Start();
        }

        private void Finish_point(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Você Venceu!!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            lblTempo.Text = "Você terminou em " + _tempo.ToString()+ " segundos";
            
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

        private void movetostart()
        {
            timer1.Start();
            Point startingpoint = panel1.Location;
            startingpoint.Offset(10,37);
            Cursor.Position = PointToScreen(startingpoint); 
        }

        private void hit_Wall(object sender, EventArgs e)
        {
            timer1.Stop(); 
            MessageBox.Show("Você Bateu no Muro", "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             
            movetostart();
            _tempo = 0; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tempo++;
            lblTempo.Text = "Pontuação " +  _tempo.ToString(); 
        }

        private void label34_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
