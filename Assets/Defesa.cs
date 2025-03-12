public class Defesa : Carta{
    public int Vida { get; }

    public Defesa(string nome, string descricao, int custo, int vida) : base(nome, descricao, custo){
        Vida = vida;

    }

    public override bool UsarCarta(Jogador jogador, Jogador oponente) {
        try{
            if (jogador.Energia - this.Custo >= 0) {
                if (jogador.Vida + this.Vida <= 30) {
                    jogador.ConsumirEnergia(this.Custo);

                    jogador.RestaurarVida(this.Vida);

                    return true;

                } else return false;

            } else return false;
            
        } catch (System.Exception) {
            throw;

        }
    }
}



