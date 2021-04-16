
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblPartidas = new System.Windows.Forms.Label();
            this.lblJogadores = new System.Windows.Forms.Label();
            this.pcbIcon1 = new System.Windows.Forms.PictureBox();
            this.pcbIcon2 = new System.Windows.Forms.PictureBox();
            this.pcbIcon3 = new System.Windows.Forms.PictureBox();
            this.pcbIcon4 = new System.Windows.Forms.PictureBox();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblJogador3 = new System.Windows.Forms.Label();
            this.lblJogador4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(12, 487);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(318, 30);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar a lista de partidas";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCriarSala
            // 
            this.btnCriarSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCriarSala.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCriarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarSala.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarSala.Location = new System.Drawing.Point(335, 357);
            this.btnCriarSala.Name = "btnCriarSala";
            this.btnCriarSala.Size = new System.Drawing.Size(281, 30);
            this.btnCriarSala.TabIndex = 4;
            this.btnCriarSala.Text = "Criar Partida";
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEntrar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(335, 393);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(281, 30);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar modo dev";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(332, 220);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(229, 21);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome do jogador ou da partida";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.ForeColor = System.Drawing.SystemColors.Window;
            this.txbNome.Location = new System.Drawing.Point(335, 244);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(281, 29);
            this.txbNome.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(336, 286);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(127, 21);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha da partida";
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.ForeColor = System.Drawing.SystemColors.Window;
            this.txbSenha.Location = new System.Drawing.Point(336, 310);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(281, 29);
            this.txbSenha.TabIndex = 12;
            // 
            // lblPartidas
            // 
            this.lblPartidas.AutoSize = true;
            this.lblPartidas.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidas.Location = new System.Drawing.Point(12, 12);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(160, 28);
            this.lblPartidas.TabIndex = 13;
            this.lblPartidas.Text = "Lista de Partidas";
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadores.Location = new System.Drawing.Point(330, 12);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(140, 28);
            this.lblJogadores.TabIndex = 14;
            this.lblJogadores.Text = "Jogadores de ";
            // 
            // pcbIcon1
            // 
            this.pcbIcon1.BackgroundImage = global::cantStop.Properties.Resources.pointR;
            this.pcbIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon1.Location = new System.Drawing.Point(340, 52);
            this.pcbIcon1.Name = "pcbIcon1";
            this.pcbIcon1.Size = new System.Drawing.Size(23, 24);
            this.pcbIcon1.TabIndex = 15;
            this.pcbIcon1.TabStop = false;
            // 
            // pcbIcon2
            // 
            this.pcbIcon2.BackgroundImage = global::cantStop.Properties.Resources.pointB;
            this.pcbIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon2.Location = new System.Drawing.Point(340, 93);
            this.pcbIcon2.Name = "pcbIcon2";
            this.pcbIcon2.Size = new System.Drawing.Size(23, 24);
            this.pcbIcon2.TabIndex = 16;
            this.pcbIcon2.TabStop = false;
            // 
            // pcbIcon3
            // 
            this.pcbIcon3.BackgroundImage = global::cantStop.Properties.Resources.pointG;
            this.pcbIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon3.Location = new System.Drawing.Point(340, 138);
            this.pcbIcon3.Name = "pcbIcon3";
            this.pcbIcon3.Size = new System.Drawing.Size(23, 24);
            this.pcbIcon3.TabIndex = 17;
            this.pcbIcon3.TabStop = false;
            // 
            // pcbIcon4
            // 
            this.pcbIcon4.BackgroundImage = global::cantStop.Properties.Resources.pointY;
            this.pcbIcon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon4.Location = new System.Drawing.Point(340, 183);
            this.pcbIcon4.Name = "pcbIcon4";
            this.pcbIcon4.Size = new System.Drawing.Size(23, 24);
            this.pcbIcon4.TabIndex = 18;
            this.pcbIcon4.TabStop = false;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(369, 53);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(79, 21);
            this.lblJogador1.TabIndex = 19;
            this.lblJogador1.Text = "Jogador 1";
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.Location = new System.Drawing.Point(369, 96);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(79, 21);
            this.lblJogador2.TabIndex = 20;
            this.lblJogador2.Text = "Jogador 2";
            // 
            // lblJogador3
            // 
            this.lblJogador3.AutoSize = true;
            this.lblJogador3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador3.Location = new System.Drawing.Point(369, 141);
            this.lblJogador3.Name = "lblJogador3";
            this.lblJogador3.Size = new System.Drawing.Size(79, 21);
            this.lblJogador3.TabIndex = 21;
            this.lblJogador3.Text = "Jogador 3";
            // 
            // lblJogador4
            // 
            this.lblJogador4.AutoSize = true;
            this.lblJogador4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador4.Location = new System.Drawing.Point(369, 186);
            this.lblJogador4.Name = "lblJogador4";
            this.lblJogador4.Size = new System.Drawing.Size(79, 21);
            this.lblJogador4.TabIndex = 22;
            this.lblJogador4.Text = "Jogador 4";
            // 
            // FormLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(628, 529);
            this.Controls.Add(this.lblJogador4);
            this.Controls.Add(this.lblJogador3);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.pcbIcon4);
            this.Controls.Add(this.pcbIcon3);
            this.Controls.Add(this.pcbIcon2);
            this.Controls.Add(this.pcbIcon1);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.lblPartidas);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCriarSala;
        private System.Windows.Forms.DataGridView dgvListaPartidas;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblPartidas;
        private System.Windows.Forms.Label lblJogadores;
        private System.Windows.Forms.PictureBox pcbIcon1;
        private System.Windows.Forms.PictureBox pcbIcon2;
        private System.Windows.Forms.PictureBox pcbIcon3;
        private System.Windows.Forms.PictureBox pcbIcon4;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblJogador3;
        private System.Windows.Forms.Label lblJogador4;
    }
}

