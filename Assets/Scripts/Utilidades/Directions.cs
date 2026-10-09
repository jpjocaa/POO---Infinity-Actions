using UnityEngine.UI;
using TMPro;

public class Directions
{
    ConfigButtons editarBotao = new();

    public void Direcoes(TMP_Text mensagem, Button[] botoes, GameManager manager)
    {
        mensagem.text = "Escolha a direção que você quer seguir em frente";
        editarBotao.ConfigurarBotao(0, "Esquerda", () => manager.Andar("Indo para a esquerda"), botoes);
        editarBotao.ConfigurarBotao(1, "Direita", () => manager.Andar("Indo para a direita"), botoes);
        editarBotao.ConfigurarBotao(2, "Frente", () => manager.Andar("Seguindo em frente"), botoes);
        editarBotao.ConfigurarBotao(3, "Voltar", () => manager.Andar("Voltando"), botoes);
    }
}
