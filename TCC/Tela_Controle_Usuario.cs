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
    public partial class Tela_Controle_Usuario : Form
    {
        public string codigo = "",nome="",funcao ="",login="",senha = "";
        public Tela_Controle_Usuario()
        {
            InitializeComponent();
        }

        public void carregaDataGrid()
        {
            usuarioBD usuarioBD = new usuarioBD();
            dataGridView1.DataSource = usuarioBD.getUsuario();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tela_Cadastro_Usuario_2 Tela_Cadastro_Usuario_2 = new Tela_Cadastro_Usuario_2();
            Tela_Cadastro_Usuario_2.codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Tela_Cadastro_Usuario_2.txtNome.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Tela_Cadastro_Usuario_2.funcao = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Tela_Cadastro_Usuario_2.txtLogin.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Tela_Cadastro_Usuario_2.txtSenha.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Tela_Cadastro_Usuario_2.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Tela_Menu Tela_Menu = new Tela_Menu();
            Tela_Menu.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tela_Controle_Usuario_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Informações do usuario" +
                "\n Nome : " + nome + " || Função : " + funcao
                + "\n Login : " + login + "  |  Senha : " + senha);
            btnVisualizar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nome = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            funcao = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            login = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            senha = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            btnExcluir.Visible = true;
            btnVisualizar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir o usuário " + txtNome.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usuarioBD usuarioBD = new usuarioBD();
                usuarioBD.excluirUsuario(int.Parse(codigo));
                MessageBox.Show("Usuário : " + nome + " excluido com sucesso");
                btnExcluir.Visible = false;
                dataGridView1.AutoGenerateColumns = false;
                btnVisualizar.Visible = false;
                carregaDataGrid();
                btnLimpar.PerformClick();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }
    }
}
