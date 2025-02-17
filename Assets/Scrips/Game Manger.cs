using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    public TextMeshProUGUI textoTiempo; // Arrastra aquí el TextMeshPro en el Inspector
    private float tiempo;

    void Update()
    {
        tiempo += Time.deltaTime; // Aumenta el tiempo cada frame
        textoTiempo.text = tiempo.ToString("F2"); // Muestra con 2 decimales
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    
}
