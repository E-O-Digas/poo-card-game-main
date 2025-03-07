public abstract class Carta {
    public string Descricao { get; }
    public string Nome { get; }

    public int Custo { get; private set; }

    public Carta(string nome, string descricao, int custo){
        Descricao = descricao;
        
        Nome = nome;

        Custo = custo;

    }

    public abstract bool UsarCarta (Jogador jogador, Jogador oponente);
}