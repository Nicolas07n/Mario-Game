using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Crono : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo; // Arrastra aquí el TextMeshPro en el Inspector
    private float tiempo;

    void Update()
    {
        tiempo += Time.deltaTime; // Aumenta el tiempo cada frame
        textoTiempo.text = tiempo.ToString("F2"); // Muestra con 2 decimales
    }
}
