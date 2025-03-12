using System.Collections.Generic;

class Game {
    public List<Carta> monte;

    public List<Carta> maoJ, maoC;

    private Jogador usuario, computador;

    public Game() {
        monte = new List<Carta>();

        maoJ = new List<Carta>();
        maoC = new List<Carta>();

        monte.Add(new Ataque("Golpe Rápido"         , "Um corte veloz que fere o oponente."                       , 1, 2 ));
        monte.Add(new Ataque("Estocada Precisa"     , "Um ataque certeiro que perfura a defesa."                  , 2, 4 ));
        monte.Add(new Ataque("Machado Brutal"       , "Um golpe destruidor com machado pesado."                   , 3, 6 ));
        monte.Add(new Ataque("Espada Flamejante"    , "Um corte envolto em chamas, causando queimaduras."         , 3, 5 ));
        monte.Add(new Ataque("Flecha Venenosa"      , "Atinge o inimigo e causa dano persistente."                , 2, 3 ));
        monte.Add(new Ataque("Rajada de Gelo"       , "Um golpe congelante que reduz a movimentação."             , 3, 4 ));
        monte.Add(new Ataque("Golpe Sombrio"        , "Um ataque das trevas, consumindo energia vital."           , 4, 8 ));
        monte.Add(new Ataque("Fúria do Berserker"   , "Um ataque feroz, mas consome toda sua energia."            , 5, 10));
        monte.Add(new Ataque("Impacto Sísmico"      , "Um golpe que faz o chão tremer, atingindo em cheio."       , 6, 12));
        monte.Add(new Ataque("Lança Sombria"        , "Uma lança de energia negra atravessa o adversário."        , 4, 6 ));
        monte.Add(new Ataque("Flecha Tripla"        , "Três flechas rápidas atingem o inimigo ao mesmo tempo."    , 3, 5 ));
        monte.Add(new Ataque("Espinhos do Caos"     , "Projeta espinhos mágicos que perfuram a armadura."         , 4, 7 ));
        monte.Add(new Ataque("Trovão Arcano"        , "Um raio destruidor cai sobre o oponente."                  , 5, 9 ));
        monte.Add(new Ataque("Golpe Veloz"          , "Um ataque ágil que confunde o inimigo."                    , 2, 4 ));
        monte.Add(new Ataque("Rajada de Lâminas"    , "Várias lâminas cortam o oponente de diferentes ângulos."   , 4, 7 ));
        monte.Add(new Ataque("Garras da Fera"       , "Um ataque selvagem como de uma fera raivosa."              , 3, 5 ));
        monte.Add(new Ataque("Chamas do Inferno"    , "Um fogo intenso consome o adversário."                     , 6, 11));
        monte.Add(new Ataque("Corte Duplo"          , "Dois cortes rápidos que ignoram parte da defesa."          , 3, 5 ));
        monte.Add(new Ataque("Golpe Fantasma"       , "Uma espada espectral atinge o inimigo sem ser bloqueada."  , 5, 9 ));
        monte.Add(new Ataque("Lança de Sangue"      , "Usa o próprio sangue para fortalecer o ataque."            , 4, 7 ));
        monte.Add(new Defesa("Poção de Cura"        , "Uma poção básica que recupera energia vital."              , 2, 4 ));
        monte.Add(new Defesa("Escudo Espiritual"    , "Uma barreira de luz bloqueia ataques."                     , 3, 6 ));
        monte.Add(new Defesa("Regeneração Mágica"   , "Uma magia que regenera feridas lentamente."                , 4, 7 ));
        monte.Add(new Defesa("Cura do Druida"       , "A energia da natureza restaura suas forças."               , 3, 5 ));
        monte.Add(new Defesa("Armadura de Pedra"    , "Endurece sua pele como rocha."                             , 4, 6 ));
        monte.Add(new Defesa("Aura de Vida"         , "Um brilho sagrado envolve o corpo, curando ferimentos."    , 5, 8 ));
        monte.Add(new Defesa("Bênção dos Ancestrais", "Espíritos antigos restauram sua vitalidade."               , 6, 10));
        monte.Add(new Defesa("Meditação Interior"   , "Acalma a mente e acelera a cura natural."                  , 2, 4 ));
        monte.Add(new Defesa("Pele de Aço"          , "Fortalece a resistência física por alguns instantes."      , 3, 5 ));
        monte.Add(new Defesa("Muralha Arcana"       , "Uma barreira mágica absorve parte do impacto."             , 4, 6 ));
        monte.Add(new Defesa("Fôlego Renovado"      , "Um segundo fôlego para continuar lutando."                 , 2, 3 ));
        monte.Add(new Defesa("Reflexos Felinos"     , "Movimentos rápidos evitam golpes fatais."                  , 3, 5 ));
        monte.Add(new Defesa("Escudo Elemental"     , "Uma barreira de fogo, gelo ou trovão protege você."        , 4, 7 ));
        monte.Add(new Defesa("Proteção Divina"      , "Luz celestial fortalece sua alma."                         , 5, 9 ));
        monte.Add(new Defesa("Pele do Dragão"       , "Adquire resistência lendária temporária."                  , 6, 11));
        monte.Add(new Defesa("Poção de Vitalidade"  , "Uma mistura poderosa que restaura o vigor."                , 2, 4 ));
        monte.Add(new Defesa("Resiliência Suprema"  , "Suporta ataques com a força de um titã."                   , 5, 9 ));
        monte.Add(new Defesa("Armadura Sagrada"     , "A luz purifica seu corpo, curando feridas profundas."      , 6, 12));
        monte.Add(new Defesa("Restauração Total"    , "Uma magia suprema que regenera completamente."             , 7, 15));
        monte.Add(new Defesa("Cura Sombria"         , "Poder negro que sacrifica um pouco de energia para curar." , 4, 6 ));

        usuario = new Jogador("Jogador 1");
        usuario.GerarDeck(monte);
        usuario.PegarCartas(0);

        computador = new Jogador("Computador");
        computador.GerarDeck(monte);
        computador.PegarCartas(0);

    }



    public void Run() {
        string opcaoComputador1, opcaoUsuario1, opcaoComputador2, opcaoUsuario2, qtdCartas;

        while (usuario.Vida >= 0 && computador.Vida >= 0) {
            int rounds= 1;
            
            Console.Clear();
            Console.WriteLine("Inicio de jogo\n");

            Console.WriteLine($"Jogador      ({usuario.Nome}) - Vida: {usuario.Vida}     | Energia: {usuario.Energia}");

            Console.WriteLine("\n-----Versus-----\n");

            Console.WriteLine($"Computador ({computador.Nome}) - Vida: {computador.Vida} | Energia: {computador.Energia}\n");
            
            Console.WriteLine($"Inicio da {rounds}° rodada.\n");
            
            Console.WriteLine("Selecione uma das opções, 1-> Pegar mais cartas 2-> Ver suas cartas 3-> Restaurar energia\n");

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
                        Console.WriteLine(usuario.VerMao());

                        maoJ = usuario.getMao();

                        opcaoUsuario2 = Console.ReadLine()!;

                        switch (opcaoUsuario2) {
                            case "1":
                                Console.WriteLine($"Jogador 1 tentou usar a carta - ({maoJ.ElementAt(0).Nome})\n");
                                
                                if (maoJ.ElementAt(0).UsarCarta(usuario, computador)) maoJ.RemoveAt(0);
                                
                                else Console.WriteLine($"E nao conseguiu\n");

                                break;

                            case "2":
                                Console.WriteLine($"Jogador 1 tentou usar a carta - ({maoJ.ElementAt(1).Nome})");

                                if (maoJ.ElementAt(1).UsarCarta(usuario, computador)) maoJ.RemoveAt(1);
                                
                                else Console.WriteLine($"E nao conseguiu\n");

                                break;

                            case "3":
                                Console.WriteLine($"Jogador 1 tentou usar a carta - ({maoJ.ElementAt(2).Nome})");

                                if(maoJ.ElementAt(2).UsarCarta(usuario, computador)) maoJ.RemoveAt(2);

                                else Console.WriteLine($"E nao conseguiu\n");
                                
                                break;

                            case "4":
                                Console.WriteLine($"Jogador 1 tentou usar a carta - ({maoJ.ElementAt(3).Nome})");

                                if (maoJ.ElementAt(3).UsarCarta(usuario, computador)) maoJ.RemoveAt(3);
                                
                                else Console.WriteLine($"E nao conseguiu\n");

                                break;

                            case "5":
                                Console.WriteLine($"Jogador 1 tentou usar a carta - ({maoJ.ElementAt(4).Nome})");

                                if (maoJ.ElementAt(4).UsarCarta(usuario, computador)) maoJ.RemoveAt(4);
                                
                                else Console.WriteLine($"E nao conseguiu\n");

                                break;

                            default:
                                break;
                        }

                        break;

                    case "3":
                        Console.WriteLine("\nJogador 1 tentou recuperar energia.\n");
                        usuario.RestaurarEnergia();

                        break;

                    default:
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
                                Console.WriteLine($"Jogador 2 tentou usar a carta - ({maoC.ElementAt(0).Nome})\n");
                                if (maoC.ElementAt(0).UsarCarta(computador, usuario)) maoC.RemoveAt(0);
                                
                                else Console.WriteLine($"E nao conseguio");

                                break;

                            case "2":
                                Console.WriteLine($"Jogador 2 tentou usar a carta - ({maoC.ElementAt(1).Nome}) \n");

                                if (maoC.ElementAt(1).UsarCarta(computador, usuario)) maoC.RemoveAt(1);
                                
                                else Console.WriteLine($"E nao conseguio");

                                break;

                            case "3":
                                Console.WriteLine($"Jogador 2 tentou usar a carta - ({maoC.ElementAt(2).Nome}) \n");

                                if (maoC.ElementAt(2).UsarCarta(computador, usuario)) maoC.RemoveAt(2);
                                
                                else Console.WriteLine($"E nao conseguio");

                                break;

                            case "4":
                                Console.WriteLine($"Jogador 2 tentou usar a carta - ({maoC.ElementAt(3).Nome}) \n");

                                if (maoC.ElementAt(3).UsarCarta(computador, usuario)) maoC.RemoveAt(3);
                                
                                else Console.WriteLine($"E nao conseguio");

                                break;

                            case "5":
                                Console.WriteLine($"Jogador 2 tentou usar a carta - ({maoC.ElementAt(4).Nome}) \n");

                                if(maoC.ElementAt(4).UsarCarta(computador, usuario)) maoC.RemoveAt(4);
                                
                                else Console.WriteLine($"E nao conseguio");

                                break;


                            default:
                                break;
                        }

                        break;

                    case "3":
                        Console.WriteLine("Jogador 2 tentou recuperar energia.\n");
                        computador.RestaurarEnergia();
                        break;

                    default:
                        break;

                }

            } catch (System.Exception) {
                throw;

            }

            Console.WriteLine("\nFim do turno do Jogador 2.\n");

            Console.WriteLine($"Jogador ({usuario.Nome}) - Vida:{usuario.Vida} Energia:{usuario.Energia}   \n");
            Console.WriteLine($"Computador ({computador.Nome}) - Vida:{computador.Vida} Energia:{computador.Energia}\n");

            Console.WriteLine($"Fim da {rounds}° rodada.\n");

            Thread.Sleep(5000);
            
            rounds++;
        }

        if (usuario.Vida <= 0) Console.WriteLine($"O jogador {usuario.Nome} morreu! Fim de jogo.\n Parabens {computador.Nome}, voce venceu!");
            
        else if (computador.Vida <= 0) Console.WriteLine($"O jogador {computador.Nome} morreu! Fim de jogo.\n Parabens {usuario.Nome}, voce venceu!");

        
    }
}