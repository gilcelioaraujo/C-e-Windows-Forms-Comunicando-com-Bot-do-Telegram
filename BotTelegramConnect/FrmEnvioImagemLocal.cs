using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using System.IO;
using System.Drawing.Imaging;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemLocal : Form
    {
        public FrmEnvioImagemLocal()
        {
            InitializeComponent();
        }

        private Stream ToStream(Image imagem, ImageFormat formato)
        {
            var stream = new MemoryStream();
            imagem.Save(stream, formato);
            stream.Position = 0;
            return stream;
        }


        private void btnBscImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) 
            {
                ofd.InitialDirectory = @"C:\Imagens\";
                ofd.Filter = "Imagens (*.jpg; *.jpeg;*.png;) |*.jpg; *.jpeg;*.png;";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK) 
                    txtCaminhoImagem.Text = ofd.FileName;   
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCaminhoImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe o caminho da imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new Telegram.Bot.TelegramBotClient("5975491306:AAHVl9V3VtXmdOHE8AZG0J9aqIz5mIzR-YU");
                
                using (var imgEnvio = Image.FromFile(txtCaminhoImagem.Text.Trim()))
                {
                    var stream = ToStream(imgEnvio, ImageFormat.Jpeg);
                    await telegramBot.SendPhotoAsync(chatId: "-1001871685828", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                }

                MessageBox.Show("Mensagem Enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar enviar a mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
                txtCaminhoImagem.Text = string.Empty;
            }
        }
    }
}
