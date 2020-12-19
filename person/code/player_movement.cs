using UnityEngine;

namespace person.code
{
    public class player_movement : MonoBehaviour
    {
        public float MoveSpeed = 5f;

        public float MoveSpeednormal;

        public Rigidbody2D RB;

        Vector2 movement;

        public Camera Cam;

        public Vector3 MousePosition;

        public int sellcted;

        private weapon Weapon;

        public GameObject player;

        private float movespeedfloat;

        public NewControls inputs;

        public Vector2 mouse;

        private float abilityOne;

        public Vector2 mouse1;

        private void Awake()
        {
            inputs = new NewControls();

            inputs.player.movement.performed += context => movement = context.ReadValue<Vector2>();

            inputs.player.movement.canceled += context => movement = new Vector2(0,0);

            inputs.player.look.performed += context => mouse = context.ReadValue<Vector2>();

            inputs.player.abilityone.performed += context => abilityOne = context.ReadValue<float>();

            inputs.player.abilityone.canceled += context => abilityOne = 0f;
        }

        private void OnEnable()
        {
            inputs.Enable();
        }
        private void OnDisable()
        {
            inputs.Disable();
        }
        // Start is called before the first frame update
        void Start()
        {
            sellcted = PlayerPrefs.GetInt("Selcted"); 

            MoveSpeednormal = MoveSpeed;

            Weapon = player.GetComponent<weapon>();
        }

        // Update is called once per frame
        void Update()
        {
            if(mouse != new Vector2(0,0))
            {
                mouse1 = mouse * 1000;
            }

            if (Weapon.hardshot == 1 && sellcted == 1) 
            {
                MoveSpeed = MoveSpeednormal / 4;
            }

            if(Weapon.hardshot == 0 && sellcted == 1) 
            {
                MoveSpeed = MoveSpeednormal;
            }

            if(sellcted == 3) 
            {
                if (abilityOne == 1)
                {
                    movespeedfloat = (float)MoveSpeednormal;

                    MoveSpeed = movespeedfloat * 1.5f;

                    Weapon.speed = 1;
                }

                else 
                {
                    MoveSpeed = 5f;

                    Weapon.speed = 0;
                }
            }

            if (PlayerPrefs.GetInt("shop") == 0)
            {
                //movement.x = Input.GetAxis("Horizontal");

                //movement.y = Input.GetAxis("Vertical");

                if(mouse.x == Mathf.Round(mouse.x) && mouse != new Vector2(0,0))
                {
                    MousePosition = Camera.main.ScreenToWorldPoint(mouse);
                }
                else
                {
                    MousePosition = gameObject.transform.position + (Vector3)mouse1;
                }

                //MousePosition = Camera.main.ScreenToWorldPoint(mouse);
            }
        

        }

        void FixedUpdate()
        {
            if (PlayerPrefs.GetInt("shop") == 0)
            {
                RB.MovePosition(RB.position + movement * MoveSpeed * Time.fixedDeltaTime);

                Vector3 PlayerLooking = MousePosition - transform.position;

                float angle = Mathf.Atan2(PlayerLooking.y, PlayerLooking.x) * Mathf.Rad2Deg - 90f;

                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
            }
        }
    }
}
