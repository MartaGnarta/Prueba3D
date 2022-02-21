using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Pax/Actions/Push")]
public class PushAction : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("Push", true);
        //controller.SetAnimation("attack", false);
        //controller.SetAnimation("Shot", false);
    }
}
