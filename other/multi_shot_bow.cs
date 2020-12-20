using person.code;
using UnityEngine;

namespace other
{
    public class multi_shot_bow : MonoBehaviour
    {
        public int selected;
        public float timetillnextmultshot = 10f;
        public GameObject Bullet;
        public Transform self;
        public GameObject Player;
        private float nextActionTime;
        private weapon player2;


        // Start is called before the first frame update
        private void Start()
        {
            selected = PlayerPrefs.GetInt("Selcted");

            player2 = Player.GetComponent<weapon>();

            timetillnextmultshot = player2.timetillnextmultshot;
        }

        // Update is called once per frame
        private void Update()
        {
            if (selected != 1) return;
            if (!Input.GetKey(KeyCode.LeftShift)) return;
            if (!(Time.time > nextActionTime)) return;
            nextActionTime = Time.time + timetillnextmultshot;

            Instantiate(Bullet, self.position, self.rotation);
        }
    }
}