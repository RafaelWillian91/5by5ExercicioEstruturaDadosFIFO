Console.WriteLine("*********  ESTRUTURA DE DADOS FIFO ***********");


Pessoa f1 = new Pessoa();
f1.nome = "Rafael";
f1.idade = 34;


Pessoa f2 = new Pessoa();
f2.nome = "Josi";
f2.idade = 33;

f1.proximo = f2;

Console.WriteLine(f1.nome);
Console.WriteLine(f2.nome);

Console.WriteLine("-------------------------------------");

f1.nome = "Paulo";
f2.nome = "LUcio";

Console.WriteLine(f1.nome);
Console.WriteLine(f2.nome);


