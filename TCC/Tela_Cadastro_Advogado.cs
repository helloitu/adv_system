using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class Tela_Cadastro_Advogado : Form
    {
        public string sexo = "";
        public string status = "";
        public string funcao = "";
        public Tela_Cadastro_Advogado()
        {
            InitializeComponent();
            advogadoBD advogadoBD = new advogadoBD();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCidade.Clear();
            txtCep.Clear();
            txtBairro.Clear();
            cmbEstado.SelectedText = "";
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
            txtLogin.Clear();
            txtSenha.Clear();
            rdbMasc.Checked = false;
            rdbFem.Checked = false;
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
            txtData.Clear();
            txtEmail.Clear();
            txtEspecialidade.Clear();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Tela_Cadastro_Advogado_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtRG.Text.Equals("") || txtCPF.Text.Equals("") || txtEndereco.Text.Equals("") || cmbEstado.SelectedItem.ToString().Equals("") || txtCelular.Text.Equals("") || txtCidade.Text.Equals("") || txtNumero.Text.Equals("") )
            {
                MessageBox.Show("Campos obrigatórios em branco");
                return;
            }
            try
            {
                //inicia checkin de login
                var request3 = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:8000/api/consulta/login");
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
                    var request2 = (HttpWebRequest)WebRequest.Create("http://192.168.0.115:8000/api/registro/usuario");
                    var postDataUsu = "usu_nome=" + txtNome.Text;
                    postDataUsu += "&usu_funcao=Advogado";
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
                    //inicia cadastro do advogado em si
                    var request = (HttpWebRequest)WebRequest.Create("http://192.168.0.115:8000/api/registro/adv");
                    var postData = "adv_nome=" + txtNome.Text;
                    postData += "&adv_rg=" + txtRG.Text;
                    postData += "&adv_cpf=" + txtCPF.Text;
                    postData += "&adv_sexo=" + sexo;
                    postData += "&adv_email=" + txtEmail.Text;
                    postData += "&adv_endereco=" + txtEndereco.Text;
                    postData += "&adv_bairro=" + txtBairro.Text;
                    postData += "&adv_estado=" + cmbEstado.SelectedItem.ToString();
                    postData += "&adv_cep=" + txtCep.Text;
                    postData += "&adv_cidade=" + txtCidade.Text;
                    postData += "&adv_numero=" + txtNumero.Text;
                    postData += "&adv_telefone=" + txtTelefone.Text;
                    postData += "&adv_celular=" + txtCelular.Text;
                    postData += "&adv_especialidade=" + txtEspecialidade.Text;
                    postData += "&adv_registro=" + txtOAB.Text;
                    postData += "&adv_data_emissao=" + txtData.Text;
                    postData += "&adv_status=" + status;
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
                    bool statusCadAdv = stuff.status;
                    string msgAdv = stuff.message;
                    //if de login usando as responses do json
                    if (statusCadAdv == false)
                    {
                        MessageBox.Show(msgAdv);
                    }
                    else if (statusCadAdv == true)
                    {
                        MessageBox.Show(msgAdv);
                        btnLimpar.PerformClick();
                    }
                }else {
                    MessageBox.Show("Usuario: " + txtLogin.Text + " Já existe, favor tentar novamente");
                    txtLogin.Clear();
                }
                //Cadastro na tabela advogado

                /*
                 * FUNCIONAAAL
                
                advogadoBD advogadoBD = new advogadoBD();
                advogado advogado = new advogado(txtNome.Text, txtRG.Text, txtCPF.Text, sexo, txtEmail.Text, txtEndereco.Text,
                    txtNumero.Text, txtTelefone.Text, txtCelular.Text, txtEspecialidade.Text, txtOAB.Text, txtData.Text, status);
                advogadoBD.IncluirAdvogado(advogado);
                usuarioBD usuarioBD = new usuarioBD();
                usuario usuario = new usuario(txtNome.Text, funcao, txtLogin.Text, txtSenha.Text);
                usuarioBD.IncluirUsuario(usuario);
                MessageBox.Show("Advogado cadastrado com sucesso");
                btnLimpar.PerformClick();
                */
            }
            catch(Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void rdbMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasc.Checked)
            {
                sexo = "Masculino";
                funcao = "Advogado";
                rdbFem.Checked = false;
            }
        }

        private void rdbFem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFem.Checked)
            {
                sexo = "Feminino";
                funcao = "Advogada";
                rdbMasc.Checked = false;
            }
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAtivo.Checked)
            {
                if (rdbMasc.Checked)
                {
                    status = "Ativo";
                }
                if (rdbFem.Checked)
                {
                    status = "Ativa";
                }
            }
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInativo.Checked)
            {
                if (rdbMasc.Checked)
                {
                    status = "Inativo";
                }
                if (rdbFem.Checked)
                {
                    status = "Inativa";
                }
            }
        }

        private void txtData2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txtData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtEspecialidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtOAB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }
    }
}
