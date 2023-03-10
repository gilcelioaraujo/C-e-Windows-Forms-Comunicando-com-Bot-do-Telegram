using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegramConnect
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control  controle in this.Controls) 
            { 
                if (controle is MdiClient) 
                {
                    controle.BackgroundImage = Properties.Resources.telegram_image;
                    break;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void envioDeMenssagemSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTexto();
            frm.MdiParent = this;
            frm.Show();


        }

        private void imagemWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioImagemWeb();
            frm.MdiParent = this;
            frm.Show();

        }

        private void imagemLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioImagemLocal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void envioDeMenssagemComEmojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTextoComEmoji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void envioDeMenssagemComTemporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioComTemporizador();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
