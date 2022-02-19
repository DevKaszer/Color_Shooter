using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMode : MonoBehaviour
{
    [SerializeField] GameObject PanelMenu;
    private PointAndShoot point;
    float time;
    
    void Start()
    { 
       time = Time.timeScale = 1;  
    }

    void Update()
    {
        if (PanelMenu.activeSelf == true)
        {
            time = 0;
            Cursor.visible = true;        
        }
        else
        {
            time = 1;
            Cursor.visible = false;
        }
    }
}
