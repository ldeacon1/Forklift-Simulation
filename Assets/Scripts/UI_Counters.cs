using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_Counters : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI speedtext;
    [SerializeField] TextMeshProUGUI time;
    [SerializeField] TextMeshProUGUI deliveriesText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] GameObject FailedMenu;
    [SerializeField] GameObject MenuButton;

    float time_passed = 300;
    float speed;
    int deliveries_to_make;
    int deliveries_made = 0;
    private string level;
    private Forklift forklift;
    private Level_Manager level_manager;

    private void Start()
    {
        forklift = GameObject.Find("Forklift").GetComponent<Forklift>();
        level_manager = GameObject.Find("Level Manager").GetComponent<Level_Manager>();
        deliveries_to_make = level_manager.deliveries;
        level = level_manager.level_choice;
    }
    void FixedUpdate()
    {
        speed = forklift.curSpeed;
        speedtext.text = speed.ToString();
        time_passed -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(time_passed / 60);
        int seconds = Mathf.FloorToInt(time_passed % 60);
        time.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        deliveriesText.text = deliveries_made.ToString() + " / " + deliveries_to_make.ToString();
        levelText.text = "Level: " + level.ToString(); 

        if (deliveries_made == 3)
        {
            Endgame();
        }
        if (minutes <= 0 && seconds <= 0)
        {
            Time.timeScale = 0f;
            FailedMenu.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(MenuButton);
        }
    }

    private void Endgame()
    {
        StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        UnityEngine.SceneManagement.SceneManager.LoadScene("End_Room");
    }
    public void Increment_deliveries()
    {
        deliveries_made += 1;
    }

    public void Negative_Increment()
    {
        deliveries_made -= 1;
    }

    public void Penalty()
    {
        time_passed -= 15;
    }
}
