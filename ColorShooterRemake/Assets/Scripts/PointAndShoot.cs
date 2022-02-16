using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    private Camera _cam;
            
        

    // Start is called before the first frame update
    void Awake()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);

        transform.up = mousePos;
    }
}
