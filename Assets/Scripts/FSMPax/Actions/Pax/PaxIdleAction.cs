using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Pax/Actions/Idle")]
public class PaxIdleAction : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("Idle", true);
        //controller.SetAnimation("attack", false);
        //controller.SetAnimation("Shot", false);
    }
}
