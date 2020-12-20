using UnityEngine;

namespace other
{
    public class numberofeni : MonoBehaviour
    {
        public TextMesh tm;

        public int numberofeni1;

        // Start is called before the first frame update
        private void Start()
        {
            numberofeni1 -= 1;
        }

        // Update is called once per frame
        private void Update()
        {
            tm.text = numberofeni1.ToString();
        }
    }
}