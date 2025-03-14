public class Defesa : Carta{
    public string Vida { get; }

    public Defesa(string nome, string descricao, int custo, string vida) : base(nome, descricao, custo){
        Vida = vida;

    }

    public override bool UsarCarta(Jogador jogador, Jogador oponente) {
        try{
            if (jogador.Energia - this.Custo >= 0) {
                if (jogador.Vida + int.Parse(this.Vida) <= 30) {
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



