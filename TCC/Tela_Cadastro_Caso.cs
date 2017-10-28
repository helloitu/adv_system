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
    public partial class Tela_Cadastro_Caso : Form
    {
        public string codigoadv = "", codigocli = "",pagamento = "",tipo = "",valor="";
        public Tela_Cadastro_Caso()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public void limpar()
        {
            txtNaurezaCausa.Clear();
            txtVara.Clear();
            txtCartorio.Clear();
            txtNumeroPasta.Clear();
            txtValor.Clear();
            pagamento = "";
            txtNomeCliente.Clear();
            txtPosicao.Clear();
            txtNomeAdvogado.Clear();
            txtNomeParteContraria.Clear();
            txtEnderecoParteContraria.Clear();
            txtNumero.Clear();
            txtTelefoneParteContraria.Clear();
            txtCelularParteContraria.Clear();
            txtData.Clear();
            txtAndamento.Clear();
            txtData.Clear();
            rdbCheque.Checked = false;
            rdbCredito.Checked = false;
            rdbDebito.Checked = false;
            rdbDinheiro.Checked = false;
            txtNumeroCaso.Clear();
        }

        private void Tela_Cadastro_Caso_Load(object sender, EventArgs e)
        {
            txtNaurezaCausa.Text = DadosCaso.NaturezaCausa;
             txtVara.Text= DadosCaso.Vara;
             txtCartorio.Text= DadosCaso.Cartorio;
             txtNumeroPasta.Text= DadosCaso.NumeroPasta;
             txtValor.Text = DadosCaso.Valor;
             pagamento = DadosCaso.Pagamento;
             txtNomeCliente.Text = DadosCaso.Cliente;
            codigocli=DadosCaso.IDcliente;
             txtPosicao.Text = DadosCaso.PosicaoProcessual;
             txtNomeAdvogado.Text = DadosCaso.Advogado;
             codigoadv = DadosCaso.IDadvogado;
             txtNomeParteContraria.Text = DadosCaso.NomeParteContraria;
             txtEnderecoParteContraria.Text = DadosCaso.EnderecoParteContraria;
             txtNumero.Text = DadosCaso.NumeroParteContraria;
             txtTelefoneParteContraria.Text = DadosCaso.TelefoneParteContraria;
             txtCelularParteContraria.Text = DadosCaso.CelularParteContraria;
             txtData.Text = DadosCaso.Data;
             txtAndamento.Text = DadosCaso.Andamento;
            valor = DadosCaso.Valor;
            tipo = DadosCaso.Tipo;
            txtNumeroCaso.Text = DadosCaso.Numero;

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

            if (tipo.Equals("Convenio"))
            {
                rdbConvenio.Checked = true;
            }
            else if (tipo.Equals("Particular"))
            {
                rdbParticular.Checked = true;
            }
            //txtNumeroPrestacoes.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void btnTelaEscolheCliente_Click(object sender, EventArgs e)
        {
            DadosCaso.NaturezaCausa = txtNaurezaCausa.Text;
            DadosCaso.Vara = txtNumeroPasta.Text;
            DadosCaso.Cartorio = txtCartorio.Text;
            DadosCaso.NumeroPasta = txtNumeroPasta.Text;
            DadosCaso.Valor = txtValor.Text;
            DadosCaso.Pagamento = pagamento;
            DadosCaso.Cliente = txtNomeCliente.Text;
            DadosCaso.IDcliente = codigocli;
            DadosCaso.PosicaoProcessual = txtPosicao.Text;
            DadosCaso.Advogado = txtNomeAdvogado.Text;
            DadosCaso.IDadvogado = codigoadv;
            DadosCaso.NomeParteContraria = txtNomeParteContraria.Text;
            DadosCaso.EnderecoParteContraria = txtEnderecoParteContraria.Text;
            DadosCaso.NumeroParteContraria = txtNumero.Text;
            DadosCaso.TelefoneParteContraria = txtTelefoneParteContraria.Text;
            DadosCaso.CelularParteContraria = txtCelularParteContraria.Text;
            DadosCaso.Data = txtData.Text;
            DadosCaso.Tipo = tipo;
            DadosCaso.Numero = txtNumeroCaso.Text;
            DadosCaso.Andamento = txtAndamento.Text;
            Tela_Escolhe_Cliente tela_escolhe_cliente = new Tela_Escolhe_Cliente();
            tela_escolhe_cliente.Show();
            this.Close();
        }

        private void btnTelaEscolheAdvogado_Click(object sender, EventArgs e)
        {
            DadosCaso.NaturezaCausa = txtNaurezaCausa.Text;
            DadosCaso.Vara = txtNumeroPasta.Text;
            DadosCaso.Cartorio = txtCartorio.Text;
            DadosCaso.NumeroPasta = txtNumeroPasta.Text;
            DadosCaso.Valor = txtValor.Text;
            DadosCaso.Pagamento = pagamento;
            DadosCaso.Cliente = txtNomeCliente.Text;
            DadosCaso.IDcliente = codigocli;
            DadosCaso.PosicaoProcessual = txtPosicao.Text;
            DadosCaso.Advogado = txtNomeAdvogado.Text;
            DadosCaso.IDadvogado = codigoadv;
            DadosCaso.NomeParteContraria = txtNomeParteContraria.Text;
            DadosCaso.EnderecoParteContraria = txtEnderecoParteContraria.Text;
            DadosCaso.NumeroParteContraria = txtNumero.Text;
            DadosCaso.TelefoneParteContraria = txtTelefoneParteContraria.Text;
            DadosCaso.CelularParteContraria = txtCelularParteContraria.Text;
            DadosCaso.Data = txtData.Text;
            DadosCaso.Andamento = txtAndamento.Text;
            DadosCaso.Tipo = tipo;
            DadosCaso.Numero = txtNumeroCaso.Text;
            this.Close();
            Tela_Escolhe_Advogado tela_escolhe_advogado = new Tela_Escolhe_Advogado();
            tela_escolhe_advogado.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDinheiro.Checked)
            {
                pagamento = "Dinheiro";
            }
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCredito.Checked)
            {
                pagamento = "Cartão de crédito";
            }
        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDebito.Checked)
            {
                pagamento = "Cartão de débito";
            }
        }

        private void rdbConvenio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConvenio.Checked)
            {
                tipo = "Convenio";
                groupBox2.Visible = false;
                lblValor.Visible = false;
                lblPagamento.Visible = false;
                txtValor.Visible = false;
                pagamento = " Convenio ";
                txtValor.Text = "";
            }
        }

        private void rdbParticular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbParticular.Checked)
            {
                tipo = "Particular";
                groupBox2.Visible = true;
                lblValor.Visible = true;
                lblPagamento.Visible = true;
                txtValor.Visible = true;
            }
        }

        private void rdbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCheque.Checked)
            {
                pagamento = "Cheque";
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

            

            if (txtNomeCliente.Text.Equals(""))
            {
                MessageBox.Show("Campos obrigatórios em branco");
                return;
            }
            try
            {

                casoBD casoBD = new casoBD();
                caso caso = new caso(txtNaurezaCausa.Text, txtVara.Text, txtCartorio.Text, txtNumeroPasta.Text,txtNumeroCaso.Text,tipo,
                    txtValor.Text, pagamento, txtNomeCliente.Text, txtPosicao.Text, txtNomeAdvogado.Text, txtNomeParteContraria.Text,
                    txtEnderecoParteContraria.Text, txtNumero.Text, txtTelefoneParteContraria.Text, txtCelularParteContraria.Text,
                    txtData.Text, txtAndamento.Text, txtData.Text);
                casoBD.IncluirCaso(caso);
                MessageBox.Show("Processo cadastrado com sucesso");
                limpar();
                Tela_Menu tela_menu = new Tela_Menu();
                tela_menu.Show();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
