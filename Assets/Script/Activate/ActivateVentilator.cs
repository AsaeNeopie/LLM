using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateVentilator : MonoBehaviour
{
    [SerializeField] List<GameObject> ventilators = new List<GameObject>();
    private Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject ventilator in ventilators)
        {
            ventilator.SetActive(!ventilator.activeSelf);
        }
    }
}
