namespace BotTelegramConnect
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMenssagemSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMenssagemSimplesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMenssagemComEmojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMenssagemComTemporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.envioDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // envioDeToolStripMenuItem
            // 
            this.envioDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envioDeMenssagemSimplesToolStripMenuItem,
            this.envioDeMenssagemSimplesToolStripMenuItem1,
            this.envioDeMenssagemComEmojiToolStripMenuItem,
            this.envioDeMenssagemComTemporizadorToolStripMenuItem});
            this.envioDeToolStripMenuItem.Name = "envioDeToolStripMenuItem";
            this.envioDeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.envioDeToolStripMenuItem.Text = "Envio";
            // 
            // envioDeMenssagemSimplesToolStripMenuItem
            // 
            this.envioDeMenssagemSimplesToolStripMenuItem.Name = "envioDeMenssagemSimplesToolStripMenuItem";
            this.envioDeMenssagemSimplesToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.envioDeMenssagemSimplesToolStripMenuItem.Text = "Envio de Menssagem Simples";
            this.envioDeMenssagemSimplesToolStripMenuItem.Click += new System.EventHandler(this.envioDeMenssagemSimplesToolStripMenuItem_Click);
            // 
            // envioDeMenssagemSimplesToolStripMenuItem1
            // 
            this.envioDeMenssagemSimplesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemWebToolStripMenuItem,
            this.imagemLocalToolStripMenuItem});
            this.envioDeMenssagemSimplesToolStripMenuItem1.Name = "envioDeMenssagemSimplesToolStripMenuItem1";
            this.envioDeMenssagemSimplesToolStripMenuItem1.Size = new System.Drawing.Size(288, 22);
            this.envioDeMenssagemSimplesToolStripMenuItem1.Text = "Envio de Menssagem com Imagem";
            // 
            // imagemWebToolStripMenuItem
            // 
            this.imagemWebToolStripMenuItem.Name = "imagemWebToolStripMenuItem";
            this.imagemWebToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.imagemWebToolStripMenuItem.Text = "Imagem da Web";
            this.imagemWebToolStripMenuItem.Click += new System.EventHandler(this.imagemWebToolStripMenuItem_Click);
            // 
            // imagemLocalToolStripMenuItem
            // 
            this.imagemLocalToolStripMenuItem.Name = "imagemLocalToolStripMenuItem";
            this.imagemLocalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.imagemLocalToolStripMenuItem.Text = "Imagem Local";
            this.imagemLocalToolStripMenuItem.Click += new System.EventHandler(this.imagemLocalToolStripMenuItem_Click);
            // 
            // envioDeMenssagemComEmojiToolStripMenuItem
            // 
            this.envioDeMenssagemComEmojiToolStripMenuItem.Name = "envioDeMenssagemComEmojiToolStripMenuItem";
            this.envioDeMenssagemComEmojiToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.envioDeMenssagemComEmojiToolStripMenuItem.Text = "Envio de Menssagem com Emoji";
            this.envioDeMenssagemComEmojiToolStripMenuItem.Click += new System.EventHandler(this.envioDeMenssagemComEmojiToolStripMenuItem_Click);
            // 
            // envioDeMenssagemComTemporizadorToolStripMenuItem
            // 
            this.envioDeMenssagemComTemporizadorToolStripMenuItem.Name = "envioDeMenssagemComTemporizadorToolStripMenuItem";
            this.envioDeMenssagemComTemporizadorToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.envioDeMenssagemComTemporizadorToolStripMenuItem.Text = "Envio de Menssagem com Temporizador";
            this.envioDeMenssagemComTemporizadorToolStripMenuItem.Click += new System.EventHandler(this.envioDeMenssagemComTemporizadorToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 315);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMenssagemSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMenssagemSimplesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imagemWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMenssagemComEmojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMenssagemComTemporizadorToolStripMenuItem;
    }
}