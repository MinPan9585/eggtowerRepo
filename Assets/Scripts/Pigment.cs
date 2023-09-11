using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigment : MonoBehaviour
{
    Vector3 mousePos;
    bool isFollowing = false;
    bool isInBowl = false;
    Vector3 initialPos;

    private void Start()
    {
        initialPos = transform.position;
    }

    private void OnMouseDown()
    {
        isFollowing = !isFollowing;
        if (!isFollowing)
        {
            //
        }
    }

    private void Update()
    {
        if (isFollowing)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
        if (!isFollowing)
        {
            if (isInBowl)
            {
                //play animation
                //ran se
            }
            else
            {
                //fly back to initial position;
            }
        }
    }
}
