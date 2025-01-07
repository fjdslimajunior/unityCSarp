using UnityEngine;

public class ternarios : MonoBehaviour
{
    int idade = 15, menorIdade = 16;
    string resultado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //uso do "?" operador ternário.
        //variavel = condição ? "" : "";
        resultado = idade > menorIdade ? "Você tem permissão!" : "Você não tem permissão!";
        Debug.Log(resultado);
    }

}
