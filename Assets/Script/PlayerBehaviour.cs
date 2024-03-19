using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] float vitesseRotation;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(Vector3.right * vitesseRotation*Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(Vector3.left * vitesseRotation * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(Vector3.back * vitesseRotation * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * vitesseRotation * Time.deltaTime);
        }
    }
}
