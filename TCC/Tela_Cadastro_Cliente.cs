using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
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
            txtCep.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
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
            else {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:8000/api/registro/cliente");
                var postData = "cli_nome=" + txtNome.Text;
                postData += "&cli_rg=" + txtRG.Text;
                postData += "&cli_cpf=" + txtCPF.Text;
                postData += "&cli_sexo=" + sexo;
                postData += "&cli_email=" + txtEmail.Text;
                postData += "&cli_endereco=" + txtEndereco.Text;
                postData += "&cli_bairro=" + txtBairro.Text;
                postData += "&cli_estado=" + cmbEstado.SelectedItem.ToString();
                postData += "&cli_cep=" + txtCep.Text;
                postData += "&cli_cidade=" + txtCidade.Text;
                postData += "&cli_numero=" + txtNumero.Text;
                postData += "&cli_data_nascimento=" + txtDataNascimento;
                postData += "&cli_telefone=" + txtTelefone.Text;
                postData += "&cli_celular=" + txtCelular.Text;
                var data = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                //pega a response do server e converte em object
                var response = (HttpWebResponse)request.GetResponse();
                //converte o object pra string
                var responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();
                //descerializa o json adquirido e pica as responses
                dynamic stuff = JsonConvert.DeserializeObject(responseString);
                //armazena as responses
                bool statusCadCli = stuff.status;
                string msgCli = stuff.message;
                //if de login usando as responses do json
                if (statusCadCli == false)
                {
                    MessageBox.Show(msgCli);
                }
                else if (statusCadCli == true)
                {
                    MessageBox.Show(msgCli);
                    btnLimpar.PerformClick();
                }

            }

        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbMasculino.Checked)
            {
                txtSexo.Text = "Masculino";
                rdbFeminino.Checked = false;
            }

        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFeminino.Checked)
            {
                txtSexo.Text = "Feminino";
                rdbMasculino.Checked = false;
            }
        }
    }
}
