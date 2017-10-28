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
    public partial class Tela_Escolhe_Advogado : Form
    {
        public Tela_Escolhe_Advogado()
        {
            InitializeComponent();
        }
        public void carregaDataGrid()
        {
            advogadoBD advogadoBD = new advogadoBD();
            dataGridView1.DataSource = advogadoBD.getAdvogado();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Caso Tela_Cadastro_Caso_4 = new Tela_Cadastro_Caso();
            Tela_Cadastro_Caso_4.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Caso Tela_Cadastro_Caso_4 = new Tela_Cadastro_Caso();
            Tela_Cadastro_Caso_4.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Tela_Cadastro_Caso_4 Tela_Cadastro_Caso4 = new Tela_Cadastro_Caso_4();
            Tela_Cadastro_Caso4.codigoadv = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Tela_Cadastro_Caso4.txtNomeAdvogado.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();*/
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            
        }

        private void Tela_Escolhe_Advogado_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Tela_Cadastro_Caso Tela_Cadastro_Caso_4 = new Tela_Cadastro_Caso();
            //Tela_Cadastro_Caso_4.codigoadv = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Tela_Cadastro_Caso_4.txtNomeAdvogado.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DadosCaso.Advogado = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Tela_Cadastro_Caso_4.Show();
            this.Close();

        }
    }
}
