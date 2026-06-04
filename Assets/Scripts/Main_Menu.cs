using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Main_Menu : MonoBehaviour
{
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject ControlsMenu;
    [SerializeField] private GameObject DriveButton;
    [SerializeField] private GameObject LevelMenu;
    [SerializeField] private GameObject LevelButton;

    void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(StartButton);
    }
    public void LoadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game_Scene");
    }
    public void OpenControls()
    {
        MainMenu.SetActive(false);
        ControlsMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(DriveButton);
    }
    public void OpenLevel()
    {
        MainMenu.SetActive(false);
        LevelMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(LevelButton);
    }
    public void back()
    {
        ControlsMenu.SetActive(false);
        LevelMenu.SetActive(false);
        MainMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(StartButton);
    }
    public void Quit()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
    public void level1()
    {
        MainMenu.SetActive(true);
        LevelMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(StartButton);
    }
    public void level2()
    {
        MainMenu.SetActive(true);
        LevelMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(StartButton);
    }
    public void level3()
    {
        MainMenu.SetActive(true);
        LevelMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(StartButton);
    }
    public void level4()
    {
        MainMenu.SetActive(true);
        LevelMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(StartButton);
    }
    public void level5()
    {
        MainMenu.SetActive(true);
        LevelMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(StartButton);
    }
}