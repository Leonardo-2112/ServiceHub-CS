using ServiceHubClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicehub
{
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }
        private void CarregaGrid(string texto = "")
        {
            dgvNiveis.Rows.Clear();
            List<Nivel> niveis = Nivel.ObterLista(texto);//Atribui no objeto categorias todas as categorias que foram retornadas do método ObterLista
            foreach (var nivel in niveis)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[dgvNiveis.Rows.Count - 1].Cells[0].Value = nivel.Id;
                dgvNiveis.Rows[dgvNiveis.Rows.Count - 1].Cells[1].Value = nivel.Nome;
                dgvNiveis.Rows[dgvNiveis.Rows.Count - 1].Cells[2].Value = nivel.Sigla;
            }
        }

        private void FrmNivel_Load(object sender, EventArgs e)
        {
            CarregaGrid();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNome.Text, txtSigla.Text);
            nivel.Inserir();
            if (nivel.Id > 0)
            {
                MessageBox.Show($"NIvel {nivel.Id} inserido com sucesso!");
                CarregaGrid();
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(int.Parse(txtID.Text), txtNome.Text, txtSigla.Text);
            if (nivel.Atualizar())
            {
                txtID.Clear();
                txtNome.Clear();
                txtSigla.Clear();
                CarregaGrid();
                MessageBox.Show($"Nivel {nivel.Id}- {nivel.Nome} alterado com sucesso! \nLista Atualizada");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                var resposta = MessageBox.Show($"Deseja excluir o Nivel {txtID.Text}- {txtNome.Text}",
                    $" Exclusão de Nivel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    );
                if (resposta == DialogResult.Yes)
                {
                    Nivel nivel = new(int.Parse(txtID.Text));
                    nivel.Excluir();
                    CarregaGrid();
                }

            }
        }

        private void dgvNiveis_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvNiveis.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvNiveis.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSigla.Text = dgvNiveis.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
