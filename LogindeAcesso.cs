using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV
{
    class LogindeAcesso
    {
        public bool existe = false;
        public string mensagem = "";
        string sql;
        MySqlCommand cmd = new MySqlCommand();
        Conexao connec = new Conexao();
        MySqlDataReader dr;

        public bool verficarLogin(string login, string senha)
        {
            connec.AbrirConexao();
            sql = "select * from login WHERE login = @Login and senha = @Senha"; //vericicando se o login e a senha estão corretos
            cmd = new MySqlCommand(sql, connec.con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);
            dr = cmd.ExecuteReader(); //jogando na variavel DR o valor digitado

            try
            {
                               
                
                if (dr.HasRows) 
                {
                    existe = true;
                }
            }
            catch (MySqlException)
            {

                this.mensagem = "Erro com Banco de Dados!!";
            }
            return existe;
        }

    }
}
