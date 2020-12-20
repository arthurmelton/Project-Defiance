using person.bullets;
using UnityEngine;
using UnityEngine.Serialization;

namespace other
{
    public class bullet2 : MonoBehaviour
    {
        public float speed = 20f;

        public Rigidbody2D RB;

        public int dmg = 3;

        public int hardhit;

        public int selected;

        public GameObject bullet3;

        public bullet bullet1;

        public float bulletmultiplier = 2f;

        [FormerlySerializedAs("speedMultiplyer")] [FormerlySerializedAs("speedmultiplyer")]
        public float speedMultiplayer = 1f;

        private breakable_wall breakable_Wall;

        // Start is called before the first frame update
        private void Start()
        {
            RB.velocity = transform.right * speed * speedMultiplayer;

            selected = PlayerPrefs.GetInt("Selcted");

            bullet1 = bullet3.GetComponent<bullet>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            //Debug.Log(col);
            //Debug.Log(col.gameObject.name);
            if (!gameObject.CompareTag("Bullet") || col.gameObject.CompareTag("Bullet") ||
                col.gameObject.CompareTag("Player") || col.gameObject.CompareTag("EniBullet") ||
                col.gameObject.CompareTag("healthPod")) return;
            if (col.gameObject.CompareTag("destrutable_wall"))
            {
                breakable_Wall = col.gameObject.GetComponent<breakable_wall>();

                breakable_Wall.health -= dmg;
            }

            if (gameObject.CompareTag("Bullet") && col.gameObject.CompareTag("Eni") ||
                col.gameObject.CompareTag("Zombie"))
            {
                var eni = col.gameObject.GetComponent<eni.eni>();
                // decrease my health by the bullet damage

                dmg = bullet1.dmg * (int) bulletmultiplier;

                eni.health -= dmg;
            }

            Destroy(gameObject);
        }
    }
}