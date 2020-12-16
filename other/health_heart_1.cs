using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_heart_1 : MonoBehaviour
{

    public GameObject Player;

    private health Player_health;

    public int Max_Player_health;

    private double health_thing;

    private float heath_thing3;

    private decimal health_thing2;

    public Rigidbody2D RB;

    public Transform heart;

    // Start is called before the first frame update
    void Start()
    {
        Player_health = Player.GetComponent<health>();

        Max_Player_health = Player_health.startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Player_health = Player.GetComponent<health>();

        if (Player_health.Health >= ((Max_Player_health / 5)))
        {
            heart = transform.Find("heart_red_1");

            heart.localScale = new Vector3(0.76f, 0.7875f);
        }

        if (Player_health.Health < (Max_Player_health / 5))
        {
            
            health_thing = (Player_health.Health * 3.8);

            health_thing2 = (decimal)health_thing / Max_Player_health;

            heath_thing3 = (float)health_thing2;

            Transform heart1 = transform.Find("heart_red_1");

            heart1.localScale = new Vector3(heath_thing3, 0.7875f);
        }
    }
}
