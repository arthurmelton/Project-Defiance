using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class time : MonoBehaviour
{
    public TextMeshProUGUI tmp;

    public float time1;

    public float nowtime;

    public GameObject player;

    private weapon weapon;

    public int round;
    
    // Start is called before the first frame update
    void Start()
    {
        nowtime = Time.time;

        weapon = player.GetComponent<weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        time1 = Time.time - nowtime;

        time1 = Mathf.Floor(time1);

        tmp.text = "Time : " + time1.ToString() + "     Enemies killed : " + weapon.killed.ToString() + "     Round : " + round.ToString();
    }
}
