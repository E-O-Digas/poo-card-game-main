public class Defesa : Carta
{
    public int Vida { get; }

    public Defesa(string nome, string descricao, int custo, int vida) : base(nome, descricao, custo)
    {
        Vida = vida;

    }

    public override bool UsarCarta(Jogador jogador, Jogador oponente)
    {
        try{
            if (jogador.ConsumirEnergia(this)){
                if (jogador.RestaurarVida(this)){
                    if (Vida + carta.Vida < 30){
                        Vida += carta.Vida;

                    }else{
                        Vida = Vida + carta.Vida - (Vida - 30);

                    }

                    Energia -= carta.Custo;
                    Console.WriteLine($"O {jogador.Nome} recuperou {Vida} de vida e consumiu {Custo}");
                    return true;

                }else {
                    Console.WriteLine("Vida ja cheia!");
                    return false;
                }

            }else{
                Console.WriteLine("Energia Insuficiente!");
                return false;

            }
        }catch (System.Exception){
            throw;
        }
    }
}



