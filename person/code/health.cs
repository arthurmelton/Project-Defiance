using JetBrains.Annotations;
using other;
using person.bullets;
using UnityEngine;
using UnityEngine.EventSystems;

namespace person.code
{
    public class health : MonoBehaviour
    {
        public int Health = 100;

        public int startHealth;

        private bullet1 Bullet;

        public int instenthealth;

        private bullet1 Bullet1;

        private health_heart_1 health_Heart_1;

        public GameObject heald_heart1;

        private health_heart_2 health_Heart_2;

        public GameObject heald_heart2;

        private health_heart_3 health_Heart_3;

        public GameObject heald_heart3;

        private health_heart_4 health_Heart_4;

        public GameObject heald_heart4;

        private health_heart_5 health_Heart_5;

        public GameObject heald_heart5;

        public GameObject Ui_at_death;

        public GameObject Ui_To_disable;

        public ParticleSystem partial;

        public GameObject selleted;

        // Start is called before the first frame update
        void Start()
        {
            startHealth = Health;
            health_Heart_1 = heald_heart1.GetComponent<health_heart_1>();
            health_Heart_1.maxPlayerHealth = startHealth;
            health_Heart_2 = heald_heart2.GetComponent<health_heart_2>();
            health_Heart_2.maxPlayerHealth = startHealth;
            health_Heart_3 = heald_heart3.GetComponent<health_heart_3>();
            health_Heart_3.maxPlayerHealth = startHealth;
            health_Heart_4 = heald_heart4.GetComponent<health_heart_4>();
            health_Heart_4.maxPlayerHealth = startHealth;
            health_Heart_5 = heald_heart5.GetComponent<health_heart_5>();
            health_Heart_5.maxPlayerHealth = startHealth;
            Ui_at_death.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        

            if (Health <= 0)
            {
                Instantiate(partial, transform.position, Quaternion.identity);

                Destroy(gameObject);

                Ui_at_death.SetActive(true);
                Ui_To_disable.SetActive(false);
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(selleted);
            }

            if (Health > 100)
            {
                Health = 100;
            }
        }  

        public void healthin()
        {
            if (Health != 100)
            {
                Health += instenthealth;
            }
        }

        void OnCollisionEnter2D([NotNull] Collision2D collision)
        {
            if (!collision.gameObject.CompareTag("EniBullet")) return;
            Bullet1 = collision.gameObject.GetComponent<bullet1>();
            Health -= Bullet1.dmg;

        }
    }
}
