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
    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), 0);
    }

    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(direction.x * speed, rb2D.velocity.y);
    }


}
