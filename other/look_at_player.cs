using UnityEngine;
using UnityEngine.Serialization;

namespace other
{
    public class LookAtPlayer : MonoBehaviour
    {
        [FormerlySerializedAs("RB")] public Rigidbody2D rb;
        [FormerlySerializedAs("Player")] public Rigidbody2D player;
        [FormerlySerializedAs("Range")] public int range = 5;


        // Start is called before the first frame update

        // Update is called once per frame


        private void FixedUpdate()
        {
            // what is the players current position
            var playerPosition = player.position;
            // what is the my current position
            var myPosition = rb.position;

            // try to look at the person
            // what direction should i be looking
            var lookAt = playerPosition - myPosition;
            // what is the angle to turn?
            var angle = Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg + 90f;
            // rotate the player
            rb.rotation = angle;
        }
    }
}