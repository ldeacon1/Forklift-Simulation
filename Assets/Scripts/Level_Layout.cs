using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Layout : MonoBehaviour
{
    public bool Door1_Locked = true;
    public bool Door2_Locked = true;
    public bool Door3_Locked = true;
    public bool Door4_Locked = true;
    public bool Door5_Locked = true;
    public bool Door6_Locked = true;

    private Level_Manager level_manager;

    private void Awake()
    {
        level_manager = GameObject.Find("Level Manager").GetComponent<Level_Manager>();
    }

    private void Start()
    {
        
    }

}
