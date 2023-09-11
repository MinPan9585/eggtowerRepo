using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigmentsFlyIn : MonoBehaviour
{
    public GameObject pigmentsSelect;

    private void Start()
    {
        StartCoroutine(EndFlyIn());
    }

    IEnumerator EndFlyIn()
    {
        yield return new WaitForSeconds(2.5f);
        this.gameObject.SetActive(false);
        pigmentsSelect.SetActive(true);
    }
}
