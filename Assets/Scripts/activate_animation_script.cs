using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_animation_script : MonoBehaviour
{
    
    private Animator _animator;
    private static readonly int _activate_idle = Animator.StringToHash("isActive");
    private static readonly int _activate_jumping = Animator.StringToHash("isJumping");
    private bool _isActive = true;


    private void Start()
    {
        _animator= GetComponent<Animator>();
    }


    void Update()
    {
        ActivateAnimation();
    }


    private void ActivateAnimation()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if(hit.collider != null && _isActive)
            {
               _animator.SetBool(_activate_idle, true);
                _animator.SetTrigger(_activate_jumping);
                _isActive = false;
               
            }
            else if (hit.collider != null && !_isActive)
            {
                _animator.SetBool(_activate_idle, false);
                _isActive = true;
            }
        }
    }
}
