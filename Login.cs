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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            LogindeAcesso login = new LogindeAcesso();
            login.verficarLogin(txtLogin.Text, txtSenha.Text);
            if (login.existe)
            {

                this.Hide();
                MessageBox.Show("Logado com Sucesso!!!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal frm = new frmPrincipal();
                
                frm.ShowDialog();
                
                
            }

            else
            {
                MessageBox.Show("Login não encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
            }
        }
    }
}
