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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        private void CarregaGrid(string texto = "")
        {
            dgvCategorias.Rows.Clear();
            List<Categoria> categorias = Categoria.ObterLista(texto);//Atribui no objeto categorias todas as categorias que foram retornadas do método ObterLista
            foreach (var categoria in categorias)
            {
                dgvCategorias.Rows.Add();
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[0].Value = categoria.Id;
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[1].Value = categoria.Nome;
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells[2].Value = categoria.Sigla;
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(txtNome.Text, txtSigla.Text);
            categoria.Inserir();
            if (categoria.Id > 0)
            {
                MessageBox.Show($"Categoria {categoria.Id} inserida com sucesso!");
                CarregaGrid();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 1)
            {
                CarregaGrid(txtBuscar.Text);
            }
        }




        private void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria(int.Parse(txtID.Text), txtNome.Text, txtSigla.Text);
            if (cat.Atualizar())
            {
                txtID.Clear();
                txtNome.Clear();
                txtSigla.Clear();
                CarregaGrid();
                MessageBox.Show($"Categoria {cat.Id} alterada com sucesso! \n Lista Atualizada");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                var resposta = MessageBox.Show($"Deseja excluir a categoria {txtID.Text}- {txtNome.Text}",
                    $" Exclusão de Categoria",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    );
                if (resposta == DialogResult.Yes)
                {
                    Categoria cat = new(int.Parse(txtID.Text));
                    cat.Excluir();
                    CarregaGrid();
                }

            }
        }

        private void dgvCategorias_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCategorias.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSigla.Text = dgvCategorias.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                txtID.Text = dgvCategorias.CurrentRow.Cells[0].Value?.ToString() ?? "";
                txtNome.Text = dgvCategorias.CurrentRow.Cells[1].Value?.ToString() ?? "";
                txtSigla.Text = dgvCategorias.CurrentRow.Cells[2].Value?.ToString() ?? "";
            }
        }
    }
}
