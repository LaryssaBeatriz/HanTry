using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HanTry
{
    public class Pergunta
    {
        int id;
        String textoPergunta;
        String opcao1;
        String opcao2;
        String opcao3;
        String opcao4;
        String opcaoCerta;

        public Pergunta(int id, String textoPergunta,String opcao1,String opcao2, String opcao3,String opcao4, String opcaoCerta) {
            this.id = id;
            this.textoPergunta = textoPergunta;
            this.opcao1 = opcao1;
            this.opcao2 = opcao2;
            this.opcao3 = opcao3;
            this.opcao4 = opcao4;
            this.opcaoCerta = opcaoCerta;
        }
    }
}