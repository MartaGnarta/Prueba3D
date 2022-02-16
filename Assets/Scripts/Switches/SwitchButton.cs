using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : SwitchesPax
{
    public override void OnTriggerEnter(Collider hit)
    {
        base.OnTriggerEnter(hit);
        base.b.ActionButton();

    }
    public override void switchesAction()
    {
        base.switchesAction();
    }
}
