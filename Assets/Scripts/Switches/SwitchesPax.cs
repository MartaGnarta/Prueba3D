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
        switchesAction(hit);
        Debug.Log("touching");
    }

    public virtual void OnTriggerExit(Collider hit)
    {
        onRange = false;
        Debug.Log("not touching");
    }

    public abstract void switchesAction(Collider hit);
}
