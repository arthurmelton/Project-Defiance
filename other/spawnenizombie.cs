using UnityEngine;

namespace other
{
    public class spawnenizombie : MonoBehaviour
    {
    
        public GameObject eni;
    
        public float nextActionTime = 0.0f;

        public float timetillnextenispawn = 10f;

        public float nextActionTime1 = 0.0f;

        public float timetillnextactiontimeislowered = 10;

        public Transform RB;

        public time time;

        public GameObject timetext;
    
        // Start is called before the first frame update
        void Start()
        {
            time = timetext.GetComponent<time>();
        }

        // Update is called once per frame
        void Update()
        {
            if(Time.time > nextActionTime) 
            {
                nextActionTime = Time.time + timetillnextenispawn;

                Instantiate(eni, RB.position, RB.rotation);

                time.round += 1;
            }

            if(Time.time > nextActionTime1) 
            {
                nextActionTime1 = Time.time + timetillnextactiontimeislowered;

                timetillnextenispawn -= 0.1f;
            }
        }
    }
}
