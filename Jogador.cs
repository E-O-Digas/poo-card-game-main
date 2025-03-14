public class Jogador {
    public string Nome { get; }
    public int Energia { get; private set; }
    public int Vida { get; private set; }
    
    private List<Carta> Mao { get; }
    private List<Carta> Deck { get; }

    public Jogador(string nome) {
        Energia = 10;
        Vida = 30;
        Nome = nome;
        Deck = new List<Carta>();
        Mao = new List<Carta>();

    }

    public void RestaurarEnergia(){
        if (Energia < 10) {
            Energia = Energia + 2;

            if (Energia + 2 > 10) 
                Energia -= Energia - 10;
            
        }
    }

    public void ConsumirEnergia(int custo){
        Energia -= custo;

    }

    public void RestaurarVida(string recuperarVida){
        Vida += int.Parse(recuperarVida);

    }

    public void ReceberDano(string dano){
        Vida -= int.Parse(dano);
        
    }

    public List<Carta> GerarDeck(List<Carta> monte){
        Random random = new Random();

        for(int i= 0; i < 20; i++)
            Deck.Add(monte.ElementAt(random.Next(0, monte.Count)));
        
        return Deck;        

    }

    private List<Carta> GerarMao(List<Carta> deck){
        for(int i= 0; i < 5; i++){
            Mao.Add(deck.ElementAt(i));

            Deck.RemoveAt(i);

        }

        return Mao;   
    }

    private void PegarCarta(int qtdDeCartas){
        for (int i= 0; i < qtdDeCartas; i++)
            Mao.Add(Deck.ElementAt(i));
        
    }

    public void PegarCartas(int qtdDeCartas){
        if(qtdDeCartas != 0 && Mao.Count < 5 )
            PegarCarta(qtdDeCartas);

        else if(Mao.Count >= 5)
            Console.WriteLine("Mao ja está cheia!");

        else        
            GerarMao(Deck);
     
    }

    public List<Carta> getMao(){
        return Mao;
        
    }
}