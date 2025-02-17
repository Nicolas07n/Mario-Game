using System.Collections;
using System.Collections.Generic;
using UnityEngine;




using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private Movement _Movement;

    public AudioClip pewClip; // Se declara correctamente la variable AudioClip

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _Movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (_Movement.GetCurrentState())
        {
            case PlayerState.IDLE:
                _animator.SetBool("caminando", false); // Corregido: IDLE no camina
                break;

            case PlayerState.WALKING:
                _animator.SetBool("caminando", true); // Corregido: WALKING sí camina
                break;
        }
    }

    public void PlaySound(float volume)
    {
        if (pewClip != null)
        {
            AudioManager.instance.PlayAudio(pewClip, "sfx", false, volume);
        }
        else
        {
            Debug.LogWarning("pewClip no está asignado en PlayerAnimation.");
        }
    }
}
