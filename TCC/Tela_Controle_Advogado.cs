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
    public partial class Tela_Controle_Advogado : Form
    {
        private MySqlConnection minhaConexao;
        private MySqlCommand meuComando;

        public string codigo = "",nome="",rg="",cpf="",sexo="",email="",
            endereco="",numero ="", telefone="",celular="",especialidade="",
            registro="",dataadimissao="",status="", bairro = "", cidade = "", cep = "", estado = "";
        /*
        private void FiltrarDados()
        {
            //instrução SQL
            string strSql = "select eq_id,eq_registro,eq_descricao from cad_equipamentos where eq_descricao like '%" + textBox1.Text + "%'";
            //conexão com o banco de dados
            SqlConnection con = new SqlConnection(string_de_conexao);
            //objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, con);
            //abre a conexao
            con.Open();
            //tipo do comando
            cmd.CommandType = CommandType.Text;
            //dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //objeto datatable
            DataTable equipamentos = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(equipamentos);
            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = equipamentos;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrarDados();
        }*/

        public void carregaDataGrid()
        {
            advogadoBD advogadoBD = new advogadoBD();
            dataGridView1.DataSource = advogadoBD.getAdvogado();
        }

        public Tela_Controle_Advogado()
        {
            InitializeComponent();
            minhaConexao = new MySqlConnection("Persist Security Info = false; server = localhost; database = adv_sys;uid = root ; pwd =");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Consultar()
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void Tela_Controle_Advogado_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Advogado tela_cadastro_advogado = new Tela_Cadastro_Advogado();
            tela_cadastro_advogado.Show();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void SeuMetodo(DataGridViewRow row)
        {
            /*DadosAdvogado.AdvogadoID = row.Cells["Cod"].Value.ToString(); ;
            DadosAdvogado.Nome = row.Cells["Nome"].Value.ToString();
            DadosAdvogado.Rg = row.Cells["Rg"].Value.ToString();
            DadosAdvogado.Cpf = row.Cells["CPF"].Value.ToString();
            DadosAdvogado.Email = row.Cells["Email"].Value.ToString();
            DadosAdvogado.Endereco = row.Cells["Endereço"].Value.ToString();
            DadosAdvogado.Numero = row.Cells["Num."].Value.ToString();
            DadosAdvogado.Telefone = row.Cells["Telefone"].Value.ToString();
            DadosAdvogado.Celular = row.Cells["Celular"].Value.ToString();
            DadosAdvogado.Especialidade = row.Cells["Especialidade"].Value.ToString();
            DadosAdvogado.Registro = row.Cells["Registro"].Value.ToString();
            DadosAdvogado.DataEmissao = row.Cells["Data admissão"].Value.ToString();
            DadosAdvogado.Status = row.Cells["Status"].Value.ToString();
            DadosAdvogado.Login = row.Cells["Login"].Value.ToString();
            DadosAdvogado.Senha = row.Cells["Senha"].Value.ToString();*/

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*var row = dataGridView1.Rows[e.RowIndex];
            SeuMetodo(row);*/
            Tela_Cadastro_Advogado_2 tela_cadastro_2 = new Tela_Cadastro_Advogado_2();
            tela_cadastro_2.codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tela_cadastro_2.txtNome.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tela_cadastro_2.txtRG.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tela_cadastro_2.txtCPF.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tela_cadastro_2.sexo = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tela_cadastro_2.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tela_cadastro_2.txtEndereco.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tela_cadastro_2.txtNumero.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tela_cadastro_2.txtBairro.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tela_cadastro_2.txtCidade.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tela_cadastro_2.txtCep.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tela_cadastro_2.cmbEstado.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            tela_cadastro_2.txtTelefone.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            tela_cadastro_2.txtCelular.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            tela_cadastro_2.txtEspecialidade.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            tela_cadastro_2.txtOAB.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            tela_cadastro_2.txtData.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            tela_cadastro_2.status = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            tela_cadastro_2.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja mesmo excluir o advogado " + nome, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                advogadoBD advogadoBD= new advogadoBD();
                advogadoBD.excluirAdvogado(int.Parse(codigo));
                MessageBox.Show("Advogado : " + nome + " excluído com sucesso");
                dataGridView1.AutoGenerateColumns = false;
                btnExcluir.Visible = false;
                btnVisualizar.Visible = false;
                carregaDataGrid();
                btnLimpar.PerformClick();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nome = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rg = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cpf = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sexo = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            email = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            endereco = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            numero = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            bairro = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cidade = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cep = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            estado = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            telefone = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            celular = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            especialidade = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            registro = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            dataadimissao = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            status = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            btnVisualizar.Visible = true;
            btnExcluir.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Informações do advogado " +
               "\n Nome : " + nome + "  | Sexo : " + sexo
               + "\n RG : " + rg + "  |  CPF : " + cpf
               + "\n Email : " + email
               + "\n Endereço : " + endereco + "  |  Numero : " + numero + "  |  Bairro :  " + bairro
               + "\n Cidade : " + cidade + "  |  Estado : " + estado
               + "\n Telefone : " + telefone + "  | Celular : " + celular
               + "\n Especialidade : " + especialidade + "  |  Registro OAB : " + registro
               + "\n Data de admissão : " + dataadimissao + "  |  Status : " + status);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}