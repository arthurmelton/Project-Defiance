using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPodScript : MonoBehaviour
{
    public int AddHealth = 10;

    private int MaxHeath = 100;

    public CircleCollider2D CircleCollider2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var person = collision.gameObject.GetComponent<health>();
            if (person.Health < MaxHeath)
            {
                Destroy(gameObject);
                person.Health += AddHealth;
            }

        }
    }
}
