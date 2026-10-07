namespace NotasApp;

public class Nota
{
    public int Id { get; set; }
    public string Conteudo { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Nota {Id}: {Conteudo}";
    }
}
