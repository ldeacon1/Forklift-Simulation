using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marker2 : MonoBehaviour
{
    [SerializeField] private Image marker;
    [SerializeField] private Transform Objective;

    private void Update()
    {
        float minX = marker.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;
        float minY = marker.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;
        Vector2 pos = Camera.main.WorldToScreenPoint(Objective.position);
        if (Vector3.Dot((Objective.position - transform.position), transform.forward) < 0)
        {
            if (pos.x < Screen.width / 2)
            {
                pos.x = maxX;
            }
            else
            {
                pos.x = minX;
            }
        }
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        marker.transform.position = pos;

    }
}
