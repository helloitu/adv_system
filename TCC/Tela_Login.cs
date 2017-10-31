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
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //realizando autenticação com API
            var request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:8000/api/login");
            var postData = "login=" + txtUsuario.Text;
            postData += "&senha=" + txtSenha.Text;
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
            bool statusLogin = stuff.status;
            string msgLogin = stuff.message;
            //if de login usando as responses do json
            if (statusLogin == false)
            {
                MessageBox.Show(msgLogin);
            }
            else if (statusLogin == true)
            {
                MessageBox.Show(msgLogin);
                Tela_Menu tela_menu = new Tela_Menu();
                tela_menu.Show();
                this.Close();

            }

            /* 
             * LOGIN COM BD
            usuarioBD usuarioBD = new usuarioBD();
            usuario usuario = usuarioBD.selecionaUser(txtUsuario.Text,txtSenha.Text);

            if (String.IsNullOrEmpty(usuario.Nome))
            {
                MessageBox.Show("Usuária(o) inválida(o)");
            }
            else
            {
                Tela_Menu tela_menu = new Tela_Menu();
                tela_menu.Show();
                this.Close();
            }    
            */
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do ADVSYS ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
