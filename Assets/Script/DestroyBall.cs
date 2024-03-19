using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }
}
