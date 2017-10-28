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
    public partial class Tela_Cadastro_Cliente : Form
    {

        public string sexo = "";

        public Tela_Cadastro_Cliente()
        {
            InitializeComponent();
            clienteBD clienteBD = new clienteBD();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtDataNascimento.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCidade.Clear();
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            if (txtNome.Text.Equals("") || txtRG.Text.Equals("") || txtCPF.Text.Equals(""))
            {
                MessageBox.Show("Campos obrigatórios em branco");
                return;
            }
            try
            {
                clienteBD clienteBD = new clienteBD();
                cliente cliente = new cliente(txtNome.Text,txtSexo.Text,txtEmail.Text,
                    txtRG.Text,txtCPF.Text,txtDataNascimento.Text,txtCidade.Text,txtEndereco.Text,
                    txtNumero.Text,txtTelefone.Text,txtCelular.Text);
                clienteBD.IncluirCliente(cliente);
                MessageBox.Show("Cliente " + txtNome.Text + " cadastrado com sucesso");
                btnLimpar.PerformClick();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbMasculino.Checked)
            {
                txtSexo.Text = "Masculino";
                rdbFeminino.Checked = false;
            }
            /*else
            {
                txtSexo.Text = "";
            }
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFeminino.Checked)
            {
                txtSexo.Text = "Feminino";
                rdbMasculino.Checked = false;
            }
            /*else
            {
                txtSexo.Text = "";
            }*/
        }
    }
}
