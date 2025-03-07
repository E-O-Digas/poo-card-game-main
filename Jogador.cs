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

    public int RestaurarEnergia(){
        if (Energia != 10) {
            int novaEnergia = Energia + 2;

            if (novaEnergia >= 10) 
                Energia -= Energia - 10;
            
        }

        return Energia;
    }

    public bool ConsumirEnergia(Carta carta){
        if(Energia - carta.Custo < 0)
            return false;
        
        else {
            Energia -= carta.Custo;
            return true;    

        }

    }

    public bool RestaurarVida(Defesa carta){
        if (Vida >= 30)
            return false;

        else{
            Vida += carta.Vida;
            return true;

        }
        
    }

    public bool ReceberDano(Ataque carta){
        if(Vida - carta.Dano <= 0)
            return false;

        else {
            Vida -= carta.Dano; 
            return true;
        
        }
        
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

    public string VerMao(){
        Carta carta;
        string res = "";

        for(int item = 0; item < Mao.Count; item++){
            carta = Mao.ElementAt(item);
            res += $"Carta {item+1}° Nome: {carta.Nome} Descrição: {carta.Descricao} Custo:{carta.Custo} \n";
        
        }

        return res;

    }

    public List<Carta> getMao(){
        return Mao;
        
    }
}