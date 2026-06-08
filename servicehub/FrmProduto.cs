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
    public partial class FrmProduto : Form
    {
        private int produtoSelecionadoId = 0;
        private bool editando = false;
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CarregarProdutos(string busca = "")
        {
            dgvProduto.AutoGenerateColumns = true;
            dgvProduto.DataSource = null;
            dgvProduto.DataSource = Produto.ObterLista(busca);
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Categoria.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";


            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduto.MultiSelect = false;
            dgvProduto.ReadOnly = true;
            dgvProduto.AutoGenerateColumns = true;

            CarregarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(txtCodBarras.Text,
                txtDescricao.Text,
                (double)nudValorUnit.Value,
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)nudEstoqueMinimo.Value,
                (double)nudClasseDesconto.Value);
            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto {produto.Descricao} gravado com sucesso");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {

                Produto produto = Produto.ObterPorId(produtoSelecionadoId);

                txtId.Text = produto.Id.ToString();
                txtCodBarras.Text = produto.CodBarras;
                txtDescricao.Text = produto.Descricao;
                nudValorUnit.Value = Convert.ToDecimal(produto.ValorUnit);
                txtUnidadeVenda.Text = produto.UnidadeVenda;
                cmbCategoria.SelectedValue = produto.Categoria.Id;
                nudEstoqueMinimo.Value = Convert.ToDecimal(produto.EstoqueMinimo);
                nudClasseDesconto.Value = Convert.ToDecimal(produto.ClasseDesconto);
                if (produto.Categoria != null)
                {
                    cmbCategoria.SelectedValue = produto.Categoria.Id;
                }

                editando = true;
                btnEditar.Text = "Salvar";

                txtCodBarras.Focus();
            }
            else
            {

                Produto produto = new Produto(
                    Convert.ToInt32(txtId.Text),
                    txtCodBarras.Text,
                    txtDescricao.Text,
                    Convert.ToDouble(nudValorUnit.Value),
                    txtUnidadeVenda.Text,
                    Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                    Convert.ToInt32(nudEstoqueMinimo.Value),
                    Convert.ToInt32(nudClasseDesconto.Value)
                );

                if (produto.Atualizar())
                {
                    MessageBox.Show("Usuário atualizado com sucesso!");

                    CarregarProdutos();
                }
                else
                {
                    MessageBox.Show("Nenhum usuário foi atualizado.");
                }
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Produto produto = dgvProduto.Rows[e.RowIndex].DataBoundItem as Produto;

            if (produto == null)
            {
                return;
            }

            produtoSelecionadoId = produto.Id;
            txtId.Text = produto.Id.ToString();
            txtCodBarras.Text = produto.CodBarras;
            txtDescricao.Text = produto.Descricao;
            nudValorUnit.Value = Convert.ToDecimal(produto.ValorUnit);
            txtUnidadeVenda.Text = produto.UnidadeVenda;
            cmbCategoria.SelectedValue = produto.Categoria.Id;
            nudEstoqueMinimo.Value = Convert.ToDecimal(produto.EstoqueMinimo);
            nudClasseDesconto.Value = Convert.ToDecimal(produto.ClasseDesconto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string busca = txtCodBarras.Text;

            CarregarProdutos(busca);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este produto?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
);

            if (resposta == DialogResult.Yes)
            {
                if (Produto.Excluir(produtoSelecionadoId))
                {
                    MessageBox.Show("Usuário excluído com sucesso!");

                    CarregarProdutos();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o usuário.");
                }
            }
        }
    }

}
