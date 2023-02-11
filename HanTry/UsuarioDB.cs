using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HanTry
{
    public class UsuarioDB
    {
        public string conex;
        public MySqlConnection conexao;
        public MySqlCommand comando;
        public Usuario usuario; 

        public UsuarioDB()
        {
            conex = ConfigurationManager.AppSettings["banco"];
        }

        // o retorno feito em usuario no verifica resposta volta para página e é enviado por parametro para essa função 
        // Aqui os dados obtidos com o quiz devem ser adicionados aos dados do banco 
        public int sincronizaDados(int[] respostasUsuarios, int idUsuario) {
            conexao = new MySqlConnection(conex);
            string sql = "update usuario set erroUsuario=erroUsuario + ?erro, acertoUsuario= acertoUsuario+?acerto where idUsuario = ?idUsuario;";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("acerto", respostasUsuarios[0]);
            comando.Parameters.AddWithValue("erro", respostasUsuarios[1]);
            comando.Parameters.AddWithValue("idUsuario", idUsuario);
            try {
                conexao.Open();
                int quant = comando.ExecuteNonQuery();
                return quant;
            }
            catch (MySqlException e) {
                throw;
            }

        }

    }
} 