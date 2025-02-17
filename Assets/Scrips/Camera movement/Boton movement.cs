using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botonmovement : MonoBehaviour
{
    public void CambiarANuevaEscena()
    {
        SceneManager.LoadScene("Carga de pantalla");
        
    }
}