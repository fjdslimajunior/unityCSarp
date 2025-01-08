using UnityEngine;

public class condicionais : MonoBehaviour
{
    /*
    OPERADORES LÓGICOS
    && (E / AND)
    || (OU / OR)
     ! (NÃO / NOT)
    */

    //string humor;
    //bool pizza, refrigerante;
    int moeda = 50, precoPersonagem = 100;
    void Start()
    {
        // pizza = true;
        // refrigerante = true;
        /* humor = (pizza == true) || (refrigerante == false) ? "feliz" : "triste";
         Debug.Log(humor);
         
        
        */
        string resultado;
        int idade = 18, menorIdade = 16;
        resultado = idade > menorIdade ? "Maior" : "Menor";

        if (idade <= menorIdade && moeda <= precoPersonagem)
        {
            print("Passa caixa!");
        }
        else if (idade == menorIdade && moeda == precoPersonagem)
        {
            print("Vai comprar mais vai ficar liso!");
        }
        else
        {
            print(resultado);
        }


    }


}
