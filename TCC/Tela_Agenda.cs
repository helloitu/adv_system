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
    public partial class Tela_Agenda : Form
    {
        public string data = "";
        public string codigo = "";
        public string nome = "";
        public Tela_Agenda()
        {
            InitializeComponent();
        }
        public void carregaDataGrid()
        {
            agendaBD agendaBD = new agendaBD();
            dataGridView1.DataSource = agendaBD.getAgenda();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_menu = new Tela_Menu();
            tela_menu.Show();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
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

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Campo obrigatório em branco");
                return;
            }
            try
            {
                agendaBD agendaBD = new agendaBD();
                agenda agenda = new agenda(txtNome.Text,txtData.Text,txtHorario.Text,txtSituacao.Text,
                    txtAssunto.Text,txtTelefone.Text, txtCelular.Text);
                agendaBD.IncluirAgenda(agenda);
                MessageBox.Show("Horario marcado com sucesso");
                carregaDataGrid();
                btnLimpar.PerformClick();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtData.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtHorario.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSituacao.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAssunto.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTelefone.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtCelular.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            btnCancelar.Visible = true;
            txtNome.Enabled = false;
            txtData.Enabled = false;
            txtHorario.Enabled = false;
            txtSituacao.Enabled = false;
            txtAssunto.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            btnAlterar.Visible = true;
            btnMarcar.Visible = false;
            btnLimpar.Visible = false;
        }

        private void Tela_Agenda_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtData.Enabled = true;
            txtHorario.Enabled = true;
            txtSituacao.Enabled = true;
            txtAssunto.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            btnConfirma.Visible = true;
            btnAlterar.Visible = false;
            btnCancelar.Visible = false;
            /*agenda agenda = new agenda(txtNome.Text, txtData.Text, txtHorario.Text, txtSituacao.Text,
                    txtAssunto.Text, txtTelefone.Text, txtCelular.Text);
            agendaBD agendaBD = new agendaBD();
            agendaBD.alterarAgenda(agenda, int.Parse(codigo));
            MessageBox.Show("Horario da(o) cliente : " + txtNome.Text + " alterado com sucesso");
            btnAlterar.Visible = false;
            btnMarcar.Visible = true;
            btnLimpar.Visible =true;
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
            btnLimpar.PerformClick();*/
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtHorario.Clear();
            txtSituacao.Clear();
            txtAssunto.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtData.Clear();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            agenda agenda = new agenda(txtNome.Text, txtData.Text, txtHorario.Text, txtSituacao.Text,
            txtAssunto.Text, txtTelefone.Text, txtCelular.Text);
            agendaBD agendaBD = new agendaBD();
            agendaBD.alterarAgenda(agenda, int.Parse(codigo));
            MessageBox.Show("Horario do cliente : " + txtNome.Text + " alterado com sucesso");
            btnAlterar.Visible = false;
            btnMarcar.Visible = true;
            btnLimpar.Visible = true;
            dataGridView1.AutoGenerateColumns = false;
            carregaDataGrid();
            btnLimpar.PerformClick();
            btnConfirma.Visible = false;
            btnAlterar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtData.Enabled = true;
            txtHorario.Enabled = true;
            txtSituacao.Enabled = true;
            txtAssunto.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtNome.Clear();
            txtHorario.Clear();
            txtSituacao.Clear();
            txtAssunto.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtData.Clear();
            btnCancelar.Visible = false;
            btnAlterar.Visible = false;
            btnConfirma.Visible = false;
            btnMarcar.Visible = true;
            btnLimpar.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nome = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            btnExcluir.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir o horário do cliente " + txtNome.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agendaBD agendaBD = new agendaBD();
                agendaBD.excluirAgenda(int.Parse(codigo));
                MessageBox.Show("Horário do cliente : " + txtNome.Text + " excluído com sucesso");
                txtNome.Clear();
                txtHorario.Clear();
                txtSituacao.Clear();
                txtAssunto.Clear();
                txtTelefone.Clear();
                txtCelular.Clear();
                txtData.Clear();
                txtNome.Enabled = true;
                txtData.Enabled = true;
                txtHorario.Enabled = true;
                txtSituacao.Enabled = true;
                txtAssunto.Enabled = true;
                txtTelefone.Enabled = true;
                txtCelular.Enabled = true;
                btnExcluir.Visible = false;
                dataGridView1.AutoGenerateColumns = false;
                carregaDataGrid();
                btnLimpar.PerformClick();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
