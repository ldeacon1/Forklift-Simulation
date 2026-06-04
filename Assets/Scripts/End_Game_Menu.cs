using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class End_Game_Menu : MonoBehaviour
{
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject ReturnButton;
   

    void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(ReturnButton);
    }
    public void LoadStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main_Menu");
    }
    public void Quit()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
