using person.code;
using UnityEngine;
using UnityEngine.Serialization;

public class barrel : MonoBehaviour
{

    public ParticleSystem particle;
    public float radius;
    [FormerlySerializedAs("PlayerDmg")] public int playerDmg;
    [FormerlySerializedAs("EniDmg")] public int eniDmg;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EniBullet") || collision.gameObject.CompareTag("Bullet"))
        {
            dead();
        }
    }

    public void dead()
    {
        Destroy(gameObject);
        var o = gameObject;
        Instantiate(particle, o.transform.position, o.transform.rotation);
        var collider2Ds = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach(var collider2D in collider2Ds)
        {
            var health = collider2D.GetComponent<health>();
            if(health != null)
            {
                health.Health -= (int)((radius - Vector2.Distance(transform.position, collider2D.gameObject.transform.position)) * playerDmg);
            }

            var eni = collider2D.GetComponent<eni.eni>();
            if (eni != null)
            {
                eni.health -= (int)((radius - Vector2.Distance(transform.position, collider2D.gameObject.transform.position)) * eniDmg);
            }
        }
    }
}
