using UnityEngine;

public class aplicacaoTreino : MonoBehaviour
{
    int num1 = 110, num2 = 110, num3 = 100, media;
    int resto;


    /*
        Crie um programa que receba três números inteiros do usuário, calcule a média deles e mostre na tela se o resultado é maior, menor ou igual a 10.
    Dicas:
    Use variáveis para armazenar os números.
    Utilize operadores aritméticos para calcular a média.
    Use uma estrutura if-else para comparar a média com o número 10.
    Digite o primeiro número: 5
    Digite o segundo número: 7
    Digite o terceiro número: 10
    A média é 7. A média é menor que 10.

    */
    void Start()
    {
        media = (num1 + num2 + num3) / 3;

        // Debug.Log(media);
        // if (media < 7)
        // {
        //     print("você precisa estudar mais um pouco.");
        // }
        // else if (media >= 7)
        // {
        //     print("Você atingiu a média, porém não tem o necessário para se classificar para a primeiação do fim do semestre.");
        // }
        // else if (media >= 9 || media == 10)
        // {
        //     print("Você atingiu o esperado, agora está concorrendo uma viagem para LA, EUA.");
        // }
        // else
        // {
        //     print("Iniciamos o semestre.");
        // }
        resto = media % 3;
        Debug.Log(resto);
    }


}
