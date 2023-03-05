using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HanTry
{
    public class Pergunta
    {
        int id;
        public String textoPergunta;
        public String opcao1;
        public String opcao2;
        public String opcao3;
        public String opcao4;
        private String opcaoCerta;

        public Pergunta(int id, String textoPergunta, String opcaoCerta, String opcao1,String opcao2, String opcao3,String opcao4) {
            this.id = id;
            this.textoPergunta = textoPergunta;
            this.opcao1 = opcao1;
            this.opcao2 = opcao2;
            this.opcao3 = opcao3;
            this.opcao4 = opcao4;
            this.opcaoCerta = opcaoCerta;
        }

        
        // função para validar as respostas dadas pelos usuários 
        public Boolean ValidaResposta(string respostaUsuario, string respostaSistema) {
            return respostaUsuario.Equals(respostaSistema) ? true : false;
        }

        public String GetOpcaoCerta() { return opcaoCerta; }

        public int[] VerificaRepostas(Boolean[] respostas)
        {
            int contCerto = 0;
            int contErrado = 0;
            for (int i = 0; i < 10; i++)
            {
                if (respostas[i] == true)
                {
                    contCerto++;
                }
                else
                {
                    contErrado++;
                }
            }
            int[] respostasUsuario = new int[2];
            respostasUsuario[0] = contCerto;
            respostasUsuario[1] = contErrado;
            return respostasUsuario;
        }

    }
}