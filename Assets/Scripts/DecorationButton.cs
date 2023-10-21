using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject decorationObj;
    void Start()
    {

    }
    void OnMouseUp()
    {
        GameObject obj = Instantiate(decorationObj);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
