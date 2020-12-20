using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace other
{
    public class player : MonoBehaviour
    {
        public int selected;
        public SpriteRenderer sprite;
        public Sprite bow;
        public Sprite crossbow;
        public Sprite dual;
        public Sprite sniper;
        public Sprite uzi;
        public float cloak;

        [FormerlySerializedAs("timetillnextcloak")]
        public float timeTillNextCloak = 10f;

        [FormerlySerializedAs("timecanholdfloat")]
        public float timeCanHoldFloat = 9f;

        [FormerlySerializedAs("_startCloak")] [SerializeField]
        private float startCloak = float.MaxValue;

        private float _abilityOne;
        private float _abilityTwo;
        private float _nextActionTime;
        private int _rightNow;


        public NewControls Inputs;

        private void Awake()
        {
            Inputs = new NewControls();

            Inputs.player.abilityone.performed += context => _abilityOne = context.ReadValue<float>();

            Inputs.player.abilityone.canceled += context => _abilityOne = 0f;

            Inputs.player.abilitytwo.performed += context => _abilityTwo = context.ReadValue<float>();

            Inputs.player.abilitytwo.canceled += context => _abilityTwo = 0f;
        }

        // Start is called before the first frame update
        private void Start()
        {
            selected = PlayerPrefs.GetInt("Selcted");

            switch (selected)
            {
                case 1:
                    sprite.sprite = bow;
                    break;
                case 2:
                    sprite.sprite = crossbow;
                    break;
                case 3:
                    sprite.sprite = dual;
                    break;
                case 4:
                    sprite.sprite = sniper;
                    break;
                case 5:
                    sprite.sprite = uzi;
                    break;
            }
        }

        // Update is called once per frame
        private void Update()
        {
            if (cloak == 0)
                if (_rightNow == 1)
                {
                    _nextActionTime = Time.time + timeTillNextCloak;
                    _rightNow = 0;
                }

            if (selected == 4)
            {
                if (_abilityOne == 1)
                {
                    if (_abilityTwo == 1)
                    {
                        cloak = 0;
                        sprite.color = new Color(1f, 1f, 1f, 1f);
                    }
                    else
                    {
                        if (!(Time.time > _nextActionTime)) return;
                        cloak = 1;

                        StartCoroutine(Cloak1());

                        sprite.color = new Color(1f, 1f, 1f, 0.5f);

                        _rightNow = 1;
                    }
                }
                else
                {
                    cloak = 0;
                    sprite.color = new Color(1f, 1f, 1f, 1f);
                }
            }
            else
            {
                cloak = 0;
                sprite.color = new Color(1f, 1f, 1f, 1f);
            }
        }

        private void OnEnable()
        {
            Inputs.Enable();
        }

        private void OnDisable()
        {
            Inputs.Disable();
        }

        private IEnumerator Cloak1()
        {
            yield return new WaitForSeconds(timeCanHoldFloat);

            if (cloak != 1) yield break;
            cloak = 0;
            sprite.color = new Color(1f, 1f, 1f, 1f);
            _rightNow = 1;
        }
    }
}