using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HanTry
{
    public partial class telaFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int[] desempenho = (int[])Session["desempenho"];

            desempenhoLabel.Text = Convert.ToString(desempenho);

            mensagem_feedback.InnerText = "Você acertou um total de " + Convert.ToString(desempenho[0]);

            
        }
    }
}