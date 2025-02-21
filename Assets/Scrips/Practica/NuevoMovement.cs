using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;





public class NuevoMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Vector2 direction;
    public float speed = 1, jumpForce = 1, heightToScan = 2f;
    
    private Vector2 dir;
    private SpriteRenderer _rend;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode leftKey = KeyCode.A;

    // Usamos un LayerMask para el suelo, similar al script de referencia.
    private bool isJumping = false; 
    
    private PlayerState _currentState;//
    public LayerMask grndMask;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        _rend = GetComponent<SpriteRenderer>();
    }
    public enum PlayerState
    {
        IDLE,
        RUNNING,
        JUMPING,
        FALLING
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


    void jump()
    {
        if (Input.GetButtonDown("Jump") && EstaSuelo())
        {
            isJumping = true;
            rb2D.velocity = new Vector2(rb2D.velocity.x, 0);
            rb2D.AddForce(Vector2.up * jumpForce * rb2D.gravityScale, ForceMode2D.Impulse);
            _currentState = PlayerState.JUMPING;

        }

    }


    private bool EstaSuelo()
    {
        bool contact = Physics2D.Raycast(transform.position, Vector2.down, heightToScan, grndMask);
        isJumping = false;
        return contact;
    }

   


}