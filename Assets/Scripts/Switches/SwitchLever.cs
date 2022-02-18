using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : SwitchesPax
{
    public override void OnTriggerEnter(Collider hit)
    {
        base.OnTriggerEnter(hit);
    }
    public override void switchesAction(Collider hit)
    {
        if (onRange)
        {
            Debug.Log("He tocao el level");
            hit.gameObject.TryGetComponent<Box>(out Box b);
            b.ActionLavel();
        }
    }
}
