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
    public partial class Tela_Cadastro_Secretaria_2 : Form
    {
        public string codigo = "";
        public string sexo = "";
        public Tela_Cadastro_Secretaria_2()
        {
            InitializeComponent();
            if (sexo.Equals("Masculino"))
            {
                rdbMasc.Checked = true;
            }
            else if (sexo.Equals("Feminino"))
            {
                rdbFem.Checked = true;
            }
        }

        private void Tela_Cadastro_Secretaria_2_Load(object sender, EventArgs e)
        {
            if (sexo.Equals("Masculino"))
            {
                rdbMasc.Checked = true;
            }
            else if (sexo.Equals("Feminino"))
            {
                rdbFem.Checked = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Controle_Secretaria tela_controle_secretaria = new Tela_Controle_Secretaria();
            tela_controle_secretaria.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tela_Controle_Secretaria tela_controle_secretaria = new Tela_Controle_Secretaria();
            tela_controle_secretaria.Show();
            this.Close();
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
            rdbMasc.Checked = false;
            rdbFem.Checked = false;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            secretaria secretaria = new secretaria(txtNome.Text, txtRG.Text, txtCPF.Text, sexo,
                txtEndereco.Text, txtCep.Text, txtCidade.Text, cmbEstado.Text, txtBairro.Text,
                txtNumero.Text, txtTelefone.Text, txtCelular.Text
                );
            secretariaBD secretariaBD = new secretariaBD();
            secretariaBD.alterarSecretaria(secretaria, int.Parse(codigo));
            MessageBox.Show("Cadastro do secretário : " + txtNome.Text + " alterado com sucesso");
            Tela_Controle_Secretaria controlesec = new Tela_Controle_Secretaria();
            controlesec.ShowDialog();
            this.Close();
        }

        private void rdbMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasc.Checked)
            {
                sexo = "Masculino";
                rdbFem.Checked = false;
            }
        }

        private void rdbFem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFem.Checked)
            {
                sexo = "Feminino";
                rdbMasc.Checked = false;
            }
        }
    }
}
