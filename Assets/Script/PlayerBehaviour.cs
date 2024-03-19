using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] float vitesseRotation;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Rotate(Vector3.right*vitesseRotation*Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(Vector3.left*vitesseRotation * Time.deltaTime);
        }
    }
}
