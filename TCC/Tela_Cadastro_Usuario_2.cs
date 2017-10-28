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
    public partial class Tela_Cadastro_Usuario_2 : Form
    {
        public string funcao = "", codigo = "";
        public Tela_Cadastro_Usuario_2()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Tela_Controle_Usuario Tela_Controle_Usuario = new Tela_Controle_Usuario();
            Tela_Controle_Usuario.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Controle_Usuario Tela_Controle_Usuario = new Tela_Controle_Usuario();
            Tela_Controle_Usuario.Show();
            this.Close();
        }

        private void btnConcluido_Click(object sender, EventArgs e)
        {
            usuario usuario = new usuario(txtNome.Text, funcao,txtLogin.Text,txtSenha.Text);
            usuarioBD usuarioBD = new usuarioBD();
            usuarioBD.alterarUsuario(usuario, int.Parse(codigo));
            MessageBox.Show("Cadastro do usuário : " + txtNome.Text + " alterado com sucesso");
            //
            Tela_Controle_Usuario Tela_Controle_Usuario = new Tela_Controle_Usuario();
            Tela_Controle_Usuario.Show();
            this.Close();
        }

        private void btnMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tela_Cadastro_Usuario_2_Load(object sender, EventArgs e)
        {
            txtFuncao.Text = funcao;
        }
    }
}
