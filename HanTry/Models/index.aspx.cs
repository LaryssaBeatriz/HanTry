using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HanTry.Models
{
   
    public partial class index : System.Web.UI.Page
    {
      
        // vou imprimir as perguntas uma de cada vez,  e armazenar as ids e as respostas 
        QuizDB quiz = new QuizDB();

        int i;

        Pergunta perguntaQuiz; 

        string respostaCorreta;
        
        string[] respostas = new string[10];
        
    
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {
                // sessão para fazer a contagem de perguntas do quiz 
                Session["contagem"] = 0;

                //sessão para armazenar as respostas do usuário 
                Session["respostas"] = new string[10];

                //sessão para armazenar o desempenho do usuário no quiz 
                inicializaDesempenho();
                perguntaQuiz = ExibeQuiz(quiz.GeraQuiz());

                //iLabel1.Text = Convert.ToString(Session["contagem"]);
                

            } else { 
             //   LabelSegundaExecucao.Visible = true;
                int a = Convert.ToInt32(Session["contagem"]);
                string[] respostas = (string[])Session["respostas"];

                perguntaQuiz = ExibeQuiz(quiz.GeraQuiz());
                respostaCorretaLabel.Text = (string)Session["respostaCorreta"];
               // question1.Text = perguntaQuiz.textoPergunta;

                /*iLabel2.Text = Convert.ToString(a);
                if (a > 1) { 
                   respostaAnterior.Text = " A resposta anterior é " + respostas[--a];
                }*/
          

                if (a >=9)
                {

                    /*for (int c = 0; c < 10; c++)
                    {
                        respostaCorreta = perguntaQuiz.GetOpcaoCerta();

                        Boolean[] isCorrect = new Boolean[10];

                        isCorrect[c] = perguntaQuiz.ValidaResposta(respostas[c], respostaCorreta);

                       Session["numerosRespostas"] = perguntaQuiz.VerificaRepostas(isCorrect);
                    }*/

                    Response.Redirect("telaFeedback.aspx");
                }
            }
        }

        public Pergunta ExibeQuiz(int quizId) {
            perguntaQuiz = quiz.BuscaPerguntas(quizId);
            tituloQuiz.InnerText = perguntaQuiz.textoPergunta;
            opcao1.Text = perguntaQuiz.opcao1;
            opcao2.Text = perguntaQuiz.opcao2;
            opcao3.Text = perguntaQuiz.opcao3;
            opcao4.Text = perguntaQuiz.opcao4;

            Session["respostaCorreta"] = perguntaQuiz.GetOpcaoCerta();

            return perguntaQuiz;
        }

        protected void Opcao1Btn_Click(object sender, EventArgs e)
        {
        
            int b = Convert.ToInt32(Session["contagem"]);
           
            verificarResposta(opcao1.Text);
           
            b++;
            Session["contagem"] = b;
        }

        protected void Opcao2Btn_Click(object sender, EventArgs e)
        {
       
            int b = Convert.ToInt32(Session["contagem"]);
            
            verificarResposta(opcao2.Text);

            b++;
            Session["contagem"] = b;
        }

        protected void Opcao3Btn_Click(object sender, EventArgs e)
        {
         
            int b = Convert.ToInt32(Session["contagem"]);
            
            verificarResposta(opcao3.Text);

            b++;
            Session["contagem"] = b;
            
        }

        protected void Opcao4Btn_Click(object sender, EventArgs e)
        {
           
            int b = Convert.ToInt32(Session["contagem"]);

            verificarResposta(opcao4.Text);

            b++;
            Session["contagem"] = b;
        }

        public void verificarResposta(string respostaUsuario)
        {
            LabelRespostaUsuario.Text = respostaUsuario;
            string respostaCerta = (string)(Session["respostaCorreta"]);
            if (respostaUsuario.Equals(respostaCerta))
            {
                int[] contagem = (int[])Session["desempenho"];
                int acerto = contagem[0];
                acerto++;
                contagem[0] = acerto;
                Session["desempenho"] = contagem;
                contando.Text = Convert.ToString(contagem[0]);
            }
            else {
                int[] contagem = (int[])Session["desempenho"];
                contagem[1] = contagem[1]++;
                Session["desempenho"] = contagem;
            }
        }

        public void inicializaDesempenho()
        {
            int[] desempenho = new int[2];
            desempenho[0] = 0;
            desempenho[1] = 0;
            Session["desempenho"] = desempenho;
        }
    }

        

}