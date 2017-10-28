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
    public partial class Tela_Escolhe_Cliente : Form
    {
        public Tela_Escolhe_Cliente()
        {
            InitializeComponent();
        }
        public void carregaDataGrid()
        {
            clienteBD clienteBD = new clienteBD();
            dataGridView1.DataSource = clienteBD.getCliente();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Caso Tela_Cadastro_Caso = new Tela_Cadastro_Caso();

            Tela_Cadastro_Caso.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Caso Tela_Cadastro_Caso = new Tela_Cadastro_Caso();

            Tela_Cadastro_Caso.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tela_Cadastro_Caso Tela_Cadastro_Caso3 = new Tela_Cadastro_Caso();
            Tela_Cadastro_Caso3.codigocli = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Tela_Cadastro_Caso3.txtNomeCliente.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DadosCaso.Cliente = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); 
            Tela_Cadastro_Caso3.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tela_Escolhe_Cliente_Load(object sender, EventArgs e)
        {
            carregaDataGrid();
        }
    }
}
