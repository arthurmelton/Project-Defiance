using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multi_shot_bow : MonoBehaviour
{
    public int selected;
    private float nextActionTime = 0.0f;
    public float timetillnextmultshot = 10f;
    public GameObject Bullet;
    public Transform self;
    public GameObject Player;
    private weapon player2;


    // Start is called before the first frame update
    void Start()
    {
        selected = PlayerPrefs.GetInt("Selcted");

        player2 = Player.GetComponent<weapon>();

        timetillnextmultshot = player2.timetillnextmultshot;
    }

    // Update is called once per frame
    void Update()
    {
        if (selected == 1)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Time.time > nextActionTime)
                {
                    nextActionTime = Time.time + timetillnextmultshot;

                    Instantiate(Bullet, self.position, self.rotation);
                }
            }
        }
    }
}
