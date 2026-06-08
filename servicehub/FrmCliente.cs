using MySqlX.XDevAPI;
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
    public partial class FrmCliente : Form
    {
        private int clienteSelecionadoId = 0;
        private bool editando = false;
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void CarregarClientes(string busca = "")
        {
            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Cliente.ObterLista(busca);
        }
        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCpf.Clear();
            txtDataNasc.Clear();
            txtBuscar.Clear();

            clienteSelecionadoId = 0;
            editando = false;

            btnEditar.Text = "Editar";
            txtNome.Focus();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {

            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.AutoGenerateColumns = true;

            CarregarClientes();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Cliente cliente = dgvClientes.Rows[e.RowIndex].DataBoundItem as Cliente;

            if (cliente == null)
            {
                return;
            }

            clienteSelecionadoId = cliente.Id;
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            txtEmail.Text = cliente.Email;
            txtTelefone.Text = cliente.Telefone;
            txtDataNasc.Text = cliente.DataNasc.ToString("dd/MM/yyyy");
            checkBox1.Checked = cliente.Ativo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                txtNome.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtEmail.Text,
                Convert.ToDateTime(txtDataNasc.Text)
            );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                MessageBox.Show($"Cliente {cliente.Id}- {cliente.Nome} inserido com sucesso!");
                LimparCampos();
                CarregarClientes();
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string busca = txtBuscar.Text;
            LimparCampos();
            CarregarClientes(busca);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {

                Cliente cliente = Cliente.ObterPorId(clienteSelecionadoId);

                txtId.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                txtEmail.Text = cliente.Email;
                txtTelefone.Text = cliente.Telefone;
                txtCpf.Text = cliente.Cpf;
                txtDataNasc.Text = cliente.DataNasc.ToString("dd/MM/yyyy");

                editando = true;
                btnEditar.Text = "Salvar";

                txtNome.Focus();
            }
            else
            {

                Cliente cliente = new Cliente(
                    Convert.ToInt32(txtId.Text),
                    txtNome.Text,
                    txtCpf.Text,
                    txtTelefone.Text,
                    Convert.ToDateTime(txtDataNasc.Text)
                );

                if (cliente.Atualizar())
                {
                    MessageBox.Show("Usuário atualizado com sucesso!");
                    LimparCampos();
                    CarregarClientes();
                }
                else
                {
                    MessageBox.Show("Nenhum usuário foi atualizado.");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este cliente?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                if (Cliente.Excluir(clienteSelecionadoId))
                {
                    MessageBox.Show("Cliente excluído com sucesso!");

                    LimparCampos();
                    CarregarClientes(); 
                    
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o cliente.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarClientes();
        }
    }
}
