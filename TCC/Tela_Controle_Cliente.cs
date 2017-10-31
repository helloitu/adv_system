using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TCC
{
    public partial class Tela_Controle_Cliente : Form
    {
        string nome = "",sexo = "",email = "",rg = "",cpf="",datanasc="",endereco="",
            num="",telefone="",celular="", bairro = "", cidade = "", cep = "", estado = "";
        public string codigo = "";
        public Tela_Controle_Cliente()
        {
            InitializeComponent();
        }

        public void carregaDataGrid()
        {
            clienteBD clienteBD = new clienteBD();
            dataGridView1.DataSource = clienteBD.getCliente();
        }

        public void configurarDataGrid()
        {
            /*dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Sexo";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "RG";
            dataGridView1.Columns[5].HeaderText = "CPF";
            dataGridView1.Columns[6].HeaderText = "Data de Nasc.";
            dataGridView1.Columns[7].HeaderText = "Cidade";
            dataGridView1.Columns[8].HeaderText = "Endereço";
            dataGridView1.Columns[9].HeaderText = "Num.";
            dataGridView1.Columns[10].HeaderText = "Telefone";
            dataGridView1.Columns[11].HeaderText = "Celular";

            //tamanho
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 390;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 200 ;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 200;
            dataGridView1.Columns[9].Width = 60;
            dataGridView1.Columns[10].Width = 60;
            dataGridView1.Columns[11].Width = 60;

            dataGridView1.Columns["cli_cod"].Visible = false;*/

        }
        private void Tela_Cliente_Load(object sender, EventArgs e)
        {
            //configurarDataGrid();
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Cliente tela_cadastro_cliente = new Tela_Cadastro_Cliente();
            tela_cadastro_cliente.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Informações do cliente " + codigo +
                "\n Nome : " + nome + " |  Sexo : " + sexo
                + "\n Email : " + email
                + "\n RG : " + rg + "  |  CPF : " + cpf
                + "\n Data de Nascimento : " + datanasc
                + "\n Endereço : " + endereco + "  |  CEP : " + cep + "  |  Numero : " + num
                + "\n Bairro : " + bairro + "  |  Cidade : " + cidade + "  |  Estado : " + estado
                + "\n Telefone : " + telefone + "  |  Celular : " + celular
                );
            btnVisualizar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tela_Cadastro_Cliente_2 cliente = new Tela_Cadastro_Cliente_2();
            cliente.txtCodigo.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cliente.txtNome.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cliente.txtSexo.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cliente.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cliente.txtRG.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cliente.txtCPF.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cliente.txtDataNascimento.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cliente.txtCidade.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cliente.txtEndereco.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cliente.txtNumero.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cliente.txtTelefone.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cliente.txtCelular.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cliente.txtBairro.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            cliente.txtCep.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cliente.cmbEstado.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            cliente.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir o cliente " + nome, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteBD clienteBD = new clienteBD();
                clienteBD.excluirCliente(int.Parse(codigo));
                MessageBox.Show("Cliente : " + nome + " excluído com sucesso");
                dataGridView1.AutoGenerateColumns = false;
                btnExcluir.Visible = false;
                carregaDataGrid();
                btnLimpar.PerformClick();
                btnVisualizar.Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nome = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sexo = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            email = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rg = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cpf = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            datanasc = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cidade = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            endereco = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            num = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            telefone = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            celular = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            bairro = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            cep = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            estado = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            btnVisualizar.Visible = true;
            btnExcluir.Visible = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /*nome = txtNome.Text;
            clienteBD clienteBD = new clienteBD();
            dataGridView1.DataSource = clienteBD.selecionaCliente(nome);*/
            MessageBox.Show("Opção em construção");

        }
    }
}
