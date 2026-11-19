public class SenhaComum : Senha
{

    public SenhaComum()
    {
        identificacaoNumeroFila = "N" + Random.Shared.Next(1, 1000).ToString("D3");
    }
}
