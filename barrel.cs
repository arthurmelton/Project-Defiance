using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour
{

    public ParticleSystem particle;
    public float radius;
    public int PlayerDmg;
    public int EniDmg;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EniBullet" || collision.gameObject.tag == "Bullet")
        {
            dead();
        }
    }

    public void dead()
    {
        Destroy(gameObject);
        Instantiate(particle, gameObject.transform.position, gameObject.transform.rotation);
        Collider2D[] collider2Ds = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach(Collider2D collider2D in collider2Ds)
        {
            health health = collider2D.GetComponent<health>();
            if(health != null)
            {
                health.Health -= (int)((radius - Vector2.Distance(transform.position, collider2D.gameObject.transform.position)) * PlayerDmg);
            }

            eni eni = collider2D.GetComponent<eni>();
            if (eni != null)
            {
                eni.health -= (int)((radius - Vector2.Distance(transform.position, collider2D.gameObject.transform.position)) * EniDmg);
            }
        }
    }
}
