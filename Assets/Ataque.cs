public class Ataque : Carta{
    public int Dano { get; }

    public Ataque(string nome, string descricao, int custo, int dano) : base(nome, descricao, custo){
        Dano = dano;

    }

    public override bool UsarCarta(Jogador jogador, Jogador oponente){
        try{
            if (jogador.Energia - this.Custo >= 0) {
                if (oponente.Vida - this.Dano > 0) {
                    jogador.ConsumirEnergia(this.Custo);

                    oponente.ReceberDano(this.Dano);

                    return true;

                } else return false;
                

            } else return false;

            
        }catch (System.Exception){
            throw;

        }

    }
}