using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeBehaviour : MonoBehaviour
{
    [SerializeField] List<GameObject> spawnCol = new List<GameObject>();
    [SerializeField] GameObject Color;
    Transform pos;
    private bool canColor;
    Transform transformSpawn;
    private void Start()
    {
        GameObject firstSpawnPos = spawnCol[0];
        transformSpawn = firstSpawnPos.transform;
    }
    private void OnMouseDown()
    {
        Instantiate(Color, transformSpawn);
        Debug.Log("Clique");
    }
}
