using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{

    public float coroutineTime = 0.1f;
    private SpriteRenderer _rend;
    // Start is called before the first frame update
    void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
        StartCoroutine(FadeOut());
    }

    // Update is called once per frame
    void Update()
    {
        
    
    
    }

    IEnumerator FadeOut()
    {
        for (float alpha = 1; alpha > 0; alpha -= Time.deltaTime)//
        {
            Color newColor = _rend.color;
            newColor.a = alpha;
            _rend.color = newColor;

            yield return new WaitForSeconds(coroutineTime);

        }
        StartCoroutine(FadeIn());

    }

    IEnumerator FadeIn()
    {
        for (float alpha = 0; alpha < 1; alpha += Time.deltaTime)
        {
            Color newColor = _rend.color;
            newColor.a = alpha;
            _rend.color = newColor;

            yield return new WaitForSeconds(coroutineTime); 
        }

        
        StartCoroutine(FadeOut());
    }



}





