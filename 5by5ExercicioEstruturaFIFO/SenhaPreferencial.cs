public class SenhaPreferencial : Senha
{

    

    public SenhaPreferencial()
    {
        identificacaoNumeroFila = "P" + Random.Shared.Next(1,1000).ToString("D3");
    }
}
