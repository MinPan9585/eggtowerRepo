using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroAnimation : MonoBehaviour{
    public GameObject gaminitor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void  OnClick()
    {
        Debug.Log("isClick");
        gaminitor.GetComponent<Animator>().enabled = true;
    }
}
