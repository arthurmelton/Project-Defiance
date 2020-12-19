using UnityEngine;

namespace person.code
{
    public class camera_move : MonoBehaviour
    {

        public Rigidbody2D RB;

        public GameObject GameObject;

        void FixedUpdate()
        {

            RB.MovePosition(GameObject.transform.position);

        }
    }
}
