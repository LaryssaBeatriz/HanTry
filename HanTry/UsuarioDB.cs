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
        public String conex;
        public MySqlConnection conexao;
        public MySqlCommand comando;
        public Usuario usuario; 

        public UsuarioDB()
        {
            conex = ConfigurationManager.AppSettings["banco"];
        }

        // o retorno feito em usuario no verifica resposta volta para página e é enviado por parametro para essa função 
        // Aqui os dados obtidos com o quiz devem ser adicionados aos dados do banco 
        public int sincronizaDados(int[] respostasUsuarios) { 
            
        }

    }
} 