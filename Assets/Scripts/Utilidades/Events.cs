using TMPro;
using UnityEngine.UI;

public class Eventos //QUE SCRIPT GRANDEEEE. Mas relaxa que a maioria é texto e tals, ent só assuta msm. A estrutura principal é a mesma
{
    ConfigButtons editarBotao = new();
    //temos dois botões : o de sucesso (calcula o sucesso, ava) e o normal (configurarbotao), que serve para seguir em frente
    //Nota: Eu descobri da pior forma que usar while na Unity n dá certo... não tentem fazer isso, de verdade.



    public void EventoBoaVindas(TMP_Text mensagem, Button[] botoes, GameManager manager)
    {
        mensagem.text = "Seja bem vindo ao nosso jogo!!\nEle foi feito com muito carinho e dedicação, afinal, isso foi algo totalmente novo, então aproveite!";
        editarBotao.ConfigurarBotao(0, "Clique no botão para prosseguir", manager.IniciarJogo, botoes);
    }

    public void AnimalFeroz(TMP_Text mensagem, Button[] botoes, GameManager manager, ButtonImages images)
    {
        mensagem.text = manager.TextoDeDirecao + "Oh não, eu encontrei um animal feroz!\nO que faço agora?";

        string sucesso = "Ufá! Consegui escapar, mas é bom não passar mais ali!";
        string falha = "O personagem foi pego pelo animal feroz!";

        //índice, texto,limite, bônus (só tem para o animal feroz), texto de sucesso, texto de falha
        editarBotao.ConfigurarBotaoDeSucesso(0, "",             80,  0, sucesso, falha, botoes, manager);
        editarBotao.CustomizarBotao(0, images.animalFeroz[0], botoes);
        editarBotao.ConfigurarBotaoDeSucesso(1, "2- Desviar rapidamente",           60,  0, sucesso, falha, botoes, manager);
        editarBotao.ConfigurarBotaoDeSucesso(2, "3- Pular o animal",                40,  0, sucesso, falha, botoes, manager);
        editarBotao.ConfigurarBotaoDeSucesso(3, "4- Voltar silenciosamente",       100, 10, sucesso, falha, botoes, manager);
        editarBotao.ConfigurarBotaoDeSucesso(4, "5- Esconder-se",                   90,  0, sucesso, falha, botoes, manager);
        editarBotao.ConfigurarBotaoDeSucesso(5, "6- Tentar capturar o animal",      40,  0, sucesso, falha, botoes, manager);
    }



    public void PedraMisteriosa(TMP_Text mensagem, Button[] botoes, GameManager manager)
    {
        mensagem.text = manager.TextoDeDirecao + "Que pedra estranha, o que será que é?\nO que faço agora?";

        string sucesso = "Tirei a sorte grande! É OUROOOOOOOO!";
        string falha = "A pedra era na verdade um bicho venenoso, e você morreu! ops...";

        editarBotao.ConfigurarBotaoDeSucesso(0, "1- Analisar a pedra", 100, 0, sucesso, falha, botoes, manager);

        editarBotao.ConfigurarBotao(1, "2- Guardar a pedra na bolsa",() => manager.MostrarResultado("Realmente, é melhor guardar e analisar quando tiver ferramentas melhores."), botoes);

        editarBotao.ConfigurarBotao(2, "3- Jogar a pedra fora",() => manager.MostrarResultado("Joguei a pedra fora e segui meu caminho."),botoes);
    }



    public void Abismo(TMP_Text mensagem, Button[] botoes, GameManager manager)
    {
        mensagem.text = manager.TextoDeDirecao + "Ufá! Que bom que parei antes de cair no abismo.\nO que faço agora?";

        editarBotao.ConfigurarBotaoDeSucesso(0, "1- Tentar descer o abismo", 30, 0,"Quase que tudo acaba, por pouco não escorreguei e caí...","O personagem caiu tentando descer...", botoes, manager);

        editarBotao.ConfigurarBotaoDeSucesso(1, "2- Tentar pular para o outro lado", 40, 0,"Essa foi por pouco, nunca vou ser louco desse jeito...", "O personagem até TENTOU, mas caiu no abismo...", botoes, manager);

        editarBotao.ConfigurarBotao(2, "3- Voltar por onde veio", () => manager.MostrarResultado("Foi a decisão certa, aquele abismo era muito profundo."), botoes);
    }



    public void NovoCaminho(TMP_Text mensagem, Button[] botoes, GameManager manager) //O mais sem graça pra ser sincero.
    {
        mensagem.text = manager.TextoDeDirecao + "Inacreditável! Encontrei um novo caminho.\nEsta parte da floresta ainda não tinha explorado...\nO que será que vou encontrar seguindo em frente?";
        editarBotao.ConfigurarBotao(0, "Seguir em frente", manager.Caminhada, botoes);
    }
}
