public class Jogador{
    public string Nome    { get; }   
    public int    Energia { get; set; }
    public int    Vida    { get; set; }

    public Jogador( string nome ){
        Energia = 10;
        Vida    = 30;
        Nome    = nome;
        
    }
}