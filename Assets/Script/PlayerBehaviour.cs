using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] float vitesseRotation;
    [SerializeField] Camera camera;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(camera.transform.right, vitesseRotation * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(camera.transform.right, -vitesseRotation * Time.deltaTime, Space.World) ;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back* vitesseRotation * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward, vitesseRotation * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up * vitesseRotation * Time.deltaTime, Space.World);
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * -vitesseRotation * Time.deltaTime, Space.World);
        }
    }
}
