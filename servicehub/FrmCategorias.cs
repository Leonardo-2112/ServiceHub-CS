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
        private void CarregaGrid()
        {
            dgvCategorias.Rows.Clear();
            List<Categoria> categorias = Categoria.ObterLista();//Atribui no objeto categorias todas as categorias que foram retornadas do método ObterLista
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
            if(categoria.Id > 0)
            {
                MessageBox.Show($"Categoria {categoria.Id} inserida com sucesso!");
                CarregaGrid();
            }
        }
    }
}
