using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigment : MonoBehaviour
{
    Vector3 mousePos;
    bool isFollowing = false;
    float radius;
    public LayerMask layerMask;
    Vector3 initialPos;
    public int id;
    bool sceneFinished = false;
    Animator anim;

    private void Start()
    {
        initialPos = transform.position;
        radius = 1f;
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    private void OnMouseDown()
    {
        isFollowing = !isFollowing;
        if (!isFollowing)
        {
            //
        }
    }

    private void Update()
    {
        if (isFollowing)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
        if (!isFollowing)
        {

            if (Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), radius, layerMask))
            {
                //play animation
                anim.enabled = true;
                anim.SetTrigger("Used");
                //ran se
                StartCoroutine(ChangeEggColor());
                PigmentColorSelected.instance.colorId = id;
            }
            else
            {
                //fly back to initial position;
            }
        }
        if (sceneFinished)
        {
            GameController.instance.LoadNextLevel();
        }
    }

    IEnumerator ChangeEggColor()
    {
        yield return new WaitForSeconds(0.6f);
        EggLiquid egg = GameObject.Find("Egg").GetComponent<EggLiquid>();
        SpriteRenderer eggRenderer = GameObject.Find("Egg").GetComponent<SpriteRenderer>();
        eggRenderer.sprite = egg.coloredEgg[id];
        yield return new WaitForSeconds(2f);
        sceneFinished = true;
    }
}
