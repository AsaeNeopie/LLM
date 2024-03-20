using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] GameObject victoryPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            victoryPanel.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
