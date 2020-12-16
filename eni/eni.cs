using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pathfinding;

public class eni : MonoBehaviour
{
    public int health = 100;
    public Rigidbody2D RB;
    public Rigidbody2D Player;
    public int Range = 5;
    public float MoveSpeed = 3f;
    public Transform FirePoint1;
    public GameObject Bullet1;
    private float nextActionTime = 0.0f;
    public float TimeBetweenShootCycle = 1.0f;
    private int StartHealth;
    private bool HasBeenSeen;
    public SpriteRenderer SpriteRenderer;
    private decimal heathdouble;
    private float healthFloat;
    private player Player1;
    public GameObject Player2;
    private health health1;
    public GameObject theint;
    private numberofeni numberofeni;
    public int ZombieDmg;
    private float nextActionTime7 = 0.0f;
    public float zombieAttackSpeed = 0.2f;
    public ParticleSystem partial;
    public animationGif image;
    private Vector3 location;
    public AIPath path;
    public ParticleSystem partial1;

    private weapon weapon;


    // Start is called before the first frame update
    void Start()
    {
        StartHealth = health;

        health1 = Player2.GetComponent<health>();

        weapon = Player2.GetComponent<weapon>();

        location = gameObject.transform.position;

        path.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            Instantiate(partial1, transform.position, Quaternion.identity);

            Instantiate(partial, transform.position, Quaternion.identity);

            Destroy(gameObject);

            health1.Health += 3;

            weapon.killed += 1;
        }

        heathdouble = (decimal)health / StartHealth;

        healthFloat = (float)heathdouble;

        //color = new Color(255, 1, 1, 1f);

        SpriteRenderer.color = new Color(1, healthFloat, healthFloat, 1);


    }


    void FixedUpdate()
    {

        // what is the players current position
        Vector2 playerPosition = Player.position;
        // what is the my current position
        Vector2 myPosition = RB.position;

        Player1 = Player2.GetComponent<player>();

        if(Player1.cloak == 0)
        {
            // is the player within range
            if (Vector2.Distance(playerPosition, myPosition) <= Range || health != StartHealth || HasBeenSeen == true)
            {

                HasBeenSeen = true;

                // try to look at the person
                // what direction should i be looking
                Vector2 lookAt = playerPosition - myPosition;
                // what is the angle to trun?
                float angle = Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg + 90f;
                // rotate the player
                RB.rotation = angle;
                // now chase them
                if (gameObject.tag == "Zombie" && image.destroy == true)
                {
                    path.canMove = true;
                }
                if (gameObject.tag != "Zombie")
                {
                    path.canMove = true;
                }

                if (Time.time > nextActionTime && TimeBetweenShootCycle != 9999)
                {
                    nextActionTime = Time.time + TimeBetweenShootCycle;

                    float time = TimeBetweenShootCycle;

                    Instantiate(Bullet1, FirePoint1.position, FirePoint1.rotation);
                }
            }
        }
        
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // ouch i hit something?  was it a bullet?
        if (col.gameObject.tag == "Bullet" && gameObject.tag == "Eni")
        {
            bullet Bullet = col.gameObject.GetComponent<bullet>();
            // decrese my health by the bullet damage
            health -= Bullet.dmg;
        }

    }
    void OnCollisionStay2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Player" && gameObject.tag == "Zombie")
        {
            if (Time.time > nextActionTime7)
            {
                nextActionTime7 = Time.time + zombieAttackSpeed;
                health1.Health -= ZombieDmg;
            }
        } 
    }

}
