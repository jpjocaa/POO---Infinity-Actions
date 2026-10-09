using UnityEngine;

public class EventsOptions //Fazer desse script um "jogo utils"
{
    private int LIMITE_DE_FALHA = 30;

    public void Prosseguir(GameManager manager)
    {
        manager.Caminhada();
    }

    public bool CalcularSucesso(int limite, int bonus = 0) //É bool pq vai retornar se sobreviveu ou não.
    {
        int taxaDeSucesso = Random.Range(0, limite) + bonus;
        Debug.Log($"Taxa de sucesso sorteada: {taxaDeSucesso}"); //vamos ver se é realmente aleatorio isso.
        return taxaDeSucesso >= LIMITE_DE_FALHA;
    }

    public void ResolverAcao(GameManager manager, int limite, int bonus, string msgSucesso, string msgFalha)
    {
        if (CalcularSucesso(limite, bonus))         //admito que só descobri que dá pra usar um if sem o {} graças ao Enzão (Enzo Felipe). Vivendo e aprendendo né?
            manager.MostrarResultado(msgSucesso);
        else
            manager.FimDeJogo(msgFalha);
    }
}
