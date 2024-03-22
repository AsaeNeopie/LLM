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
        if (other.tag == "Ball" && !canRepulse)
        {
            other.GetComponent<Rigidbody>().AddForce(transform.right * force);
        }
        else if (other.tag == "Ball" && canRepulse == true)
        {
            other.GetComponent<Rigidbody>().AddForce(-transform.right * force);
        }
    }
}
