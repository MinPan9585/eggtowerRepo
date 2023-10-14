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
    void OnMouseDown()
    {
        Debug.Log("isClick");
        gaminitor.GetComponent<Animator>().enabled = true;
        StartCoroutine("LoadNextL");
    }

    IEnumerator LoadNextL()
    {
        yield return new WaitForSeconds(4.5f);
        GameController.instance.LoadNextLevel();
    }
}
