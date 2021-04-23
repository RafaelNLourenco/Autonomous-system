
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.dgvListaPartidas = new System.Windows.Forms.DataGridView();
            this.btnEntrarDev = new System.Windows.Forms.Button();
            this.lblNomeEntrarPartida = new System.Windows.Forms.Label();
            this.txbNomeEntrarPartida = new System.Windows.Forms.TextBox();
            this.lblSenhaEntrarPartida = new System.Windows.Forms.Label();
            this.txbSenhaEntrarPartida = new System.Windows.Forms.TextBox();
            this.lblPartidas = new System.Windows.Forms.Label();
            this.lblJogadoresPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblJogador3 = new System.Windows.Forms.Label();
            this.lblJogador4 = new System.Windows.Forms.Label();
            this.txbSenhaCriarPartida = new System.Windows.Forms.TextBox();
            this.lblSenhaCriarPartida = new System.Windows.Forms.Label();
            this.txbNomeCriarPartida = new System.Windows.Forms.TextBox();
            this.lblNomeCriarPartida = new System.Windows.Forms.Label();
            this.lblPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblNomePartidaSelecionada = new System.Windows.Forms.Label();
            this.lblStatusPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblEntrarPartida = new System.Windows.Forms.Label();
            this.btnEntrarBot = new System.Windows.Forms.Button();
            this.lblVisualizar = new System.Windows.Forms.Label();
            this.btnVisualizarPartida = new System.Windows.Forms.Button();
            this.btnIntrucoes = new System.Windows.Forms.Button();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.lblFeedbackCriarPartida = new System.Windows.Forms.Label();
            this.pcbIcon4 = new System.Windows.Forms.PictureBox();
            this.pcbIcon3 = new System.Windows.Forms.PictureBox();
            this.pcbIcon2 = new System.Windows.Forms.PictureBox();
            this.pcbIcon1 = new System.Windows.Forms.PictureBox();
            this.pcbSenhaCriarPartida = new System.Windows.Forms.PictureBox();
            this.pcbSenhaEntrarPartida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenhaCriarPartida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenhaEntrarPartida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(25, 500);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(281, 30);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar a lista de partidas";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCriarPartida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.Location = new System.Drawing.Point(25, 718);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(281, 30);
            this.btnCriarPartida.TabIndex = 4;
            this.btnCriarPartida.Text = "Criar";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // dgvListaPartidas
            // 
            this.dgvListaPartidas.AllowUserToAddRows = false;
            this.dgvListaPartidas.AllowUserToDeleteRows = false;
            this.dgvListaPartidas.AllowUserToResizeColumns = false;
            this.dgvListaPartidas.AllowUserToResizeRows = false;
            this.dgvListaPartidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvListaPartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaPartidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaPartidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPartidas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaPartidas.EnableHeadersVisualStyles = false;
            this.dgvListaPartidas.Location = new System.Drawing.Point(25, 65);
            this.dgvListaPartidas.MultiSelect = false;
            this.dgvListaPartidas.Name = "dgvListaPartidas";
            this.dgvListaPartidas.ReadOnly = true;
            this.dgvListaPartidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaPartidas.RowHeadersVisible = false;
            this.dgvListaPartidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaPartidas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPartidas.Size = new System.Drawing.Size(281, 424);
            this.dgvListaPartidas.TabIndex = 6;
            this.dgvListaPartidas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaPartidas_CellMouseClick);
            // 
            // btnEntrarDev
            // 
            this.btnEntrarDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEntrarDev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEntrarDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarDev.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarDev.Location = new System.Drawing.Point(340, 533);
            this.btnEntrarDev.Name = "btnEntrarDev";
            this.btnEntrarDev.Size = new System.Drawing.Size(281, 30);
            this.btnEntrarDev.TabIndex = 7;
            this.btnEntrarDev.Text = "Entrar modo dev";
            this.btnEntrarDev.UseVisualStyleBackColor = false;
            this.btnEntrarDev.Click += new System.EventHandler(this.btnEntrarDev_Click);
            // 
            // lblNomeEntrarPartida
            // 
            this.lblNomeEntrarPartida.AutoSize = true;
            this.lblNomeEntrarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEntrarPartida.Location = new System.Drawing.Point(337, 395);
            this.lblNomeEntrarPartida.Name = "lblNomeEntrarPartida";
            this.lblNomeEntrarPartida.Size = new System.Drawing.Size(133, 21);
            this.lblNomeEntrarPartida.TabIndex = 9;
            this.lblNomeEntrarPartida.Text = "Nome do jogador";
            // 
            // txbNomeEntrarPartida
            // 
            this.txbNomeEntrarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txbNomeEntrarPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeEntrarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEntrarPartida.ForeColor = System.Drawing.SystemColors.Window;
            this.txbNomeEntrarPartida.Location = new System.Drawing.Point(340, 423);
            this.txbNomeEntrarPartida.Name = "txbNomeEntrarPartida";
            this.txbNomeEntrarPartida.Size = new System.Drawing.Size(281, 29);
            this.txbNomeEntrarPartida.TabIndex = 10;
            this.txbNomeEntrarPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNomeEntrarPartida_KeyPress);
            // 
            // lblSenhaEntrarPartida
            // 
            this.lblSenhaEntrarPartida.AutoSize = true;
            this.lblSenhaEntrarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaEntrarPartida.Location = new System.Drawing.Point(341, 454);
            this.lblSenhaEntrarPartida.Name = "lblSenhaEntrarPartida";
            this.lblSenhaEntrarPartida.Size = new System.Drawing.Size(127, 21);
            this.lblSenhaEntrarPartida.TabIndex = 11;
            this.lblSenhaEntrarPartida.Text = "Senha da partida";
            // 
            // txbSenhaEntrarPartida
            // 
            this.txbSenhaEntrarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txbSenhaEntrarPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenhaEntrarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaEntrarPartida.ForeColor = System.Drawing.SystemColors.Window;
            this.txbSenhaEntrarPartida.Location = new System.Drawing.Point(341, 481);
            this.txbSenhaEntrarPartida.Name = "txbSenhaEntrarPartida";
            this.txbSenhaEntrarPartida.Size = new System.Drawing.Size(281, 29);
            this.txbSenhaEntrarPartida.TabIndex = 12;
            this.txbSenhaEntrarPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSenhaEntrarPartida_KeyPress);
            // 
            // lblPartidas
            // 
            this.lblPartidas.AutoSize = true;
            this.lblPartidas.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidas.Location = new System.Drawing.Point(22, 13);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(215, 37);
            this.lblPartidas.TabIndex = 13;
            this.lblPartidas.Text = "Lista de Partidas";
            // 
            // lblJogadoresPartidaSelecionada
            // 
            this.lblJogadoresPartidaSelecionada.AutoSize = true;
            this.lblJogadoresPartidaSelecionada.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadoresPartidaSelecionada.Location = new System.Drawing.Point(342, 145);
            this.lblJogadoresPartidaSelecionada.Name = "lblJogadoresPartidaSelecionada";
            this.lblJogadoresPartidaSelecionada.Size = new System.Drawing.Size(177, 28);
            this.lblJogadoresPartidaSelecionada.TabIndex = 14;
            this.lblJogadoresPartidaSelecionada.Text = "Lista de Jogadores:";
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(375, 191);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(79, 21);
            this.lblJogador1.TabIndex = 19;
            this.lblJogador1.Text = "Jogador 1";
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.Location = new System.Drawing.Point(375, 232);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(79, 21);
            this.lblJogador2.TabIndex = 20;
            this.lblJogador2.Text = "Jogador 2";
            // 
            // lblJogador3
            // 
            this.lblJogador3.AutoSize = true;
            this.lblJogador3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador3.Location = new System.Drawing.Point(375, 274);
            this.lblJogador3.Name = "lblJogador3";
            this.lblJogador3.Size = new System.Drawing.Size(79, 21);
            this.lblJogador3.TabIndex = 21;
            this.lblJogador3.Text = "Jogador 3";
            // 
            // lblJogador4
            // 
            this.lblJogador4.AutoSize = true;
            this.lblJogador4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador4.Location = new System.Drawing.Point(375, 317);
            this.lblJogador4.Name = "lblJogador4";
            this.lblJogador4.Size = new System.Drawing.Size(79, 21);
            this.lblJogador4.TabIndex = 22;
            this.lblJogador4.Text = "Jogador 4";
            // 
            // txbSenhaCriarPartida
            // 
            this.txbSenhaCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txbSenhaCriarPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenhaCriarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaCriarPartida.ForeColor = System.Drawing.SystemColors.Window;
            this.txbSenhaCriarPartida.Location = new System.Drawing.Point(25, 669);
            this.txbSenhaCriarPartida.Name = "txbSenhaCriarPartida";
            this.txbSenhaCriarPartida.Size = new System.Drawing.Size(281, 29);
            this.txbSenhaCriarPartida.TabIndex = 26;
            this.txbSenhaCriarPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSenhaCriarPartida_KeyPress);
            // 
            // lblSenhaCriarPartida
            // 
            this.lblSenhaCriarPartida.AutoSize = true;
            this.lblSenhaCriarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCriarPartida.Location = new System.Drawing.Point(25, 641);
            this.lblSenhaCriarPartida.Name = "lblSenhaCriarPartida";
            this.lblSenhaCriarPartida.Size = new System.Drawing.Size(127, 21);
            this.lblSenhaCriarPartida.TabIndex = 25;
            this.lblSenhaCriarPartida.Text = "Senha da partida";
            // 
            // txbNomeCriarPartida
            // 
            this.txbNomeCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txbNomeCriarPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeCriarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCriarPartida.ForeColor = System.Drawing.SystemColors.Window;
            this.txbNomeCriarPartida.Location = new System.Drawing.Point(24, 608);
            this.txbNomeCriarPartida.Name = "txbNomeCriarPartida";
            this.txbNomeCriarPartida.Size = new System.Drawing.Size(282, 29);
            this.txbNomeCriarPartida.TabIndex = 24;
            // 
            // lblNomeCriarPartida
            // 
            this.lblNomeCriarPartida.AutoSize = true;
            this.lblNomeCriarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCriarPartida.Location = new System.Drawing.Point(21, 580);
            this.lblNomeCriarPartida.Name = "lblNomeCriarPartida";
            this.lblNomeCriarPartida.Size = new System.Drawing.Size(127, 21);
            this.lblNomeCriarPartida.TabIndex = 23;
            this.lblNomeCriarPartida.Text = "Nome da partida";
            // 
            // lblPartidaSelecionada
            // 
            this.lblPartidaSelecionada.AutoSize = true;
            this.lblPartidaSelecionada.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaSelecionada.Location = new System.Drawing.Point(340, 13);
            this.lblPartidaSelecionada.Name = "lblPartidaSelecionada";
            this.lblPartidaSelecionada.Size = new System.Drawing.Size(253, 37);
            this.lblPartidaSelecionada.TabIndex = 27;
            this.lblPartidaSelecionada.Text = "Partida selecionada";
            // 
            // lblNomePartidaSelecionada
            // 
            this.lblNomePartidaSelecionada.AutoSize = true;
            this.lblNomePartidaSelecionada.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartidaSelecionada.Location = new System.Drawing.Point(341, 65);
            this.lblNomePartidaSelecionada.Name = "lblNomePartidaSelecionada";
            this.lblNomePartidaSelecionada.Size = new System.Drawing.Size(75, 28);
            this.lblNomePartidaSelecionada.TabIndex = 28;
            this.lblNomePartidaSelecionada.Text = "Nome: ";
            // 
            // lblStatusPartidaSelecionada
            // 
            this.lblStatusPartidaSelecionada.AutoSize = true;
            this.lblStatusPartidaSelecionada.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPartidaSelecionada.Location = new System.Drawing.Point(342, 104);
            this.lblStatusPartidaSelecionada.Name = "lblStatusPartidaSelecionada";
            this.lblStatusPartidaSelecionada.Size = new System.Drawing.Size(75, 28);
            this.lblStatusPartidaSelecionada.TabIndex = 29;
            this.lblStatusPartidaSelecionada.Text = "Status: ";
            // 
            // lblEntrarPartida
            // 
            this.lblEntrarPartida.AutoSize = true;
            this.lblEntrarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrarPartida.Location = new System.Drawing.Point(339, 355);
            this.lblEntrarPartida.Name = "lblEntrarPartida";
            this.lblEntrarPartida.Size = new System.Drawing.Size(65, 28);
            this.lblEntrarPartida.TabIndex = 30;
            this.lblEntrarPartida.Text = "Entrar";
            // 
            // btnEntrarBot
            // 
            this.btnEntrarBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEntrarBot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEntrarBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarBot.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarBot.Location = new System.Drawing.Point(340, 580);
            this.btnEntrarBot.Name = "btnEntrarBot";
            this.btnEntrarBot.Size = new System.Drawing.Size(281, 30);
            this.btnEntrarBot.TabIndex = 31;
            this.btnEntrarBot.Text = "Entrar modo bot";
            this.btnEntrarBot.UseVisualStyleBackColor = false;
            this.btnEntrarBot.Click += new System.EventHandler(this.btnEntrarBot_Click);
            // 
            // lblVisualizar
            // 
            this.lblVisualizar.AutoSize = true;
            this.lblVisualizar.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar.Location = new System.Drawing.Point(342, 623);
            this.lblVisualizar.Name = "lblVisualizar";
            this.lblVisualizar.Size = new System.Drawing.Size(102, 28);
            this.lblVisualizar.TabIndex = 32;
            this.lblVisualizar.Text = "Vislualizar";
            // 
            // btnVisualizarPartida
            // 
            this.btnVisualizarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnVisualizarPartida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnVisualizarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarPartida.Location = new System.Drawing.Point(340, 671);
            this.btnVisualizarPartida.Name = "btnVisualizarPartida";
            this.btnVisualizarPartida.Size = new System.Drawing.Size(281, 30);
            this.btnVisualizarPartida.TabIndex = 33;
            this.btnVisualizarPartida.Text = "Assistir partida";
            this.btnVisualizarPartida.UseVisualStyleBackColor = false;
            this.btnVisualizarPartida.Click += new System.EventHandler(this.btnVisualizarPartida_Click);
            // 
            // btnIntrucoes
            // 
            this.btnIntrucoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnIntrucoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnIntrucoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntrucoes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntrucoes.Location = new System.Drawing.Point(340, 717);
            this.btnIntrucoes.Name = "btnIntrucoes";
            this.btnIntrucoes.Size = new System.Drawing.Size(281, 30);
            this.btnIntrucoes.TabIndex = 34;
            this.btnIntrucoes.Text = "Instruções";
            this.btnIntrucoes.UseVisualStyleBackColor = false;
            this.btnIntrucoes.Click += new System.EventHandler(this.btnIntrucoes_Click);
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarPartida.Location = new System.Drawing.Point(22, 540);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(122, 28);
            this.lblCriarPartida.TabIndex = 35;
            this.lblCriarPartida.Text = "Criar Partida";
            // 
            // lblFeedbackCriarPartida
            // 
            this.lblFeedbackCriarPartida.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackCriarPartida.Location = new System.Drawing.Point(25, 751);
            this.lblFeedbackCriarPartida.Name = "lblFeedbackCriarPartida";
            this.lblFeedbackCriarPartida.Size = new System.Drawing.Size(281, 21);
            this.lblFeedbackCriarPartida.TabIndex = 36;
            this.lblFeedbackCriarPartida.Text = "Feedback criar partida";
            this.lblFeedbackCriarPartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbIcon4
            // 
            this.pcbIcon4.BackgroundImage = global::cantStop.Properties.Resources.pointY;
            this.pcbIcon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon4.Location = new System.Drawing.Point(347, 318);
            this.pcbIcon4.Name = "pcbIcon4";
            this.pcbIcon4.Size = new System.Drawing.Size(23, 24);
            this.pcbIcon4.TabIndex = 18;
            this.pcbIcon4.TabStop = false;
            // 
            // pcbIcon3
            // 
            this.pcbIcon3.BackgroundImage = global::cantStop.Properties.Resources.pointG;
            this.pcbIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon3.Location = new System.Drawing.Point(347, 275);
            this.pcbIcon3.Name = "pcbIcon3";
            this.pcbIcon3.Size = new System.Drawing.Size(23, 24);
            this.pcbIcon3.TabIndex = 17;
            this.pcbIcon3.TabStop = false;
            // 
            // pcbIcon2
            // 
            this.pcbIcon2.BackgroundImage = global::cantStop.Properties.Resources.pointB;
            this.pcbIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon2.Location = new System.Drawing.Point(347, 233);
            this.pcbIcon2.Name = "pcbIcon2";
            this.pcbIcon2.Size = new System.Drawing.Size(23, 24);
            this.pcbIcon2.TabIndex = 16;
            this.pcbIcon2.TabStop = false;
            // 
            // pcbIcon1
            // 
            this.pcbIcon1.BackgroundImage = global::cantStop.Properties.Resources.pointR;
            this.pcbIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon1.Location = new System.Drawing.Point(347, 192);
            this.pcbIcon1.Name = "pcbIcon1";
            this.pcbIcon1.Size = new System.Drawing.Size(23, 24);
            this.pcbIcon1.TabIndex = 15;
            this.pcbIcon1.TabStop = false;
            // 
            // pcbSenhaCriarPartida
            // 
            this.pcbSenhaCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pcbSenhaCriarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbSenhaCriarPartida.Image = global::cantStop.Properties.Resources.icon_visualize;
            this.pcbSenhaCriarPartida.Location = new System.Drawing.Point(272, 674);
            this.pcbSenhaCriarPartida.Margin = new System.Windows.Forms.Padding(10);
            this.pcbSenhaCriarPartida.Name = "pcbSenhaCriarPartida";
            this.pcbSenhaCriarPartida.Size = new System.Drawing.Size(31, 19);
            this.pcbSenhaCriarPartida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbSenhaCriarPartida.TabIndex = 37;
            this.pcbSenhaCriarPartida.TabStop = false;
            this.pcbSenhaCriarPartida.Click += new System.EventHandler(this.pcbSenhaCriarPartida_Click);
            // 
            // pcbSenhaEntrarPartida
            // 
            this.pcbSenhaEntrarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pcbSenhaEntrarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbSenhaEntrarPartida.Image = global::cantStop.Properties.Resources.icon_visualize;
            this.pcbSenhaEntrarPartida.Location = new System.Drawing.Point(588, 486);
            this.pcbSenhaEntrarPartida.Margin = new System.Windows.Forms.Padding(10);
            this.pcbSenhaEntrarPartida.Name = "pcbSenhaEntrarPartida";
            this.pcbSenhaEntrarPartida.Size = new System.Drawing.Size(31, 19);
            this.pcbSenhaEntrarPartida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbSenhaEntrarPartida.TabIndex = 38;
            this.pcbSenhaEntrarPartida.TabStop = false;
            this.pcbSenhaEntrarPartida.Click += new System.EventHandler(this.pcbSenhaEntrarPartida_Click);
            // 
            // FormLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(647, 787);
            this.Controls.Add(this.pcbSenhaEntrarPartida);
            this.Controls.Add(this.pcbSenhaCriarPartida);
            this.Controls.Add(this.lblFeedbackCriarPartida);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.btnIntrucoes);
            this.Controls.Add(this.btnVisualizarPartida);
            this.Controls.Add(this.lblVisualizar);
            this.Controls.Add(this.btnEntrarBot);
            this.Controls.Add(this.lblEntrarPartida);
            this.Controls.Add(this.lblStatusPartidaSelecionada);
            this.Controls.Add(this.lblNomePartidaSelecionada);
            this.Controls.Add(this.lblPartidaSelecionada);
            this.Controls.Add(this.txbSenhaCriarPartida);
            this.Controls.Add(this.lblSenhaCriarPartida);
            this.Controls.Add(this.txbNomeCriarPartida);
            this.Controls.Add(this.lblNomeCriarPartida);
            this.Controls.Add(this.lblJogador4);
            this.Controls.Add(this.lblJogador3);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.pcbIcon4);
            this.Controls.Add(this.pcbIcon3);
            this.Controls.Add(this.pcbIcon2);
            this.Controls.Add(this.pcbIcon1);
            this.Controls.Add(this.lblJogadoresPartidaSelecionada);
            this.Controls.Add(this.lblPartidas);
            this.Controls.Add(this.txbSenhaEntrarPartida);
            this.Controls.Add(this.lblSenhaEntrarPartida);
            this.Controls.Add(this.txbNomeEntrarPartida);
            this.Controls.Add(this.lblNomeEntrarPartida);
            this.Controls.Add(this.btnEntrarDev);
            this.Controls.Add(this.dgvListaPartidas);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.btnAtualizar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLobby";
            this.Text = "Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenhaCriarPartida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenhaEntrarPartida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.DataGridView dgvListaPartidas;
        private System.Windows.Forms.Button btnEntrarDev;
        private System.Windows.Forms.Label lblNomeEntrarPartida;
        private System.Windows.Forms.TextBox txbNomeEntrarPartida;
        private System.Windows.Forms.Label lblSenhaEntrarPartida;
        private System.Windows.Forms.TextBox txbSenhaEntrarPartida;
        private System.Windows.Forms.Label lblPartidas;
        private System.Windows.Forms.Label lblJogadoresPartidaSelecionada;
        private System.Windows.Forms.PictureBox pcbIcon1;
        private System.Windows.Forms.PictureBox pcbIcon2;
        private System.Windows.Forms.PictureBox pcbIcon3;
        private System.Windows.Forms.PictureBox pcbIcon4;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblJogador3;
        private System.Windows.Forms.Label lblJogador4;
        private System.Windows.Forms.TextBox txbSenhaCriarPartida;
        private System.Windows.Forms.Label lblSenhaCriarPartida;
        private System.Windows.Forms.TextBox txbNomeCriarPartida;
        private System.Windows.Forms.Label lblNomeCriarPartida;
        private System.Windows.Forms.Label lblPartidaSelecionada;
        private System.Windows.Forms.Label lblNomePartidaSelecionada;
        private System.Windows.Forms.Label lblStatusPartidaSelecionada;
        private System.Windows.Forms.Label lblEntrarPartida;
        private System.Windows.Forms.Button btnEntrarBot;
        private System.Windows.Forms.Label lblVisualizar;
        private System.Windows.Forms.Button btnVisualizarPartida;
        private System.Windows.Forms.Button btnIntrucoes;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.Label lblFeedbackCriarPartida;
        private System.Windows.Forms.PictureBox pcbSenhaCriarPartida;
        private System.Windows.Forms.PictureBox pcbSenhaEntrarPartida;
    }
}

