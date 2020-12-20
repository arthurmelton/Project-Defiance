using UnityEngine;

namespace other
{
    public class talk_to_shop : MonoBehaviour
    {
        public LookAtPlayer look_At_Player;

        public Rigidbody2D Shop;

        public Rigidbody2D RB;

        public GameObject Ui_to_disable;

        public GameObject Ui_to_enable;

        // Start is called before the first frame update
        private void Start()
        {
            Ui_to_disable.SetActive(true);
            Ui_to_enable.SetActive(false);
            PlayerPrefs.SetInt("shop", 0);
        }

        // Update is called once per frame
        private void Update()
        {
            // what is the players current position
            var shopPosition = Shop.position;
            // what is the my current position
            var myPosition = RB.position;

            // is the player within range
            if (Vector2.Distance(shopPosition, myPosition) <= look_At_Player.range && Input.GetKeyDown(KeyCode.E) &&
                Ui_to_disable.activeSelf)
            {
                Ui_to_enable.SetActive(true);
                Ui_to_disable.SetActive(false);
                PlayerPrefs.SetInt("shop", 1);
                PlayerPrefs.Save();
            }

            if (Vector2.Distance(shopPosition, myPosition) > look_At_Player.range)
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