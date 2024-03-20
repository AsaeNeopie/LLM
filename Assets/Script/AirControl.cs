using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AirControl : MonoBehaviour
{
    [SerializeField] bool canRepulse;
    [SerializeField] float force;




    private void OnTriggerStay(Collider other)
    {
        if (other && !canRepulse)
        {
            other.GetComponent<Rigidbody>().AddForce(transform.right * force);
            Debug.Log(other);
        }
        else if (other && canRepulse == true)
        {
            other.GetComponent<Rigidbody>().AddForce(-transform.right * force);
        }
    }
}
