
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCriarSala = new System.Windows.Forms.Button();
            this.dgvListaPartidas = new System.Windows.Forms.DataGridView();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.dgvJogadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 334);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(156, 30);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCriarSala
            // 
            this.btnCriarSala.Location = new System.Drawing.Point(174, 334);
            this.btnCriarSala.Name = "btnCriarSala";
            this.btnCriarSala.Size = new System.Drawing.Size(156, 30);
            this.btnCriarSala.TabIndex = 4;
            this.btnCriarSala.Text = "Criar Sala";
            this.btnCriarSala.UseVisualStyleBackColor = true;
            this.btnCriarSala.Click += new System.EventHandler(this.btnCriarSala_Click);
            // 
            // dgvListaPartidas
            // 
            this.dgvListaPartidas.AllowUserToAddRows = false;
            this.dgvListaPartidas.AllowUserToDeleteRows = false;
            this.dgvListaPartidas.AllowUserToResizeColumns = false;
            this.dgvListaPartidas.AllowUserToResizeRows = false;
            this.dgvListaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPartidas.Location = new System.Drawing.Point(12, 36);
            this.dgvListaPartidas.Name = "dgvListaPartidas";
            this.dgvListaPartidas.ReadOnly = true;
            this.dgvListaPartidas.RowHeadersVisible = false;
            this.dgvListaPartidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaPartidas.Size = new System.Drawing.Size(318, 305);
            this.dgvListaPartidas.TabIndex = 6;
            this.dgvListaPartidas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaPartidas_CellMouseClick);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(335, 334);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(281, 30);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // dgvJogadores
            // 
            this.dgvJogadores.AllowUserToAddRows = false;
            this.dgvJogadores.AllowUserToDeleteRows = false;
            this.dgvJogadores.AllowUserToResizeColumns = false;
            this.dgvJogadores.AllowUserToResizeRows = false;
            this.dgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadores.Location = new System.Drawing.Point(336, 23);
            this.dgvJogadores.Name = "dgvJogadores";
            this.dgvJogadores.ReadOnly = true;
            this.dgvJogadores.RowHeadersVisible = false;
            this.dgvJogadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJogadores.Size = new System.Drawing.Size(280, 249);
            this.dgvJogadores.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(332, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(335, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 26);
            this.textBox1.TabIndex = 10;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 376);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJogadores);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.dgvListaPartidas);
            this.Controls.Add(this.btnCriarSala);
            this.Controls.Add(this.btnAtualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCriarSala;
        private System.Windows.Forms.DataGridView dgvListaPartidas;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.DataGridView dgvJogadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

