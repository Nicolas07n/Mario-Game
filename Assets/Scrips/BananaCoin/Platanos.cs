using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platanos : MonoBehaviour
{
    // Nombre de la capa a la que pertenece el jugador (asegúrate de que coincida con la configuración en Unity)
    public string playerLayerName = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comprueba si el objeto que colisiona pertenece a la capa "Player"
        if (collision.gameObject.layer == LayerMask.NameToLayer(playerLayerName))
        {
            // Aquí podrías sumar puntos o reproducir un sonido adicional, por ejemplo:
            // GameManager.Instance.AddCoin();

            // Destruye el objeto banana (simulando que se ha recogido)
            Destroy(gameObject);
        }
    }
}