using person.code;
using UnityEngine;
using UnityEngine.Serialization;

namespace other
{
    public class HealthPodScript : MonoBehaviour
    {
        [FormerlySerializedAs("AddHealth")] public int addHealth = 10;

        [FormerlySerializedAs("CircleCollider2D")]
        public CircleCollider2D circleCollider2D;

        private readonly int MaxHeath = 100;

        // Start is called before the first frame update

        // Update is called once per frame

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Player")) return;
            var person = collision.gameObject.GetComponent<health>();
            if (person.Health >= MaxHeath) return;
            Destroy(gameObject);
            person.Health += addHealth;
        }
    }
}