using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Penalty : MonoBehaviour
{
    private UI_Counters ui_Counters;

    private void Awake()
    {
        ui_Counters = GameObject.Find("ScreenSpace Canvas").GetComponent<UI_Counters>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            ui_Counters.Penalty();
        }   
    }


}
