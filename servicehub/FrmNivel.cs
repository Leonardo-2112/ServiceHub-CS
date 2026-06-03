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
                MessageBox.Show($"Categoria {nivel.Id} inserida com sucesso!");
                CarregaGrid();
            }
        }
    }
}
