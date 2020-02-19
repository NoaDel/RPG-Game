using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private int moveInt = 5;
    public int[] test = new int[2] { 0, 0 };
    private Vector3 pos;
    private float speed = 8.0f;
    private Transform tr;
    private float timeTurn = 0;
    private bool done;

    void Start()
    {
        transform.position = new Vector2(test[0], test[1]);
        tr = transform;
    }

    void Update()
    {
        timeTurn += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W) && tr.position == pos)
        {
            //transform.Translate(0, 1, 0);
            pos += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.A) && tr.position == pos)
        {
            //transform.Translate(-1, 0, 0);
            pos += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.S) && tr.position == pos)
        {
            //transform.Translate(0, -1, 0);
            pos += Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.D) && tr.position == pos)
        {
            //transform.Translate(1, 0, 0);
            pos += Vector3.right;
        }
        if (transform.position != pos && timeTurn > .3f)
        {
            done = false;
            timeTurn = 0;
            if ((transform.position.y - pos.y) > 0 && done == false)
            {
                //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
                done = true;
            }
            if ((transform.position.y - pos.y) < 0 && done == false)
            {
                //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                done = true;
            }
            if ((transform.position.x - pos.x) > 0 && done == false)
            {
                //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                done = true;
            }
            if ((transform.position.x - pos.x) < 0 && done == false)
            {
                //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                done = true;
            }
        }
        //transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }
    public void MouseClicked(float x, float y)
    {
        pos = new Vector3(x,y,0);
    }

}
