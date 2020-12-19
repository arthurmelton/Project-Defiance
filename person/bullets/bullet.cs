using other;
using person.code;
using UnityEngine;
using UnityEngine.Serialization;

namespace person.bullets
{
    public class bullet : MonoBehaviour
    {

        public float speed = 20f;

        [FormerlySerializedAs("RB")] public Rigidbody2D rb;

        public int dmg = 3;

        private int hardHit { get; set; } = 0;

        public int selected;

        private breakable_wall _breakableWall;

        public int gamemode;

        private health _health;


    
        // Start is called before the first frame update
        private void Start()
        {
            rb.velocity = transform.right * speed;

            gamemode = PlayerPrefs.GetInt("gamemode");

            selected = PlayerPrefs.GetInt("Selcted");

            switch (selected)
            {
                case 1:
                    dmg = 10;
                    break;
                case 2:
                    dmg = 7;
                    break;
                case 4:
                    dmg = 15;
                    break;
                case 5:
                    dmg = 2;
                    break;
            }

            hardHit = 0;

        }

        private void OnTriggerEnter2D(Collider2D col)
        {

            if(col.gameObject.CompareTag("barrel"))
            {
                col.GetComponent<barrel>().dead();
            }

            //Debug.Log(col);
            //Debug.Log(col.gameObject.name);
            if (!gameObject.CompareTag("Bullet") || col.gameObject.CompareTag("Bullet") ||
                col.gameObject.CompareTag("Player") || col.gameObject.CompareTag("EniBullet") ||
                col.gameObject.CompareTag("healthPod")) return;
            if (col.gameObject.CompareTag("destrutable_wall"))
            {
                _breakableWall = col.gameObject.GetComponent<breakable_wall>();

                _breakableWall.health -= dmg;
            }

            if (gameObject.CompareTag("Bullet") && col.gameObject.CompareTag("Eni") || col.gameObject.CompareTag("Zombie"))
            {
                var eni = col.gameObject.GetComponent<eni.eni>();
                // decrease my health by the bullet damage
                eni.health -= dmg;
            }

            Destroy(gameObject);

        }
    

    }
}
