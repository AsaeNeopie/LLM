using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetStar : MonoBehaviour
{
    [SerializeField] TMP_Text starText;
    private int starCount;
    private void Awake()
    {
        starCount = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        starCount++;
        starText.text = starCount.ToString();
    }
}
