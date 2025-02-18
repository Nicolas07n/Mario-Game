using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platanos : MonoBehaviour
{
    // Nombre de la capa a la que pertenece el jugador
    public string playerLayerName = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica que el objeto colisionante pertenezca a la capa "Player"
        if (collision.gameObject.layer == LayerMask.NameToLayer(playerLayerName))
        {
            // Suma 1 al contador de monedas
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddCoin();
            }

            // Destruye el objeto banana, simulando que se recogió
            Destroy(gameObject);
        }
    }
}