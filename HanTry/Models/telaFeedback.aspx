<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="telaFeedback.aspx.cs" Inherits="HanTry.telaFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
      <main>
            <a href="index.aspx"><img src="/assets/casa-unica.png" alt="Home/Quizzes"></a>    
            <div id="seta-icon-home"></div> <!-- Div para fazer a seta da barra de volta rs -->
            <h6> Hangul Quiz</h6>

            <div id="main-wrapper">
                <img src="/assets/img-simulator.png" alt="capa-feedback"> <!-- Imagem que vai acompanhar o feedback, alguma mensagem motivacional/ de apoio vai ser grande -->
                <h2 id="mensagem_feedback" runat="server"> </h2>      

                <asp:Label  runat="server" id="desempenhoLabel"/>

                <h4 runat="server" id="msgFinal"> Mensagem motivacional aqui !!</h4>

                <a href="index.aspx">Voltar para menu</a>
            </div>
        </main>
        <footer>
            Pensado e desenvolvido por Laryssa Beatriz.
        </footer>
</body>
</html>
