using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInterruptor : SwitchesPax
{
    public override void OnTriggerEnter(Collider hit)
    {
        base.OnTriggerEnter(hit);
    }
    public override void switchesAction(Collider hit)
    {
        if (onRange)
        {
            Debug.Log("He tocao el interruptor");
            hit.gameObject.TryGetComponent<Box>(out Box b);
            b.ActionInterruptor();
        }
    }
}
