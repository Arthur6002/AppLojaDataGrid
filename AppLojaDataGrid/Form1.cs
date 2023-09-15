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
        double ValorTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double Quantidade = double.Parse(txtQuantidade.Text), ValorUnitario = double.Parse(txtQuantidade.Text);

            dgvProdutos.Rows.Add(txtDescricao.Text, txtQuantidade.Text, txtValorUnitario.Text);

            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValorUnitario.Clear();

            ValorTotal += (Quantidade * ValorUnitario);

            lblValorTotal.Text = ($"R${ValorTotal.ToString()}");
        }


        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                double Quantidade = double.Parse(dgvProdutos.CurrentRow.Cells[1].Value.ToString());
                double ValorUnitario = double.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());

                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);

                ValorTotal -= (Quantidade * ValorUnitario);
                lblValorTotal.Text = ($"R${ValorTotal.ToString()}");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dgvProdutos.CurrentRow.Cells[0].Value = txtDescricao.Text;
            dgvProdutos.CurrentRow.Cells[1].Value = txtQuantidade.Text;
            dgvProdutos.CurrentRow.Cells[2].Value = txtValorUnitario.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtSelecionados.Clear();
            txtValorUnitario.Clear();
            dgvProdutos.Rows.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtSelecionados.Clear();
            txtValorUnitario.Clear();
            dgvProdutos.Rows.Clear();

            int Venda = int.Parse(lblVenda.Text) + 1;

            lblVenda.Text = Venda.ToString();

            lblValorTotal.Text = "R$0";
        }
    }
}
