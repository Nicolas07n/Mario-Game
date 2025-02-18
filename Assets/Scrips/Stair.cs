using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Strairsmovement>().enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<Strairsmovement>().enabled = false;
    }


}
