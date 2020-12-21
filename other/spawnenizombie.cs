using UnityEngine;

namespace other
{
    public class spawnenizombie : MonoBehaviour
    {
        public GameObject eni;

        public float nextActionTime;

        public float timetillnextenispawn = 10f;

        public Transform RB;

        public time time;

        public GameObject timetext;

        private bool _isTimeNotNull;

        // Start is called before the first frame update
        private void Start()
        {
            _isTimeNotNull = time != null;
            time = timetext.GetComponent<time>();
        }

        // Update is called once per frame
        public void Update()
        {
            if (!(Time.time > nextActionTime)) return;
            nextActionTime = Time.time + timetillnextenispawn;
            if (_isTimeNotNull) time.round += 1;

            Instantiate(eni, RB.position, RB.rotation);
        }
    }
}