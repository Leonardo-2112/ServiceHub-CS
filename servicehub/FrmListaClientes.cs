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
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Rows.Add();
            dgvClientes.Rows[0].Cells[0].Value = 1;
            dgvClientes.Rows[0].Cells[1].Value = 122345;
            dgvClientes.Rows[0].Cells[2].Value = "Leonardo";
            dgvClientes.Rows[0].Cells[3].Value = 12345678901;
            dgvClientes.Rows[0].Cells[4].Value = "leonardo@gmail.com";
            dgvClientes.Rows[0].Cells[5].Value = "1198765432";
            dgvClientes.Rows[0].Cells[6].Value = true;

            dgvClientes.Rows.Add();
            dgvClientes.Rows[1].Cells[0].Value = 2;
            dgvClientes.Rows[1].Cells[1].Value = 6767778;
            dgvClientes.Rows[1].Cells[2].Value = "Claúdia";
            dgvClientes.Rows[1].Cells[3].Value = 78565635434;
            dgvClientes.Rows[1].Cells[4].Value = "Claudia@gmail.com";
            dgvClientes.Rows[1].Cells[5].Value = "1192234555";
            dgvClientes.Rows[1].Cells[6].Value = true;

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show(id);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
