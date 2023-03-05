using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace HanTry
{
    public class QuizDB 
    {
        public string conex;
        public MySqlConnection conexao;
        public MySqlCommand comando;
        public MySqlDataReader dr;
        public MySqlDataAdapter da; 
        

        public QuizDB() { 
            conex = ConfigurationManager.AppSettings["banco"];
        }

        //TODO: Funções do quiz, receber resposta, enviar resposta pro banco e etc

        public int GeraQuiz() {
            int idPergunta;
            Random random = new Random();
            idPergunta = random.Next(0, 25);
            return idPergunta;
        }

        // pegar o array gerado acima e puxar as perguntas do banco criando objetos 
        public Pergunta BuscaPerguntas(int idPergunta) {
            conexao = new MySqlConnection(conex);
            int i = 0;
            Pergunta pergunta;
                string sql = "Select * from perguntas where idPergunta = ?idP; ";
                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("?idP", idPergunta);
                try {
                    conexao.Open();
                    dr = comando.ExecuteReader();
                    dr.Read();
                if (dr.Read())
                {
                    pergunta = new Pergunta(idPergunta, dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));
                    i++;
                }
                else {
                    conexao.Close();
                    conexao.Open();
                    dr = comando.ExecuteReader();
                    dr.Read();
                    pergunta = new Pergunta(idPergunta, dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));
                }
            } catch (MySqlException) { 
                    throw; 
                }finally {
                    conexao.Close();
                }
          
            return pergunta;
        }

   

    }
}