using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ResetSCENE : MonoBehaviour
{

   
    //[SerializeField] private UnityEngine.Vector2 posicionInicial = new UnityEngine.Vector2(0, 0); // Posición inicial de Mario

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    // Verificar si el objeto que entra tiene el tag "Player"
    //    if (collision.CompareTag("Player"))
    //    {
    //        // Reiniciar la posición de Mario
    //        collision.transform.position = posicionInicial;
    //    }
    //}

    //{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comprueba si el objeto colisionante está en la capa "Player"
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // Recarga la escena actual, lo que reinicia todo, incluidos los plátanos
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
















   