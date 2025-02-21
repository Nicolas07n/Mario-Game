using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NuevoMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Vector2 direction;
    public float speed = 1;
    
    private Vector2 dir;
    private SpriteRenderer _rend;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode leftKey = KeyCode.A;

    // Usamos un LayerMask para el suelo, similar al script de referencia.
    public LayerMask Ground;  // Asigna en el Inspector la capa de tu Tilemap Collider 2D
    private PlayerState _currentState;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        _rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), 0);

        dir = Vector2.zero;
        if (Input.GetKey(rightKey))
        {
            _rend.flipX = false;
            dir = Vector2.right;
        }
        else if (Input.GetKey(leftKey))
        {
            _rend.flipX = true;
            dir = new Vector2(-1, 0);
        }

       

       

        
    }
    void FixedUpdate()
    {
            rb2D.velocity = new Vector2(direction.x * speed, rb2D.velocity.y);
    }    
}