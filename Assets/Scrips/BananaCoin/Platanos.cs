using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platanos : MonoBehaviour
{
    // Nombre de la capa del jugador. 
    public string playerLayerName = "Player";

    // Variable pública para asignar el AudioClip en el Inspector
    public AudioClip recogidaSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica que el objeto que colisiona esté "en el jugador"
        if (collision.gameObject.layer == LayerMask.NameToLayer(playerLayerName))
        {
            // Reproduce el sonido de los platanos
            if (recogidaSound != null && AudioManager.instance != null)
            {
                AudioManager.instance.PlayAudio(recogidaSound, "RecogidaPlatano", false, 1.0f);// se reproduce el sonido 
            }

            
            
                ScoreManager.instance.AddCoin();//Suma una moneda
            

            // Destruye el objeto plátano
            Destroy(gameObject);
        }
    }
}