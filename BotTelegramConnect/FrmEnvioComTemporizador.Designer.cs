namespace BotTelegramConnect
{
    partial class FrmEnvioComTemporizador
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMensagens = new System.Windows.Forms.ListBox();
            this.btnCarregarMensagens = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prbStatusEnvio = new System.Windows.Forms.ProgressBar();
            this.lblStatusEnvio = new System.Windows.Forms.Label();
            this.timerControle = new System.Windows.Forms.Timer(this.components);
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagens:";
            // 
            // lbMensagens
            // 
            this.lbMensagens.FormattingEnabled = true;
            this.lbMensagens.Location = new System.Drawing.Point(12, 34);
            this.lbMensagens.Name = "lbMensagens";
            this.lbMensagens.Size = new System.Drawing.Size(664, 173);
            this.lbMensagens.TabIndex = 1;
            // 
            // btnCarregarMensagens
            // 
            this.btnCarregarMensagens.Location = new System.Drawing.Point(426, 213);
            this.btnCarregarMensagens.Name = "btnCarregarMensagens";
            this.btnCarregarMensagens.Size = new System.Drawing.Size(114, 34);
            this.btnCarregarMensagens.TabIndex = 2;
            this.btnCarregarMensagens.Text = "Carregar Mensagens";
            this.btnCarregarMensagens.UseVisualStyleBackColor = true;
            this.btnCarregarMensagens.Click += new System.EventHandler(this.btnCarregarMensagens_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(565, 213);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(111, 34);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar Mensagens";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status de Envio:";
            // 
            // prbStatusEnvio
            // 
            this.prbStatusEnvio.Location = new System.Drawing.Point(12, 263);
            this.prbStatusEnvio.Name = "prbStatusEnvio";
            this.prbStatusEnvio.Size = new System.Drawing.Size(664, 43);
            this.prbStatusEnvio.TabIndex = 5;
            // 
            // lblStatusEnvio
            // 
            this.lblStatusEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusEnvio.Location = new System.Drawing.Point(12, 322);
            this.lblStatusEnvio.Name = "lblStatusEnvio";
            this.lblStatusEnvio.Size = new System.Drawing.Size(664, 22);
            this.lblStatusEnvio.TabIndex = 6;
            this.lblStatusEnvio.Text = "Aguardando Envio...";
            this.lblStatusEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTempo.Location = new System.Drawing.Point(594, 8);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(82, 20);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tempo:";
            // 
            // FrmEnvioComTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblStatusEnvio);
            this.Controls.Add(this.prbStatusEnvio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCarregarMensagens);
            this.Controls.Add(this.lbMensagens);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioComTemporizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mensagens Com Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMensagens;
        private System.Windows.Forms.Button btnCarregarMensagens;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar prbStatusEnvio;
        private System.Windows.Forms.Label lblStatusEnvio;
        private System.Windows.Forms.Timer timerControle;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label3;
    }
}