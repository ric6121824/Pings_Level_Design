using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool closed = true;
    public float targetHeight;
    float defaultPosition;
    public float speed = 2f;

    void Start()
    {
        defaultPosition = transform.position.x;
    }

    void Update()
    {
        if (closed == true && transform.position.x > defaultPosition)
        {
            transform.position = transform.position - new Vector3(0, speed * Time.deltaTime, 0);
            if (transform.position.y < defaultPosition)
            {
                transform.position = new Vector3(transform.position.x, defaultPosition, transform.position.z);
            }
        }
        else if (closed == false && transform.position.y < targetHeight)
        {
            transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
            if (transform.position.y > targetHeight)
            {
                transform.position = new Vector3(transform.position.x, targetHeight, transform.position.z);
            }
        }
    }
    public void SetDoorState(bool newState)
    {
        closed = newState;
    }



}
