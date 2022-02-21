using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SwitchesPax : MonoBehaviour
{
    protected int id;
    protected bool onRange;

    public void OnTriggerEnter(Collider hit)
    {
        onRange = true;
        switchesAction(hit);
    }

    public void OnTriggerExit(Collider hit)
    {
        onRange = false;
    }

    public abstract void switchesAction(Collider hit);
}
