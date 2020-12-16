using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int Health = 100;

    public int startHealth;

    private bullet1 Bullet;

    public int instenthealth;

    private bullet1 Bullet1;

    private health_heart_1 health_Heart_1;

    public GameObject heald_heart1;

    private health_heart_2 health_Heart_2;

    public GameObject heald_heart2;

    private health_heart_3 health_Heart_3;

    public GameObject heald_heart3;

    private health_heart_4 health_Heart_4;

    public GameObject heald_heart4;

    private health_heart_5 health_Heart_5;

    public GameObject heald_heart5;

    public GameObject Ui_at_death;

    public GameObject Ui_To_disable;

    public ParticleSystem partial;

    // Start is called before the first frame update
    void Start()
    {
        startHealth = Health;
        health_Heart_1 = heald_heart1.GetComponent<health_heart_1>();
        health_Heart_1.Max_Player_health = startHealth;
        health_Heart_2 = heald_heart2.GetComponent<health_heart_2>();
        health_Heart_2.Max_Player_health = startHealth;
        health_Heart_3 = heald_heart3.GetComponent<health_heart_3>();
        health_Heart_3.Max_Player_health = startHealth;
        health_Heart_4 = heald_heart4.GetComponent<health_heart_4>();
        health_Heart_4.Max_Player_health = startHealth;
        health_Heart_5 = heald_heart5.GetComponent<health_heart_5>();
        health_Heart_5.Max_Player_health = startHealth;
        Ui_at_death.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Health <= 0)
        {
            Instantiate(partial, transform.position, Quaternion.identity);

            Destroy(gameObject);

            Ui_at_death.SetActive(true);
            Ui_To_disable.SetActive(false);
        }

        if (Health > 100)
        {
            Health = 100;
        }
    }  

    public void healthin()
    {
        if (Health != 100)
        {
            Health += instenthealth;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EniBullet")
        {
            Bullet1 = collision.gameObject.GetComponent<bullet1>();
            Health -= Bullet1.dmg;
        }

    }
}
