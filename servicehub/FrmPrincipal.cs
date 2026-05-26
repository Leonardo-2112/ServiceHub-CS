namespace servicehub
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criar uma instância do formulário Listar Clientes
            FrmListaClientes listaClientes = new FrmListaClientes();

            //Associando o form listar Clientes como filho do principal
            listaClientes.MdiParent = this;

            //Chamar o form de Clientes
            listaClientes.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoCliente novoCliente = new FrmNovoCliente();
            novoCliente.MdiParent = this;
            novoCliente.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListaServicos listaServico = new FrmListaServicos();
            listaServico.MdiParent = this;
            listaServico.Show();
        }
    }
}
