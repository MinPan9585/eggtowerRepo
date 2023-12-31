using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PictureTimer : MonoBehaviour
{
    public TMP_Text timerText;
    float timer = 3f;

    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = Mathf.Floor(timer).ToString();

        if (timer <= 0.1f)
        {
            GameController.instance.LoadNextLevel();
        }
    }
}
