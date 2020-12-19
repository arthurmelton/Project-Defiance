using TMPro;
using UnityEngine;

namespace money
{
    public class MoneyBehaviorScript : MonoBehaviour
    {

        public int AmountOfMoney;
        public int RespawnRate;
        public GameObject moneyObject;
        public TextMeshProUGUI ScoreText;

        private float lastRespawn = 0;
        private int totalCollected = 0;
        private int lastCollectedCount = 0;

        // Start is called before the first frame update
        void Start()
        {
            CreateMoney( AmountOfMoney );        
        }

        // Update is called once per frame
        void Update()
        {
            var currentMoney = GameObject.FindGameObjectsWithTag( "Money" ).Length;

            if( Time.time - lastRespawn > RespawnRate ) {            

                CreateMoney( AmountOfMoney - currentMoney );
            }

            // This might not be the best way to keep track but i want this prefab to be totaly
            // selfcontained so the scene does not have to update the UI
            var collected = ( AmountOfMoney - currentMoney );
            if( collected > 0 && collected != lastCollectedCount ) {
                totalCollected += collected;
                ScoreText.text = $"{totalCollected} Bitcoin";
            }

            lastCollectedCount = collected;
        }

        private void CreateMoney( int monies ) {

            for( int i = 0; i < monies; i++ ) {
                var randomx = UnityEngine.Random.Range( -20, 20 );
                var randomy = UnityEngine.Random.Range( -20, 20 );

                var newLocation = new Vector3( randomx, randomy );

                Instantiate( moneyObject, newLocation, new Quaternion() );
            }

            lastRespawn = Time.time;
        }
    }
}
