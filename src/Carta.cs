public abstract class Carta {
    private int custo;

    public string Descricao { get; }
    public string Nome      { get; }

    public int Custo { 
        get { return Custo; }

        private set { 
            if (Custo >= 0)
                throw new ArgumentException("Custo da carta invalido");

            custo = Custo;
         
        }
    
    }

    public Carta(string nome, string descricao, int custo){
        Descricao = descricao;
        Nome      = nome;

        Custo = custo;

    }

    public abstract void UsarCarta (Jogador jogador, Jogador oponente);
}