namespace ProjetoHOW
{
    partial class DadosUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosUsuario));
            this.dataGridConta = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextAtualizaTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextAtualizaCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextAtualizaCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAtualizaSenha = new System.Windows.Forms.TextBox();
            this.txtAtualizaEmail = new System.Windows.Forms.TextBox();
            this.txtAtualizaEndereco = new System.Windows.Forms.TextBox();
            this.txtAtualizaNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConta
            // 
            this.dataGridConta.BackgroundColor = System.Drawing.Color.White;
            this.dataGridConta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnCpf,
            this.ColumnTelefone,
            this.ColumnEndereco,
            this.ColumnCep,
            this.ColumnEmail,
            this.ColumnSenha});
            this.dataGridConta.GridColor = System.Drawing.Color.White;
            this.dataGridConta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridConta.Location = new System.Drawing.Point(337, 0);
            this.dataGridConta.Name = "dataGridConta";
            this.dataGridConta.RowHeadersVisible = false;
            this.dataGridConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridConta.Size = new System.Drawing.Size(10, 62);
            this.dataGridConta.TabIndex = 0;
            this.dataGridConta.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConta_CellEnter);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.Name = "ColumnCpf";
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.HeaderText = "Endereço";
            this.ColumnEndereco.Name = "ColumnEndereco";
            // 
            // ColumnCep
            // 
            this.ColumnCep.HeaderText = "CEP";
            this.ColumnCep.Name = "ColumnCep";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnSenha
            // 
            this.ColumnSenha.HeaderText = "Senha";
            this.ColumnSenha.Name = "ColumnSenha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMAÇÕES DE CADASTRO";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 419);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(247, 33);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.Location = new System.Drawing.Point(12, 467);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(247, 33);
            this.btnExcluirCadastro.TabIndex = 3;
            this.btnExcluirCadastro.Text = "EXCLUIR CADASTRO";
            this.btnExcluirCadastro.UseVisualStyleBackColor = true;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(94, 519);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "VOLTAR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(191, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // maskedTextAtualizaTelefone
            // 
            this.maskedTextAtualizaTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTextAtualizaTelefone.Location = new System.Drawing.Point(147, 115);
            this.maskedTextAtualizaTelefone.Mask = "(00) 0000-0000";
            this.maskedTextAtualizaTelefone.Name = "maskedTextAtualizaTelefone";
            this.maskedTextAtualizaTelefone.Size = new System.Drawing.Size(112, 24);
            this.maskedTextAtualizaTelefone.TabIndex = 3;
            // 
            // maskedTextAtualizaCPF
            // 
            this.maskedTextAtualizaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTextAtualizaCPF.Location = new System.Drawing.Point(13, 115);
            this.maskedTextAtualizaCPF.Mask = "000,000,000-00";
            this.maskedTextAtualizaCPF.Name = "maskedTextAtualizaCPF";
            this.maskedTextAtualizaCPF.Size = new System.Drawing.Size(112, 24);
            this.maskedTextAtualizaCPF.TabIndex = 2;
            // 
            // maskedTextAtualizaCEP
            // 
            this.maskedTextAtualizaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTextAtualizaCEP.Location = new System.Drawing.Point(13, 215);
            this.maskedTextAtualizaCEP.Mask = "00,000-000";
            this.maskedTextAtualizaCEP.Name = "maskedTextAtualizaCEP";
            this.maskedTextAtualizaCEP.Size = new System.Drawing.Size(87, 24);
            this.maskedTextAtualizaCEP.TabIndex = 5;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCEP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCEP.Location = new System.Drawing.Point(11, 192);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 20);
            this.lblCEP.TabIndex = 22;
            this.lblCEP.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(11, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Senha:";
            // 
            // txtAtualizaSenha
            // 
            this.txtAtualizaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAtualizaSenha.Location = new System.Drawing.Point(13, 322);
            this.txtAtualizaSenha.Name = "txtAtualizaSenha";
            this.txtAtualizaSenha.Size = new System.Drawing.Size(246, 24);
            this.txtAtualizaSenha.TabIndex = 7;
            this.txtAtualizaSenha.UseSystemPasswordChar = true;
            // 
            // txtAtualizaEmail
            // 
            this.txtAtualizaEmail.Enabled = false;
            this.txtAtualizaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAtualizaEmail.Location = new System.Drawing.Point(13, 276);
            this.txtAtualizaEmail.Name = "txtAtualizaEmail";
            this.txtAtualizaEmail.Size = new System.Drawing.Size(247, 24);
            this.txtAtualizaEmail.TabIndex = 6;
            // 
            // txtAtualizaEndereco
            // 
            this.txtAtualizaEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAtualizaEndereco.Location = new System.Drawing.Point(14, 165);
            this.txtAtualizaEndereco.Name = "txtAtualizaEndereco";
            this.txtAtualizaEndereco.Size = new System.Drawing.Size(246, 24);
            this.txtAtualizaEndereco.TabIndex = 4;
            // 
            // txtAtualizaNome
            // 
            this.txtAtualizaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAtualizaNome.Location = new System.Drawing.Point(13, 65);
            this.txtAtualizaNome.Name = "txtAtualizaNome";
            this.txtAtualizaNome.Size = new System.Drawing.Size(247, 24);
            this.txtAtualizaNome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(11, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(11, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(143, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome completo:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(337, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(10, 20);
            this.txtID.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(12, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Confirmar senha:";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtConfirmaSenha.Location = new System.Drawing.Point(14, 370);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(246, 24);
            this.txtConfirmaSenha.TabIndex = 8;
            this.txtConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // DadosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(285, 548);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextAtualizaTelefone);
            this.Controls.Add(this.maskedTextAtualizaCPF);
            this.Controls.Add(this.maskedTextAtualizaCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAtualizaSenha);
            this.Controls.Add(this.txtAtualizaEmail);
            this.Controls.Add(this.txtAtualizaEndereco);
            this.Controls.Add(this.txtAtualizaNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluirCadastro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DadosUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do usuário";
            this.Load += new System.EventHandler(this.DadosUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextAtualizaTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextAtualizaCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextAtualizaCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAtualizaSenha;
        private System.Windows.Forms.TextBox txtAtualizaEmail;
        private System.Windows.Forms.TextBox txtAtualizaEndereco;
        private System.Windows.Forms.TextBox txtAtualizaNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
    }
}