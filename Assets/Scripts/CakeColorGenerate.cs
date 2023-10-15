using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeColorGenerate : MonoBehaviour
{
    public Sprite[] colors;

    private void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = colors[PigmentColorSelected.instance.colorId];
    }
}
