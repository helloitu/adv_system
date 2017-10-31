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
    public partial class Tela_Cadastro_Advogado_2 : Form
    {
        public string status = "",codigo="",sexo="";

        public Tela_Cadastro_Advogado_2()
        {
            InitializeComponent();
            if (status.Equals("Ativo"))
            {
                rdbAtivo.Checked = true;
            }
            else if (status.Equals("Inativo"))
            {
                rdbInativo.Checked = true;
            }


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
            Tela_Controle_Advogado tela_controle_advogado = new Tela_Controle_Advogado();
            tela_controle_advogado.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Tela_Controle_Advogado tela_controle_advogado = new Tela_Controle_Advogado();
            tela_controle_advogado.Show();
            this.Close();
        }

        private void btnMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            txtOAB.Clear();
            rdbAtivo.Checked = false; ;
            rdbInativo.Checked = false; ;
            
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
            txtData.Clear();
            txtEmail.Clear();
            txtEspecialidade.Clear();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtOAB.Clear();
            rdbAtivo.Checked = false; ;
            rdbInativo.Checked = false; ;
           
            rdbMasc.Checked = false;
            rdbFem.Checked = false;
            txtData.Clear();
            txtEmail.Clear();
            txtEspecialidade.Clear();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Tela_Controle_Advogado tela_controle_advogado = new Tela_Controle_Advogado();
            tela_controle_advogado.Show();
            this.Close();
        }

        private void rdbMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tela_Cadastro_Advogado_2_Load(object sender, EventArgs e)
        {
            /*txtCodigo.Text = DadosAdvogado.AdvogadoID;
            txtNome.Text = DadosAdvogado.Nome;
            txtRG.Text = DadosAdvogado.Rg;
            txtCPF.Text = DadosAdvogado.Cpf;
            txtEmail.Text = DadosAdvogado.Email;
            txtEndereco.Text = DadosAdvogado.Endereco;
            txtNumero.Text = DadosAdvogado.Numero;
            txtTelefone.Text = DadosAdvogado.Telefone;
            txtCelular.Text = DadosAdvogado.Celular;
            txtEspecialidade.Text = DadosAdvogado.Especialidade;
            txtOAB.Text = DadosAdvogado.Registro;
            txtData.Text = DadosAdvogado.DataEmissao;
            txtStatus.Text = DadosAdvogado.Status;
            */
            if (status.Equals("Ativo"))
            {
                rdbAtivo.Checked = true;
            }
            else if (status.Equals("Inativo"))
            {
                rdbInativo.Checked = true;
            }


            if (sexo.Equals("Masculino"))
            {
                rdbMasc.Checked = true;
            }
            else if (sexo.Equals("Feminino"))
            {
                rdbFem.Checked = true;
            }/*
            txtLogin.Text = DadosAdvogado.Login;
            txtSenha.Text = DadosAdvogado.Senha;*/
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAtivo.Checked)
            {
                status = "Ativo";
                rdbInativo.Checked = false;
            }
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInativo.Checked)
            {
                status = "Inativo";
                rdbAtivo.Checked = false;
            }
        }

        private void btnConcluido_Click(object sender, EventArgs e)
        {
            advogado advogado = new advogado(txtNome.Text, txtRG.Text, txtCPF.Text, sexo, txtEmail.Text, txtEndereco.Text,
                   txtBairro.Text, cmbEstado.Text, txtCep.Text, txtCidade.Text,
                   txtNumero.Text, txtTelefone.Text, txtCelular.Text, txtEspecialidade.Text, txtOAB.Text, txtData.Text, status);
            advogadoBD advogadoBD = new advogadoBD();
            advogadoBD.alterarAdvogado(advogado, int.Parse(codigo));
            MessageBox.Show("Cadastro do advogado : " + txtNome.Text + " alterado com sucesso");
            //
            Tela_Controle_Advogado controleadvogado = new Tela_Controle_Advogado();
            controleadvogado.ShowDialog();
            this.Close();
        }

        private void rdbMasc_CheckedChanged_1(object sender, EventArgs e)
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
