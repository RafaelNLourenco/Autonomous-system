
namespace cantStop
{
    partial class Lobby
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExibirPartidas = new System.Windows.Forms.Button();
            this.btnExibirJogadores = new System.Windows.Forms.Button();
            this.dgvListaPartidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExibirPartidas
            // 
            this.btnExibirPartidas.Location = new System.Drawing.Point(37, 39);
            this.btnExibirPartidas.Name = "btnExibirPartidas";
            this.btnExibirPartidas.Size = new System.Drawing.Size(119, 65);
            this.btnExibirPartidas.TabIndex = 3;
            this.btnExibirPartidas.Text = "Exibir Partidas";
            this.btnExibirPartidas.UseVisualStyleBackColor = true;
            this.btnExibirPartidas.Click += new System.EventHandler(this.btnExibirPartidas_Click);
            // 
            // btnExibirJogadores
            // 
            this.btnExibirJogadores.Location = new System.Drawing.Point(37, 158);
            this.btnExibirJogadores.Name = "btnExibirJogadores";
            this.btnExibirJogadores.Size = new System.Drawing.Size(119, 65);
            this.btnExibirJogadores.TabIndex = 4;
            this.btnExibirJogadores.Text = "Exibir Jogadores";
            this.btnExibirJogadores.UseVisualStyleBackColor = true;
            this.btnExibirJogadores.Click += new System.EventHandler(this.btnExibirJogadores_Click);
            // 
            // dgvListaPartidas
            // 
            this.dgvListaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPartidas.Location = new System.Drawing.Point(194, 29);
            this.dgvListaPartidas.Name = "dgvListaPartidas";
            this.dgvListaPartidas.Size = new System.Drawing.Size(794, 346);
            this.dgvListaPartidas.TabIndex = 6;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 537);
            this.Controls.Add(this.dgvListaPartidas);
            this.Controls.Add(this.btnExibirJogadores);
            this.Controls.Add(this.btnExibirPartidas);
            this.Name = "Lobby";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExibirPartidas;
        private System.Windows.Forms.Button btnExibirJogadores;
        private System.Windows.Forms.DataGridView dgvListaPartidas;
    }
}

