using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowmotion : MonoBehaviour
{
    // Start is called before the first frame update
    void SlowMotion()
    {
        Time.timeScale = 0.5f;  // Todo el juego va a la mitad de velocidad
        Time.fixedDeltaTime = 0.5f * 0.02f;  // Ajuste para la física
    }

}
