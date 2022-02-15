using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : SwitchesPax
{
    public override void OnTriggerEnter(Collider hit)
    {
        onRange = true;
        hit.gameObject.TryGetComponent<Box>(out Box b);
        b.ActionLavel();
        switchesAction(hit);
    }
    public override void switchesAction(Collider hit)
    {
        if (onRange)
        {
            Debug.Log("He tocao el level");
        }
    }
}
