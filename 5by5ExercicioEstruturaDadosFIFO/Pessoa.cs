using static System.Runtime.InteropServices.JavaScript.JSType;

public class Pessoa
{

    public string nome { get; set; }
    public int idade { get; set; }

    //cada objeto FilaPreferencial possui uma propriedade capaz
    //de armazenar a referência de outro objeto do mesmo tipo.
    public Pessoa proximo;
}

//Objeto Rafael
//├── Nome = "Rafael"
//├── Idade = 34
//└── Proximo ──────────┐
//                      ↓
//                 Objeto Josi
//                 ├── Nome = "Josi"
//                 ├── Idade = 33
//                 └── Proximo = null
