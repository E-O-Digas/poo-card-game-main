public class Ataque : Carta
{
    public int Dano { get; }

    public Ataque(string nome, string descricao, int custo, int dano) : base(nome, descricao, custo)
    {
        Dano = dano;

    }

    public override bool UsarCarta(Jogador jogador, Jogador oponente)
    {
        try
        {
            if (!oponente.ReceberDano(this))
            {
                Console.WriteLine($"{jogador.Nome} venceu. Fim de combate");
                return false;

            }
            else
            {
                if (jogador.ConsumirEnergia(this))
                {
                    Console.WriteLine($"Dano causado ao {oponente.Nome} de {Dano} e consumiu {Custo} de energia");
                    return true;

                }
                else
                {
                    Console.WriteLine("Energia Insuficiente!");
                    return false;

                }

            }

        }
        catch (System.Exception)
        {

            throw;
        }

    }
}