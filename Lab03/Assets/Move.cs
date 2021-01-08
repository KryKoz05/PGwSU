using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   
    public float speed;
    Vector3 end;
    Vector3 end1;
    Vector3 end2;
    Vector3 end3;
    Vector3 goTo;
    Vector3 start;
    private void Start()
    {
        start = transform.position;
        end.x = transform.position.x + 10;
        end.y = transform.position.y;
        end.z = transform.position.z;
        goTo = end;
    }
    private void FixedUpdate()
    {

        transform.position = Vector3.MoveTowards(transform.position, goTo, speed * Time.deltaTime);
        if (transform.position == end)
        {
            goTo = start;
        }
        if (transform.position == start)
        {
            goTo = end;
        }
    }
    
}
