using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamBagButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CurrentCreamShape;
    public GameObject CreamBagButtonImage, CreamBagMouse;
    public Transform creamTarget;
    public bool PickedUp;
    public void PickUpCreamBag()
    {
        CreamBagMouse.SetActive(true);
        CreamBagButtonImage.SetActive(false);
        StartCoroutine(setpickedup());

    }
    IEnumerator setpickedup()
    {
        yield return new WaitForEndOfFrame();
        PickedUp = true;
    }

    public void PutDownCreamBag()
    {
        CreamBagMouse.SetActive(false);
        CreamBagButtonImage.SetActive(true);
        PickedUp = false;
    }
    public void PlaceCream()
    {
        GameObject creamshape = Instantiate(CurrentCreamShape);
        creamshape.transform.position = creamTarget.position;
    }

    void OnMouseDown()
    {
        if (PickedUp)
        {
            PutDownCreamBag();
            Debug.Log("putdown");
        }
        else
        {
            PickUpCreamBag();
            Debug.Log("Pickup");
        }
    }



    void Start()
    {
        PickedUp = false;
        CreamBagMouse.SetActive(false);
        CreamBagButtonImage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (PickedUp)
        {
            Vector3 mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mPos = new Vector3(mPos.x, mPos.y, 0f);
            CreamBagMouse.transform.position = mPos;

            if (Input.GetMouseButtonDown(0))
            {
                PlaceCream();
                Debug.Log("place");
            }
        }

    }
}

