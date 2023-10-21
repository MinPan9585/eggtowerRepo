using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class CreamSession : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CurrentCreamShape;
    public GameObject CreemBagButtonImage, CreemBagMouse;
    bool PickedUp;

    void PickUpCreemBag()
    {
        CreemBagMouse.SetActive(true);
        CreemBagButtonImage.SetActive(false);
    }

    void PutDownCreemBag()
    {
        CreemBagMouse.SetActive(false);
        CreemBagButtonImage.SetActive(true);
    }

    void Start()
    {
        PickedUp = false;
        CreemBagMouse.SetActive(false);
        CreemBagButtonImage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (PickedUp)
        {
            Vector3 mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mPos = new Vector3(mPos.x, mPos.y, 0f);
            CreemBagMouse.transform.position = mPos;
        }
    }
}
