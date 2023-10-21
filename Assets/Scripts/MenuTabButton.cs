using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTabButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MySubMenu;
    public List<GameObject> SubMenus;
    void Start()
    {

    }

    void OnMouseDown()
    {
        foreach (GameObject obj in SubMenus)
        {
            if (obj != MySubMenu)
            {
                obj.SetActive(false);
            }
            else
            {
                obj.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
