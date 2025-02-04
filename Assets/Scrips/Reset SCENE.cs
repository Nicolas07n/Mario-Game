using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ResetSCENE : MonoBehaviour
{

   
    [SerializeField] private UnityEngine.Vector2 posicionInicial = new UnityEngine.Vector2(0, 0); // Posici�n inicial de Mario

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si el objeto que entra tiene el tag "Player"
        if (collision.CompareTag("Player"))
        {
            // Reiniciar la posici�n de Mario
            collision.transform.position = posicionInicial;
        }
    }
}













   