using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
           
        }

       
        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MenuFuncionários_Click(object sender, EventArgs e)
        {
            cadastro.FrmFuncionario frm = new cadastro.FrmFuncionario();
            frm.ShowDialog();
        }

        private void MenuCargos_Click(object sender, EventArgs e)
        {
            cadastro.FrmCargo frm = new cadastro.FrmCargo();
            frm.ShowDialog();
        }

       
    }
}
