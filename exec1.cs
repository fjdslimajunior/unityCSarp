using UnityEngine;

public class treinoAplicacao : MonoBehaviour
{
    /*
    Crie um programa que receba o preço de um produto e um percentual de desconto. Em seguida, calcule o valor final com o desconto aplicado e informe se o valor final é maior ou menor que 100 reais.

        Dicas:

        Use variáveis para armazenar o preço e o desconto.
        Calcule o valor final aplicando o desconto ao preço.
        Utilize if-else para comparar o valor final com 100 reais.
    */
    int precoProd, desconto, valorFinal;

    void Start()
    {
        precoProd = 111;
        desconto = 10 * precoProd / 100; //X% de desconto
        valorFinal = precoProd - desconto;

        if (valorFinal > 100)
        {
            print($"O {valorFinal} é maior que R$ 100,00.");
        }
        else if (valorFinal < 100)
        {
            print($"O {valorFinal} é menor que R$ 100,00.");
        }
        else
        {
            print($"esses {valorFinal} está no parâmetro normal, é igual a R$ 100,00");
        }

    }
}
