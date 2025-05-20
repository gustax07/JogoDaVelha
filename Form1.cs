using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {

        // Variaveis Globais:
        string jogadaAtual = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Jogada_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            botaoClicado.Text = jogadaAtual;
            botaoClicado.Enabled = false;
            // Troca de X para O e de O para X:
            if (jogadaAtual == "X")
            {
                jogadaAtual = "O";
            }
            else
            {
                jogadaAtual = "X";
            }
            // Atualizar label
            lblinfo.Text = $"É a Vez do {jogadaAtual}";

            VerificarVencedor();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            jogadaAtual = "X";
            lblinfo.Text = $"É a Vez do {jogadaAtual}";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
        }

        public void VerificarVencedor()
        {
            // verificar linhas:
            if (btn11.Text == btn12.Text && btn12.Text == btn13.Text && btn11.Text != "")
            {
                lblinfo.Text = $"O Vencedor foi {btn11.Text}";
                DesabilitarTudo();
            }
            else if (btn21.Text == btn22.Text && btn22.Text == btn23.Text && btn21.Text != "")
            {
                lblinfo.Text = $"O Vencedor foi {btn21.Text}";
                DesabilitarTudo();
            }
            else if (btn31.Text == btn32.Text && btn32.Text == btn33.Text && btn31.Text != "")
            {
                lblinfo.Text = $"O Vencedor foi {btn31.Text}";
                DesabilitarTudo();
            }
            else if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn11.Text != "")
            {
                lblinfo.Text = $"O Vencedor foi {btn11.Text}";
                DesabilitarTudo();
            }
            else if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn12.Text != "")
            {
                lblinfo.Text = $"O Vencedor foi {btn12.Text}";
                DesabilitarTudo();
            }
            else if (btn13.Text == btn23.Text && btn23.Text == btn33.Text && btn13.Text != "")
            {
                lblinfo.Text = $"O Vencedor foi {btn13.Text}";
                DesabilitarTudo();
            }
            else if (btn11.Text == btn22.Text && btn22.Text == btn33.Text && btn11.Text != "")
            {
                lblinfo.Text = $"O Vencedor foi {btn11.Text}";
                DesabilitarTudo();
            }
            else if (btn13.Text == btn22.Text && btn22.Text == btn31.Text && btn13.Text != "")
            {
                lblinfo.Text = $"O Vencedor foi {btn31.Text}";
                DesabilitarTudo();
            }
            else if (!btn11.Enabled && !btn12.Enabled && !btn13.Enabled && 
                !btn21.Enabled && !btn22.Enabled && !btn23.Enabled && 
                !btn31.Enabled && !btn32.Enabled && !btn33.Enabled)
            {
                lblinfo.Text = "    Empate!";
            }
        }
        public void DesabilitarTudo()
        {
            btn11.Enabled = false ;
            btn12.Enabled = false ; 
            btn13.Enabled = false ;
            btn21.Enabled = false ;
            btn22.Enabled = false ;
            btn23.Enabled = false ;
            btn31.Enabled = false ;
            btn32.Enabled = false ;
            btn33.Enabled = false ;
        }
    }
}
