<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HanTry.Models.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div id="wrapper">
            <nav>
                <div id="topo-nav-bar">
                    <a href="#"><img src="assets/H.png" alt="Logo"></a> <!-- Link para um sobre nós ou algo do tipo-->
                    <a href="#"><img src="assets/iconeUsuario - Copia.png" alt="Minha conta"></a>

                </div>
            </nav>
            <main>
                    <h1>Quiz</h1>
                    
                 <div id="wrapper-quiz">
                <img src="/assets/img-simulator.png" alt="capa-pergunta"/> <!-- Imagem que vai acompanhar a pergunta-->
                <h1 runat="server"> Pergunta do quiz </h1>      

                <div id="barra-progresso"> 
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                    <div class="barra-progresso-icone"></div>
                </div>

                <div id="wrapper-quiz-opcoes">
                    <asp:Button runat="server" type="submit" class="opcao" id="opcao1"> <img src="/assets/img-simulator.png"></asp:Button>
                    <asp:Button runat="server" type="submit" class="opcao" id="opcao2"> <img src="/assets/img-simulator.png"></asp:Button>
                    <asp:Button runat="server" type="submit" class="opcao" id="opcao3"> <img src="/assets/img-simulator.png"></asp:Button>
                    <asp:Button runat="server" type="submit" class="opcao" id="opcao4"> <img src="/assets/img-simulator.png"></asp:Button>
                </div>
            </div>
                    
            </main>
            <footer>
                    Pensado e desenvolvido por Laryssa Beatriz. 
            </footer>
        </div>
</body>
</html>
