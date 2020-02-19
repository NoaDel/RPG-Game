using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }
    bool revert = false;
    // Update is called once per frame
    void Update()
    {
        //if (!Input.mousePresent)
        //{
        //    revert = RenderSettings.fog;
        //    RenderSettings.fog = enabled;
        //}
        if (Input.mousePresent)
        {
            //RenderSettings.fog = revert;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);
        }
    }
}
