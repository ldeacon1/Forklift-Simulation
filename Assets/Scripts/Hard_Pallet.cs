using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard_Pallet : MonoBehaviour
{
    [SerializeField] GameObject Box1;
    [SerializeField] GameObject Box2;
    [SerializeField] GameObject Box3;
    [SerializeField] GameObject Box4;
    [SerializeField] GameObject Box5;
    [SerializeField] GameObject Box6;
    [SerializeField] GameObject Box7;
    [SerializeField] GameObject Box8;
    [SerializeField] GameObject Box9;
    private Vector3 box1_spawn;
    private Vector3 box2_spawn;
    private Vector3 box3_spawn;
    private Vector3 box4_spawn;
    private Vector3 box5_spawn;
    private Vector3 box6_spawn;
    private Vector3 box7_spawn;
    private Vector3 box8_spawn;
    private Vector3 box9_spawn;

    private Quaternion rotation_offset;

    private void Awake()
    {
        rotation_offset = transform.rotation;
        rotation_offset.y += 90f;

        box1_spawn = transform.position;
        box1_spawn.x = box1_spawn.x - 0.029f;
        box1_spawn.y = box1_spawn.y + 0.11f;
        box1_spawn.z = box1_spawn.z - 0.002f;

        box2_spawn = transform.position;
        box2_spawn.x = box2_spawn.x - 0.1574f;
        box2_spawn.y = box2_spawn.y + 0.3230002f;
        box2_spawn.z = box2_spawn.z - 0.1718999f;

        box3_spawn = transform.position;
        box3_spawn.x = box3_spawn.x - 0.1737f;
        box3_spawn.y = box3_spawn.y + 0.1644f;
        box3_spawn.z = box3_spawn.z + 0.08980006f;

        box4_spawn = transform.position;
        box4_spawn.x = box4_spawn.x + 0.1431f;
        box4_spawn.y = box4_spawn.y + 0.1981f;
        box4_spawn.z = box4_spawn.z + 0.08980006f;

        box5_spawn = transform.position;
        box5_spawn.x = box5_spawn.x + 0.138f;
        box5_spawn.y = box5_spawn.y + 0.2244f;
        box5_spawn.z = box5_spawn.z - 0.1899999f;

        box6_spawn = transform.position;
        box6_spawn.x = box6_spawn.x + 0.0582f;
        box6_spawn.y = box6_spawn.y + 0.3401f;
        box6_spawn.z = box6_spawn.z + 0.02440006f;

        box7_spawn = transform.position;
        box7_spawn.x = box7_spawn.x + 0.158f;
        box7_spawn.y = box7_spawn.y + 0.3401f;
        box7_spawn.z = box7_spawn.z + 0.05000007f;

        box8_spawn = transform.position;
        box8_spawn.x = box8_spawn.x + 0.1014f;
        box8_spawn.y = box8_spawn.y + 0.3401f;
        box8_spawn.z = box8_spawn.z + 0.1603001f;

        box9_spawn = transform.position;
        box9_spawn.x = box9_spawn.x + 0.209f;
        box9_spawn.y = box9_spawn.y + 0.3401f;
        box9_spawn.z = box9_spawn.z + 0.1603001f;
    }

    void Start()
    {
        Instantiate(Box1, box1_spawn, rotation_offset);
        Instantiate(Box2, box2_spawn, rotation_offset);
        Instantiate(Box3, box3_spawn, rotation_offset);
        Instantiate(Box4, box4_spawn, rotation_offset);
        Instantiate(Box5, box5_spawn, rotation_offset);
        Instantiate(Box6, box6_spawn, rotation_offset);
        Instantiate(Box7, box7_spawn, rotation_offset);
        Instantiate(Box8, box8_spawn, rotation_offset);
        Instantiate(Box9, box9_spawn, rotation_offset);
    }
}
