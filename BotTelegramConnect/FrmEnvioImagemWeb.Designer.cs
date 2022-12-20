namespace BotTelegramConnect
{
    partial class FrmEnvioImagemWeb
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtURLImagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(14, 39);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(507, 104);
            this.txtMensagem.TabIndex = 1;
            // 
            // txtURLImagem
            // 
            this.txtURLImagem.BackColor = System.Drawing.SystemColors.Info;
            this.txtURLImagem.Location = new System.Drawing.Point(14, 181);
            this.txtURLImagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtURLImagem.Multiline = true;
            this.txtURLImagem.Name = "txtURLImagem";
            this.txtURLImagem.Size = new System.Drawing.Size(507, 34);
            this.txtURLImagem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL da Imagem";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(382, 235);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(140, 38);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar Mensagem";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_ClickAsync);
            // 
            // FrmEnvioImagemWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 288);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURLImagem);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioImagemWeb";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mensagem com Imagem da Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtURLImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
    }
}