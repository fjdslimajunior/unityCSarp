using UnityEngine;

public class condicionais : MonoBehaviour
{
    /*
    OPERADORES LÓGICOS
    && (E / AND)
    || (OU / OR)
     ! (NÃO / NOT)
    */

    string humor;
    bool pizza, refrigerante;
    void Start()
    {
        // pizza = true;
        // refrigerante = true;
        humor = (pizza == true) && (refrigerante == true) ? "triste" : "feliz";
        Debug.Log(humor);

    }


}
