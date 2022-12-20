using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using System.Net;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemWeb : Form
    {
        public FrmEnvioImagemWeb()
        {
            InitializeComponent();
        }

        private async void btnEnviar_ClickAsync(object sender, EventArgs e)
        {
            if (txtURLImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a URL da imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new Telegram.Bot.TelegramBotClient("5975491306:AAHVl9V3VtXmdOHE8AZG0J9aqIz5mIzR-YU");
                var imagemRequest = WebRequest.Create(txtURLImagem.Text.Trim());

                using (var imagemResponse = imagemRequest.GetResponse())  
                {
                    var stream = imagemResponse.GetResponseStream();
                    await telegramBot.SendPhotoAsync(chatId: "-1001871685828",photo:stream, caption: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
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
                txtURLImagem.Text = string.Empty;
            }
        }
    }
}
