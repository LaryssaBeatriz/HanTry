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
        public String conex;
        public MySqlConnection conexao;
        public MySqlCommand comando;
        public MySqlDataReader dr;
        public MySqlDataAdapter da; 
        

        public QuizDB() { 
            conex = ConfigurationManager.AppSettings["banco"];
        }

        //TODO: Funções do quiz, receber resposta, enviar resposta pro banco e etc

        public int[] GeraQuiz() {
            int[] idPerguntas = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++) {
                idPerguntas[i] = random.Next(0, 25);
            }
            return idPerguntas;
        }

        // pegar o array gerado acima e puxar as perguntas do banco criando objetos 
        public Pergunta[] BuscaPerguntas(int[] idPerguntas) {
            conexao = new MySqlConnection(conex);
            Pergunta[] perguntas = new Pergunta[10];
            int i = 0;
            foreach (int id in idPerguntas) {
                string sql = "Select * from perguntas where id= ?idP ";
                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("?idP", id);
                try {
                    conexao.Open();
                    dr = comando.ExecuteReader();
                    dr.Read();
                    perguntas[i] = new Pergunta(id, dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));
                    i++;
                 } catch (MySqlException) { 
                    throw; 
                }finally {
                    conexao.Close();
                }
            }
            return perguntas;
        }

   

    }
}