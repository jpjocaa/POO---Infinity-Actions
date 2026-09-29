 
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Eventos
{
    EventsOptions OpcoesDeEventos = new();
    ConfigButtons editarBotao = new();
    public void EventoBoaVindas(TMP_Text mensagem, Button[] botoes, GameManager manager)
    {
        mensagem.text = "Seja bem vindo ao nosso jogo!!\nEle foi feito com muito carinho e dedicação, afinal, isso foi algo totalmente novo, então aproveite!";
        editarBotao.ConfigurarBotao(1, "Clique no botão para prosseguir", manager.IniciarJogo , botoes);
    }

    public void AnimalFeroz(TMP_Text mensagem, Button[] botoes, GameManager manager) //Seria daora fazer uma classe subeventos para detalhar mais os acontecimentos.
    {
        mensagem.text = "Oh não,eu encontrei um animal feroz!";
        editarBotao.ConfigurarBotaoDeSucesso(0 , "1- Corrrer para longe", 40 , OpcoesDeEventos.CalcularSucesso, botoes);
        editarBotao.ConfigurarBotaoDeSucesso(1 , "2- Desviar rapidamente",20 , OpcoesDeEventos.CalcularSucesso, botoes);
        editarBotao.ConfigurarBotaoDeSucesso(2 , "3- Pular o animal",10 , OpcoesDeEventos.CalcularSucesso, botoes);
        editarBotao.ConfigurarBotaoDeSucesso(3 , "4- Voltar silenciosamente",80, OpcoesDeEventos.CalcularSucesso, botoes);
        editarBotao.ConfigurarBotaoDeSucesso(4 , "5- Esconder-se", 60, OpcoesDeEventos.CalcularSucesso, botoes);
        editarBotao.ConfigurarBotaoDeSucesso(5 , "6- Tentar capturar o animal", 0 , OpcoesDeEventos.CalcularSucesso, botoes);
        
    }

}