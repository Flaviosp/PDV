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
using System.IO;

namespace PDV.cadastro
{
    public partial class FrmFuncionario : Form
    {
        Conexao connec = new Conexao();
        string sql;
        string foto;
        string id;
        string cpfCadastrado;
        MySqlCommand cmd;
        int alterouImagem = 0;


        public FrmFuncionario()
        {
            InitializeComponent();
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o nome do campo", "Cadastro do Funcioário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNome.Text = "";
                textNome.Focus();
                return;
            }

            if (textCpf.Text == "   ,   ,   -" || textCpf.Text.Length > 14)
            {
                MessageBox.Show("Preenche o CPF", "Cadatro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCpf.Focus();
                return;
            }
            MessageBox.Show("Cadastrado com Sucesso", "Cadastro de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //nome	cfp	telefone	cargo	endereco	data	foto	
            connec.AbrirConexao();
            sql = "INSERT INTO funcionarios(nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @foto)";
            cmd = new MySqlCommand(sql, connec.con);
            cmd.Parameters.AddWithValue("@nome", textNome.Text);
            cmd.Parameters.AddWithValue("@cpf", textCpf.Text);
            cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@endereco", textEndereco.Text);
            cmd.Parameters.AddWithValue("@foto", img());

            cmd.ExecuteNonQuery();
            connec.FecharConexao();

            LimparFoto();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
            Listar();


        }

        private byte[] img()
        {
            byte[] img_byte = null; //variavel para pegar comprimento da imagem
            if (foto == "")
            {
                return null;
            }
            //Usa FileStream para enviar imagem para o BD
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            img_byte = br.ReadBytes((int)fs.Length);

            return img_byte;
        }

        private void Listar()
        {
            connec.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            cmd = new MySqlCommand(sql, connec.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            connec.FecharConexao();
        }

        private void ListarCargos()
        {
            connec.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY Cargo asc";
            cmd = new MySqlCommand(sql, connec.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbCargo.DataSource = dt;
            cbCargo.DisplayMember = "Cargo";
            connec.FecharConexao();

        }

        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Tel.:";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "Imagem";

            grid.Columns[0].Width = 50;
            grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = false;
            grid.Columns[7].Visible = false;
        }



        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString(); //pegando o caminho da imagem
                image.ImageLocation = foto; //jogando o caminho da imagem para componente imagem
                alterouImagem = 1;
            }

        }


        private void LimparFoto()
        {
            image.Image = Properties.Resources.semFoto;
            foto = "img/semFoto.png";
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
            Listar();
            FormatarGD();
            ListarCargos();
            alterouImagem = 0;
            cbCargo.Text = "Selecione o Cargo:";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            textNome.Focus();
            LimparCampos();
        }
        private void habilitarCampos()
        {
            btnSalvar.Enabled = true;
            textNome.Enabled = true;
            textCpf.Enabled = true;
            textEndereco.Enabled = true;
            textTelefone.Enabled = true;
            btnfoto.Enabled = true;
            btnLimpar.Enabled = true;
            cbCargo.Enabled = true;
            btnNovo.Enabled = false;

        }

        private void habilitarBtn()
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            DesabilitarCampos();
        }
        private void LimparCampos()
        {
            textNome.Text = "";
            textEndereco.Text = "";
            textCpf.Text = "";
            textTelefone.Text = "";
        }
        private void DesabilitarCampos()
        {
            textNome.Enabled = false;
            textCpf.Enabled = false;
            textEndereco.Enabled = false;
            textTelefone.Enabled = false;
            btnfoto.Enabled = false;
            cbCargo.Enabled = false;

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                habilitarCampos();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;


                id = grid.CurrentRow.Cells[0].Value.ToString();
                textNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                textCpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                textTelefone.Text = grid.CurrentRow.Cells[3].Value.ToString();
                cbCargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
                textEndereco.Text = grid.CurrentRow.Cells[5].Value.ToString();
                cpfCadastrado = grid.CurrentRow.Cells[2].Value.ToString(); //Jogando valor do CPF para uma variavel


                if (grid.CurrentRow.Cells[7].Value != DBNull.Value) //Verificando se existe foto
                {
                    byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imagem);

                    image.Image = Image.FromStream(ms);
                }
                else
                {
                    image.Image = Properties.Resources.semFoto;
                }
                
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            habilitarBtn();
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (textNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preecnha o nome do campo", "Cadastro do Funcioário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNome.Text = "";
                textNome.Focus();
                return;
            }

            if (textCpf.Text == "   ,   ,   -" || textCpf.Text.Length > 14)
            {
                MessageBox.Show("Preenche o CPF", "Cadatro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCpf.Focus();
                return;
            }
            connec.AbrirConexao();
            if (alterouImagem == 1)
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo , endereco = @endereco, foto = @foto WHERE id = @id";
                cmd = new MySqlCommand(sql, connec.con);
                cmd.Parameters.AddWithValue("@id", id); //Esse é o "WHERE"
                cmd.Parameters.AddWithValue("@nome", textNome.Text);
                cmd.Parameters.AddWithValue("@cpf", textCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", textEndereco.Text);
                cmd.Parameters.AddWithValue("@foto", img());
            }
            else if (alterouImagem == 0)
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo , endereco = @endereco  WHERE id = @id";
                cmd = new MySqlCommand(sql, connec.con);
                cmd.Parameters.AddWithValue("@id", id); //Esse é o "WHERE"
                cmd.Parameters.AddWithValue("@nome", textNome.Text);
                cmd.Parameters.AddWithValue("@cpf", textCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", textEndereco.Text);
                
            }
            if (textCpf.Text != cpfCadastrado)
            {
                MySqlCommand cmdVerficar;
                cmdVerficar = new MySqlCommand("SELECT * FROM funcionarios WHERE cpf = @cpf", connec.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerficar;
                cmdVerficar.Parameters.AddWithValue("@cpf", textCpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já registrado", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textCpf.Text = "";
                    textCpf.Focus();
                    return;
                }
            }

            cmd.ExecuteNonQuery();
            connec.FecharConexao();
            Listar();

            MessageBox.Show("Registro Editado com Sucesso!", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            habilitarBtn();
            DesabilitarCampos();
            LimparCampos();
            LimparFoto();
            alterouImagem = 0;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                connec.AbrirConexao();
                sql = "DELETE FROM funcionarios WHERE id = @id";
                cmd = new MySqlCommand(sql, connec.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connec.FecharConexao();

                Listar();

                MessageBox.Show("Registro Excluído com Sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                habilitarBtn();
                LimparCampos();
                DesabilitarCampos();
            }
            
        }
    }
}