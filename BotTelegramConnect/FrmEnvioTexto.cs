using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioTexto : Form
    {
        public FrmEnvioTexto()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a mensagem para envio!",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new Telegram.Bot.TelegramBotClient("5975491306:AAHVl9V3VtXmdOHE8AZG0J9aqIz5mIzR-YU");
                await telegramBot.SendTextMessageAsync(chatId: "-1001871685828", text: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                MessageBox.Show("Mensagem Enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar enviar a mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            finally
            {
                txtMensagem.Text = string.Empty;
            }
        }
    }
}
