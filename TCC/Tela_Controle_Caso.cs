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
    public partial class Tela_Controle_Caso : Form
    {
        public string codigo = "", causa = "", vara = "", cartorio = "", pasta = "", tipo = "", valor = "", pagamento = "",
            nome = "", posicao = "", advogado = "", partenome = "", parteendereco = "", partenumero = "", partetelefone = "",
            partecelular = "", data = "", andamento = "", dataandamento = "",numero="";

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Informações do processo " + numero
                + "\n Nome : " + nome
                + "\n Posição processual :" + posicao
                + "\n Causa : " + causa
                + "\n Advogado : " + advogado
                + "\n Vara : " + vara
                + "\n Cartório : " + cartorio
                + "\n Numero da pasta : " + pasta
                + "\n Tipo de atendimento : " + tipo
                + "\n Valor : R$" + valor
                + "\n Tipo de pagamento : " + pagamento
                + "\n Parte contrária" 
                + "\n Nome : " + partenome
                + "\n Endereço : " + parteendereco + "  |  Numero : " + partenumero
                + "\n Telefone : " + partetelefone + "  |  Celular : " + partecelular
                + "\n Caso "
                + "\n Data : " + data
                + "\n Andamento : " + andamento + "  |   Data do andamento : " + dataandamento) ;
            btnVisualizar.Visible = false;
                }

        public Tela_Controle_Caso()
        {
            InitializeComponent();
        }

        public void carregaDataGrid()
        {
            casoBD casoBD = new casoBD();
            dataGridView1.DataSource = casoBD.getCaso();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Caso tela_cadastro = new Tela_Cadastro_Caso();
            tela_cadastro.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Caso_2 tela_cadastro_2 = new Tela_Cadastro_Caso_2();
            tela_cadastro_2.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void Tela_Controle_Caso_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo excluir o caso da(o) cliente " + nome, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                casoBD casoBD = new casoBD();
                casoBD.excluirCaso(int.Parse(codigo));
                MessageBox.Show("Caso do(a) cliente: " + nome + " excluído com sucesso");
                dataGridView1.AutoGenerateColumns = false;
                btnExcluir.Visible = false;
                carregaDataGrid();
                btnLimpar.PerformClick();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nome = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            posicao = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            causa = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            advogado = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            vara = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cartorio = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pasta = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tipo = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            numero = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            valor = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            pagamento = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            partenome = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            parteendereco = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            partenumero = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            partetelefone= this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            partecelular = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            data = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            andamento = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            dataandamento = this.dataGridView1.CurrentRow.Cells[19].Value.ToString();
            btnExcluir.Visible = true;
            btnVisualizar.Visible = true;txtNome.Text = nome;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tela_Cadastro_Caso_2 caso = new Tela_Cadastro_Caso_2();
            caso.codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            caso.txtNomeCliente.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            caso.txtPosicao.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            caso.txtNaurezaCausa.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            caso.txtNomeAdvogado.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            caso.txtVara.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            caso.txtCartorio.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            caso.txtNumeroPasta.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            caso.tipo = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            caso.txtNumeroProcesso.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            caso.valor = this.dataGridView1.CurrentRow.Cells[10].Value.ToString(); 
            caso.pagamento= this.dataGridView1.CurrentRow.Cells[11].Value.ToString(); 
            caso.txtNomeParteContraria.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString(); 
            caso.txtEnderecoParteContraria.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString(); 
            caso.txtNumeroParteContraria.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString(); 
            caso.txtTelefoneParteContraria.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString(); 
            caso.txtCelularParteContraria.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString(); 
            caso.txtData.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString(); 
            caso.txtAndamento.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString(); 
            caso.txtDataAndamento.Text = this.dataGridView1.CurrentRow.Cells[19].Value.ToString(); 
            caso.Show();
            this.Close();
        }
    }
}
