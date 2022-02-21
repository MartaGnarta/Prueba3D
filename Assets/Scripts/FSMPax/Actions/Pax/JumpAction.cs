using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Pax/Actions/Jump")]
public class JumpAction : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("Jump", true);
        //controller.SetAnimation("attack", false);
        //controller.SetAnimation("Shot", false);
    }
}
