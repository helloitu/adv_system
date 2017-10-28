using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class Tela_Cadastro_Caso_3 : Form
    {
        public string codigoadv = "", codigocli = "", pagamento = "";
        public Tela_Cadastro_Caso_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void btnTelaEscolheAdvogado_Click(object sender, EventArgs e)
        {

        }

        private void btnTelaEscolheCliente_Click(object sender, EventArgs e)
        {
            DadosCaso.NaturezaCausa = txtNaurezaCausa.Text;
            DadosCaso.Vara = txtNumeroPasta.Text;
            DadosCaso.Cartorio = txtCartorio.Text;
            DadosCaso.NumeroPasta = txtNumeroPasta.Text;
            DadosCaso.Valor = txtValor.Text;
            DadosCaso.Pagamento = pagamento;
            Tela_Escolhe_Cliente tela_escolhe_cliente = new Tela_Escolhe_Cliente();
            tela_escolhe_cliente.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void Tela_Cadastro_Caso_3_Load(object sender, EventArgs e)
        {
            txtNaurezaCausa.Text = DadosCaso.NaturezaCausa;
            txtVara.Text = DadosCaso.Vara;
            txtCartorio.Text = DadosCaso.Cartorio;
            txtNumeroPasta.Text = DadosCaso.NumeroPasta;
            txtValor.Text = DadosCaso.Valor;
            pagamento = DadosCaso.Pagamento ;
            if (pagamento.Equals("Dinheiro"))
            {
                rdbDinheiro.Checked = true;
            }
            else if (pagamento.Equals("Cartão de crédito"))
            {
                rdbCredito.Checked = true;
            }
            else if (pagamento.Equals("Cartão de débito"))
            {
                rdbDebito.Checked = true;
            }
            else if (pagamento.Equals("Cheque"))
            {
                rdbCheque.Checked = true;
            }
        }
    }
}
