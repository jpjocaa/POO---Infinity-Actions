using UnityEngine;
using TMPro;
using UnityEngine.UI;
using OpcoesDeEvento = EventsEnum.OpcoesDeEvento;

//Olha, eu deixei umas partes comentadas para vocês entenderem a minha logica blz? "" Algumas "" 
//Por sinal, eu acho que algumas partes eu dexei comentada da epóca em que eu estava me matando para fazer, então se tiver uns comentarios nada haver, tipo (fazer tal coisa!!) sendo que já tá feito, vcs sabem o motivo.

public class GameManager : MonoBehaviour
{
    public Button[] botoes;   //Aparece no inspetor para colocar os botoes
    public TMP_Text mensagem;   //mesma coisa , só que com o texto


    //Aba de scripts. Nenhum deles é MonoBehaviour (que está em um objeto da unity.) O unico que é MonoBehavirou é esse script. Ele seria de uma forma bem "boba" o nosso program.
    Eventos events = new();
    Directions directions = new();
    ConfigButtons editarBotao = new();

    [SerializeField] private ButtonImages images;

    //preguiçaaa
    string direcaoEscolhida ;
    int contadordeTurno = 0;

    public string TextoDeDirecao
    {
        get { return string.IsNullOrEmpty(direcaoEscolhida) ? "" : direcaoEscolhida + "...\n\n"; } //Mano, vou ser sincero que sem esse get n estava dando certo e n sei pq. Tive que pedi pra IA ( só dessa vez)
    }

    void Start()    //primeiro a rodar
    {
        ConfigurarEvento(OpcoesDeEvento.Boasvindas); //vamos começar com o boas vindas né.
    }

    public void ConfigurarEvento(OpcoesDeEvento evento) //Mudar para Enum, e não int!!!
    {
        EsconderBotoes(); //antes estava junto aqui, mas eu percebi que vou precisar esconder os botões em outros momentos,logo deixei separado.

        switch (evento)
        {
            case OpcoesDeEvento.AnimalFeroz:    
                events.AnimalFeroz(mensagem, botoes, this, images);
                break;

            case OpcoesDeEvento.PedraMisteriosa:
                events.PedraMisteriosa(mensagem, botoes, this);
                break;

            case OpcoesDeEvento.Abismo:
                events.Abismo(mensagem, botoes, this);
                break;

            case OpcoesDeEvento.NovoCaminho:
                events.NovoCaminho(mensagem, botoes, this);
                break;

            case OpcoesDeEvento.Boasvindas:
                events.EventoBoaVindas(mensagem, botoes, this);
                break;

            case OpcoesDeEvento.Direcoes:
                directions.Direcoes(mensagem, botoes, this); //Unico script separado do events. Eu fiz isso pq ele é o diferentão,e pq eu tava achando o events muito grande
                break;
        }
    }

    void EsconderBotoes()
    {
        foreach (Button botao in botoes)
        {
            botao.gameObject.SetActive(false);
        }
    }

    // Botão para zerar todas as estatisticas.
    public void IniciarJogo()
    {
        contadordeTurno = 0;
        direcaoEscolhida = ""; // só pra ter certeza que está realmente vazio. Teve uns momentos que n deu vazio por algum motivo (tava fazendo alguma coisa errada. T
        Caminhada();
    }

    // Tela de escolher a direção. Ou seja, esquerda direita,enfim ...
    public void Caminhada()
    {
        direcaoEscolhida = "";
        ConfigurarEvento(OpcoesDeEvento.Direcoes);
    }

    // botões de direção
    public void Andar(string textoDaDirecao)
    {
        direcaoEscolhida = textoDaDirecao;
        SortearEvento();
    }

    //Meio auto explicatorio o nome...
    public void SortearEvento()
    {
        contadordeTurno += 1; //Só vai acontecer após um turno ser concluido
        int eventoAleatorio = Random.Range(1, 5);
        ConfigurarEvento((OpcoesDeEvento)eventoAleatorio);
    }

    // Quando uma ação dá certa. Yipeeeee :)
    public void MostrarResultado(string texto)
    {
        EsconderBotoes();
        mensagem.text = texto;
        editarBotao.ConfigurarBotao(0, "Continuar", Caminhada, botoes);
    }

    //auto explicatorio pt2
    public void FimDeJogo(string motivo)
    {
        EsconderBotoes();
        mensagem.text = "Sua aventura durou";
        editarBotao.ConfigurarBotao(0, "Jogar novamente", IniciarJogo, botoes);
    }
}
