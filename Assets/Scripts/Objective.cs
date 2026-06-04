using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Objective : MonoBehaviour
{
    [SerializeField] private GameObject marker;
    private UI_Counters counters;

    private void Awake()
    {
        counters = GameObject.Find("ScreenSpace Canvas").GetComponent<UI_Counters>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pallet"))
        {
            marker.SetActive(false);
            counters.Increment_deliveries();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pallet"))
        {
            marker.SetActive(true);
            counters.Negative_Increment();
        }
    }
}
