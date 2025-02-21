public class Carta {
    private String Nome { get; }
    private String Descricao { get; }
    private int Custo { get; }

    public Carta(String nome, String descricao, int custo){
        this.Nome = nome;
        this.Descricao = descricao;
        this.Custo = custo; 

    }
}