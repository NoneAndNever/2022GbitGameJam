using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject PlayMenu;

    public void Pause()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        PlayMenu.SetActive(false);
    }
    
    public void Continue()
    {
        Time.timeScale = 1;
        PlayMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
