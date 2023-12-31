using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Dialog : MonoBehaviour
{
    public GameObject character1;
    public string[] sentenceTalk;
    public TMP_Text sentenceText;
    public int index;
    public AudioSource button;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        //character1.SetActive(true);
        sentenceText.text = sentenceTalk[index];
    }

    // Update is called once per frame
    public void MoveNext()
    {
        index++;
        //character1.SetActive(true);
        sentenceText.text = sentenceTalk[index];
        button.Play();

    }

    private void Update()
    {
        if(index == sentenceTalk.Length - 1)
        {
            GameController.instance.LoadNextLevel();
        }
    }
}
