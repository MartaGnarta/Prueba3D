using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Pax/Actions/Switch")]
public class SwitchesAction : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("Switch", true);
        //controller.SetAnimation("attack", false);
        //controller.SetAnimation("Shot", false);
    }
}
