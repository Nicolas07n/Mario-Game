using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NuevoMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb2D;
    
    private Vector2 direction;
    
    public float speed = 1;

    private Vector2 dir;//
    private SpriteRenderer _rend;//
    public KeyCode rightKey = KeyCode.D;  // Tecla para mover a la derecha
    public KeyCode leftKey = KeyCode.A;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
        _rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
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

    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(direction.x * speed, rb2D.velocity.y);
    }





}
