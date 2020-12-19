using UnityEngine;

namespace other
{
    public class gun_point_1 : MonoBehaviour
    {

        public int sellected;
        public Transform tran;
    
        // Start is called before the first frame update
        private void Start()
        {
            sellected = PlayerPrefs.GetInt("Selcted");

            switch (sellected)
            {
                case 1:
                case 2:
                    tran.position = new Vector3(0f, 0.5f);
                    break;
                case 4:
                    tran.position = new Vector3(0.05f, 0.53f);
                    break;
                case 5:
                    tran.position = new Vector3(0f, 0.5f);
                    break;
            }
        }

        // Update is called once per frame
    }
}
