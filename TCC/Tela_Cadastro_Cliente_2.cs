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
    public partial class Tela_Cadastro_Cliente_2 : Form
    {
        public Tela_Cadastro_Cliente_2()
        {
            InitializeComponent();
            if (txtSexo.Text.Equals("Masculino"))
            {
                rdbMasculino.Checked = true;
            }
            else if (txtSexo.Text.Equals("Feminino"))
            {
                rdbFeminino.Checked = true;
            }
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
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cliente cliente = new cliente(txtNome.Text, txtSexo.Text, txtEmail.Text, txtRG.Text,
                txtCPF.Text, txtDataNascimento.Text, txtCidade.Text, txtCep.Text, txtBairro.Text,
                cmbEstado.Text, txtEndereco.Text,
                txtNumero.Text, txtTelefone.Text, txtCelular.Text);
            clienteBD clienteBD = new clienteBD();
            clienteBD.alterarCliente(cliente, int.Parse(txtCodigo.Text));
            MessageBox.Show("Cadastro do cliente : " + txtNome.Text + " alterado com sucesso");
            Tela_Controle_Cliente Tela_Controle_Cliente = new Tela_Controle_Cliente();
            Tela_Controle_Cliente.ShowDialog();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Controle_Cliente tela_controle_cliente = new Tela_Controle_Cliente();
            tela_controle_cliente.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tela_Controle_Cliente tela_controle_cliente = new Tela_Controle_Cliente();
            tela_controle_cliente.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
            {
                txtSexo.Text = "Masculino";
                rdbFeminino.Checked = false;
            }
            
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFeminino.Checked)
            {
                txtSexo.Text = "Feminino";
                rdbMasculino.Checked = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tela_Cadastro_Cliente_2_Load(object sender, EventArgs e)
        {
            if (txtSexo.Text.Equals("Masculino"))
            {
                rdbMasculino.Checked = true;
            }
            else if (txtSexo.Text.Equals("Feminino"))
            {
                rdbFeminino.Checked = true;
            }
        }
    }
}
