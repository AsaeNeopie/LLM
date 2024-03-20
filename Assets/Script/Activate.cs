using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    [SerializeField] List<GameObject> lasers = new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
        foreach(GameObject laser in lasers)
        {
            laser.SetActive(!laser.activeSelf);
        }
    }
}
