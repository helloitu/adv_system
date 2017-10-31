using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
//api
using System.Net;
using System.IO;    

namespace TCC
{
    public partial class Tela_Splash : Form
    {
        public Tela_Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                    try
                    {
                        var requisicao = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:8000/api/hellou");

                        var resposta = (HttpWebResponse)requisicao.GetResponse();

                        var responseCheckin = new StreamReader(resposta.GetResponseStream()).ReadToEnd();

                        if (progressBar2.Value < 100)
                        {
                            progressBar2.Value = progressBar2.Value + 2;
                        }

                        else
                        {
                            timer1.Enabled = false;
                            this.Visible = false;
                            Tela_Login tela_login = new Tela_Login();
                            tela_login.Show();
                        }
                    }
                    catch
                    {
                            Application.Exit();
                        

                    }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
