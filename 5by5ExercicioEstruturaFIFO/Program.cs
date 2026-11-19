Console.WriteLine("******** FILA HOSPITAL _ SÒ FALTA VOCE ************");


SenhaComum senhaNormal01 = new SenhaComum();
SenhaComum senhaNormal02 = new SenhaComum();
SenhaComum senhaNormal03 = new SenhaComum();

SenhaPreferencial senhaPreferencial01 = new SenhaPreferencial();
SenhaPreferencial senhaPreferencial02 = new SenhaPreferencial();
SenhaPreferencial senhaPreferencial03 = new SenhaPreferencial();


Fila filaNormal = new Fila();
Fila filaPrioritaria = new Fila();


filaNormal.inserirELemento(senhaNormal01);
filaNormal.inserirELemento(senhaNormal02);
filaNormal.inserirELemento(senhaNormal03);

filaPrioritaria.inserirELemento(senhaPreferencial01);
filaPrioritaria.inserirELemento(senhaPreferencial02);
filaPrioritaria.inserirELemento(senhaPreferencial03);


int contadorPreferencial = 0;

//verifica as duas filas se estao com elementos 
while (!filaPrioritaria.FilaVazia() || !filaNormal.FilaVazia())
{
    
    for (int i = 0; i < 2 && !filaPrioritaria.FilaVazia(); i++)
    {
        Console.WriteLine("Preferencial: " + filaPrioritaria.Head);
        filaPrioritaria.tirarELementoFila();
    }

    
    if (!filaNormal.FilaVazia())
    {
        Console.WriteLine("Normal: " + filaNormal.Head);
        filaNormal.tirarELementoFila();
    }
}


Console.WriteLine("Todas as senhas foram atendidas!");


