﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //单例 singleton
    public static GameController instance;

    public int levelIndex = 0;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadNextLevel()
    {
        levelIndex++;
        SceneManager.LoadScene(levelIndex);
    }
}
