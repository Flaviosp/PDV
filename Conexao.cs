using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV
{
    public class Conexao
    {
        
        //para usar o servidor local

        public string connec = "SERVER=localhost; DATABASE=pdv; UID=root; PWD=; PORT=;";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(connec);
                con.Open();
            }

            catch (Exception)
            {
                
            }
            
        }
       

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(connec);
                con.Close();
                con.Dispose(); //Derruba conexão aberta
                con.ClearAllPoolsAsync(); //metodo de limpeza
            }
            catch (Exception)
            {

            }
        }
    }
}
