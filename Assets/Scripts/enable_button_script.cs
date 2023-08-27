using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class enable_button_script : MonoBehaviour
{
    [SerializeField] private UnityEvent switchOn;
    

    private void Update()
    {
        ActivateButton();
    }

    private void ActivateButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null )
            {
                switchOn?.Invoke();

            }
        }
    }
}
