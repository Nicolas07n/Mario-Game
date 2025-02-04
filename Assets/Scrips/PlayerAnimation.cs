using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerAnimation : MonoBehaviour
{

    private Animator _animator;
    private Movement _Movement;

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
            case PlayerState.IDLE:_animator.SetBool("caminando", true);
                
                break;

            case PlayerState.WALKING:
                _animator.SetBool("caminando", false);
                break;
        
        
        }


    }
}
