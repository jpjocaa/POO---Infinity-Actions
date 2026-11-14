using UnityEngine.UI;
using TMPro;

public class Directions
{
    ConfigButtons editarBotao = new();

    public void Direcoes(TMP_Text mensagem, Button[] botoes, GameManager manager, ButtonImages images)
    {
        mensagem.text = "Escolha a direção que você quer seguir em frente";
        editarBotao.ConfigurarBotao(0, "", () => manager.Andar("Indo para a esquerda"), botoes);
        editarBotao.CustomizarBotao(0, images.CaminhosSprites[2], botoes);

        editarBotao.ConfigurarBotao(1, "", () => manager.Andar("Indo para a direita"), botoes);
        editarBotao.CustomizarBotao(1, images.CaminhosSprites[3], botoes);

        editarBotao.ConfigurarBotao(2, "", () => manager.Andar("Seguindo em frente"), botoes);
        editarBotao.CustomizarBotao(2, images.CaminhosSprites[4], botoes);

        editarBotao.ConfigurarBotao(3, "", () => manager.Andar("Voltando"), botoes);
        editarBotao.CustomizarBotao(3, images.CaminhosSprites[5], botoes);

    }
}
