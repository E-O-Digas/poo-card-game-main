public class Defesa : Carta{
    private int vida;

    public Defesa(string nome, string descricao, int custo, int vida) : base(nome, descricao, custo) {
        this.vida = vida;
        
    }
    public override void UsarCarta(Jogador jogador, Jogador oponente){

    }
}