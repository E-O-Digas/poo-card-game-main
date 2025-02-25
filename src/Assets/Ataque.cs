public class Ataque : Carta{
    private int dano;

    public Ataque(string nome, string descricao, int custo, int dano) : base(nome, descricao, custo) {
        this.dano = dano;
        
    }   

    public override void UsarCarta(Jogador jogador, Jogador oponente){

    }
}