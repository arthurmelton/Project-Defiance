using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at_player : MonoBehaviour
{
    public Rigidbody2D RB;
    public Rigidbody2D Player;
    public int Range = 5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {

        // what is the players current position
        Vector2 playerPosition = Player.position;
        // what is the my current position
        Vector2 myPosition = RB.position;

        // try to look at the person
        // what direction should i be looking
        Vector2 lookAt = playerPosition - myPosition;
        // what is the angle to trun?
        float angle = Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg + 90f;
        // rotate the player
        RB.rotation = angle;

        
    }

    void OnCollisionEnter2D(Collision2D col)
    {

    }
}
