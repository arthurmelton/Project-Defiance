using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_display : MonoBehaviour
{

    public GameObject Player;
    private health health;
    public Text healthtext;

    void Update()
    {

        health = Player.GetComponent<health>();

        healthtext.text = "Heath : " + health.Health;
    }
}
