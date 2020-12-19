using UnityEngine;

namespace other
{
    public class talk_to_shop : MonoBehaviour
    {
        public look_at_player look_At_Player;

        public Rigidbody2D Shop;

        public Rigidbody2D RB;

        public GameObject Ui_to_disable;

        public GameObject Ui_to_enable;
        // Start is called before the first frame update
        void Start()
        {
            Ui_to_disable.SetActive(true);
            Ui_to_enable.SetActive(false);
            PlayerPrefs.SetInt("shop", 0);
        }

        // Update is called once per frame
        void Update()
        {
            // what is the players current position
            Vector2 shopPosition = Shop.position;
            // what is the my current position
            Vector2 myPosition = RB.position;

            // is the player within range
            if (Vector2.Distance(shopPosition, myPosition) <= look_At_Player.Range && Input.GetKeyDown(KeyCode.E) && Ui_to_disable.activeSelf)
            {
                Ui_to_enable.SetActive(true);
                Ui_to_disable.SetActive(false);
                PlayerPrefs.SetInt("shop", 1);
                PlayerPrefs.Save();
            }

            if (Vector2.Distance(shopPosition, myPosition) > look_At_Player.Range)
            {
                Ui_to_enable.SetActive(false);
                Ui_to_disable.SetActive(true);
                PlayerPrefs.SetInt("shop", 0);
                PlayerPrefs.Save();
            }
        }

        public void exitshop()
        {
            Ui_to_enable.SetActive(false);
            Ui_to_disable.SetActive(true);
            PlayerPrefs.SetInt("shop", 0);
            PlayerPrefs.Save();
        }
    }
}
