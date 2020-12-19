using System;
using other;
using Pathfinding;
using person.bullets;
using person.code;
using UnityEngine;

namespace eni
{
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
        private player _player;


        // Start is called before the first frame update
        private void Start()
        {
            _player = Player2.GetComponent<player>();
            StartHealth = health;

            health1 = Player2.GetComponent<health>();

            weapon = Player2.GetComponent<weapon>();

            location = gameObject.transform.position;

            path.canMove = false;
        }

        // Update is called once per frame
        private void Update()
        {
            path.maxSpeed = MoveSpeed * Time.deltaTime * 60; // fixed pathfinding speed so it goes the same speed for everyone

            if (health <= 0)
            {
                var position = transform.position;
                Instantiate(partial1, position, Quaternion.identity);

                Instantiate(partial, position, Quaternion.identity);

                Destroy(gameObject);

                health1.Health += 3;

                weapon.killed += 1;
            }

            heathdouble = (decimal)health / StartHealth;

            healthFloat = (float)heathdouble;

            //color = new Color(255, 1, 1, 1f);

            SpriteRenderer.color = new Color(1, healthFloat, healthFloat, 1);


        }


        private void FixedUpdate()
        {

            // what is the players current position
            var playerPosition = Player.position;
            // what is the my current position
            var myPosition = RB.position;

            Player1 = _player;

            switch (Player1.cloak)
            {
                case 0:
                {
                    // is the player within range
                    if (Vector2.Distance(playerPosition, myPosition) <= Range || health != StartHealth || HasBeenSeen)
                    {

                        // HasBeenSeen = true;

                        // try to look at the person
                        // what direction should i be looking
                        var lookAt = playerPosition - myPosition;
                        // what is the angle to turn?
                        var angle = Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg + 90f;
                        // rotate the player
                        RB.rotation = angle;
                        // now chase them
                        if (gameObject.CompareTag("Zombie") && image.destroy)
                        {
                            path.canMove = true;
                        }
                        if (!gameObject.CompareTag("Zombie"))
                        {
                            path.canMove = true;
                        }

                        const double tolerance = 0;
                        if (Time.time > nextActionTime && Math.Abs(TimeBetweenShootCycle - 9999) > tolerance)
                        {
                            nextActionTime = Time.time + TimeBetweenShootCycle;

                            Instantiate(Bullet1, FirePoint1.position, FirePoint1.rotation);
                        }
                    }

                    break;
                }
                case 1:
                    path.canMove = false;
                    break;
            }

            if (Player1.cloak == 0)
            {
                path.canMove = true;
            }

        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            // ouch i hit something?  was it a bullet?
            if (!col.gameObject.CompareTag("Bullet") || !gameObject.CompareTag("Eni")) return;
            var bullet = col.gameObject.GetComponent<bullet>();
            // decrease my health by the bullet damage
            health -= bullet.dmg;
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            if (!collision.gameObject.CompareTag("Player") || !gameObject.CompareTag("Zombie")) return;
            if (!(Time.time > nextActionTime7)) return;
            nextActionTime7 = Time.time + zombieAttackSpeed;
            health1.Health -= ZombieDmg;
        }

    }
}
