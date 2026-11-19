public class Fila
{

    public Senha Head;
    public Senha Tail;
    public int Contador = 0;
    public Fila()
    {
        Head = Tail = null;

    }

    public bool FilaVazia()
    {
        if(Head == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void inserirELemento(Senha aux)
    {
        if (FilaVazia())
        {
            Head = aux;
            Tail = aux;
        }
        else
        {
           //Tail tem um tipo senha que aponta para o proximo elemento
           Tail.proximo = aux;
           Tail = aux;
        }
        Contador++;
    }

    public void tirarELementoFila()
    {
        if (!FilaVazia())
        {
            Head = Head.proximo;
            Contador--;
        }
    }

    public void MostrarFila()
    {
        Senha s = Head;
        for (int i = 0; i < Contador; i++)
        {
            Console.WriteLine(s);
            s = s.proximo;
        }

    }

    

}
