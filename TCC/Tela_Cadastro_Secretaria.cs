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
            if (txtNome.Text.Equals("") || txtRG.Text.Equals("") || txtCPF.Text.Equals("") || txtLogin.Text.Equals("") || txtSenha.Text.Equals("") || txtEndereco.Text.Equals("") || cmbEstado.SelectedItem.ToString().Equals("") || txtCelular.Text.Equals("") || txtCidade.Text.Equals("") || txtNumero.Text.Equals(""))
            {
                MessageBox.Show("Campos obrigatórios em branco");
                return;
            }
            else
            {
                try
                {
                    //inicia checkin de login
                    var request3 = (HttpWebRequest)WebRequest.Create("http://localhost:8000/api/consulta/login");
                    var postCheckinUsu = "usu_login=" + txtLogin.Text;
                    var data3 = Encoding.ASCII.GetBytes(postCheckinUsu);
                    request3.Method = "POST";
                    request3.ContentType = "application/x-www-form-urlencoded";
                    request3.ContentLength = data3.Length;
                    using (var stream3 = request3.GetRequestStream())
                    {
                        stream3.Write(data3, 0, data3.Length);
                    }
                    var response3 = (HttpWebResponse)request3.GetResponse();
                    var responseString3 = new System.IO.StreamReader(response3.GetResponseStream()).ReadToEnd();
                    dynamic stuffCheckinLogin = JsonConvert.DeserializeObject(responseString3);
                    bool statusCheckinLogin = stuffCheckinLogin.status;
                    if (statusCheckinLogin == true)
                    {
                        //inicia cadastro de login na tabela usuario
                        var request2 = (HttpWebRequest)WebRequest.Create("http://localhost:8000/api/registro/usuario");
                        var postDataUsu = "usu_nome=" + txtNome.Text;
                        postDataUsu += "&usu_funcao= Secretaria(o)";
                        postDataUsu += "&usu_login=" + txtLogin.Text;
                        postDataUsu += "&usu_senha=" + txtSenha.Text;
                        var data2 = Encoding.ASCII.GetBytes(postDataUsu);
                        request2.Method = "POST";
                        request2.ContentType = "application/x-www-form-urlencoded";
                        request2.ContentLength = data2.Length;
                        using (var stream2 = request2.GetRequestStream())
                        {
                            stream2.Write(data2, 0, data2.Length);
                        }
                        var response2 = (HttpWebResponse)request2.GetResponse();
                        var responseString2 = new System.IO.StreamReader(response2.GetResponseStream()).ReadToEnd();
                        //inicia cadastro do secretario em si
                        var request = (HttpWebRequest)WebRequest.Create("http://localhost:8000/api/registro/secretaria");
                        var postData = "sec_nome=" + txtNome.Text;
                        postData += "&sec_rg=" + txtRG.Text;
                        postData += "&sec_cpf=" + txtCPF.Text;
                        postData += "&sec_sexo=" + sexo;
                        postData += "&sec_endereco=" + txtEndereco.Text;
                        postData += "&sec_bairro=" + txtBairro.Text;
                        postData += "&sec_estado=" + cmbEstado.SelectedItem.ToString();
                        postData += "&sec_cep=" + txtCep.Text;
                        postData += "&sec_cidade=" + txtCidade.Text;
                        postData += "&sec_numero=" + txtNumero.Text;
                        postData += "&sec_telefone=" + txtTelefone.Text;
                        postData += "&sec_celular=" + txtCelular.Text;
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
                        bool statusCadSec = stuff.status;
                        string msgSec = stuff.message;
                        //if de login usando as responses do json
                        if (statusCadSec == false)
                        {
                            MessageBox.Show(msgSec);
                        }
                        else if (statusCadSec == true)
                        {
                            MessageBox.Show(msgSec);
                            btnLimpar.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario: " + txtLogin.Text + " Já existe, favor tentar novamente");
                        txtLogin.Clear();
                    }

                    /*
                     * codigo do bd original(que funciona)
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
                    */

                }

                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void Tela_Cadastro_Secretaria_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }
    }
}
