namespace AppExemploMenu
{
    partial class FrmVerde
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFormVerde,
            this.exibirFormAzul,
            this.exibirFormAmarelo});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // exibirFormVerde
            // 
            this.exibirFormVerde.Name = "exibirFormVerde";
            this.exibirFormVerde.Size = new System.Drawing.Size(180, 22);
            this.exibirFormVerde.Text = "Verde";
            this.exibirFormVerde.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // exibirFormAzul
            // 
            this.exibirFormAzul.Name = "exibirFormAzul";
            this.exibirFormAzul.Size = new System.Drawing.Size(180, 22);
            this.exibirFormAzul.Text = "Azul";
            this.exibirFormAzul.Click += new System.EventHandler(this.exibirFormAzul_Click);
            // 
            // exibirFormAmarelo
            // 
            this.exibirFormAmarelo.Name = "exibirFormAmarelo";
            this.exibirFormAmarelo.Size = new System.Drawing.Size(180, 22);
            this.exibirFormAmarelo.Text = "Amarelo";
            this.exibirFormAmarelo.Click += new System.EventHandler(this.exibirFormAmarelo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmVerde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVerde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verde";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFormVerde;
        private System.Windows.Forms.ToolStripMenuItem exibirFormAzul;
        private System.Windows.Forms.ToolStripMenuItem exibirFormAmarelo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}