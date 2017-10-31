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
    public partial class Tela_Controle_Secretaria : Form
    {
        public string codigo = "", nome = "", rg = "", cpf = "", sexo = "",
            endereco = "", num = "", telefone = "", celular = "",
            bairro = "", cidade = "", cep = "", estado = "";
            
        public void carregaDataGrid()
        {
            secretariaBD secretariaBD = new secretariaBD();
            dataGridView1.DataSource = secretariaBD.getSecretaria();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Tela_Controle_Secretaria()
        {
            InitializeComponent();
            secretariaBD secretariaBD = new secretariaBD();
            dataGridView1.DataSource = secretariaBD.getSecretaria();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Informações do secretário" +
                "\n Nome : " + nome + "  |  Sexo : " + sexo
                + "\n RG : " + rg + "  |  CPF : " + cpf
                + "\n Endereço : " + endereco + "  |  Numero : " + num + "  |  Bairro : " + bairro
                + "\n Cidade : " + cidade + "  | Estado : " + estado
                + "\n Telefone : " + telefone + "  |  Celular : " + celular
                );
            btnVisualizar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Tela_Cadastro_Secretaria_2 tela_cadastro_2 = new Tela_Cadastro_Secretaria_2();
            tela_cadastro_2.codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tela_cadastro_2.txtNome.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tela_cadastro_2.txtRG.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tela_cadastro_2.txtCPF.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tela_cadastro_2.sexo = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tela_cadastro_2.txtEndereco.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tela_cadastro_2.txtNumero.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tela_cadastro_2.txtTelefone.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            tela_cadastro_2.txtCelular.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            tela_cadastro_2.txtBairro.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tela_cadastro_2.txtCidade.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tela_cadastro_2.txtCep.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            estado = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tela_cadastro_2.Show();
            this.Close();
        }

        private void Tela_Controle_Secretaria_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nome = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rg = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cpf = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sexo = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            endereco = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            num = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            telefone = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            celular = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            bairro = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cidade = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cep = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            estado = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            btnExcluir.Visible = true;
            btnVisualizar.Visible = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo excluir o secretário " + nome, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                secretariaBD secretariaBD = new secretariaBD();
                secretariaBD.excluirSecretaria(int.Parse(codigo));
                MessageBox.Show("Secretário : " +nome + " excluído com sucesso");
                btnExcluir.Visible = false;
                dataGridView1.AutoGenerateColumns = false;
                carregaDataGrid();
                btnLimpar.PerformClick();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
