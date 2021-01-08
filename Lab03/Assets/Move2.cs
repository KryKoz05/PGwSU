using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
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
            end1.x = goTo.x;
            end1.y = goTo.y;
            end1.z = goTo.z + 10;
            goTo = end1;
            transform.Rotate(0f, 90f, 0);
        }

        if (transform.position == end1)
        {
            end2.x = goTo.x - 10;
            end2.y = goTo.y;
            end2.z = goTo.z;
            goTo = end2;
            transform.Rotate(0f, 90f, 0f);
        }

        if (transform.position == end2)
        {
            end3.x = goTo.x;
            end3.y = goTo.y;
            end3.z = goTo.z - 10;
            goTo = end3;
            transform.Rotate(0f, 90f, 0f);
        }

        if (transform.position == end3)
        {

            goTo = start;
            transform.Rotate(0f, -90f, 0f);
        }

        if (transform.position == start)
        {

            goTo = end;

        }

    }


}
