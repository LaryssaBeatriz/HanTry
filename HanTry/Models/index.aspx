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
               <!--<img src="/assets/img-simulator.png" alt="capa-pergunta"/>  Imagem que vai acompanhar a pergunta-->
                <h1 runat="server" id="tituloQuiz"> Pergunta do quiz </h1>      

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
                    <form runat="server">
                        <asp:Button runat="server" type="submit" class="opcao" id="opcao1"  OnClick="Opcao1Btn_Click"> </asp:Button>
                        <asp:Button runat="server" type="submit" class="opcao" id="opcao2" OnClick="Opcao2Btn_Click"> </asp:Button>
                        <asp:Button runat="server" type="submit" class="opcao" id="opcao3" OnClick="Opcao3Btn_Click"> </asp:Button>
                        <asp:Button runat="server" type="submit" class="opcao" id="opcao4" OnClick="Opcao4Btn_Click"> </asp:Button>
                    </form>
                </div>
            </div>
                    


             

                <asp:Label ID="Labelresposta" runat="server">     </asp:Label>
                

                <br />
                <br />
                
                <asp:Label ID="contando" runat="server">     </asp:Label>
                <br />
                <asp:Label ID="respostaCorretaLabel" runat="server" >         </asp:Label>
                
                <asp:Label ID="LabelRespostaUsuario" runat="server">     </asp:Label>

                
            </main>
            <footer>
                    Pensado e desenvolvido por Laryssa Beatriz. 
            </footer>
           <asp:Label ID="resposta_certa" runat="server" ></asp:Label>
        <asp:Label ID="resposta_errada" runat="server" ></asp:Label>
        </div>
</body>
</html>


<script type="text/javascript">
    function DisableButtons() {
        var inputs = document.getElementsByTagName("INPUT");
        for (var i in inputs) {
            if (inputs[i].type == "button" || inputs[i].type == "submit") {
                inputs[i].disabled = true;
            }
        }
    }
    window.onbeforeunload = DisableButtons;
</script>

