using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Level_Manager : MonoBehaviour
{
    public string level_choice = "1";
    public int deliveries = 3;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void level1()
    {
        level_choice = "1";
        deliveries = 3;
    }
    public void level2()
    {
        level_choice = "2";
        deliveries = 3;
    }
    public void level3()
    {
        level_choice = "3";
        deliveries = 3;
    }
    public void level4()
    {
        level_choice = "4";
        deliveries = 3;
    }
    public void level5()
    {
        level_choice = "5";
        deliveries = 3;
    }

    public void delete()
    {
        Destroy(this.gameObject);
    }
}
