using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_point_1 : MonoBehaviour
{

    public int sellected;
    public Transform tran;
    
    // Start is called before the first frame update
    void Start()
    {
        sellected = PlayerPrefs.GetInt("Selcted");

        if(sellected == 1)
        {
            tran.position = new Vector3(0f, 0.5f);
        }

        if (sellected == 2)
        {
            tran.position = new Vector3(0f, 0.5f);
        }

        if (sellected == 4)
        {
            tran.position = new Vector3(0.05f, 0.53f);
        }

        if (sellected == 5)
        {
            tran.position = new Vector3(0f, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
