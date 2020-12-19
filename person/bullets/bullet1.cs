using person.code;
using UnityEngine;

namespace person.bullets
{
    public class bullet1 : MonoBehaviour
    {

        public float speed = 20f;

        public Rigidbody2D RB;

        public int dmg = 3;

        private health Health;

        public float timetilldealeated = 15.0f;

        // Start is called before the first frame update
        void Start()
        {
            RB.velocity = transform.right * speed;

            timetilldealeated = Time.time + timetilldealeated;
        }

        void Update()
        {
            if(Time.time > timetilldealeated) 
            {
                Destroy(gameObject);
            }


        }

        void OnTriggerEnter2D(Collider2D col)
        {

            if (col.gameObject.tag == "barrel")
            {
                col.GetComponent<barrel>().dead();
            }
        
            //Debug.Log(col);
            //Debug.Log(col.gameObject.name);
            if (gameObject.tag == "EniBullet" && col.gameObject.tag != "EniBullet" && col.gameObject.tag != "Eni" && col.gameObject.tag != "Bullet" && col.gameObject.tag != "healthPod")
            {
                Destroy(gameObject);
            }

            if (col.gameObject.tag == "Player")
            {
                Health = col.gameObject.GetComponent<health>();
                Health.Health -= dmg;
            }

        }
    

    }
}
