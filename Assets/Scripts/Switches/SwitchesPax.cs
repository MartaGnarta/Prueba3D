using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SwitchesPax : MonoBehaviour
{
    protected int id;
    protected bool onRange;

    public virtual void OnTriggerEnter(Collider hit)
    {
        onRange = true;
        hit.gameObject.TryGetComponent<Box>(out Box b);        
        switchesAction(hit);
    }

    public virtual void switchesAction(Collider hit)
    {
        if (onRange)
        {
            Debug.Log("He tocao el botón");
        }
    }
}
