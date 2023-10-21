using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoration : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private bool done;

    void Start()
    {
        done = false;
    }
    void Update()
    {
        if (!done)
        {
            Vector3 mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mPos = new Vector3(mPos.x, mPos.y, 0f);
            this.transform.position = mPos;
        }

        if (Input.GetMouseButtonDown(0) && !done)
        {
            done = true;
            this.GetComponent<Decoration>().enabled = false;
        }
    }
}
