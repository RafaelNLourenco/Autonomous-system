﻿
namespace cantStop
{
    partial class FormLobby
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCriarSala = new System.Windows.Forms.Button();
            this.dgvListaPartidas = new System.Windows.Forms.DataGridView();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.dgvJogadores = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblPartidas = new System.Windows.Forms.Label();
            this.lblJogadores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 487);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(318, 30);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCriarSala
            // 
            this.btnCriarSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCriarSala.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCriarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarSala.Location = new System.Drawing.Point(335, 402);
            this.btnCriarSala.Name = "btnCriarSala";
            this.btnCriarSala.Size = new System.Drawing.Size(281, 30);
            this.btnCriarSala.TabIndex = 4;
            this.btnCriarSala.Text = "Criar Sala";
            this.btnCriarSala.UseVisualStyleBackColor = false;
            this.btnCriarSala.Click += new System.EventHandler(this.btnCriarSala_Click);
            // 
            // dgvListaPartidas
            // 
            this.dgvListaPartidas.AllowUserToAddRows = false;
            this.dgvListaPartidas.AllowUserToDeleteRows = false;
            this.dgvListaPartidas.AllowUserToResizeColumns = false;
            this.dgvListaPartidas.AllowUserToResizeRows = false;
            this.dgvListaPartidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgvListaPartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaPartidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaPartidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPartidas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaPartidas.EnableHeadersVisualStyles = false;
            this.dgvListaPartidas.Location = new System.Drawing.Point(12, 52);
            this.dgvListaPartidas.MultiSelect = false;
            this.dgvListaPartidas.Name = "dgvListaPartidas";
            this.dgvListaPartidas.ReadOnly = true;
            this.dgvListaPartidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaPartidas.RowHeadersVisible = false;
            this.dgvListaPartidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPartidas.Size = new System.Drawing.Size(318, 429);
            this.dgvListaPartidas.TabIndex = 6;
            this.dgvListaPartidas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaPartidas_CellMouseClick);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Location = new System.Drawing.Point(335, 355);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(281, 30);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // dgvJogadores
            // 
            this.dgvJogadores.AllowUserToAddRows = false;
            this.dgvJogadores.AllowUserToDeleteRows = false;
            this.dgvJogadores.AllowUserToResizeColumns = false;
            this.dgvJogadores.AllowUserToResizeRows = false;
            this.dgvJogadores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJogadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvJogadores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvJogadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvJogadores.Location = new System.Drawing.Point(335, 52);
            this.dgvJogadores.MultiSelect = false;
            this.dgvJogadores.Name = "dgvJogadores";
            this.dgvJogadores.ReadOnly = true;
            this.dgvJogadores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvJogadores.RowHeadersVisible = false;
            this.dgvJogadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJogadores.Size = new System.Drawing.Size(280, 170);
            this.dgvJogadores.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNome.Location = new System.Drawing.Point(336, 225);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.White;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbNome.Location = new System.Drawing.Point(336, 262);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(281, 19);
            this.txbNome.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSenha.Location = new System.Drawing.Point(336, 284);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(65, 24);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha";
            // 
            // txbSenha
            // 
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbSenha.Location = new System.Drawing.Point(336, 321);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(281, 19);
            this.txbSenha.TabIndex = 12;
            // 
            // lblPartidas
            // 
            this.lblPartidas.AutoSize = true;
            this.lblPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPartidas.Location = new System.Drawing.Point(7, 11);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(216, 31);
            this.lblPartidas.TabIndex = 13;
            this.lblPartidas.Text = "Lista de Partidas";
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblJogadores.Location = new System.Drawing.Point(329, 9);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(141, 31);
            this.lblJogadores.TabIndex = 14;
            this.lblJogadores.Text = "Jogadores";
            // 
            // FormLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(628, 529);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.lblPartidas);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvJogadores);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.dgvListaPartidas);
            this.Controls.Add(this.btnCriarSala);
            this.Controls.Add(this.btnAtualizar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLobby";
            this.Text = "Lobby";
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
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblPartidas;
        private System.Windows.Forms.Label lblJogadores;
    }
}
