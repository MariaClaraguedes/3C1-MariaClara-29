using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1_MariaClara_29
{
    public partial class Form2 : Form
    {
        double num1, num2, num3;
        public Form2(string nome, string endereco, int conta, int agencia, int telefone, double saldo)
        {
            InitializeComponent();

            lblSaldo.Text = Convert.ToString(saldo);
            lblNome.Text = nome;
            lblTelefone.Text = Convert.ToString(telefone);
            lblEndereço.Text = endereco;
            lblConta.Text = Convert.ToString(conta);
            num2 = saldo;
        }
        mar objCalcular = new mar();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            num3 = objCalcular.deposito(num2, num1);
            lblSaldo.Text = "Saldo R$ " + num3;
            MessageBox.Show("deposito bem sucedido");
            num2 = num3;
        }

        private void btn_tranferencia_Click(object sender, EventArgs e)
        {
            double.TryParse(txt_digiteValor.Text, out num1);
            if (num2 > num1)
            {
                num3 = objCalcular.transferencia(num2, num1);
                lblSaldo.Text = "Saldo R$ " + num3;
                MessageBox.Show("Transferencia bem sucedido");
                num2 = num3;
            }
            else
            {
                MessageBox.Show("Saldo não suficente");
            }
        }

        private void btn_saque_Click(object sender, EventArgs e)
        {
            double.TryParse(txt_digiteValor.Text, out num1);
            if (num2 > num1)
            {
                num3 = objCalcular.saque(num2, num1);
                lblSaldo.Text = "Saldo R$ " + num3;
                MessageBox.Show("Saque bem sucedida");
                num2 = num3;
            }
            else
            {
                MessageBox.Show("Saldo não suficente");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_tel_Click(object sender, EventArgs e)
        {

        }
    }
}
