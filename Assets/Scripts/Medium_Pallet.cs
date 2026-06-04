using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medium_Pallet : MonoBehaviour
{
    [SerializeField] GameObject Box1;
    [SerializeField] GameObject Box2;
    [SerializeField] GameObject Box3;
    [SerializeField] GameObject Box4;
    private Vector3 box1_spawn;
    private Vector3 box2_spawn;
    private Vector3 box3_spawn;
    private Vector3 box4_spawn;

    private void Awake()
    {
        box1_spawn = transform.position;
        box1_spawn.y = box1_spawn.y + 0.15347f;
        box1_spawn.z = box1_spawn.z + 0.15f;

        box3_spawn = transform.position;
        box3_spawn.y = box3_spawn.y + 0.153474f;
        box3_spawn.z = box3_spawn.z - 0.11f;
        box3_spawn.x = box3_spawn.x + 0.1f;

        box4_spawn = transform.position;
        box4_spawn.y = box4_spawn.y + 0.153474f;
        box4_spawn.z = box4_spawn.z - 0.11f;
        box4_spawn.x = box4_spawn.x - 0.1f;

        box2_spawn = transform.position;
        box2_spawn.y = box2_spawn.y + 0.3315929f;
    }

    void Start()
    {
        Instantiate(Box1, box1_spawn, transform.rotation);
        Instantiate(Box3, box3_spawn, transform.rotation);
        Instantiate(Box4, box4_spawn, transform.rotation);
        Instantiate(Box2, box2_spawn, transform.rotation);
    }
}
