using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Diagnostics;
using System.Globalization;
using System.Text;



public class GameManager : MonoBehaviour
{
    public Button[] botoes;
    public TMP_Text mensagem;

    public Eventos events = new();
    public EventsEnum eventsEnum = new();
    public Directions directions = new();
    


    int contadordeTurno = 0;

    
    void Start()
    {
        ConfigurarEvento(5);
    }

    public void ConfigurarEvento(int evento)
    {
    // Primeiro esconde todos
        foreach (Button botao in botoes)
        {
            botao.gameObject.SetActive(false);
        }

        switch (evento)
        {
            case 1:
                events.AnimalFeroz(mensagem, botoes, this);
                break;

            case 2:
                //ConfigurarPedra();
                break;

            case 3:
               // ConfigurarAbismo();
                break;

            case 4:
              //  ConfigurarNovoCaminho();
                break;

            case 5:
                events.EventoBoaVindas(mensagem, botoes, this);
                break;
            case 6:
                directions.Direcoes(mensagem,botoes, this);
                break;


        }
    }   

    public void IniciarJogo()
    {
        Caminhada();
    }
    public void Caminhada()
    {
        directions.Direcoes(mensagem, botoes, this);
    }
    public void Eventos()
    {
        contadordeTurno += 1;
        int EventoAleatorio = Random.Range(1, 1);
        ConfigurarEvento(EventoAleatorio);
    }
        
}
