using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Pax/Actions/Crouch")]
public class CrouchAction : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("Crouch", true);
        //controller.SetAnimation("attack", false);
        //controller.SetAnimation("Shot", false);
    }
}
