using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
   public static GameManger Instance;
    private void Awake()
    {
        //Esto es un singleton
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);//si la escena se cambia no se destruye 
        }

        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
