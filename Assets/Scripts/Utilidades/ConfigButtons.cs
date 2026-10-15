using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;

public class ConfigButtons //Essa classe , como o nome diz, é só para configurar o botão escolhido
{
    EventsOptions opcoesDeEventos = new();

    //Botão escolhido (note que 0 = 1 nesse caso. Estranho, eu sei, mas são listas.), o texto do botão, o metodo que ele irá executar, a lista de botoes (é um saco esse ultimo ser necessario)
    //
    public void ConfigurarBotao(int indice, string texto, UnityAction acao, Button[] botoes) //Fato curioso: agora que eu terminei os codigos, eu percebi que eu só uso isso uma vez, no novo caminho. Mas ele foi o botão ""primordial"" e a base de todos
    {

        Button botao = botoes[indice]; //pegou o botao escolhido

        botao.gameObject.SetActive(true); //ativou
        botao.GetComponentInChildren<TMP_Text>().text = texto; //mudou o texto. Vamos trocar no futuro para a linha 22.

        botao.onClick.RemoveAllListeners(); //tirou qualquer ação passada dentro dele
        botao.onClick.AddListener(acao); //botou nosso metodo como ação.
        //botao.image.sprite = imagem (novo parametro);

    }

    public void CustomizarBotao(int indice, Sprite imagem, Button[] botoes)
    {
        Button botao = botoes[indice];
        botao.image.sprite = imagem;
    }

    //Muitos parametros. Espero que vcs entendam, to com preguiça.
    public void ConfigurarBotaoDeSucesso(int indice, string texto, int limite, int bonus, string msgSucesso, string msgFalha, Button[] botoes, GameManager manager)
    {
        ConfigurarBotao(indice, texto,() => opcoesDeEventos.ResolverAcao(manager, limite, bonus, msgSucesso, msgFalha), botoes);
    }


}
