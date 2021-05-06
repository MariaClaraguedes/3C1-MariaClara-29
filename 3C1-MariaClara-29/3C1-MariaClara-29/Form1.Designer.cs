
namespace _3C1_MariaClara_29
{
    partial class Form1
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
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.lbl_agencia = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_agencia = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(29, 151);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(685, 23);
            this.btn_entrar.TabIndex = 0;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Location = new System.Drawing.Point(35, 55);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(35, 13);
            this.lbl_conta.TabIndex = 1;
            this.lbl_conta.Text = "Conta";
            // 
            // lbl_agencia
            // 
            this.lbl_agencia.AutoSize = true;
            this.lbl_agencia.Location = new System.Drawing.Point(142, 55);
            this.lbl_agencia.Name = "lbl_agencia";
            this.lbl_agencia.Size = new System.Drawing.Size(46, 13);
            this.lbl_agencia.TabIndex = 2;
            this.lbl_agencia.Text = "Agencia";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(611, 55);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(34, 13);
            this.lbl_saldo.TabIndex = 3;
            this.lbl_saldo.Text = "Saldo";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(259, 55);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(371, 55);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 5;
            this.lbl_endereco.Text = "Endereco";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(488, 55);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(49, 13);
            this.lbl_tel.TabIndex = 6;
            this.lbl_tel.Text = "Telefone";
            // 
            // txt_conta
            // 
            this.txt_conta.Location = new System.Drawing.Point(29, 88);
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(100, 20);
            this.txt_conta.TabIndex = 7;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(262, 88);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // txt_agencia
            // 
            this.txt_agencia.Location = new System.Drawing.Point(145, 88);
            this.txt_agencia.Name = "txt_agencia";
            this.txt_agencia.Size = new System.Drawing.Size(100, 20);
            this.txt_agencia.TabIndex = 9;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(491, 88);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 10;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(374, 88);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(100, 20);
            this.txt_endereco.TabIndex = 11;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(614, 88);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(100, 20);
            this.txt_saldo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 224);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_agencia);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_conta);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.lbl_agencia);
            this.Controls.Add(this.lbl_conta);
            this.Controls.Add(this.btn_entrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.Label lbl_agencia;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_agencia;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_saldo;
    }
}

