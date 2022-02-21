using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : SwitchesPax
{
    public override void switchesAction(Collider hit)
    {      
        if (onRange)
        {
            Debug.Log("He tocao el botón");
            hit.gameObject.TryGetComponent<Box>(out Box b);
            b.ActionButton();
        }
    }
}
