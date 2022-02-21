using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Pax/Actions/Sprint")]
public class SprintAction : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("Sprint", true);
        //controller.SetAnimation("attack", false);
        //controller.SetAnimation("Shot", false);
    }
}
