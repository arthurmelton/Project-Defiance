using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public float MoveSpeednormal;

    public Rigidbody2D RB;

    Vector2 movement;

    public Camera Cam;

    Vector2 MousePosition;

    public int sellcted;

    private weapon Weapon;

    public GameObject player;

    private float movespeedfloat;
    // Start is called before the first frame update
    void Start()
    {
       sellcted = PlayerPrefs.GetInt("Selcted"); 

        MoveSpeednormal = MoveSpeed;

        Weapon = player.GetComponent<weapon>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Weapon.hardshot == 1 && sellcted == 1) 
        {
            MoveSpeed = MoveSpeednormal / 4;
        }

        if(Weapon.hardshot == 0 && sellcted == 1) 
        {
            MoveSpeed = MoveSpeednormal;
        }

        if(sellcted == 3) 
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                movespeedfloat = (float)MoveSpeednormal;

                MoveSpeed = movespeedfloat * 1.5f;

                Weapon.speed = 1;
            }

            else 
            {
                MoveSpeed = 5f;

                Weapon.speed = 0;
            }
        }

        if (PlayerPrefs.GetInt("shop") == 0)
        {
            movement.x = Input.GetAxis("Horizontal");

            movement.y = Input.GetAxis("Vertical");

            MousePosition = Cam.ScreenToWorldPoint(Input.mousePosition);
        }
        

    }

    void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("shop") == 0)
        {
            RB.MovePosition(RB.position + movement * MoveSpeed * Time.fixedDeltaTime);

            Vector2 PlayerLooking = MousePosition - RB.position;

            float angle = Mathf.Atan2(PlayerLooking.y, PlayerLooking.x) * Mathf.Rad2Deg - 90f;

            RB.rotation = angle;
        }
    }
}
