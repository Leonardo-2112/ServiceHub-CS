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
    public partial class FrmServico : Form
    {
        public FrmServico()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void HabilitaControle()
        {
            btnAdd.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void DesabilitaControle()
        {
            btnAdd.Enabled = false;
            btnEditar.Enabled = false;
            
        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            double preco = double.Parse(txtPreco.Text);//Conversão de decimal para double

            var cmd = Banco.Abrir();//Abre conexão com o bando de dados, retornando um objeto do tipo SqlCommand
            cmd.CommandText = $"insert servicos (nome, descricao, preco) values('{nome}', '{nome}', {preco})";//insert no banco de dados utilizando a variavel,
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
            DesabilitaControle();
            if (btnPesquisar.Text == "&Pesquisar")
            {
                txtID.ReadOnly = false;
                txtNome.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                txtPreco.ReadOnly = true;
                checkBox1.Enabled = false;
                txtID.Focus();
                btnPesquisar.Text = "Buscar";
            }
            else if (btnPesquisar.Text == "Buscar")
            {
                //busca no banco de dados
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from servicos where id = {txtID.Text}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr.GetString(1);
                    txtDescricao.Text = dr.GetString(2);
                    txtPreco.Text = dr.GetDecimal(3).ToString();
                    checkBox1.Checked = dr.GetBoolean(4);
                }
                btnPesquisar.Text = "&Pesquisar";
                txtID.ReadOnly = true;

                btnEditar.Enabled = true;
                btnPesquisar.Enabled = false;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "&Editar")
            {
                txtNome.ReadOnly = false;
                txtDescricao.ReadOnly = false;
                txtPreco.ReadOnly = false;
                checkBox1.Enabled = true;
                btnEditar.Text = "Salvar";
                txtNome.Focus();
            }
            else
            {
                var cmd = Banco.Abrir();

                int id = int.Parse(txtID.Text);
                string nome = txtNome.Text;
                string descricao = txtDescricao.Text;
                double preco = double.Parse(txtPreco.Text);//Conversão de decimal para double
                bool descontinuado = checkBox1.Checked;
                cmd.CommandText = $"update servicos set nome = '{nome}', descricao = '{descricao}', preco = {preco}, descontinuado = {descontinuado} where id = {id}";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    btnEditar.Text = "$Editar";
                    txtNome.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    txtPreco.ReadOnly = true;
                    checkBox1.Enabled = false;

                }
                HabilitaControle();
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
            HabilitaControle();
            
        }
    }
}
