using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy_Pallet : MonoBehaviour
{
    [SerializeField] GameObject Box1;
    private Vector3 box1_spawn;

    private void Awake()
    {
        box1_spawn = transform.position;
        box1_spawn.y = box1_spawn.y + 0.3230002f;
    }

    void Start()
    {
        Instantiate(Box1, box1_spawn, transform.rotation);
    }
}
