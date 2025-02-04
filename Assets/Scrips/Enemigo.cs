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

}

