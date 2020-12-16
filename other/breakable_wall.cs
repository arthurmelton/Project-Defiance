using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakable_wall : MonoBehaviour
{

    public int health = 15;

    private bullet Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Bullet = col.gameObject.GetComponent<bullet>();

            health -= Bullet.dmg;
        }

    }
}
