using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platanos : MonoBehaviour
{
    // Nombre de la capa del jugador. Asegúrate de que coincida en Unity.
    public string playerLayerName = "Player";

    // Variable pública para asignar el AudioClip en el Inspector
    public AudioClip recogidaSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica que el objeto que colisiona esté en la capa "Player"
        if (collision.gameObject.layer == LayerMask.NameToLayer(playerLayerName))
        {
            // Reproduce el sonido de recogida, si se ha asignado y existe el AudioManager
            if (recogidaSound != null && AudioManager.instance != null)
            {
                AudioManager.instance.PlayAudio(recogidaSound, "RecogidaPlatano", false, 1.0f);
            }

            // Sumar puntos o actualizar el contador, por ejemplo:
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddCoin();
            }

            // Destruye el objeto plátano
            Destroy(gameObject);
        }
    }
}