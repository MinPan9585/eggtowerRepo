using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ButtonScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator UI_Anim;
    public AudioSource AS;
    public void StartGameButton()
    {
        SceneManager.LoadScene("DialogScene0903_1");
    }

    public void NextButton()
    {
        UI_Anim.SetTrigger("Next");
        AS.Play();
    }

    public void DoneButton100()
    {
        SceneManager.LoadScene("Ending100");
    }

    public void DoneButton70()
    {
        SceneManager.LoadScene("Ending70");
    }

    public void DoneButton20()
    {
        SceneManager.LoadScene("Ending20");
    }
}
