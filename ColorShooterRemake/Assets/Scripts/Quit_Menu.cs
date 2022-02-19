using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_Menu : MonoBehaviour
{
    [SerializeField] Transform PanelMenu;

    private void Start()
    {
        PanelMenu.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {   
            PanelMenu.gameObject.SetActive(!PanelMenu.gameObject.activeSelf);
        }
    }
    public void Quit_Game()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        PanelMenu.gameObject.SetActive(!PanelMenu.gameObject.activeSelf);
    }
    public void ResumeGame()
    {
        PanelMenu.gameObject.SetActive(false);
    }

}
