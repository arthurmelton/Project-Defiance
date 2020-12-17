using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject player;
    private player_movement Player_movement;
    
    public Transform FirePoint1;

    public Transform FirePoint2;

    public GameObject Bullet;

    public GameObject Bullet2;

    public GameObject Bullet3;

    private bullet Bullet1;

    public int speed = 0;

    public int killed = 0;

    private float nextActionTime = 0.0f;
    public float TimeBetweenShootCycle = 0.5f;
    public int selected;
    private float nextActionTime2 = 0.0f;
    public float timetillnextmultshot = 10f;
    private int automatic = 0;
    private float nextActionTime3 = 0.0f;
    public float timetillnextautomatic = 10f;
    public float timeautomaticlast = 10f;
    private float nextActionTime4 = 0.0f;
    public float timetillhardshot = 10f;
    public float automaticdual = 0;
    public float timetillnextautomaticdual = 10f;
    public float timeautomaticduallast = 5f;
    private float nextActionTime5 = 0.0f;
    private float nextActionTime6 = 0.0f;
    public float timetillnexthardshot;
    public int hardshot = 0;
    private float nextActionTime7 = 0.0f;
    public float timetillnextricicheshot = 10f;
    public NewControls inputs;
    private float shootpreformed;
    public float abilityOne;
    private float abilityTwo;

    private void Awake()
    {
        inputs = new NewControls();

        inputs.player.shoot.performed += context => shootpreformed = context.ReadValue<float>();

        inputs.player.shoot.canceled += context => shootpreformed = 0f;

        inputs.player.abilityone.performed += context => abilityOne = context.ReadValue<float>();

        inputs.player.abilityone.canceled += context => abilityOne = 0f;

        inputs.player.abilitytwo.performed += context => abilityTwo = context.ReadValue<float>();

        inputs.player.abilitytwo.canceled += context => abilityTwo = 0f;
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
        Bullet1 = Bullet.GetComponent<bullet>();

        Player_movement = player.GetComponent<player_movement>();

        selected = PlayerPrefs.GetInt("Selcted");

        if (selected == 1)
        
        {
            TimeBetweenShootCycle = 1.5f;
        }

        if (selected == 2)
        {
            TimeBetweenShootCycle = 1f;
        }

        if (selected == 4)
        {
            TimeBetweenShootCycle = 2f;
        }

        if (selected == 5)
        {
            TimeBetweenShootCycle = 0.4f;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (selected == 1)
        {
            if (abilityOne == 0)
            {
                if (Time.time > nextActionTime2)
                {
                    nextActionTime2 = Time.time + timetillnextmultshot;

                    Instantiate(Bullet, FirePoint1.position, FirePoint1.rotation);
                }
            }
        }

        if (speed == 0) 
        {
            if (shootpreformed == 1 && selected != 4 && hardshot == 0)
            {

                if (Time.time > nextActionTime)
                {
                    nextActionTime = Time.time + TimeBetweenShootCycle;

                    StartCoroutine(shoot());
                }
            }

            if (shootpreformed == 1 && selected == 4 && automatic == 0 && hardshot == 0)
            {

                if (Time.time > nextActionTime)
                {
                    nextActionTime = Time.time + TimeBetweenShootCycle;

                    Instantiate(Bullet, FirePoint1.position, FirePoint1.rotation);
                }
            }

            if (shootpreformed == 1 && selected == 4 && automatic == 1 && hardshot == 0)
            {

                if (Time.time > nextActionTime)
                {
                    nextActionTime = Time.time + TimeBetweenShootCycle;

                    Instantiate(Bullet, FirePoint1.position, FirePoint1.rotation);
                }
            }

            if (abilityTwo == 1 && selected == 3 && automaticdual == 0 && hardshot == 0)
            {

                if (Time.time > nextActionTime5)
                {
                    nextActionTime5 = Time.time + timeautomaticduallast;

                    automaticdual = 1;

                    StartCoroutine(automaticdual1());
                }
            }

            if (abilityOne == 1 && selected == 2 && hardshot == 0)
            {

                if (Time.time > nextActionTime7)
                {
                    nextActionTime7 = Time.time + timetillnextricicheshot;

                    Instantiate(Bullet3, FirePoint1.position, FirePoint1.rotation);
                }
            }

        }

        if(automatic == 0 && Time.time > nextActionTime3 && abilityTwo == 1 && selected == 4 && hardshot == 0)
        {
            automatic = 1;
            StartCoroutine(automatic1());
        }

        if (abilityTwo == 1 && selected == 1 && hardshot == 0)
        {

            if (Time.time > nextActionTime6)
            {
                nextActionTime6 = Time.time + timetillnexthardshot;

                StartCoroutine(shoot2());
            }
        }

    }


    private IEnumerator shoot()
    {
        float time = TimeBetweenShootCycle / 2;

        Instantiate(Bullet, FirePoint1.position, FirePoint1.rotation);

        yield return new WaitForSeconds(time);

        if (shootpreformed == 1)
        {

            Instantiate(Bullet, FirePoint2.position, FirePoint2.rotation);
        }
    }

    private IEnumerator shoot2()
    {
        hardshot = 1;

        yield return new WaitForSeconds(timetillhardshot);

        hardshot = 0;

        Instantiate(Bullet2, FirePoint1.position, FirePoint1.rotation);
    }

    private IEnumerator automaticdual1()
    {
        TimeBetweenShootCycle = TimeBetweenShootCycle / 2;

        Bullet1 = Bullet.GetComponent<bullet>();

        yield return new WaitForSeconds(timeautomaticduallast);
        
        automaticdual = 0;

        TimeBetweenShootCycle = TimeBetweenShootCycle * 2;
    }

    private IEnumerator automatic1()
    {

        yield return new WaitForSeconds(timeautomaticlast);

        automatic = 0;
        nextActionTime3 = Time.time + timetillnextautomatic;
    }
}
