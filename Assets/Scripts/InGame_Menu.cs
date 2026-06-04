using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class InGame_Menu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject ResumeButton;
    [SerializeField] private GameObject ControlsMenu;
    [SerializeField] private GameObject DriveButton;
    private Level_Manager levelManager;

    private void Awake()
    {
        levelManager = GameObject.Find("Level Manager").GetComponent<Level_Manager>();
    }

    public void Pause(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(ResumeButton);
        }
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        levelManager.delete();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main_Menu");
    }
    public void Controls()
    {
        PauseMenu.SetActive(false);
        ControlsMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(DriveButton);
    }
    public void Back()
    {
        PauseMenu.SetActive(true);
        ControlsMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(ResumeButton);
    }
    public void Quit()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
