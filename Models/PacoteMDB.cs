using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using sistema_de_login.Models;

namespace sistema_de_login.Models
{
    public class PacoteMDB
    {

    
        private static string DadosCN = "Database=sistemfullstack ;Data Source=localhost; User Id=root;";

        public static void Inserir (PacoteM pacote){
            MySqlConnection conexao = new MySqlConnection(DadosCN);
            conexao.Open();
            string query = "INSERT INTO pacotes1 (origem, destino, mes, ida, volta, preco) VALUES (@origem, @destino, @mes, @ida, @volta, @preco) ";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@origem", pacote.origem);
            comando.Parameters.AddWithValue("@destino", pacote.destino);
            comando.Parameters.AddWithValue("@mes", pacote.mes);
            comando.Parameters.AddWithValue("@ida", pacote.ida);
            comando.Parameters.AddWithValue("@volta", pacote.volta);
            comando.Parameters.AddWithValue("@preco", pacote.preco);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public static List<PacoteM> Listar(){
            MySqlConnection conexao = new MySqlConnection(DadosCN);
            conexao.Open();
            string query = "SELECT * FROM pacotes1;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();
            
            List<PacoteM> lista = new  List<PacoteM> ();
            while (leitor.Read())
            {
                PacoteM pacote = new PacoteM();
                if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
                    pacote.id = leitor.GetInt32("id");
                if (!leitor.IsDBNull(leitor.GetOrdinal("origem")))
                    pacote.origem = leitor.GetString("origem");
                if (!leitor.IsDBNull(leitor.GetOrdinal("destino")))
                    pacote.destino = leitor.GetString("destino");
                if (!leitor.IsDBNull(leitor.GetOrdinal("mes")))
                    pacote.mes = leitor.GetString("mes");
                if (!leitor.IsDBNull(leitor.GetOrdinal("ida")))
                    pacote.ida = leitor.GetString("ida");
                if (!leitor.IsDBNull(leitor.GetOrdinal("volta")))
                    pacote.volta = leitor.GetString("volta");
                if (!leitor.IsDBNull(leitor.GetOrdinal("preco")))
                    pacote.preco = leitor.GetString("preco");    
                    lista.Add(pacote);
            }
            conexao.Close();
            return lista;
        }
        public static void Atualizar (PacoteM pacote){
            MySqlConnection conexao = new MySqlConnection(DadosCN);
            conexao.Open();
            string query = "UPDATE pacotes1 SET origem=@origem, destino=@destino, mes=@mes, ida=@ida, volta=@volta, preco=@preco WHERE id=@id";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@origem", pacote.origem);
            comando.Parameters.AddWithValue("@destino", pacote.destino);
            comando.Parameters.AddWithValue("@mes", pacote.mes);
            comando.Parameters.AddWithValue("@ida", pacote.ida);
            comando.Parameters.AddWithValue("@volta", pacote.volta);
            comando.Parameters.AddWithValue("@preco", pacote.preco);
            comando.Parameters.AddWithValue("@id", pacote.id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public static PacoteM BuscarPorId(int id){
            MySqlConnection conexao = new MySqlConnection(DadosCN);
            conexao.Open();
            string query = "SELECT * FROM pacotes1 WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("id", id);
            MySqlDataReader leitor = comando.ExecuteReader();
            PacoteM pacote = new PacoteM();
    
            if (leitor.Read())
            {
                if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
                    pacote.id = leitor.GetInt32("id");
                if (!leitor.IsDBNull(leitor.GetOrdinal("origem")))
                    pacote.origem = leitor.GetString("origem");
                if (!leitor.IsDBNull(leitor.GetOrdinal("destino")))
                    pacote.destino = leitor.GetString("destino");
                if (!leitor.IsDBNull(leitor.GetOrdinal("mes")))
                    pacote.mes = leitor.GetString("mes");
                if (!leitor.IsDBNull(leitor.GetOrdinal("ida")))
                    pacote.ida = leitor.GetString("ida");
                if (!leitor.IsDBNull(leitor.GetOrdinal("volta")))
                    pacote.volta = leitor.GetString("volta");
                if (!leitor.IsDBNull(leitor.GetOrdinal("preco")))
                    pacote.preco = leitor.GetString("preco");    
                    
            }
            conexao.Close();
            return pacote;
        }
        public static void Remover (int id){
            MySqlConnection conexao = new MySqlConnection(DadosCN);
            conexao.Open();
            string query = "DELETE FROM pacotes1 WHERE id=@id";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("id", id);
            comando.ExecuteNonQuery();
            conexao.Close();
           
        }
    }
}
    
