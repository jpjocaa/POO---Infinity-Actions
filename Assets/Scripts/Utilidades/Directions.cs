using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class Directions
{
    ConfigButtons editarBotao = new();
    EventsOptions OpcoesDeEventos = new();

    public void Direcoes(TMP_Text mensagem, Button[] botoes, GameManager manager)
    {
        mensagem.text = "Escolha a direção que você quer seguir em frente";
        editarBotao.ConfigurarBotao(0, "Esquerda", manager.Eventos, botoes);
        editarBotao.ConfigurarBotao(1, "Direita", manager.Eventos, botoes);
        editarBotao.ConfigurarBotao(2, "Frente", manager.Eventos, botoes);
        editarBotao.ConfigurarBotao(3, "Voltar", manager.Eventos, botoes);
    }

}