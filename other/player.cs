using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public int selected;
    public SpriteRenderer sprite;
    public Sprite bow;
    public Sprite crossbow;
    public Sprite dual;
    public Sprite sniper;
    public Sprite uzi;
    public float cloak = 0;
    private float nextActionTime = 0.0f;
    public float timetillnextcloak = 10f;
    public float timecanholdfloat = 9f;
    private int rightnow = 0;

    private float startCloak = float.MaxValue;

    // Start is called before the first frame update
    void Start()
    {
        selected = PlayerPrefs.GetInt("Selcted");

        if (selected == 1)
        {
            sprite.sprite = bow;
        }

        if (selected == 2)
        {
            sprite.sprite = crossbow;
        }

        if (selected == 3)
        {
            sprite.sprite = dual;
        }

        if (selected == 4)
        {
            sprite.sprite = sniper;
        }

        if (selected == 5)
        {
            sprite.sprite = uzi;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (cloak == 0)
        {
            if (rightnow == 1)
            {
                nextActionTime = Time.time + timetillnextcloak;
                rightnow = 0;
            }
        }

        if (selected == 4)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    cloak = 0;
                    sprite.color = new Color(1f, 1f, 1f, 1f);
                }
                else
                {
                    if (Time.time > nextActionTime)
                    {

                        cloak = 1;

                        StartCoroutine(Cloak1());

                        sprite.color = new Color(1f, 1f, 1f, 0.5f);

                        rightnow = 1;
                    }
                }
            }
            else
            {
                cloak = 0;
                sprite.color = new Color(1f, 1f, 1f, 1f);
            }
        }
        else
        {
            cloak = 0;
            sprite.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    private IEnumerator Cloak1()
    {
        yield return new WaitForSeconds(timecanholdfloat);

        if (cloak == 1)
        {
            cloak = 0;
            sprite.color = new Color(1f, 1f, 1f, 1f);
            rightnow = 1;
        }
    }
}
