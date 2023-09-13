using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);

            txtNome.Clear();
            txtCurso.Clear();

            MessageBox.Show("Aluno incluido com sucesso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }
    }
}
