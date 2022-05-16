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
    public partial class frmEscolha : Form
    {
        public frmEscolha()
        {
            InitializeComponent();
        }

        private void btnNivelFacil_Click(object sender, EventArgs e)
        {
            Form1 nivelfacil = new Form1();
            nivelfacil.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNivelMedio_Click(object sender, EventArgs e)
        {
            frmNivelMedio medio = new frmNivelMedio();
            medio.Show();
            this.Close(); 
        }

        private void frmEscolha_Load(object sender, EventArgs e)
        {
            btnNivelFacil.Focus(); 
        }

        private void btnNvelDificil_Click(object sender, EventArgs e)
        {
            frmNivedificil2 dificil = new frmNivedificil2();
            dificil.Show();
            this.Close(); 
        }
    }
}
