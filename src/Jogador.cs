public class Jogador {
    public string Nome { get; }
    public int Energia { get; private set; }
    public int Vida    { get; private set; }

    public Jogador(string nome) {
        Energia = 10;
        Vida    = 30;
        Nome    = nome;

    }

    public int RestaurarEnergia(){
        if (Energia != 10) {
            int novaEnergia = Energia + 2;

            if (novaEnergia >= 10) 
                Energia -= Energia - 10;
            
        }

        return Energia;
    }

    public int ConsumirEnergia(Carta carta){
        if(Energia - carta.Custo < 0)
            throw new Exception("Energia insuficiente");
        
        return Energia - carta.Custo;
    }
}