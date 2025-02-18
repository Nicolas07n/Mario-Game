using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int coinCount = 0; // Contador de plátanos

    //pones el text mesh del platano
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
           
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Método para sumar monedas
    public void AddCoin(int amount = 1)
    {
        coinCount += amount;
        UpdateUI();//Actualiza el canvas
    }

    // Actualiza la interfaz de usuario 
    private void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = coinCount.ToString();
        }
    }
}