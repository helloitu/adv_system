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
    public partial class Tela_Menu : Form
    {
        public Tela_Menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblData.Text = DateTime.Now.ToShortDateString();
            //lblHorario2.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Cliente tela_cadastro_cliente = new Tela_Cadastro_Cliente();
            tela_cadastro_cliente.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Cliente tela_cadastro_cliente = new Tela_Cadastro_Cliente();
            tela_cadastro_cliente.Show();
            this.Close();
        }

        private void exToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tela_Agenda tela_agenda = new Tela_Agenda();
            tela_agenda.Show();
            this.Close();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Advogado tela_cadastro_advogado = new Tela_Cadastro_Advogado();
            tela_cadastro_advogado.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do ADVSYS ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Advogado tela_cadastro_advogado = new Tela_Cadastro_Advogado();
            tela_cadastro_advogado.Show();
            this.Close();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Secretaria tela_cadastro_secretaria = new Tela_Cadastro_Secretaria();
            tela_cadastro_secretaria.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Caso tela_cadastro_caso = new Tela_Cadastro_Caso();
            tela_cadastro_caso.Show();
            this.Close();
        }

        private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Caso tela_cadastro_caso = new Tela_Cadastro_Caso();
            tela_cadastro_caso.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja sair do ADVSYS ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void stripClienteControle_Click(object sender, EventArgs e)
        {
            Tela_Controle_Cliente tela_cliente = new Tela_Controle_Cliente();
            tela_cliente.Show();
            this.Close();
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Agenda tela_agenda = new Tela_Agenda();
            tela_agenda.Show();
            this.Close();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Controle_Advogado tela_cntro_advogado = new Tela_Controle_Advogado();
            tela_cntro_advogado.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_Controle_Advogado tela_cntro_advogado = new Tela_Controle_Advogado();
            tela_cntro_advogado.Show();
            this.Close();
        }

        private void btnControleCliente_Click(object sender, EventArgs e)
        {
            Tela_Controle_Cliente tela_cliente = new Tela_Controle_Cliente();
            tela_cliente.Show();
            this.Close();
        }

        private void btnControleCasos_Click(object sender, EventArgs e)
        {
            Tela_Controle_Caso tela_controle_caso = new Tela_Controle_Caso();
            tela_controle_caso.Show();
            this.Close();
        }

        private void alterarExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Controle_Caso tela_controle_caso = new Tela_Controle_Caso();
            tela_controle_caso.Show();
            this.Close();
        }

        private void controleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Controle_Secretaria tela_controle_secretaria = new Tela_Controle_Secretaria();
            tela_controle_secretaria.Show();
            this.Close();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void controleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_Controle_Usuario Tela_Controle_Usuario = new Tela_Controle_Usuario();
            Tela_Controle_Usuario.Show();
            this.Close();
        }

        private void exToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
