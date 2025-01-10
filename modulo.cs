using UnityEngine;

public class modulo : MonoBehaviour
{
    //Programa que recebe um valor interio e define se ele é par ou impar usando o operador de módulo (%)
    int valorReceber = 4, resultado;
    string condicacao;

    void Start()
    {

        resultado = valorReceber % 2;
        condicacao = resultado == 0 ? "Valor par!" : "Valor impar!";
        Debug.Log(condicacao);


    }

}