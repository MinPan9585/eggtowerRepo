using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigmentColorSelected : MonoBehaviour
{
    public static PigmentColorSelected instance;

    public int colorId;

    private void Awake()
    {
        instance = this;
    }

    public void SetColorId(int id)
    {
        colorId = id;
    }
}
