using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int coinCount = 0; // Contador de plátanos

    // Opcional: referencia a un TextMeshProUGUI para mostrar el puntaje en pantalla
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            // Si deseas que el ScoreManager persista entre escenas, descomenta la siguiente línea:
            // DontDestroyOnLoad(gameObject);
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
        UpdateUI();
    }

    // Actualiza la interfaz de usuario (si tienes una)
    private void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = coinCount.ToString();
        }
    }
}