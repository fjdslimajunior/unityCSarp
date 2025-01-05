using Unity.VisualScripting;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    // string personagem;
    int lifePlayer = 100, attackEnemy = 10, resultadoVida;


    void Start()
    {
        resultadoVida = statusPlayer(lifePlayer, attackEnemy);
        Debug.Log($"Você tomou {resultadoVida} lapada seca!");
    }


    void Update()
    {
        // StatusPlayer();
    }

    int statusPlayer(int lifePlayer, int attackEnemy)
    {
        resultadoVida = 40;
        int vidaAtual = (lifePlayer - resultadoVida) / attackEnemy;
        return vidaAtual;
    }

}
