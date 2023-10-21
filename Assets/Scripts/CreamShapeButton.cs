using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamShapeButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MyCreamShape;
    public CreamBagButton CreamScript;
    void Start()
    {

    }

    void OnMouseUp()
    {
        CreamScript.CurrentCreamShape = MyCreamShape;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
