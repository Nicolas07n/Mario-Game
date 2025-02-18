using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strairsmovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(0,y) * speed * Time.deltaTime);
    }

    private void OnEnable()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;

    }

    private void OnDisable()
    {
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }


}
