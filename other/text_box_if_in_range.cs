using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_box_if_in_range : MonoBehaviour
{

    public Rigidbody2D player;

    public Rigidbody2D RB;

    public int range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 shopPosition = player.position;
        // what is the my current position
        Vector2 myPosition = RB.position;

        // is the player within range
        if (Vector2.Distance(shopPosition, myPosition) <= range)
        {
           
        }
    }
}
