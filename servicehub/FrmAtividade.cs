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
    public partial class FrmAtividade : Form
    {
        public FrmAtividade()
        {
            InitializeComponent();
        }
        private void FrmAtividade_Load(object sender, EventArgs e)
        {
            txtDataCad.ReadOnly = true;
            txtDataNasc.ReadOnly = true;
            checkBox1.Enabled = false;
            txtNome.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string cpf = txtCpf.Text;
            bool descontinuado = checkBox1.Checked;




            var cmd = Banco.Abrir();//Abre conexão com o bando de dados, retornando um objeto do tipo SqlCommand
            cmd.CommandText = $"insert clientes (nome, email, telefone, cpf) values('{nome}', '{email}', {telefone}, '{cpf}')";//insert no banco de dados utilizando a variavel,
                                                                                                                                                       //cujo o valor é o que veio do formulário
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.CommandText = "select last_insert_id()";
                txtID.Text = cmd.ExecuteScalar().ToString();
                btnAdd.Enabled = false;
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (btnPesquisar.Text == "&Pesquisar")
            {
                txtID.ReadOnly = false;
                txtNome.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtDataCad.ReadOnly = true;
                txtDataNasc.ReadOnly = true;
                checkBox1.Enabled = false;
                txtID.Focus();
                btnPesquisar.Text = "Buscar";
                btnAdd.Enabled = false;
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
            }
            else if (btnPesquisar.Text == "Buscar")
            {
                //busca no banco de dados
                var cmd = Banco.Abrir();
                int id = int.Parse(txtID.Text);
                cmd.CommandText = $"select * from clientes where id = {id}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr.GetString(1);
                    txtEmail.Text = dr.GetString(2);
                    txtCpf.Text = dr.GetString(3);
                    txtTelefone.Text = dr.GetString(4);
                    txtDataCad.Text = dr.GetString(5);
                    txtDataNasc.Text = dr.GetString(6);
                    checkBox1.Checked = dr.GetBoolean(7);
                }
                //while (dr.Read())
                //{
                //    dgvCliente.Rows.Add();
                //    int linha = dgvCliente.RowCount - 1;
                //    dgvCliente.Rows[linha].Cells[0].Value = dr.GetInt32(0);
                //    dgvCliente.Rows[linha].Cells[1].Value = dr.GetString(1);
                //    dgvCliente.Rows[linha].Cells[2].Value = dr.GetString(2);
                //    dgvCliente.Rows[linha].Cells[3].Value = dr.GetString(3);
                //    dgvCliente.Rows[linha].Cells[4].Value = dr.GetString(4);
                //    dgvCliente.Rows[linha].Cells[5].Value = dr.GetString(5);
                //    dgvCliente.Rows[linha].Cells[6].Value = dr.GetString(6);
                //    dgvCliente.Rows[linha].Cells[7].Value = dr.GetBoolean(7);

                //}
                btnPesquisar.Text = "&Pesquisar";
                txtID.ReadOnly = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;               
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "&Editar")
            {
                txtID.ReadOnly = true;
                txtNome.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtCpf.ReadOnly = false;
                txtTelefone.ReadOnly = false;
                txtDataCad.ReadOnly = true;
                txtDataNasc.ReadOnly = false;
                checkBox1.Enabled = true;
                btnEditar.Text = "Salvar";
                txtNome.Focus();

            }
            else
            {
                var cmd = Banco.Abrir();

                int id = int.Parse(txtID.Text);
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string cpf = txtCpf.Text;
                string dataNasc = txtDataNasc.Text;
                bool descontinuado = checkBox1.Checked;
                cmd.CommandText = $"update servicos set nome = '{nome}', email = '{email}', telefone = '{telefone}', data_nasc = '{dataNasc}', descontinuado = {descontinuado} where id = {id}";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    btnEditar.Text = "$Editar";
                    txtNome.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtCpf.ReadOnly = true;
                    txtTelefone.ReadOnly = true;
                    txtDataNasc.ReadOnly = true;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cmd = Banco.Abrir();
            int id = int.Parse(txtID.Text);
            cmd.CommandText = $"delete from servicos where id = {id}";
            if (cmd.ExecuteNonQuery() > 0)
            {
                btnExcluir.Enabled = false;
            }

        }
    }
}
