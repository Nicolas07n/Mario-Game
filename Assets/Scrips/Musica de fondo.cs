using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicadefondo : MonoBehaviour
{
    public AudioClip musicSource;
    private bool isLoop =  true;
    public float volumen = 1.0f;
  
    
    
    
    void Start()
    {
        AudioManager.instance.PlayAudio(musicSource,"Music", isLoop,volumen);//esto es la musica
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
