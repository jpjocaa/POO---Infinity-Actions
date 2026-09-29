
    using UnityEngine.Events;
    using TMPro;
    using UnityEngine.UI;
    

    public class ConfigButtons
    {
        public Button botao;
        public Button[] Botoes;

        
        public void ConfigurarBotao(int indice, string texto, UnityAction acao, Button[] botoes)
        {
            this.Botoes = botoes;
            Button botao = Botoes[indice];

            botao.gameObject.SetActive(true);

            botao.GetComponentInChildren<TMP_Text>().text = texto;

            botao.onClick.RemoveAllListeners();
            botao.onClick.AddListener(acao);
        }
        public void ConfigurarBotaoDeSucesso(int indice, string texto, int chance, UnityAction<int> acao, Button[] botoes)
        {
            this.Botoes = botoes;
            Button botao = Botoes[indice];

            botao.gameObject.SetActive(true);

            botao.GetComponentInChildren<TMP_Text>().text = texto;

            botao.onClick.RemoveAllListeners();
            botao.onClick.AddListener(() => acao(chance));
        }
        public void ConfigurarBotaoSemAcao(int indice, string texto, Button[] botoes)
        {
            Button botao = botoes[indice];

            botao.gameObject.SetActive(true);
            botao.GetComponentInChildren<TMP_Text>().text = texto;
        }
    }
