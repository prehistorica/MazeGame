
namespace Maze_Game
{
    partial class frmEscolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolha));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNivelFacil = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNivelMedio = new System.Windows.Forms.Button();
            this.btnNvelDificil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Maze_Game.Properties.Resources.labirinto;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnNivelFacil
            // 
            this.btnNivelFacil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNivelFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivelFacil.Location = new System.Drawing.Point(59, 282);
            this.btnNivelFacil.Name = "btnNivelFacil";
            this.btnNivelFacil.Size = new System.Drawing.Size(146, 35);
            this.btnNivelFacil.TabIndex = 1;
            this.btnNivelFacil.Text = "Nível Fácil ";
            this.btnNivelFacil.UseVisualStyleBackColor = true;
            this.btnNivelFacil.Click += new System.EventHandler(this.btnNivelFacil_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(315, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(146, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNivelMedio
            // 
            this.btnNivelMedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNivelMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivelMedio.Location = new System.Drawing.Point(59, 337);
            this.btnNivelMedio.Name = "btnNivelMedio";
            this.btnNivelMedio.Size = new System.Drawing.Size(146, 35);
            this.btnNivelMedio.TabIndex = 4;
            this.btnNivelMedio.Text = "Nível Médio";
            this.btnNivelMedio.UseVisualStyleBackColor = true;
            this.btnNivelMedio.Click += new System.EventHandler(this.btnNivelMedio_Click);
            // 
            // btnNvelDificil
            // 
            this.btnNvelDificil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNvelDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvelDificil.Location = new System.Drawing.Point(59, 392);
            this.btnNvelDificil.Name = "btnNvelDificil";
            this.btnNvelDificil.Size = new System.Drawing.Size(146, 35);
            this.btnNvelDificil.TabIndex = 5;
            this.btnNvelDificil.Text = "Nível Difícil ";
            this.btnNvelDificil.UseVisualStyleBackColor = true;
            this.btnNvelDificil.Click += new System.EventHandler(this.btnNvelDificil_Click);
            // 
            // frmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 447);
            this.Controls.Add(this.btnNvelDificil);
            this.Controls.Add(this.btnNivelMedio);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNivelFacil);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEscolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.frmEscolha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNivelFacil;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNivelMedio;
        private System.Windows.Forms.Button btnNvelDificil;
    }
}