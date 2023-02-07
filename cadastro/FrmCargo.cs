using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDV.cadastro
{
    public partial class FrmCargo : Form
    {

        Conexao connec = new Conexao();
        string sql;        
        string id;
        MySqlCommand cmd;
        string nomeAntigo;

        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargos";
            grid.Columns[0].Width = 50;
            grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = false;


        }

        private void Listar()
        {
            connec.AbrirConexao();
            sql = "SELECT Cargo FROM cargos ORDER BY Cargo asc";
            cmd = new MySqlCommand(sql, connec.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            connec.FecharConexao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textNome.Enabled = true;
            textNome.Focus();
            btnSalvar.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o nome do ", "Cadastro ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNome.Text = "";
                textNome.Focus();
                return;
            }

            MessageBox.Show("Cadastrado com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //	cargo	
            connec.AbrirConexao();
            sql = "INSERT INTO Cargos(cargo) VALUES(@cargo)";
            cmd = new MySqlCommand(sql, connec.con);
            cmd.Parameters.AddWithValue("@cargo", textNome.Text);

            cmd.ExecuteNonQuery();
            connec.FecharConexao();


            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNome.Text = " ";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (textNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o nome do campo", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNome.Text = "";
                textNome.Focus();
                return;
            }

            connec.AbrirConexao();

            sql = "UPDATE cargos SET  cargo = @cargo  WHERE id = @id";
            cmd = new MySqlCommand(sql, connec.con);
            cmd.Parameters.AddWithValue("@id", id); //Esse é o "WHERE"
            cmd.Parameters.AddWithValue("@cargo", textNome.Text);


            if (textNome.Text != nomeAntigo)
            {
                MySqlCommand cmdVerficar;
                cmdVerficar = new MySqlCommand("SELECT * FROM Cargos WHERE cargo = @cargo", connec.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerficar;
                cmdVerficar.Parameters.AddWithValue("@cargo", textNome.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cargo " + textNome.Text + " já registrado", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textNome.Text = "";
                    textNome.Focus();
                    return;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                connec.AbrirConexao();
                sql = "DELETE FROM Cargos WHERE id = @id";
                cmd = new MySqlCommand(sql, connec.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connec.FecharConexao();

                Listar();

                MessageBox.Show("Registro " + textNome.Text + " Excluído com Sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }       

        
        private void grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                textNome.Enabled = true;


                id = grid.CurrentRow.Cells[0].Value.ToString();
                //textNome.Text = grid.CurrentRow.Cells[1].Value.ToString();


            }
        }
    }
}
