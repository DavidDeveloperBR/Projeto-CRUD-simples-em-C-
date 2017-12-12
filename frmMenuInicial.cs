using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1
{
    public partial class frm_menu : Form
    {


        public frm_menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cliente FormCliente = new frm_cliente();
            FormCliente.ShowDialog();

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_fornecedores FormFornecedores = new frm_fornecedores();
            FormFornecedores.ShowDialog();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_formCliente_Click(object sender, EventArgs e)
        {
            frm_cliente FormCliente = new frm_cliente();
            FormCliente.ShowDialog();
        }

        private void btn_formFornecedor_Click(object sender, EventArgs e)
        {
            frm_fornecedores FormFornecedores = new frm_fornecedores();
            FormFornecedores.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout AboutDialog = new frmAbout();
            AboutDialog.ShowDialog();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }
    }
}