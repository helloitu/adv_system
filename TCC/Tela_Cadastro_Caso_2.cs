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
    public partial class Tela_Cadastro_Caso_2 : Form
    {
        public string codigo = "",pagamento="",tipo = "",valor="";
        public Tela_Cadastro_Caso_2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Controle_Caso tela_controle_caso = new Tela_Controle_Caso();
            tela_controle_caso.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tela_Controle_Caso tela_controle_caso = new Tela_Controle_Caso();
            tela_controle_caso.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNaurezaCausa.Clear();
            txtVara.Clear();
            txtCartorio.Clear();
            txtNumeroPasta.Clear();
            txtValor.Clear();
            rdbDinheiro.Checked = false;
            rdbCredito.Checked = false;
            rdbDebito.Checked = false;
            rdbCheque.Checked = false;
            txtNomeCliente.Clear();
            txtPosicao.Clear();
            txtNomeAdvogado.Clear();
            txtNomeParteContraria.Clear();
            txtEnderecoParteContraria.Clear();
            txtTelefoneParteContraria.Clear();
            txtCelularParteContraria.Clear();
            txtAndamento.Clear();
            txtDataAndamento.Clear();
        }

        private void btnConcluido_Click(object sender, EventArgs e)
        {
            valor = txtValor.Text;
            caso caso = new caso(txtNaurezaCausa.Text, txtVara.Text, txtCartorio.Text,
                txtNumeroPasta.Text, tipo, txtNumeroProcesso.Text,
                valor, pagamento, txtNomeCliente.Text, txtPosicao.Text, txtNomeAdvogado.Text, txtNomeParteContraria.Text,
                txtEnderecoParteContraria.Text, txtNumeroParteContraria.Text, txtTelefoneParteContraria.Text,
                txtCelularParteContraria.Text,
                txtData.Text, txtAndamento.Text, txtDataAndamento.Text);
            casoBD advogadoBD = new casoBD();
            advogadoBD.alterarCaso(caso, int.Parse(codigo));
            MessageBox.Show("Cadastro do processo do cliente : " + txtNomeCliente.Text + " alterado com sucesso");
            //
            Tela_Controle_Caso Tela_Controle_Caso = new Tela_Controle_Caso();
            Tela_Controle_Caso.Show();
            this.Close();
        }

        private void btnAndamento_Click(object sender, EventArgs e)
        {
            txtNaurezaCausa.Enabled = false;
            txtVara.Enabled = false;
            txtCartorio.Enabled = false;
            txtNumeroPasta.Enabled = false;
            txtValor.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtPosicao.Enabled = false;
            txtNomeAdvogado.Enabled = false;
            txtNomeParteContraria.Enabled = false;
            txtEnderecoParteContraria.Enabled = false;
            txtTelefoneParteContraria.Enabled = false;
            txtCelularParteContraria.Enabled = false;
            txtData.Enabled = false;
            
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

        private void rdbConvenio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConvenio.Checked)
            {
                tipo = "Convenio";
                groupBox2.Visible = false;
                lblValor.Visible = false;
                lblPagamento.Visible = false;
                txtValor.Visible = false;
                pagamento = "Convenio ";
                txtValor.Text = "0";
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDebito.Checked)
            {
                pagamento = "Cartão de débito";
            }
        }

        private void rdbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCheque.Checked)
            {
                pagamento = "Cheque";
            }
        }

        private void Tela_Cadastro_Caso_2_Load(object sender, EventArgs e)
        {
            if (tipo.Equals("Convenio"))
            {
                rdbConvenio.Checked = true;
            }
            else if (tipo.Equals("Particular"))
            {
                rdbParticular.Checked = true;
            }
            txtValor.Text = valor;



            ///
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
