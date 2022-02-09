using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour
{
    [SerializeField]
    private float forceMagnitude;

    private Box _box;

    Transform tempTrans;

    private void Awake()
    {
        _box = GetComponent<Box>();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if (rigidbody != null)
        {           
            if (Input.GetMouseButtonDown(0))
            {
                hit.transform.SetParent(transform);
                hit.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
                _box.holding = true;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                _box.holding = false;
                hit.transform.SetParent(null);                
            }
            
            //Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            //forceDirection.y = 0;
            //forceDirection.Normalize();

            //rigidbody.AddForce(forceDirection * forceMagnitude, ForceMode.Force);
        }

        // Hacer un raycast hacia abajo que cuando detecte que no hay suelo DESBLOQUEAR la Y del rigidbody. Y que MIENTRAS esté tocando suelo que BLOQUEE la Y.
    }
}
