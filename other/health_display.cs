using person.code;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace other
{
    public class health_display : MonoBehaviour
    {

        [FormerlySerializedAs("Player")] public GameObject player;
        private health _health;
        [FormerlySerializedAs("healthtext")] public Text healthText;
        private health _health1;

        private void Start()
        {
            _health1 = player.GetComponent<health>();
        }

        private void Update()
        {

            _health = _health1;

            healthText.text = "Heath : " + _health.Health;
        }
    }
}
