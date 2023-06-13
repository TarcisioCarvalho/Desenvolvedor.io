namespace Cadastro;

public class Produto
{
    public string Descricao { get; set; }

    public void ImprimirDescricao()
    {
        System.Console.WriteLine(Descricao);
    }
}