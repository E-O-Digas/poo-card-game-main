using System.Collections.Generic;
using System.ComponentModel;

class Game {
    public List<Carta> monte;

    public List<Carta> maoJ, maoC;

    private Jogador usuario, computador;

    public Game() {
        monte = new List<Carta>();

        maoJ = new List<Carta>();
        maoC = new List<Carta>();

        monte.Add(new Ataque("Golpe Rápido"         , "Um corte veloz que fere o oponente."                       , 1, "02" ));
        monte.Add(new Ataque("Estocada Precisa"     , "Um ataque certeiro que perfura a defesa."                  , 2, "04" ));
        monte.Add(new Ataque("Machado Brutal"       , "Um golpe destruidor com machado pesado."                   , 3, "06" ));
        monte.Add(new Ataque("Espada Flamejante"    , "Um corte envolto em chamas, causando queimaduras."         , 3, "05" ));
        monte.Add(new Ataque("Flecha Venenosa"      , "Atinge o inimigo e causa dano persistente."                , 2, "03" ));
        monte.Add(new Ataque("Rajada de Gelo"       , "Um golpe congelante que reduz a movimentação."             , 3, "04" ));
        monte.Add(new Ataque("Golpe Sombrio"        , "Um ataque das trevas, consumindo energia vital."           , 4, "08" ));
        monte.Add(new Ataque("Fúria do Berserker"   , "Um ataque feroz, mas consome toda sua energia."            , 5, "10" ));
        monte.Add(new Ataque("Impacto Sísmico"      , "Um golpe que faz o chão tremer, atingindo em cheio."       , 6, "12" ));
        monte.Add(new Ataque("Lança Sombria"        , "Uma lança de energia negra atravessa o adversário."        , 4, "06" ));
        monte.Add(new Ataque("Flecha Tripla"        , "Três flechas rápidas atingem o inimigo ao mesmo tempo."    , 3, "05" ));
        monte.Add(new Ataque("Espinhos do Caos"     , "Projeta espinhos mágicos que perfuram a armadura."         , 4, "07" ));
        monte.Add(new Ataque("Trovão Arcano"        , "Um raio destruidor cai sobre o oponente."                  , 5, "09" ));
        monte.Add(new Ataque("Golpe Veloz"          , "Um ataque ágil que confunde o inimigo."                    , 2, "04" ));
        monte.Add(new Ataque("Rajada de Lâminas"    , "Várias lâminas cortam o oponente de diferentes ângulos."   , 4, "07" ));
        monte.Add(new Ataque("Garras da Fera"       , "Um ataque selvagem como de uma fera raivosa."              , 3, "05" ));
        monte.Add(new Ataque("Chamas do Inferno"    , "Um fogo intenso consome o adversário."                     , 6, "11" ));
        monte.Add(new Ataque("Corte Duplo"          , "Dois cortes rápidos que ignoram parte da defesa."          , 3, "05" ));
        monte.Add(new Ataque("Golpe Fantasma"       , "Uma espada espectral atinge o inimigo sem ser bloqueada."  , 5, "09" ));
        monte.Add(new Ataque("Lança de Sangue"      , "Usa o próprio sangue para fortalecer o ataque."            , 4, "07" ));
        monte.Add(new Defesa("Poção de Cura"        , "Uma poção básica que recupera energia vital."              , 2, "04" ));
        monte.Add(new Defesa("Escudo Espiritual"    , "Uma barreira de luz bloqueia ataques."                     , 3, "06" ));
        monte.Add(new Defesa("Regeneração Mágica"   , "Uma magia que regenera feridas lentamente."                , 4, "07" ));
        monte.Add(new Defesa("Cura do Druida"       , "A energia da natureza restaura suas forças."               , 3, "05" ));
        monte.Add(new Defesa("Armadura de Pedra"    , "Endurece sua pele como rocha."                             , 4, "06" ));
        monte.Add(new Defesa("Aura de Vida"         , "Um brilho sagrado envolve o corpo, curando ferimentos."    , 5, "08" ));
        monte.Add(new Defesa("Bênção dos Ancestrais", "Espíritos antigos restauram sua vitalidade."               , 6, "10" ));
        monte.Add(new Defesa("Meditação Interior"   , "Acalma a mente e acelera a cura natural."                  , 2, "04" ));
        monte.Add(new Defesa("Pele de Aço"          , "Fortalece a resistência física por alguns instantes."      , 3, "05" ));
        monte.Add(new Defesa("Muralha Arcana"       , "Uma barreira mágica absorve parte do impacto."             , 4, "06" ));
        monte.Add(new Defesa("Fôlego Renovado"      , "Um segundo fôlego para continuar lutando."                 , 2, "03" ));
        monte.Add(new Defesa("Reflexos Felinos"     , "Movimentos rápidos evitam golpes fatais."                  , 3, "05" ));
        monte.Add(new Defesa("Escudo Elemental"     , "Uma barreira de fogo, gelo ou trovão protege você."        , 4, "07" ));
        monte.Add(new Defesa("Proteção Divina"      , "Luz celestial fortalece sua alma."                         , 5, "09" ));
        monte.Add(new Defesa("Pele do Dragão"       , "Adquire resistência lendária temporária."                  , 6, "11" ));
        monte.Add(new Defesa("Poção de Vitalidade"  , "Uma mistura poderosa que restaura o vigor."                , 2, "04" ));
        monte.Add(new Defesa("Resiliência Suprema"  , "Suporta ataques com a força de um titã."                   , 5, "09" ));
        monte.Add(new Defesa("Armadura Sagrada"     , "A luz purifica seu corpo, curando feridas profundas."      , 6, "12" ));
        monte.Add(new Defesa("Restauração Total"    , "Uma magia suprema que regenera completamente."             , 7, "15" ));
        monte.Add(new Defesa("Cura Sombria"         , "Poder negro que sacrifica um pouco de energia para curar." , 4, "06" ));

        usuario = new Jogador("Jogador 1");
        usuario.GerarDeck(monte);
        usuario.PegarCartas(0);

        computador = new Jogador("Computador");
        computador.GerarDeck(monte);
        computador.PegarCartas(0);

    }



    public void Run() {
        int rounds= 1;
            
        string opcaoComputador1, opcaoUsuario1, opcaoComputador2, opcaoUsuario2, qtdCartas;

        while (usuario.Vida >= 0 && computador.Vida >= 0) {            
            Console.Clear();
            Console.WriteLine("Inicio de jogo\n");

            Console.WriteLine($"Jogador    ({usuario.Nome})  - Vida: {usuario.Vida} | Energia: {usuario.Energia}\n");
            Console.WriteLine("---------------Versus---------------\n");
            Console.WriteLine($"Computador ({computador.Nome}) - Vida: {computador.Vida} | Energia: {computador.Energia}\n");
            
            Console.WriteLine($"Inicio da {rounds}° rodada.\n");
            
            Console.WriteLine("Selecione uma das opções, 1-> Pegar mais cartas 2-> Ver suas cartas 3-> Restaurar energia");

            try {
                opcaoUsuario1 = Console.ReadLine()!;

                switch (opcaoUsuario1) {
                    case "1":
                        Console.WriteLine("\nDigite a quantidade de cartas a serem pegas do Deck: ");
                        qtdCartas = Console.ReadLine()!;

                        Console.WriteLine($"\nJogador 1 pegou mais {qtdCartas} cartas");
                        usuario.PegarCartas(int.Parse(qtdCartas));

                        break;

                    case "2":
                        maoJ = usuario.getMao();
                        VerMao(maoJ);

                        opcaoUsuario2 = Console.ReadLine()!;

                        switch (opcaoUsuario2) {
                            case "1":
                                ShowAction(usuario, computador, maoJ, 0);
                                break;

                            case "2":
                                ShowAction(usuario, computador, maoJ, 1);
                                break;

                            case "3":
                                ShowAction(usuario, computador, maoJ, 2);
                                break;

                            case "4":
                                ShowAction(usuario, computador, maoJ, 3);
                                break;

                            case "5":
                                ShowAction(usuario, computador, maoJ, 4);
                                break;

                            default:
                                Console.WriteLine("\nJogador 1 nao usou nenhuma carta.\n");
                                break;
                        }

                        break;

                    case "3":
                        Console.WriteLine("\nJogador 1 tentou recuperar energia.\n");
                        usuario.RestaurarEnergia();

                        break;

                    default:
                        Console.WriteLine("\nJogador 1 passou a vez.\n");
                        break;

                }
            } catch (System.Exception) {
                throw;

            }

            Console.WriteLine("Fim do turno do Jogador 1.\n");

            try {
                maoC = computador.getMao();

                if (computador.Energia <= 7)
                    opcaoComputador1 = "3";

                else if (maoC.Count() > 0)
                    opcaoComputador1 = "2";
                
                else
                    opcaoComputador1 = "1";
                

                switch (opcaoComputador1) {
                    case "1":
                        Console.WriteLine("\nJogador 2 pegou mais cartas");

                        computador.PegarCartas(5);

                        break;

                    case "2":
                        Random random = new Random();

                        opcaoComputador2 = random.Next(1, maoC.Count).ToString();

                        switch (opcaoComputador2)
                        {
                            case "1":
                                ShowAction(computador, usuario, maoC, 0);
                                break;

                            case "2":
                                ShowAction(computador, usuario, maoC, 1);
                                break;

                            case "3":
                                ShowAction(computador, usuario, maoC, 2);
                                break;

                            case "4":
                                ShowAction(computador, usuario, maoC, 3);
                                break;

                            case "5":
                                ShowAction(computador, usuario, maoC, 4);
                                break;


                            default:
                                Console.WriteLine("\nJogador 2 nao usou nenhuma carta.");
                                break;
                        }

                        break;

                    case "3":
                        Console.WriteLine("\nJogador 2 tentou recuperar energia.\n");
                        computador.RestaurarEnergia();
                        break;

                    default:
                        Console.WriteLine("\nJogador 2 passou a vez.\n");
                        break;

                }

            } catch (System.Exception) {
                throw;

            }

            Console.WriteLine("Fim do turno do Jogador 2.\n");

            Console.WriteLine($"Jogador    ({usuario.Nome})  - Vida:{usuario.Vida} Energia:{usuario.Energia}\n");
            Console.WriteLine($"Computador ({computador.Nome}) - Vida:{computador.Vida} Energia:{computador.Energia}\n");
            Console.WriteLine($"\nFim da {rounds}° rodada.\n");

            Thread.Sleep(8000);

            rounds++;
        }

        if (usuario.Vida <= 0) Console.WriteLine($"O jogador {usuario.Nome} morreu! Fim de jogo.\n Parabens {computador.Nome}, voce venceu!");
            
        else if (computador.Vida <= 0) Console.WriteLine($"O jogador {computador.Nome} morreu! Fim de jogo.\n Parabens {usuario.Nome}, voce venceu!");
        
    }

    private void ShowAction(Jogador jogador, Jogador oponente, List<Carta> maoU, int pos){
        Carta carta = maoU.ElementAt(pos);
        
        Console.WriteLine($"O {jogador.Nome} tentou usar a carta - ({carta.Nome})");

        if (carta.UsarCarta(jogador, oponente)) {
            if (carta.GetType() == typeof(Ataque)) {
                Ataque c = (Ataque) Convert.ChangeType(carta, typeof(Ataque));
                
                Console.WriteLine($"Causando {c.Dano} pontos de vida ao {oponente.Nome}");

            } else {
                Defesa c = (Defesa) Convert.ChangeType(carta, typeof(Defesa));

                Console.WriteLine($"Recuperando {c.Vida} pontos de vida");

            }
            
            maoU.RemoveAt(pos);
        
        }
                                    
        else Console.WriteLine($"E nao conseguiu\n");
    }

    private void VerMao(List<Carta> mao) {
        for (int item = 0; item < mao.Count; item++) {
            Carta carta = mao.ElementAt(item);

            if (carta.GetType() == typeof(Ataque)) {
                Ataque c = (Ataque) Convert.ChangeType(carta, typeof(Ataque));
            
                Console.WriteLine($"{item+1}° Carta - Custo: {c.Custo} Dano: {c.Dano.ToString()} Nome: {c.Nome}");

            } else {
                Defesa c = (Defesa) Convert.ChangeType(carta, typeof(Defesa));

                Console.WriteLine($"{item+1}° Carta - Custo: {c.Custo} Vida: {c.Vida.ToString()} Nome: {c.Nome}");

            }
        }
    }
}