using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLojaDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Add(txtDescricao.Text, txtQuantidade.Text, txtValorUnitario.Text);

            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValorUnitario.Clear();

            lblVenda.Text = (dgvProdutos.RowCount + 1).ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.RowCount >  0)
            {
                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);

                lblVenda.Text = (dgvProdutos.RowCount + 1).ToString();
            }
        }
    }
}
