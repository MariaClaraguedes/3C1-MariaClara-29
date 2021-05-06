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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string nome, endereco;
            int conta, agencia, telefone;
            double saldo;
            nome = txt_nome.Text;
            endereco = txt_endereco.Text;
            conta = int.Parse(txt_conta.Text);
            agencia = int.Parse(txt_agencia.Text);
            telefone = int.Parse(txt_tel.Text);
            saldo = double.Parse(txt_saldo.Text);
            if (nome != null || endereco != null || conta != null || agencia != null || telefone != null || saldo != null)
            {
                Form2 novaForm = new Form2(nome, endereco, conta, agencia, telefone, saldo);
                novaForm.Show();
            }
            else { return; }
        }
    }
}
