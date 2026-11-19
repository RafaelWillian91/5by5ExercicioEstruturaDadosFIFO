public abstract class Senha
{
    public string identificacaoNumeroFila { get; set; }
    public Senha proximo;


    public override string ToString()
    {
        return $"Chamando senha - {identificacaoNumeroFila}";
    }
}