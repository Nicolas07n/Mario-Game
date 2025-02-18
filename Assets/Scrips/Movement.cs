using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Windows;




public enum PlayerState { IDLE, WALKING, JUMP }

public class Movement : MonoBehaviour
{
    // Variables públicas para configurar velocidad y fuerza de salto
    public float velocidad = 5f; // Velocidad de movimiento horizontal
    public float fuerzaSalto = 10f; // Fuerza de salto
    public LayerMask Ground;
    // Referencia al Rigidbody2D de Mario
    private Rigidbody2D rb;

    public GameObject jugador;

    public Vector3 posicionInicial;//posicion inicial del personaje

    public AudioClip jumpSound;

    // Variable para comprobar si Mario está en el suelo
    private PlayerState _currentState;



    void Start()
    {
        // Obtener el componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();

        posicionInicial = new Vector3(-8.98f, 0.14f, 0);
    }

    void Update()
    {
        // Movimiento horizontal
        float movimientoHorizontal = UnityEngine.Input.GetAxis("Horizontal");// Obtiene la entrada horizontal del usuario (teclas A/D o flechas izquierda/derecha) y la almacena en "movimientoHorizontal".
        rb.velocity = new Vector2(movimientoHorizontal * velocidad, rb.velocity.y);// Multiplica la entrada por la variable "velocidad" para determinar qué tan rápido debe moverse el objeto.
        

        // Saltar cuando se presiona la barra espaciadora y Mario está en el suelo
        if (EstaEnElSuelo())
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);

                if (jumpSound != null && AudioManager.instance != null)
                {
                    AudioManager.instance.PlayAudio(jumpSound, "JumpSound", false, 1.0f);
                }



            }





        }
        if (rb.velocity.magnitude == 0)
        {
            _currentState = PlayerState.IDLE;

        }
        else 
        {
            _currentState = PlayerState.WALKING;


        }

    
    }

    bool EstaEnElSuelo() // Para que no salte en el aire
    {
        bool outcome = Physics2D.Raycast(transform.position, Vector2.down, 1, Ground);
        return outcome;
    }
    // Realiza un Raycast desde la posición del objeto hacia abajo (Vector2.down) con un alcance de 1 unidad.
    // Comprueba si el Raycast colisiona con un objeto del tipo definido por la capa "Ground".
    // Retorna "true" si el objeto está tocando el suelo, y "false" si no lo está.
    public void ReiniciarPosicion()// Método para reiniciar la posición del jugador al punto inicial
    {
        jugador.transform.position = posicionInicial;
        rb.velocity = Vector2.zero; 
    }
    
    // Cambia la posición del objeto "jugador" a las coordenadas almacenadas en "posicionInicial".
    // Restablece la velocidad del Rigidbody "rb" a cero para detener cualquier movimiento.
    private void OnTriggerEnter2D(Collider2D collision)// Método llamado automáticamente cuando otro objeto entra en el área del Trigger Collider 2D.
    {
        // Verificar si el objeto que entra es el personaje (Mario)
        Movement personaje = collision.GetComponent<Movement>();// Verifica si el objeto que colisiona tiene el componente "Movement", indicando que es el personaje (Mario).
        if (personaje != null)
        {
            // Invocar el método para reiniciar la posición
            personaje.ReiniciarPosicion();
        }
    }
    
    
    // Si el componente "Movement" existe, llama al método "ReiniciarPosicion()" para reiniciar la posición del personaje.
    public PlayerState GetCurrentState()
        { return _currentState; }

    

    
    // Devuelve el estado actual del jugador almacenado en la variable privada "_currentState".
}


