using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
   
    public static AudioManager instance;
    private List<AudioSource> sounds;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        { 
         Destroy(gameObject);
        
        }
    }


    void Start()
    {
        sounds = new List<AudioSource>();
    }



    public AudioSource PlayAudio(AudioClip clip, string gameOnjectName, bool isLoop = false, float volumen = 1.0f)
    {
       //1 Crear Empty
        GameObject nObject = new GameObject();
        //2 ,Ponerle nombre
        nObject.name = gameOnjectName; 
        //3añadir el audiosource para
        AudioSource audioSourceComponent = nObject.AddComponent<AudioSource>();
        //4 arrastrar audioclip
        audioSourceComponent.clip = clip;
        //5
        audioSourceComponent.loop = isLoop;
        //6Regular Propiedades volumen..
        audioSourceComponent.volume = volumen;
        //7Añadimos el objeto a la lista  con el componente add
        sounds.Add(audioSourceComponent);
        //8Que suene
        audioSourceComponent.Play();
        //9cuando deje de sonar , hay que destruirlo 
        StartCoroutine(WaitForAudio(audioSourceComponent));

        return audioSourceComponent;
    }
    private IEnumerator WaitForAudio(AudioSource source)
    {
        if (source.loop)
        {
            yield return null;

        }
        else
        {
            while (source.isPlaying)
            {


                yield return new WaitForSeconds(0.3f);
            }
        }
        

        //Cuando el audio deja de sonar se destruye 
        Destroy(source.gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
