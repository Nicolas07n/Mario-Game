using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float speed = 10f;
    public GameObject target;

    void Start()
    {
        target = FindObjectOfType<Movement>().gameObject;// Busca en la escena un objeto que tenga el componente "Movement" utilizando "FindObjectOfType".
    }
    
    
    
    
    void Update()
    {
        Vector2 newPosition = Vector2.MoveTowards(transform.position,target.transform.position,speed * Time.deltaTime); 
        transform.position = newPosition;
    }
    //Sigue al jugador en todos los ejes, pero le añades gravedad



    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si colisiona con el jugador (usando la capa "Player")
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // Si la posición Y del jugador es mayor que la del enemigo (más un margen)
            if (collision.transform.position.y > transform.position.y + 0.5f)
            {
                // El jugador "pisa" al enemigo: se destruye el enemigo
                Destroy(gameObject);

                // (Opcional) Rebota al jugador: se resetea la velocidad vertical y se le aplica una fuerza hacia arriba
                Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
                if (playerRb != null)
                {
                    playerRb.velocity = new Vector2(playerRb.velocity.x, 0f);
                    playerRb.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
                }
            }
            else
            {
                // Si no, el jugador colisiona de frente: se reinicia la escena
                UnityEngine.SceneManagement.SceneManager.LoadScene(
                    UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            }
        }
    }


}

