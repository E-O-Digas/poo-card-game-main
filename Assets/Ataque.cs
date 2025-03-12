public class Ataque : Carta{
    public int Dano { get; }

    public Ataque(string nome, string descricao, int custo, int dano) : base(nome, descricao, custo){
        Dano = dano;

    }

    public override bool UsarCarta(Jogador jogador, Jogador oponente){
        try {
            if (jogador.Energia - this.Custo >= 0) {
                jogador.ConsumirEnergia(this.Custo);

                oponente.ReceberDano(this.Dano);
                
                if (oponente.Vida <= 0) {
                    throw new Exception("Fim de jogo.");
                    
                }
            
                return true;
                

            } else return false;

            
        } catch (System.Exception) {
            throw;

        }

    }
}