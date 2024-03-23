using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] float vitesseRotation;
    [SerializeField] Camera camera;
    [SerializeField] float maxXRot;
    [SerializeField] float minXRot;
    [SerializeField] GameObject pause;
    Transform localTrans;
    
    

    private void Awake()
    {
        Time.timeScale = 1.0f;
        localTrans = GetComponent<Transform>();
    }
    private void Update()
    {
        Move();
        if (Input.GetKey(KeyCode.Escape))
        {
            pause.SetActive(true);
            Time.timeScale = 0.0f;
        }
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

        if (Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

 

   /* public static float ClampAngle(float current, float min, float max)
    {
        float dtAngle = Mathf.Abs(((min - max) + 180) % 360 - 180);
        float hdtAngle = dtAngle * 0.5f;
        float midAngle = min + hdtAngle;

        float offset = Mathf.Abs(Mathf.DeltaAngle(current, midAngle)) - hdtAngle;
        if (offset > 0)
            current = Mathf.MoveTowardsAngle(current, midAngle, offset);
        return current;
    }

    private void LimitRot()
    {
        Vector3 playerEleurAngle = localTrans.rotation.eulerAngles;
        playerEleurAngle.x = (playerEleurAngle.x < -90) ? playerEleurAngle.x - 270 : playerEleurAngle.x;
        playerEleurAngle.x = Mathf.Clamp(playerEleurAngle.x, minXRot , maxXRot);

        localTrans.rotation = Quaternion.Euler(playerEleurAngle);
    }*/
}
