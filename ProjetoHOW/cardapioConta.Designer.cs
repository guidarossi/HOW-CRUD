namespace ProjetoHOW
{
    partial class ContaCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContaCardapio));
            this.btnCardapio = new System.Windows.Forms.Button();
            this.btnMinhaConta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCardapio
            // 
            this.btnCardapio.BackColor = System.Drawing.Color.Transparent;
            this.btnCardapio.Image = ((System.Drawing.Image)(resources.GetObject("btnCardapio.Image")));
            this.btnCardapio.Location = new System.Drawing.Point(82, 43);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.Size = new System.Drawing.Size(129, 123);
            this.btnCardapio.TabIndex = 0;
            this.btnCardapio.UseVisualStyleBackColor = false;
            this.btnCardapio.Click += new System.EventHandler(this.btnCardapio_Click_1);
            // 
            // btnMinhaConta
            // 
            this.btnMinhaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinhaConta.Image = ((System.Drawing.Image)(resources.GetObject("btnMinhaConta.Image")));
            this.btnMinhaConta.Location = new System.Drawing.Point(82, 229);
            this.btnMinhaConta.Name = "btnMinhaConta";
            this.btnMinhaConta.Size = new System.Drawing.Size(129, 123);
            this.btnMinhaConta.TabIndex = 1;
            this.btnMinhaConta.UseVisualStyleBackColor = true;
            this.btnMinhaConta.Click += new System.EventHandler(this.btnMinhaConta_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fazer pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minha conta";
            // 
            // ContaCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(286, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinhaConta);
            this.Controls.Add(this.btnCardapio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContaCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzaria Univali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMinhaConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCardapio;
    }
}