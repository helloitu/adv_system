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
    public partial class Tela_Cadastro_Secretaria : Form
    {
        public string sexo = "";
        public string funcao = "";
        public Tela_Cadastro_Secretaria()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            rdbFem.Checked = false;
            rdbMasc.Checked = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rdbMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasc.Checked)
            {
                sexo = "Masculino";
                funcao = "Secretário";
                rdbFem.Checked = false;
            }
        }

        private void rdbFem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFem.Checked)
            {
                sexo = "Feminino";
                funcao = "Secretária";
                rdbMasc.Checked = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtRG.Text.Equals("") || txtCPF.Text.Equals("") || txtEndereco.Text.Equals("") || txtNumero.Text.Equals("") || txtTelefone.Text.Equals("") || txtLogin.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Campos obrigatórios em branco");
                return;
            }
            try
            {
                secretariaBD secretariaBD = new secretariaBD();
                secretaria secretaria = new secretaria(txtNome.Text, txtRG.Text, txtCPF.Text, sexo, txtEndereco.Text,
                    txtNumero.Text, txtTelefone.Text, txtCelular.Text);
                usuarioBD usuarioBD = new usuarioBD();
                usuario usuario = new TCC.usuario(txtNome.Text, funcao, txtLogin.Text, txtSenha.Text);
                usuarioBD.IncluirUsuario(usuario);
                secretariaBD.IncluirSecretaria(secretaria);
                MessageBox.Show("Secretario " + txtNome.Text + " cadastrado com sucesso");
                btnLimpar.PerformClick();
                Tela_Menu Tela_Menu = new Tela_Menu();
                Tela_Menu.Show();
                this.Close();
                
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void Tela_Cadastro_Secretaria_Load(object sender, EventArgs e)
        {

        }
    }
}
