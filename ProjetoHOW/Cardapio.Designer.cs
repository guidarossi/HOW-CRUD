namespace ProjetoHOW
{
    partial class Cardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cardapio));
            this.tamanhoPizza = new System.Windows.Forms.GroupBox();
            this.tamanho3 = new System.Windows.Forms.RadioButton();
            this.tamanho2 = new System.Windows.Forms.RadioButton();
            this.tamanho1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gBebidas = new System.Windows.Forms.GroupBox();
            this.bebida4 = new System.Windows.Forms.RadioButton();
            this.bebida3 = new System.Windows.Forms.RadioButton();
            this.bebida2 = new System.Windows.Forms.RadioButton();
            this.bebida1 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.tamanhoPizza.SuspendLayout();
            this.gBebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tamanhoPizza
            // 
            this.tamanhoPizza.BackColor = System.Drawing.Color.Transparent;
            this.tamanhoPizza.Controls.Add(this.tamanho3);
            this.tamanhoPizza.Controls.Add(this.tamanho2);
            this.tamanhoPizza.Controls.Add(this.tamanho1);
            this.tamanhoPizza.Controls.Add(this.label1);
            this.tamanhoPizza.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanhoPizza.Location = new System.Drawing.Point(12, 12);
            this.tamanhoPizza.Name = "tamanhoPizza";
            this.tamanhoPizza.Size = new System.Drawing.Size(242, 121);
            this.tamanhoPizza.TabIndex = 0;
            this.tamanhoPizza.TabStop = false;
            this.tamanhoPizza.Enter += new System.EventHandler(this.tamanhoPizza_Enter);
            // 
            // tamanho3
            // 
            this.tamanho3.AutoSize = true;
            this.tamanho3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho3.Location = new System.Drawing.Point(6, 87);
            this.tamanho3.Name = "tamanho3";
            this.tamanho3.Size = new System.Drawing.Size(226, 29);
            this.tamanho3.TabIndex = 2;
            this.tamanho3.TabStop = true;
            this.tamanho3.Text = "Gigante 40CM              R$45,90";
            this.tamanho3.UseVisualStyleBackColor = true;
            // 
            // tamanho2
            // 
            this.tamanho2.AutoSize = true;
            this.tamanho2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho2.Location = new System.Drawing.Point(6, 55);
            this.tamanho2.Name = "tamanho2";
            this.tamanho2.Size = new System.Drawing.Size(228, 29);
            this.tamanho2.TabIndex = 1;
            this.tamanho2.TabStop = true;
            this.tamanho2.Text = "Média 30CM                 R$29,90";
            this.tamanho2.UseVisualStyleBackColor = true;
            // 
            // tamanho1
            // 
            this.tamanho1.AutoSize = true;
            this.tamanho1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho1.Location = new System.Drawing.Point(8, 23);
            this.tamanho1.Name = "tamanho1";
            this.tamanho1.Size = new System.Drawing.Size(224, 29);
            this.tamanho1.TabIndex = 0;
            this.tamanho1.TabStop = true;
            this.tamanho1.Text = "Pequena 25CM            R$19,90";
            this.tamanho1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "TAMANHO";
            // 
            // gBebidas
            // 
            this.gBebidas.BackColor = System.Drawing.Color.Transparent;
            this.gBebidas.Controls.Add(this.bebida4);
            this.gBebidas.Controls.Add(this.bebida3);
            this.gBebidas.Controls.Add(this.bebida2);
            this.gBebidas.Controls.Add(this.bebida1);
            this.gBebidas.Location = new System.Drawing.Point(12, 296);
            this.gBebidas.Name = "gBebidas";
            this.gBebidas.Size = new System.Drawing.Size(242, 156);
            this.gBebidas.TabIndex = 1;
            this.gBebidas.TabStop = false;
            this.gBebidas.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bebida4
            // 
            this.bebida4.AutoSize = true;
            this.bebida4.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bebida4.Location = new System.Drawing.Point(6, 115);
            this.bebida4.Name = "bebida4";
            this.bebida4.Size = new System.Drawing.Size(220, 29);
            this.bebida4.TabIndex = 6;
            this.bebida4.TabStop = true;
            this.bebida4.Text = "Vinho Tinto Seco 1L   R$25,90";
            this.bebida4.UseVisualStyleBackColor = true;
            // 
            // bebida3
            // 
            this.bebida3.AutoSize = true;
            this.bebida3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bebida3.Location = new System.Drawing.Point(6, 83);
            this.bebida3.Name = "bebida3";
            this.bebida3.Size = new System.Drawing.Size(217, 29);
            this.bebida3.TabIndex = 5;
            this.bebida3.TabStop = true;
            this.bebida3.Text = "Suco Laranja  1L          R$5,90";
            this.bebida3.UseVisualStyleBackColor = true;
            // 
            // bebida2
            // 
            this.bebida2.AutoSize = true;
            this.bebida2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bebida2.Location = new System.Drawing.Point(6, 51);
            this.bebida2.Name = "bebida2";
            this.bebida2.Size = new System.Drawing.Size(223, 29);
            this.bebida2.TabIndex = 4;
            this.bebida2.TabStop = true;
            this.bebida2.Text = "Pureza  2L                     R$8,90";
            this.bebida2.UseVisualStyleBackColor = true;
            // 
            // bebida1
            // 
            this.bebida1.AutoSize = true;
            this.bebida1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bebida1.Location = new System.Drawing.Point(6, 19);
            this.bebida1.Name = "bebida1";
            this.bebida1.Size = new System.Drawing.Size(221, 29);
            this.bebida1.TabIndex = 3;
            this.bebida1.TabStop = true;
            this.bebida1.Text = "Coca-Cola  2L               R$9,90";
            this.bebida1.UseVisualStyleBackColor = true;
            this.bebida1.CheckedChanged += new System.EventHandler(this.bebida1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Marguerita",
            "Calabresa",
            "Carbonara",
            "Americana",
            "Alho e Óleo",
            "Frango",
            "Frango c/Catupiry",
            "Mexicana",
            "Portuguesa",
            "Atum",
            "Lombo c/Catupiry",
            "Quatro queijos",
            "Vegetariana",
            "Parmegiana"});
            this.checkedListBox1.Location = new System.Drawing.Point(22, 158);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(226, 123);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "BEBIDAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "SABORES (Até 2)";
            // 
            // btnPagamento
            // 
            this.btnPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamento.Location = new System.Drawing.Point(18, 521);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(242, 47);
            this.btnPagamento.TabIndex = 9;
            this.btnPagamento.Text = "   Finalizar Pedido";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(112, 583);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 11;
            this.label4.Tag = "";
            this.label4.Text = "Valor Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelValorTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.Location = new System.Drawing.Point(118, 480);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(51, 26);
            this.labelValorTotal.TabIndex = 13;
            this.labelValorTotal.Tag = "";
            this.labelValorTotal.Text = "R$ 0";
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(277, 580);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.gBebidas);
            this.Controls.Add(this.tamanhoPizza);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cardápio";
            this.tamanhoPizza.ResumeLayout(false);
            this.tamanhoPizza.PerformLayout();
            this.gBebidas.ResumeLayout(false);
            this.gBebidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tamanhoPizza;
        private System.Windows.Forms.RadioButton tamanho3;
        private System.Windows.Forms.RadioButton tamanho2;
        private System.Windows.Forms.RadioButton tamanho1;
        private System.Windows.Forms.GroupBox gBebidas;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton bebida4;
        private System.Windows.Forms.RadioButton bebida3;
        private System.Windows.Forms.RadioButton bebida2;
        private System.Windows.Forms.RadioButton bebida1;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelValorTotal;
    }
}