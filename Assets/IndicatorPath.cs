using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorPath : MonoBehaviour
{
    GameObject obje;
    Move move;
    private Ray ray;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        pos.x = Mathf.Round(ray.origin.x);
        pos.y = Mathf.Round(ray.origin.y);
        transform.position = pos;
        if (Input.GetMouseButtonDown(0))
        {
            obje = GameObject.Find("Player");
            move = obje.GetComponent<Move>();
            move.MouseClicked(pos.x, pos.y);
        }
    }
}
