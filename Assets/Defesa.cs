public class Defesa : Carta
{
    public int Vida { get; }

    public Defesa(string nome, string descricao, int custo, int vida) : base(nome, descricao, custo)
    {
        Vida = vida;

    }

    public override bool UsarCarta(Jogador jogador, Jogador oponente)
    {
        try
        {
            if(jogador.RestaurarVida(this))
            {
                if(jogador.ConsumirEnergia(this)) {
                    Console.WriteLine($"O {jogador.Nome} recuperou {Vida} de vida e consumiu {Custo}");
                    return true;

                }

                else {
                    Console.WriteLine("Energia Insuficiente!");
                    return false;

                }
            }

            else {
                Console.WriteLine("Vida ja cheia!");
                return false;

            };

        }
        catch (System.Exception)
        {

            throw;
        }
    }
}