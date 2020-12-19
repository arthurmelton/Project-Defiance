using person.bullets;
using UnityEngine;

namespace other
{
    public class bullet2 : MonoBehaviour
    {

        public float speed = 20f;

        public Rigidbody2D RB;

        public int dmg = 3;

        public int hardhit = 0;

        public int selected;

        public GameObject bullet3;

        public bullet bullet1;

        public float bulletmultiplier = 2f;

        public float speedmultiplyer = 1f;

        private breakable_wall breakable_Wall;
    
        // Start is called before the first frame update
        void Start()
        {
            RB.velocity = transform.right * speed * speedmultiplyer;

            selected = PlayerPrefs.GetInt("Selcted");

            bullet1 = bullet3.GetComponent<bullet>();

        }

        void Update()
        {


        }

        void OnTriggerEnter2D(Collider2D col)
        {
            //Debug.Log(col);
            //Debug.Log(col.gameObject.name);
            if (gameObject.tag == "Bullet" && col.gameObject.tag != "Bullet" && col.gameObject.tag != "Player" && col.gameObject.tag != "EniBullet" && col.gameObject.tag != "healthPod")
            {
                if (col.gameObject.tag == "destrutable_wall")
                {
                    breakable_Wall = col.gameObject.GetComponent<breakable_wall>();

                    breakable_Wall.health -= dmg;
                }

                if (gameObject.tag == "Bullet" && col.gameObject.tag == "Eni" || col.gameObject.tag == "Zombie")
                {
                    eni.eni Eni = col.gameObject.GetComponent<eni.eni>();
                    // decrese my health by the bullet damage

                    dmg = bullet1.dmg * (int)bulletmultiplier;

                    Eni.health -= dmg;
                }

                Destroy(gameObject);
            }

        }
    

    }
}
