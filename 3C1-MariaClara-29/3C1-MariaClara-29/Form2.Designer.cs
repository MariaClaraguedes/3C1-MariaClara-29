
namespace _3C1_MariaClara_29
{
    partial class Form2
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
            this.lbl_dados = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_digite = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txt_digiteValor = new System.Windows.Forms.TextBox();
            this.btn_saque = new System.Windows.Forms.Button();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.btn_tranferencia = new System.Windows.Forms.Button();
            this.lbl_endereço = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Location = new System.Drawing.Point(305, 20);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(48, 13);
            this.lbl_dados.TabIndex = 0;
            this.lbl_dados.Text = "DADOS ";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(31, 70);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Location = new System.Drawing.Point(99, 70);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(38, 13);
            this.lbl_conta.TabIndex = 2;
            this.lbl_conta.Text = "Conta:";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(176, 70);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(52, 13);
            this.lbl_tel.TabIndex = 3;
            this.lbl_tel.Text = "Telefone:";
            this.lbl_tel.Click += new System.EventHandler(this.lbl_tel_Click);
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(265, 70);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(37, 13);
            this.lbl_saldo.TabIndex = 4;
            this.lbl_saldo.Text = "Saldo:";
            // 
            // lbl_digite
            // 
            this.lbl_digite.AutoSize = true;
            this.lbl_digite.Location = new System.Drawing.Point(336, 70);
            this.lbl_digite.Name = "lbl_digite";
            this.lbl_digite.Size = new System.Drawing.Size(88, 13);
            this.lbl_digite.TabIndex = 5;
            this.lbl_digite.Text = "Informe um valor:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(31, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "lblNome";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(99, 97);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(45, 13);
            this.lblConta.TabIndex = 7;
            this.lblConta.Text = "lblConta";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(176, 97);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(59, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "lblTelefone";
            this.lblTelefone.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(265, 100);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(61, 13);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "R$ lblSaldo";
            // 
            // txt_digiteValor
            // 
            this.txt_digiteValor.Location = new System.Drawing.Point(339, 95);
            this.txt_digiteValor.Name = "txt_digiteValor";
            this.txt_digiteValor.Size = new System.Drawing.Size(85, 20);
            this.txt_digiteValor.TabIndex = 10;
            this.txt_digiteValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_saque
            // 
            this.btn_saque.Location = new System.Drawing.Point(430, 70);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Size = new System.Drawing.Size(69, 47);
            this.btn_saque.TabIndex = 11;
            this.btn_saque.Text = "Saque";
            this.btn_saque.UseVisualStyleBackColor = true;
            this.btn_saque.Click += new System.EventHandler(this.btn_saque_Click);
            // 
            // btn_deposito
            // 
            this.btn_deposito.Location = new System.Drawing.Point(505, 70);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(69, 47);
            this.btn_deposito.TabIndex = 12;
            this.btn_deposito.Text = "Deposito";
            this.btn_deposito.UseVisualStyleBackColor = true;
            this.btn_deposito.Click += new System.EventHandler(this.btn_deposito_Click);
            // 
            // btn_tranferencia
            // 
            this.btn_tranferencia.Location = new System.Drawing.Point(580, 70);
            this.btn_tranferencia.Name = "btn_tranferencia";
            this.btn_tranferencia.Size = new System.Drawing.Size(83, 47);
            this.btn_tranferencia.TabIndex = 13;
            this.btn_tranferencia.Text = "Transferencia";
            this.btn_tranferencia.UseVisualStyleBackColor = true;
            this.btn_tranferencia.Click += new System.EventHandler(this.btn_tranferencia_Click);
            // 
            // lbl_endereço
            // 
            this.lbl_endereço.AutoSize = true;
            this.lbl_endereço.Location = new System.Drawing.Point(31, 133);
            this.lbl_endereço.Name = "lbl_endereço";
            this.lbl_endereço.Size = new System.Drawing.Size(56, 13);
            this.lbl_endereço.TabIndex = 14;
            this.lbl_endereço.Text = "Endereco:";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(99, 133);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(63, 13);
            this.lblEndereço.TabIndex = 15;
            this.lblEndereço.Text = "lblEndereço";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 170);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lbl_endereço);
            this.Controls.Add(this.btn_tranferencia);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.btn_saque);
            this.Controls.Add(this.txt_digiteValor);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lbl_digite);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_conta);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_dados);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_digite;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txt_digiteValor;
        private System.Windows.Forms.Button btn_saque;
        private System.Windows.Forms.Button btn_deposito;
        private System.Windows.Forms.Button btn_tranferencia;
        private System.Windows.Forms.Label lbl_endereço;
        private System.Windows.Forms.Label lblEndereço;
    }
}