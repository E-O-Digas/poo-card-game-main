public class Carta {
    private int custo;
    private int tipo;  
    private int uso;  

    public string Descricao { get; }
    public string Nome      { get; }

    public int Custo { 
        get { return Custo; }

        private set { 
            if (Custo >= 0)
                throw new ArgumentException("Custo da carta invalido");

            custo = Custo;
         
        }
    
    }
    public int Tipo  { 
        get { return Tipo; }
        
        private set { 
            if (Tipo != 1 || Tipo != 2) 
                throw new ArgumentException("Tipo de carta invalido");

            tipo = Tipo;
        }
    
    }
    public int Uso   { 
        get { return Uso; }

        private set { 
            if (Uso >= 0) 
                throw new ArgumentException("Uso de carta invalido");

            uso = Uso; 
        }
    
    }

    public Carta(string nome, string descricao, int custo, int tipo, int uso){
        Descricao = descricao;
        Nome      = nome;

        Custo = custo;
        Tipo  = tipo;
        Uso   = uso;

    }

    public void UsarCarta ( Carta carta ) {
        if ( carta.Tipo == 1 ) {
            // Dano
            // CausarDano(carta.Uso)
        
        } else if ( carta.Tipo == 2 ) {
            // Restaurar
            // RestaurarVida(carta.Uso)
        
        }
    }
}