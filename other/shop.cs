using UnityEngine;

namespace other
{
    public class shop : MonoBehaviour
    {

        public Rigidbody2D PlayerRB;

        public Rigidbody2D RB;

        public GameObject Ui_to_disable;

        public GameObject Ui_to_enable;

        public int look_At_Player;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // what is the players current position
            Vector2 shopPosition = PlayerRB.position;
            // what is the my current position
            Vector2 myPosition = RB.position;
        
            if (Vector2.Distance(shopPosition, myPosition) <= look_At_Player && Input.GetKeyDown(KeyCode.E))
            {
                Ui_to_enable.SetActive(true);
                Ui_to_disable.SetActive(false);
                PlayerPrefs.SetInt("shop", 1);
                PlayerPrefs.Save();
            }

            if (Vector2.Distance(shopPosition, myPosition) > look_At_Player)
            {
                Ui_to_enable.SetActive(false);
                Ui_to_disable.SetActive(true);
                PlayerPrefs.SetInt("shop", 0);
                PlayerPrefs.Save();
            }
        }
    }
}
