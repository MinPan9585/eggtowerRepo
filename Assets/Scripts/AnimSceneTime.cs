using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSceneTime : MonoBehaviour
{
    float timer = 10f;


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameController.instance.LoadNextLevel();
        }
    }
}
