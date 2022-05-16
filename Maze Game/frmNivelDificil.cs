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
    public partial class frmNivelDificil : Form
    {
        public frmNivelDificil()
        {
            InitializeComponent();
        }

        private void frmNivelDificil_Load(object sender, EventArgs e)
        {
            
        }

        private void hit_wall(object sender, EventArgs e)
        {
            MessageBox.Show("Você Bateu no Muro", "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (MessageBox.Show("Deseja Jogar Novamente?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                movetostart();
                //_tempo = 0;
            }
            else
            {
                frmEscolha voltar = new frmEscolha();
                voltar.Show();
                this.Close();
            }

        }

        private void movetostart(object sender, EventArgs e)
        {

        }

        private void movetostart()
        {
            Point startingpoint = panel1.Location;
            startingpoint.Offset(8, 34);
            Cursor.Position = PointToScreen(startingpoint);
        }
    }
}
